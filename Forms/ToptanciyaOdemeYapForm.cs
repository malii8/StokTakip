using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class ToptanciyaOdemeYapForm : Form
    {
        public decimal OdemeTutari { get; private set; }
        public string Aciklama { get; private set; } = string.Empty;
        public string OdemeSekli { get; private set; } = string.Empty;

        private string toptanciAdi;
        private decimal toplamBorc;

        public ToptanciyaOdemeYapForm(string toptanciAdi, decimal toplamBorc)
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

            // Default payment method
            rbNakit.Checked = true;
            OdemeSekli = "Nakit";
        }

        private void BtnOnayla_Click(object? sender, EventArgs e)
        {
            if (ValidateInput())
            {
                OdemeTutari = Convert.ToDecimal(txtOdemeTutari.Text);
                Aciklama = txtAciklama.Text;

                if (rbNakit.Checked) OdemeSekli = "Nakit";
                else if (rbKrediKarti.Checked) OdemeSekli = "Kredi Kartı";
                else if (rbHavale.Checked) OdemeSekli = "Havale";

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
            if (string.IsNullOrWhiteSpace(txtOdemeTutari.Text))
            {
                MessageBox.Show("Ödeme tutarı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOdemeTutari.Focus();
                return false;
            }

            if (!decimal.TryParse(txtOdemeTutari.Text, out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Geçerli bir ödeme tutarı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOdemeTutari.Focus();
                return false;
            }

            if (tutar > toplamBorc)
            {
                MessageBox.Show("Ödeme tutarı toplam borçtan fazla olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOdemeTutari.Focus();
                return false;
            }

            return true;
        }

        private void RbOdemeSekli_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                OdemeSekli = rb.Text;
            }
        }
    }
}
