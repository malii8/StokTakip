using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class ToptanciBorcunaEklemeForm : Form
    {
        public decimal EklenecekTutar { get; private set; }
        public string Aciklama { get; private set; } = string.Empty;

        private string toptanciAdi;
        private decimal toplamBorc;

        public ToptanciBorcunaEklemeForm(string toptanciAdi, decimal toplamBorc)
        {
            InitializeComponent();
            this.toptanciAdi = toptanciAdi;
            this.toplamBorc = toplamBorc;
            InitializeForm();
        }

        private void InitializeForm()
        {
            txtToptanciAdi.Text = toptanciAdi;
            txtToplamBorc.Text = $"{toplamBorc:F2} TL";
            dtpTarih.Value = DateTime.Now;
            dtpSaat.Value = DateTime.Now;
        }

        private void BtnOnayla_Click(object? sender, EventArgs e)
        {
            if (ValidateInput())
            {
                EklenecekTutar = Convert.ToDecimal(txtEklenecekTutar.Text);
                Aciklama = txtAciklama.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnVazgec_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtEklenecekTutar.Text))
            {
                MessageBox.Show("Eklenecek tutar boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEklenecekTutar.Focus();
                return false;
            }

            if (!decimal.TryParse(txtEklenecekTutar.Text, out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Geçerli bir tutar giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEklenecekTutar.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAciklama.Text))
            {
                MessageBox.Show("Açıklama boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAciklama.Focus();
                return false;
            }

            return true;
        }
    }
}
