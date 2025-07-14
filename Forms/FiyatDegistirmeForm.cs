using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class FiyatDegistirmeForm : Form
    {
        public FiyatDegistirmeForm()
        {
            InitializeComponent();
            LoadSampleData();
            SetupEventHandlers();
        }

        private void LoadSampleData()
        {
            // Ürün grupları için sample data
            cmbUrunGrubu.Items.Clear();
            cmbUrunGrubu.Items.Add("Tümü");
            cmbUrunGrubu.Items.Add("BİSKÜVİ");
            cmbUrunGrubu.Items.Add("FİLTRE");
            cmbUrunGrubu.Items.Add("SALÇA");
            cmbUrunGrubu.Items.Add("TEXT11");
            cmbUrunGrubu.Items.Add("YAĞ");
            cmbUrunGrubu.SelectedIndex = 0;

            // Sample ürün fiyat listesi
            dgvUrunFiyatlari.Rows.Clear();
            string[] sampleProducts = {
                "1|KOCAELI BİSKÜVİ 100 GR|15.50|18.00",
                "2|ALTINYAG SAF YAĞ 1 LT|85.00|95.00",
                "3|SALÇA 800 GR|12.00|14.50",
                "4|FİLTRE KAHVE 250 GR|45.00|52.00",
                "5|NESCAFE GOLD 100 GR|85.00|95.00",
                "6|ACE DETERJANİ 4 KG|125.00|140.00",
                "7|SANA MARGARİN 500 GR|18.50|22.00",
                "8|DOMATES SALÇASI 70 GR|4.50|5.50",
                "9|ÇAYKUR RIZE ÇAYI 1 KG|95.00|110.00",
                "10|ÜLKER PETİBÖR 100 GR|8.50|10.00"
            };

            foreach (string product in sampleProducts)
            {
                string[] parts = product.Split('|');
                dgvUrunFiyatlari.Rows.Add(
                    false, // Checkbox
                    parts[0], // Barkod
                    parts[1], // Ürün Adı
                    parts[2], // Alış Fiyatı
                    parts[3]  // Satış Fiyatı
                );
            }
        }

        private void SetupEventHandlers()
        {
            // Fiyat değişikliği buttons
            btnYuzde10Artir.Click += (s, e) => UygulaBulkFiyatDegisikligi(1.10);
            btnYuzde20Artir.Click += (s, e) => UygulaBulkFiyatDegisikligi(1.20);
            btnYuzde30Artir.Click += (s, e) => UygulaBulkFiyatDegisikligi(1.30);
            btnYuzde15Azalt.Click += (s, e) => UygulaBulkFiyatDegisikligi(0.85);
            btnYuzde20Azalt.Click += (s, e) => UygulaBulkFiyatDegisikligi(0.80);
            btnYuzde30Azalt.Click += (s, e) => UygulaBulkFiyatDegisikligi(0.70);

            // Diğer buttons
            btnTumunuSec.Click += BtnTumunuSec_Click;
            btnHicbiriniSecme.Click += BtnHicbiriniSecme_Click;
            btnOzelFiyatUygula.Click += BtnOzelFiyatUygula_Click;
            btnKaydet.Click += BtnKaydet_Click;
            btnVazgec.Click += BtnVazgec_Click;

            // Grup filtreleme
            cmbUrunGrubu.SelectedIndexChanged += CmbUrunGrubu_SelectedIndexChanged;

            // Search box
            txtUrunAra.TextChanged += TxtUrunAra_TextChanged;
        }

        private void UygulaBulkFiyatDegisikligi(double carpan)
        {
            foreach (DataGridViewRow row in dgvUrunFiyatlari.Rows)
            {
                if (row.Cells["colSecim"].Value != null && (bool)row.Cells["colSecim"].Value)
                {
                    // Alış fiyatını değiştir
                    if (double.TryParse(row.Cells["colAlisFiyati"].Value?.ToString(), out double alisFiyati))
                    {
                        row.Cells["colAlisFiyati"].Value = (alisFiyati * carpan).ToString("F2");
                    }

                    // Satış fiyatını değiştir
                    if (double.TryParse(row.Cells["colSatisFiyati"].Value?.ToString(), out double satisFiyati))
                    {
                        row.Cells["colSatisFiyati"].Value = (satisFiyati * carpan).ToString("F2");
                    }
                }
            }
        }

        private void BtnTumunuSec_Click(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUrunFiyatlari.Rows)
            {
                row.Cells["colSecim"].Value = true;
            }
        }

        private void BtnHicbiriniSecme_Click(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUrunFiyatlari.Rows)
            {
                row.Cells["colSecim"].Value = false;
            }
        }

        private void BtnOzelFiyatUygula_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOzelFiyat.Text))
            {
                MessageBox.Show("Lütfen özel fiyat değeri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtOzelFiyat.Text, out double ozelFiyat))
            {
                MessageBox.Show("Geçerli bir fiyat değeri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgvUrunFiyatlari.Rows)
            {
                if (row.Cells["colSecim"].Value != null && (bool)row.Cells["colSecim"].Value)
                {
                    row.Cells["colSatisFiyati"].Value = ozelFiyat.ToString("F2");
                }
            }
        }

        private void BtnKaydet_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Fiyat değişiklikleri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnVazgec_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CmbUrunGrubu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string? selectedGroup = cmbUrunGrubu.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedGroup) || selectedGroup == "Tümü")
            {
                foreach (DataGridViewRow row in dgvUrunFiyatlari.Rows)
                {
                    row.Visible = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvUrunFiyatlari.Rows)
                {
                    string urunAdi = row.Cells["colUrunAdi"].Value?.ToString() ?? "";
                    row.Visible = urunAdi.ToUpper().Contains(selectedGroup.ToUpper());
                }
            }
        }

        private void TxtUrunAra_TextChanged(object? sender, EventArgs e)
        {
            string searchText = txtUrunAra.Text.ToUpper();
            foreach (DataGridViewRow row in dgvUrunFiyatlari.Rows)
            {
                string urunAdi = row.Cells["colUrunAdi"].Value?.ToString()?.ToUpper() ?? "";
                string barkod = row.Cells["colBarkod"].Value?.ToString()?.ToUpper() ?? "";

                row.Visible = string.IsNullOrEmpty(searchText) ||
                             urunAdi.Contains(searchText) ||
                             barkod.Contains(searchText);
            }
        }
    }
}
