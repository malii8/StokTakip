using System;
using System.Drawing;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class ToptanciHesapDetayiForm : Form
    {
        private string toptanciAdi;
        private decimal mevcutBorc;

        public ToptanciHesapDetayiForm(string toptanciAdi, decimal mevcutBorc)
        {
            InitializeComponent();
            this.toptanciAdi = toptanciAdi;
            this.mevcutBorc = mevcutBorc;
            InitializeForm();
            LoadToptanciBilgileri();
            LoadHesapHareketleri();
            SetupEventHandlers();
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
            lblToptanciAdi.Text = toptanciAdi;
            lblMevcutBorc.Text = $"{mevcutBorc:F2} TL";

            // Sample wholesaler details - in real application, this would come from database
            lblTelefon.Text = "0212 123 45 67";
            lblAdres.Text = "Örnek Mahalle, Örnek Sokak No:123, İstanbul";
            lblEmail.Text = "info@example.com";
            lblVergiDairesi.Text = "Kadıköy Vergi Dairesi";
            lblVergiNo.Text = "1234567890";
            lblSonOdemeTarihi.Text = "10.07.2025";
            lblSonIslemTarihi.Text = "12.07.2025";

            // Set debt status color
            if (mevcutBorc > 0)
            {
                lblMevcutBorc.ForeColor = Color.Red;
                lblBorcDurumu.Text = "BORÇLU";
                lblBorcDurumu.ForeColor = Color.Red;
            }
            else if (mevcutBorc < 0)
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
            // Sample transaction data - in real application, this would come from database
            dgvHareketler.Rows.Clear();

            dgvHareketler.Rows.Add("12.07.2025", "Alış Faturası", "AF-2025-001", "250,00", "0,00", "364,70", "Yedek parça alımı");
            dgvHareketler.Rows.Add("10.07.2025", "Ödeme", "ÖD-2025-015", "0,00", "150,00", "114,70", "Nakit ödeme");
            dgvHareketler.Rows.Add("08.07.2025", "Alış Faturası", "AF-2025-002", "180,50", "0,00", "264,70", "Filtre alımı");
            dgvHareketler.Rows.Add("05.07.2025", "Ödeme", "ÖD-2025-014", "0,00", "100,00", "84,20", "Kredi kartı ödeme");
            dgvHareketler.Rows.Add("03.07.2025", "Alış Faturası", "AF-2025-003", "120,00", "0,00", "184,20", "Motor yağı alımı");
            dgvHareketler.Rows.Add("01.07.2025", "İade", "İD-2025-001", "0,00", "35,80", "64,20", "Hatalı ürün iadesi");
            dgvHareketler.Rows.Add("30.06.2025", "Alış Faturası", "AF-2025-004", "100,00", "0,00", "100,00", "Fren balata alımı");

            ApplyRowColors();
            ApplyCurrentFilter();
        }

        private void ApplyRowColors()
        {
            foreach (DataGridViewRow row in dgvHareketler.Rows)
            {
                if (row.IsNewRow) continue;

                string islemTuru = row.Cells["colIslemTuru"].Value?.ToString() ?? "";

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
            using (var odemeForm = new ToptanciyaOdemeYapForm(toptanciAdi, mevcutBorc))
            {
                if (odemeForm.ShowDialog() == DialogResult.OK)
                {
                    // Update current debt
                    mevcutBorc = mevcutBorc - odemeForm.OdemeTutari;
                    LoadToptanciBilgileri();

                    // Add new payment transaction
                    string yeniTarih = DateTime.Now.ToString("dd.MM.yyyy");
                    dgvHareketler.Rows.Insert(0, yeniTarih, "Ödeme", $"ÖD-{DateTime.Now:yyyy-MMM}",
                        "0,00", odemeForm.OdemeTutari.ToString("F2"), mevcutBorc.ToString("F2"),
                        $"{odemeForm.OdemeSekli} ödeme");

                    ApplyRowColors();
                    ApplyCurrentFilter();

                    MessageBox.Show($"Ödeme başarıyla kaydedildi.\nÖdenen Tutar: {odemeForm.OdemeTutari:F2} TL",
                        "Ödeme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnBorcEkle_Click(object? sender, EventArgs e)
        {
            using (var borcForm = new ToptanciBorcunaEklemeForm(toptanciAdi, mevcutBorc))
            {
                if (borcForm.ShowDialog() == DialogResult.OK)
                {
                    // Update current debt
                    mevcutBorc = mevcutBorc + borcForm.EklenecekTutar;
                    LoadToptanciBilgileri();

                    // Add new debt transaction
                    string yeniTarih = DateTime.Now.ToString("dd.MM.yyyy");
                    dgvHareketler.Rows.Insert(0, yeniTarih, "Alış Faturası", $"AF-{DateTime.Now:yyyy-MMM}",
                        borcForm.EklenecekTutar.ToString("F2"), "0,00", mevcutBorc.ToString("F2"),
                        borcForm.Aciklama);

                    ApplyRowColors();
                    ApplyCurrentFilter();

                    MessageBox.Show($"Borç ekleme başarıyla kaydedildi.\nEklenen Tutar: {borcForm.EklenecekTutar:F2} TL",
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
