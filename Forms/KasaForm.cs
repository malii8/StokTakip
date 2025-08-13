using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using StokTakip.Models;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.Forms
{
    public partial class KasaForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public KasaForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            LoadCashMovementData(); // Changed from LoadSampleData
            SetupEventHandlers();
            InitializeDateRanges();
            InitializeComboBoxes();
            UpdateSummaryPanels();
        }

        private void InitializeDateRanges()
        {
            // Set default date range to current day
            dtpBaslangic.Value = DateTime.Now.Date;
            dtpBitis.Value = DateTime.Now.Date;
        }

        private void InitializeComboBoxes()
        {
            // Hareket Türü
            cmbHareketTuru.Items.AddRange(new string[] { "Tümü", "Gelir", "Gider" });
            cmbHareketTuru.SelectedIndex = 0;

            // İşlem Yapan
            cmbIslemYapan.Items.AddRange(new string[] { "Tümü", "Admin", "Kasiyer1", "Kasiyer2" });
            cmbIslemYapan.SelectedIndex = 0;
        }

        private void SetupEventHandlers()
        {
            btnSayfayiYenile.Click += BtnSayfayiYenile_Click;
            btnGelirGiderGrafigi.Click += BtnGelirGiderGrafigi_Click;
            btnGiderGirisi.Click += BtnGiderGirisi_Click;
            btnGelirGirisi.Click += BtnGelirGirisi_Click;
            btnExcelAktar.Click += BtnExcelAktar_Click;
            btnGelirGiderTuruSil.Click += BtnGelirGiderTuruSil_Click;
            btnYeniGelirGiderTuruEkle.Click += BtnYeniGelirGiderTuruEkle_Click;

            // Date and filter change events
            dtpBaslangic.ValueChanged += FilterData;
            dtpBitis.ValueChanged += FilterData;
            cmbHareketTuru.SelectedIndexChanged += FilterData;
            cmbIslemYapan.SelectedIndexChanged += FilterData;
        }

        private void LoadCashMovementData()
        {
            dgvKasaHareketleri.Rows.Clear();

            try
            {
                var cashMovements = _context.CashMovements
                    .Where(cm => cm.MovementDate >= dtpBaslangic.Value.Date && cm.MovementDate <= dtpBitis.Value.Date)
                    .OrderByDescending(cm => cm.MovementDate)
                    .ThenByDescending(cm => cm.Id)
                    .ToList();

                foreach (var movement in cashMovements)
                {
                    dgvKasaHareketleri.Rows.Add(
                        movement.MovementDate.ToShortDateString(), // Tarih
                        movement.MovementDate.ToShortTimeString(), // Saat
                        movement.MovementType, // Türü (Gelir/Gider)
                        movement.Description, // Gelir Gider Sebebi (Açıklama)
                        movement.Amount.ToString("F2"), // Tutarı
                        movement.Notes, // Açıklama (Notlar)
                        "Admin" // İşlem Yapan (Placeholder for now)
                    );
                }
                UpdateSummaryPanels();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kasa hareketleri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSummaryPanels()
        {
            double gelirToplam = 0;
            double giderToplam = 0;
            int listelenKayitSayisi = 0;

            foreach (DataGridViewRow row in dgvKasaHareketleri.Rows)
            {
                if (row.IsNewRow || !row.Visible) continue;

                listelenKayitSayisi++;
                string tur = row.Cells["colTuru"].Value?.ToString() ?? "";
                double tutar = double.TryParse(row.Cells["colTutari"].Value?.ToString(), out double t) ? t : 0;

                if (tur == "Gelir")
                {
                    gelirToplam += tutar;
                }
                else if (tur == "Gider")
                {
                    giderToplam += tutar;
                }
            }

            double toplam = gelirToplam - giderToplam;

            // Update summary panels
            lblGelirTutar.Text = $"{gelirToplam:F2} TL";
            lblGiderTutar.Text = $"{giderToplam:F2} TL";
            lblToplamTutar.Text = $"{toplam:F2} TL";
            lblListelenenKayitSayisi.Text = listelenKayitSayisi.ToString();

            // Update panel colors based on values
            pnlGelir.BackColor = Color.FromArgb(0, 200, 200); // Cyan
            pnlGider.BackColor = Color.FromArgb(0, 200, 200); // Cyan
            pnlToplam.BackColor = toplam >= 0 ? Color.FromArgb(0, 200, 200) : Color.FromArgb(255, 100, 100); // Cyan or Red
            pnlListelenenKayitSayisi.BackColor = Color.FromArgb(0, 150, 0); // Green
        }

        private void FilterData(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvKasaHareketleri.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = true;

                // Filter by date range
                if (DateTime.TryParse(row.Cells["colTarih"].Value?.ToString(), out DateTime rowDate))
                {
                    if (rowDate < dtpBaslangic.Value.Date || rowDate > dtpBitis.Value.Date)
                        visible = false;
                }

                // Filter by hareket türü
                if (cmbHareketTuru.SelectedItem?.ToString() != "Tümü")
                {
                    string tur = row.Cells["colTuru"].Value?.ToString() ?? "";
                    if (tur != cmbHareketTuru.SelectedItem?.ToString())
                        visible = false;
                }

                // Filter by işlem yapan
                if (cmbIslemYapan.SelectedItem?.ToString() != "Tümü")
                {
                    string islemYapan = row.Cells["colBarkodu"].Value?.ToString() ?? "";
                    if (islemYapan != cmbIslemYapan.SelectedItem?.ToString())
                        visible = false;
                }

                row.Visible = visible;
            }

            UpdateSummaryPanels();
        }

        private void BtnSayfayiYenile_Click(object? sender, EventArgs e)
        {
            LoadCashMovementData();
            MessageBox.Show("Sayfa yenilendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGelirGiderGrafigi_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Gelir-Gider grafiği açılıyor...", "Grafik", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGiderGirisi_Click(object? sender, EventArgs e)
        {
            using (var giderForm = _serviceProvider.GetRequiredService<GelirGiderForm>())
            {
                giderForm.SetMovementType("Gider");
                if (giderForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCashMovementData(); // Refresh data
                }
            }
        }

        private void BtnGelirGirisi_Click(object? sender, EventArgs e)
        {
            using (var gelirForm = _serviceProvider.GetRequiredService<GelirGiderForm>())
            {
                gelirForm.SetMovementType("Gelir");
                if (gelirForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCashMovementData(); // Refresh data
                }
            }
        }

        private void BtnExcelAktar_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Excel'e aktarılıyor...", "Excel Aktar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGelirGiderTuruSil_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Gelir-Gider türü silme işlemi...", "Tür Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnYeniGelirGiderTuruEkle_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Yeni Gelir-Gider türü ekleme işlemi...", "Yeni Tür Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
