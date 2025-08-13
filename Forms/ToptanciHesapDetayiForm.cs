using System;
using System.Drawing;
using System.Windows.Forms;
using StokTakip.Models;
using StokTakip.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace StokTakip.Forms
{
    public partial class ToptanciHesapDetayiForm : Form
    {
        private Wholesaler? _wholesaler;
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public ToptanciHesapDetayiForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            InitializeForm();
            SetupEventHandlers();
        }

        public void SetWholesaler(Wholesaler wholesaler)
        {
            _wholesaler = wholesaler;
            LoadToptanciBilgileri();
            LoadHesapHareketleri();
        }

        private void InitializeForm()
        {
            // Set form properties
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Initialize summary calculations
            CalculateSummary();
        }

        private void SetupEventHandlers()
        {
            // Button event handlers
            btnKapat.Click += BtnKapat_Click;
            btnYazdir.Click += BtnYazdir_Click;
            btnExcel.Click += BtnExcel_Click;
            btnYenile.Click += BtnYenile_Click;
            btnOdemeYap.Click += BtnOdemeYap_Click;
            btnBorcEkle.Click += BtnBorcEkle_Click;

            // Date filter event handlers
            dtpBaslangic.ValueChanged += DateFilter_Changed;
            dtpBitis.ValueChanged += DateFilter_Changed;
            chkTarihFiltresi.CheckedChanged += ChkTarihFiltresi_CheckedChanged;

            // Transaction type filter event handlers
            rbTumHareketler.CheckedChanged += TransactionFilter_Changed;
            rbSadeceOdemeler.CheckedChanged += TransactionFilter_Changed;
            rbSadeceBorclar.CheckedChanged += TransactionFilter_Changed;
        }

        private void LoadToptanciBilgileri()
        {
            if (_wholesaler == null) return;

            lblToptanciAdi.Text = _wholesaler.Name;
            lblMevcutBorc.Text = $"{_wholesaler.Debt:F2} TL";

            lblTelefon.Text = _wholesaler.BusinessPhone;
            lblAdres.Text = _wholesaler.Address;
            lblEmail.Text = _wholesaler.Email;
            lblVergiDairesi.Text = _wholesaler.TaxOffice;
            lblVergiNo.Text = _wholesaler.TaxNumber;

            // Find last payment and transaction dates
            var lastPayment = _context.WholesalerDebtMovements
                .Where(m => m.WholesalerId == _wholesaler.Id && m.MovementType == "Ödeme")
                .OrderByDescending(m => m.MovementDate)
                .FirstOrDefault();
            lblSonOdemeTarihi.Text = lastPayment?.MovementDate.ToShortDateString() ?? "Yok";

            var lastTransaction = _context.WholesalerDebtMovements
                .Where(m => m.WholesalerId == _wholesaler.Id)
                .OrderByDescending(m => m.MovementDate)
                .FirstOrDefault();
            lblSonIslemTarihi.Text = lastTransaction?.MovementDate.ToShortDateString() ?? "Yok";

            // Set debt status color
            if (_wholesaler.Debt > 0)
            {
                lblMevcutBorc.ForeColor = Color.Red;
                lblBorcDurumu.Text = "BORÇLU";
                lblBorcDurumu.ForeColor = Color.Red;
            }
            else if (_wholesaler.Debt < 0)
            {
                lblMevcutBorc.ForeColor = Color.Green;
                lblBorcDurumu.Text = "ALACAKLI";
                lblBorcDurumu.ForeColor = Color.Green;
            }
            else
            {
                lblMevcutBorc.ForeColor = Color.Black;
                lblBorcDurumu.Text = "BORÇ YOK";
                lblBorcDurumu.ForeColor = Color.Black;
            }
        }

        private void LoadHesapHareketleri()
        {
            dgvHareketler.Rows.Clear();

            if (_wholesaler == null) return;

            try
            {
                var movements = _context.WholesalerDebtMovements
                    .Where(m => m.WholesalerId == _wholesaler.Id)
                    .OrderByDescending(m => m.MovementDate)
                    .ToList();

                foreach (var movement in movements)
                {
                    string borc = "0,00";
                    string alacak = "0,00";
                    if (movement.MovementType == "Alış Faturası" || movement.MovementType == "Borç Ekleme")
                    {
                        borc = movement.Amount.ToString("F2");
                    }
                    else if (movement.MovementType == "Ödeme" || movement.MovementType == "İade")
                    {
                        alacak = movement.Amount.ToString("F2");
                    }

                    dgvHareketler.Rows.Add(
                        movement.Id, // Assuming a column for Sira No
                        movement.MovementDate.ToShortDateString(),
                        movement.MovementType,
                        movement.DocumentNumber ?? "",
                        borc,
                        alacak,
                        _wholesaler.Debt.ToString("F2"), // This will show current debt, not debt at time of transaction
                        movement.Description ?? ""
                    );
                }

                ApplyRowColors();
                ApplyCurrentFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hesap hareketleri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyRowColors()
        {
            foreach (DataGridViewRow row in dgvHareketler.Rows)
            {
                if (row.IsNewRow) continue;

                string islemTuru = row.Cells["colHareketTuru"].Value?.ToString() ?? "";

                switch (islemTuru)
                {
                    case "Alış Faturası":
                        row.DefaultCellStyle.BackColor = Color.LightCoral; // Borç - Kırmızı
                        break;
                    case "Ödeme":
                        row.DefaultCellStyle.BackColor = Color.LightGreen; // Ödeme - Yeşil
                        break;
                    case "İade":
                        row.DefaultCellStyle.BackColor = Color.LightBlue; // İade - Mavi
                        break;
                    default:
                        row.DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            }
        }

        private void CalculateSummary()
        {
            decimal toplamBorc = 0;
            decimal toplamOdeme = 0;
            int borcIslemSayisi = 0;
            int odemeIslemSayisi = 0;

            foreach (DataGridViewRow row in dgvHareketler.Rows)
            {
                if (row.IsNewRow || !row.Visible) continue;

                if (decimal.TryParse(row.Cells["colBorc"].Value?.ToString(), out decimal borc) && borc > 0)
                {
                    toplamBorc += borc;
                    borcIslemSayisi++;
                }

                if (decimal.TryParse(row.Cells["colAlacak"].Value?.ToString(), out decimal alacak) && alacak > 0)
                {
                    toplamOdeme += alacak;
                    odemeIslemSayisi++;
                }
            }

            lblToplamBorcIslem.Text = $"Toplam Borç: {toplamBorc:F2} TL ({borcIslemSayisi} işlem)";
            lblToplamOdemeIslem.Text = $"Toplam Ödeme: {toplamOdeme:F2} TL ({odemeIslemSayisi} işlem)";
            lblNetHareket.Text = $"Net Hareket: {(toplamBorc - toplamOdeme):F2} TL";

            // Calculate visible row count
            int gorunenSatir = 0;
            foreach (DataGridViewRow row in dgvHareketler.Rows)
            {
                if (!row.IsNewRow && row.Visible) gorunenSatir++;
            }
            lblToplamIslem.Text = $"Toplam İşlem: {gorunenSatir}";
        }

        private void ApplyCurrentFilter()
        {
            DateTime baslangic = dtpBaslangic.Value.Date;
            DateTime bitis = dtpBitis.Value.Date;

            foreach (DataGridViewRow row in dgvHareketler.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = true;

                // Date filter
                if (chkTarihFiltresi.Checked)
                {
                    if (DateTime.TryParse(row.Cells["colTarih"].Value?.ToString(), out DateTime islemTarihi))
                    {
                        if (islemTarihi.Date < baslangic || islemTarihi.Date > bitis)
                            visible = false;
                    }
                }

                // Transaction type filter
                if (visible)
                {
                    string islemTuru = row.Cells["colIslemTuru"].Value?.ToString() ?? "";

                    if (rbSadeceOdemeler.Checked && islemTuru != "Ödeme" && islemTuru != "İade")
                        visible = false;
                    else if (rbSadeceBorclar.Checked && islemTuru != "Alış Faturası")
                        visible = false;
                }

                row.Visible = visible;
            }

            CalculateSummary();
        }

        private void DateFilter_Changed(object? sender, EventArgs e)
        {
            if (chkTarihFiltresi.Checked)
            {
                ApplyCurrentFilter();
            }
        }

        private void ChkTarihFiltresi_CheckedChanged(object? sender, EventArgs e)
        {
            dtpBaslangic.Enabled = chkTarihFiltresi.Checked;
            dtpBitis.Enabled = chkTarihFiltresi.Checked;
            ApplyCurrentFilter();
        }

        private void TransactionFilter_Changed(object? sender, EventArgs e)
        {
            ApplyCurrentFilter();
        }

        private void BtnOdemeYap_Click(object? sender, EventArgs e)
        {
            if (_wholesaler == null) return;

            using (var odemeForm = _serviceProvider.GetRequiredService<ToptanciyaOdemeYapForm>())
            {
                odemeForm.SetWholesaler(_wholesaler);
                if (odemeForm.ShowDialog() == DialogResult.OK)
                {
                    LoadToptanciBilgileri(); // Refresh wholesaler details
                    LoadHesapHareketleri(); // Refresh movements

                    MessageBox.Show($"Ödeme başarıyla kaydedildi.",
                        "Ödeme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnBorcEkle_Click(object? sender, EventArgs e)
        {
            if (_wholesaler == null) return;

            using (var borcForm = _serviceProvider.GetRequiredService<ToptanciBorcunaEklemeForm>())
            {
                borcForm.SetWholesaler(_wholesaler);
                if (borcForm.ShowDialog() == DialogResult.OK)
                {
                    LoadToptanciBilgileri(); // Refresh wholesaler details
                    LoadHesapHareketleri(); // Refresh movements

                    MessageBox.Show($"Borç ekleme başarıyla kaydedildi.",
                        "Borç Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnYenile_Click(object? sender, EventArgs e)
        {
            LoadToptanciBilgileri();
            LoadHesapHareketleri();
            chkTarihFiltresi.Checked = false;
            rbTumHareketler.Checked = true;
        }

        private void BtnYazdir_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Hesap detayları yazdırılıyor...", "Yazdır", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExcel_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Hesap detayları Excel'e aktarılıyor...", "Excel'e Aktar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnKapat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
