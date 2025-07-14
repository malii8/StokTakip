using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class UrunDuzenleForm : Form
    {
        public UrunDuzenleForm()
        {
            InitializeComponent();
            LoadSampleData();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            btnKaydet.Click += BtnKaydet_Click;
            btnVazgec.Click += BtnVazgec_Click;
            cmbUrunGrubu.SelectedIndexChanged += CmbUrunGrubu_SelectedIndexChanged;
        }

        private void LoadSampleData()
        {
            // Load sample product data
            txtBarkodNo.Text = "8690511010128";
            txtUrunAdi.Text = "ABC ÇAMAŞIR SUYU 4000 ML";
            txtStokKodu.Text = "---";
            cmbUrunGrubu.Text = "BELİRTİLMEDİ";
            txtAlisFiyati.Text = "70,00";
            txtSatisFiyati.Text = "90,00";
            txtKDVOrani.Text = "10";
            txtMevcutStok.Text = "12";
            txtAsgariStok.Text = "2";
            cmbOlcuBirimi.Text = "Adet";
        }

        private void BtnKaydet_Click(object? sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün adı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSatisFiyati.Text))
            {
                MessageBox.Show("Satış fiyatı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save changes
            MessageBox.Show("Ürün bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Handle product group selection
        }
    }
}
