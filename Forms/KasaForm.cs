using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class KasaForm : Form
    {
        public KasaForm()
        {
            InitializeComponent();
            LoadSampleData();
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

        private void LoadSampleData()
        {
            dgvKasaHareketleri.Rows.Clear();

            string[] sampleTransactions = {
                "14.07.2025|10:30|Gelir|NAKİT|250.00|Satış Geliri|Admin",
                "14.07.2025|11:15|Gider|NAKİT|50.00|Elektrik Faturası|Admin",
                "14.07.2025|12:30|Gelir|NAKİT|120.00|Müşteri Ödemesi|Kasiyer1",
                "13.07.2025|09:45|Gider|NAKİT|30.00|Kırtasiye|Admin",
                "13.07.2025|14:20|Gelir|NAKİT|300.00|Toptan Satış|Kasiyer2",
                "13.07.2025|16:30|Gider|NAKİT|80.00|Temizlik Malzemesi|Admin",
                "12.07.2025|10:00|Gelir|NAKİT|180.00|Perakende Satış|Kasiyer1",
                "12.07.2025|15:45|Gider|NAKİT|25.00|Su Faturası|Admin"
            };

            foreach (string transaction in sampleTransactions)
            {
                string[] parts = transaction.Split('|');
                if (parts.Length >= 7)
                {
                    dgvKasaHareketleri.Rows.Add(
                        parts[0], // Tarih
                        parts[1], // Saat
                        parts[2], // Türü
                        parts[3], // Gelir Gider Sebebi
                        parts[4], // Tutarı
                        parts[5], // Açıklama
                        parts[6]  // Barkodu (İşlem Yapan)
                    );
                }
            }

            UpdateSummaryPanels();
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
            LoadSampleData();
            MessageBox.Show("Sayfa yenilendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGelirGiderGrafigi_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Gelir-Gider grafiği açılıyor...", "Grafik", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGiderGirisi_Click(object? sender, EventArgs e)
        {
            using (var giderForm = new GelirGiderForm("Gider"))
            {
                if (giderForm.ShowDialog() == DialogResult.OK)
                {
                    LoadSampleData(); // Refresh data
                }
            }
        }

        private void BtnGelirGirisi_Click(object? sender, EventArgs e)
        {
            using (var gelirForm = new GelirGiderForm("Gelir"))
            {
                if (gelirForm.ShowDialog() == DialogResult.OK)
                {
                    LoadSampleData(); // Refresh data
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
