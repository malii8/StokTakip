using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class GelirGiderForm : Form
    {
        public string HareketTuru { get; set; } = string.Empty;
        public string Sebep { get; set; } = string.Empty;
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; } = string.Empty;
        public string IslemYapan { get; set; } = string.Empty;

        public GelirGiderForm(string islemTuru)
        {
            InitializeComponent();
            this.Text = islemTuru == "Gelir" ? "Yeni Gelir Girişi" : "Yeni Gider Girişi";
            this.HareketTuru = islemTuru;
            LoadForm();
        }

        private void LoadForm()
        {
            // Initialize combo box items
            cmbSebep.Items.Clear();

            if (HareketTuru == "Gelir")
            {
                cmbSebep.Items.AddRange(new string[] {
                    "Satış Geliri",
                    "Faiz Geliri",
                    "Kira Geliri",
                    "Diğer Gelir"
                });
            }
            else
            {
                cmbSebep.Items.AddRange(new string[] {
                    "Satın Alma",
                    "Kira Gideri",
                    "Personel Gideri",
                    "Elektrik Gideri",
                    "Su Gideri",
                    "Telefon Gideri",
                    "Vergi Gideri",
                    "Diğer Gider"
                });
            }

            cmbIslemYapan.Items.Clear();
            cmbIslemYapan.Items.AddRange(new string[] {
                "Admin",
                "Kasiyer",
                "Muhasebe"
            });

            // Set default values
            dtpTarih.Value = DateTime.Now;
            dtpSaat.Value = DateTime.Now;
            dtpSaat.Format = DateTimePickerFormat.Time;
            dtpSaat.ShowUpDown = true;

            cmbSebep.SelectedIndex = 0;
            cmbIslemYapan.SelectedIndex = 0;

            numTutar.Value = 0;
            txtAciklama.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Sebep = cmbSebep.Text;
                Tutar = numTutar.Value;
                Aciklama = txtAciklama.Text;
                IslemYapan = cmbIslemYapan.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateForm()
        {
            if (cmbSebep.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir sebep seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSebep.Focus();
                return false;
            }

            if (numTutar.Value <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numTutar.Focus();
                return false;
            }

            if (cmbIslemYapan.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen işlem yapan kişiyi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbIslemYapan.Focus();
                return false;
            }

            return true;
        }
    }
}
