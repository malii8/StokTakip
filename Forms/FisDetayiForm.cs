using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class FisDetayiForm : Form
    {
        public FisDetayiForm(string fisNo, string tarih, string saat, string odemeTuru, string musteriAdi, string tutar, string durum)
        {
            InitializeComponent();
            LoadFisData(fisNo, tarih, saat, odemeTuru, musteriAdi, tutar, durum);
            LoadSampleProductData();
        }

        private void LoadFisData(string fisNo, string tarih, string saat, string odemeTuru, string musteriAdi, string tutar, string durum)
        {
            lblFisNoValue.Text = fisNo;
            lblTarihValue.Text = $"{tarih} {saat}";
            lblOdemeTuruValue.Text = odemeTuru;
            lblMusteriAdiValue.Text = string.IsNullOrEmpty(musteriAdi) ? "Perakende Satış" : musteriAdi;
            lblToplamTutarValue.Text = $"{tutar} TL";
            lblDurumValue.Text = durum;

            // Set status color
            if (durum == "İptal")
            {
                lblDurumValue.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblDurumValue.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void LoadSampleProductData()
        {
            // Sample product data for the receipt
            dgvUrunler.Rows.Clear();

            dgvUrunler.Rows.Add("8690511010128", "ABC ÇAMAŞIR SUYU 4000 ML", "2", "15,50", "31,00");
            dgvUrunler.Rows.Add("8690511010135", "XYZ DETERJANİ 2000 ML", "1", "22,25", "22,25");
            dgvUrunler.Rows.Add("8690511010142", "BULAŞIK DETERJANİ 500 ML", "3", "8,75", "26,25");

            CalculateTotals();
        }

        private void CalculateTotals()
        {
            decimal araToplam = 0;
            int toplamUrun = 0;

            foreach (DataGridViewRow row in dgvUrunler.Rows)
            {
                if (row.IsNewRow) continue;

                if (int.TryParse(row.Cells["colMiktar"].Value?.ToString(), out int miktar))
                {
                    toplamUrun += miktar;
                }

                if (decimal.TryParse(row.Cells["colToplam"].Value?.ToString(), out decimal toplam))
                {
                    araToplam += toplam;
                }
            }

            decimal kdv = araToplam * 0.10m; // %10 KDV
            decimal genelToplam = araToplam + kdv;

            lblToplamUrunValue.Text = toplamUrun.ToString();
            lblAraToplamValue.Text = $"{araToplam:F2} TL";
            lblKdvValue.Text = $"{kdv:F2} TL";
            lblGenelToplamValue.Text = $"{genelToplam:F2} TL";
        }
    }
}
