using System;
using System.Data;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class UrunAyrintisiForm : Form
    {
        public UrunAyrintisiForm()
        {
            InitializeComponent();
            LoadSampleData();
            SetupEventHandlers();
            InitializeDateRanges();
        }

        private void InitializeDateRanges()
        {
            // Set default date range to current month
            dtpBaslangic.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpBitis.Value = DateTime.Now;
        }

        private void SetupEventHandlers()
        {
            btnYazdir.Click += BtnYazdir_Click;
            btnExcelAktar.Click += BtnExcelAktar_Click;
            rbSadeceAlislar.CheckedChanged += RaporTuru_CheckedChanged;
            rbSadeceSatislar.CheckedChanged += RaporTuru_CheckedChanged;
            rbSadeceIadeAlinanlar.CheckedChanged += RaporTuru_CheckedChanged;
            rbSadeceIadeEdilenler.CheckedChanged += RaporTuru_CheckedChanged;
        }

        private void LoadSampleData()
        {
            // Sample product movement data
            dgvHareketler.Rows.Clear();

            string[] sampleMovements = {
                "1|Giriş|KOCAELI BİSKÜVİ|14.07.2025|10:30|KOCAELI BİSKÜVİ|12.50|15.00|5|62.50|Alış",
                "2|Satış|KOCAELI BİSKÜVİ|14.07.2025|11:15|KOCAELI BİSKÜVİ|12.50|15.00|2|30.00|Perakende",
                "3|Giriş|KOCAELI BİSKÜVİ|13.07.2025|14:20|KOCAELI BİSKÜVİ|12.00|15.00|10|120.00|Alış",
                "4|Satış|KOCAELI BİSKÜVİ|13.07.2025|16:45|KOCAELI BİSKÜVİ|12.50|15.00|3|45.00|Perakende",
                "5|İade|KOCAELI BİSKÜVİ|12.07.2025|09:10|KOCAELI BİSKÜVİ|12.50|15.00|1|15.00|Müşteri İadesi",
                "6|Giriş|KOCAELI BİSKÜVİ|12.07.2025|13:30|KOCAELI BİSKÜVİ|11.80|15.00|8|94.40|Alış",
                "7|Satış|KOCAELI BİSKÜVİ|11.07.2025|17:25|KOCAELI BİSKÜVİ|12.50|15.00|4|60.00|Toptan",
                "8|Giriş|KOCAELI BİSKÜVİ|10.07.2025|08:45|KOCAELI BİSKÜVİ|12.20|15.00|15|183.00|Alış"
            };

            foreach (string movement in sampleMovements)
            {
                string[] parts = movement.Split('|');
                if (parts.Length >= 11) // Ensure we have enough parts
                {
                    dgvHareketler.Rows.Add(
                        parts[0], // Sıra No
                        parts[1], // Hareket Türü
                        parts[2], // Cari Hesap Adı
                        parts[3], // Tarih
                        parts[4], // Saat
                        parts[5], // Ürün Adı
                        parts[6], // Alış Fiyatı
                        parts[7], // Satış Fiyatı
                        parts[8], // Miktar
                        "0", // KDV
                        "Aktif", // Durum
                        parts[9] // Toplam Tutar
                    );
                }
            }

            UpdateSummaryBoxes();
        }

        private void UpdateSummaryBoxes()
        {
            // Calculate summary values based on current data
            double urunGirisiToplam = 0;
            double satislarToplam = 0;
            double iadeEdilenToplam = 0;
            double iadeAlinanToplam = 0;

            int urunGirisiAdet = 0;
            int satislarAdet = 0;
            int iadeEdilenAdet = 0;
            int iadeAlinanAdet = 0;

            foreach (DataGridViewRow row in dgvHareketler.Rows)
            {
                if (row.IsNewRow) continue;

                string hareketTuru = row.Cells["colHareketTuru"].Value?.ToString() ?? "";
                double tutar = double.TryParse(row.Cells["colToplamTutar"].Value?.ToString(), out double t) ? t : 0;
                int miktar = int.TryParse(row.Cells["colMiktar"].Value?.ToString(), out int m) ? m : 0;

                switch (hareketTuru.ToUpper())
                {
                    case "GİRİŞ":
                        urunGirisiToplam += tutar;
                        urunGirisiAdet += miktar;
                        break;
                    case "SATIŞ":
                        satislarToplam += tutar;
                        satislarAdet += miktar;
                        break;
                    case "İADE":
                        if (tutar > 0)
                        {
                            iadeAlinanToplam += tutar;
                            iadeAlinanAdet += miktar;
                        }
                        else
                        {
                            iadeEdilenToplam += Math.Abs(tutar);
                            iadeEdilenAdet += miktar;
                        }
                        break;
                }
            }

            // Update summary labels
            lblUrunGirisiTutar.Text = $"{urunGirisiToplam:F2} TL";
            lblUrunGirisiAdet.Text = urunGirisiAdet.ToString();

            lblSatislarTutar.Text = $"{satislarToplam:F2} TL";
            lblSatislarAdet.Text = satislarAdet.ToString();

            lblIadeEdilenTutar.Text = $"{iadeEdilenToplam:F2} TL";
            lblIadeEdilenAdet.Text = iadeEdilenAdet.ToString();

            lblIadeAlinanTutar.Text = $"{iadeAlinanToplam:F2} TL";
            lblIadeAlinanAdet.Text = iadeAlinanAdet.ToString();
        }

        private void RaporTuru_CheckedChanged(object? sender, EventArgs e)
        {
            RadioButton? rb = sender as RadioButton;
            if (rb?.Checked == true)
            {
                FilterDataByReportType(rb.Name);
            }
        }

        private void FilterDataByReportType(string reportType)
        {
            foreach (DataGridViewRow row in dgvHareketler.Rows)
            {
                if (row.IsNewRow) continue;

                string hareketTuru = row.Cells["colHareketTuru"].Value?.ToString()?.ToUpper() ?? "";
                bool visible = true;

                switch (reportType)
                {
                    case "rbSadeceAlislar":
                        visible = hareketTuru == "GİRİŞ";
                        break;
                    case "rbSadeceSatislar":
                        visible = hareketTuru == "SATIŞ";
                        break;
                    case "rbSadeceIadeAlinanlar":
                        visible = hareketTuru == "İADE" && double.Parse(row.Cells["colToplamTutar"].Value?.ToString() ?? "0") > 0;
                        break;
                    case "rbSadeceIadeEdilenler":
                        visible = hareketTuru == "İADE" && double.Parse(row.Cells["colToplamTutar"].Value?.ToString() ?? "0") < 0;
                        break;
                    default:
                        visible = true;
                        break;
                }

                row.Visible = visible;
            }
        }

        private void BtnYazdir_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Rapor yazdırılıyor...", "Yazdır", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExcelAktar_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Excel'e aktarılıyor...", "Excel Aktar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
