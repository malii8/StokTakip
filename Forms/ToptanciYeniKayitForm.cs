using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class ToptanciYeniKayitForm : Form
    {
        public string ToptanciAdi { get; private set; } = string.Empty;
        public string SirketYetkisi { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string InternetAdresi { get; private set; } = string.Empty;
        public string VDaire { get; private set; } = string.Empty;
        public string VNo { get; private set; } = string.Empty;
        public string Adres { get; private set; } = string.Empty;
        public string IsTelefonu { get; private set; } = string.Empty;
        public string GsmTelefonu { get; private set; } = string.Empty;
        public string Fax { get; private set; } = string.Empty;
        public string OzelNotlar { get; private set; } = string.Empty;
        public decimal ToptanciyaOlanBorcunuz { get; private set; }

        private bool isEditMode;

        public ToptanciYeniKayitForm(bool editMode = false)
        {
            InitializeComponent();
            this.isEditMode = editMode;
            InitializeForm();
        }

        private void InitializeForm()
        {
            if (isEditMode)
            {
                this.Text = "Toptancı Bilgilerini Düzeltme";
                lblTitle.Text = "KAYIT DÜZELTME";
            }
            else
            {
                this.Text = "TOPTANCI YENI KAYIT";
                lblTitle.Text = "TOPTANCI YENI KAYIT";
                ClearAllFields();
            }
        }

        public void LoadToptanciData(string toptanciAdi, string sirketYetkisi = "", string email = "",
            string internetAdresi = "", string vDaire = "", string vNo = "", string adres = "",
            string isTelefonu = "", string gsmTelefonu = "", string fax = "", string ozelNotlar = "",
            decimal toptanciyaOlanBorcunuz = 0)
        {
            txtToptanciAdi.Text = toptanciAdi;
            txtSirketYetkisi.Text = sirketYetkisi;
            txtEmail.Text = email;
            txtInternetAdresi.Text = internetAdresi;
            txtVDaire.Text = vDaire;
            txtVNo.Text = vNo;
            txtAdres.Text = adres;
            txtIsTelefonu.Text = isTelefonu;
            txtGsmTelefonu.Text = gsmTelefonu;
            txtFax.Text = fax;
            txtOzelNotlar.Text = ozelNotlar;
            txtToptanciyaOlanBorcunuz.Text = toptanciyaOlanBorcunuz.ToString("F2");
        }

        private void ClearAllFields()
        {
            txtToptanciAdi.Clear();
            txtSirketYetkisi.Clear();
            txtEmail.Clear();
            txtInternetAdresi.Clear();
            txtVDaire.Clear();
            txtVNo.Clear();
            txtAdres.Clear();
            txtIsTelefonu.Clear();
            txtGsmTelefonu.Clear();
            txtFax.Clear();
            txtOzelNotlar.Clear();
            txtToptanciyaOlanBorcunuz.Text = "0,00";
        }

        private void BtnKaydet_Click(object? sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Collect data from form
                ToptanciAdi = txtToptanciAdi.Text.Trim();
                SirketYetkisi = txtSirketYetkisi.Text.Trim();
                Email = txtEmail.Text.Trim();
                InternetAdresi = txtInternetAdresi.Text.Trim();
                VDaire = txtVDaire.Text.Trim();
                VNo = txtVNo.Text.Trim();
                Adres = txtAdres.Text.Trim();
                IsTelefonu = txtIsTelefonu.Text.Trim();
                GsmTelefonu = txtGsmTelefonu.Text.Trim();
                Fax = txtFax.Text.Trim();
                OzelNotlar = txtOzelNotlar.Text.Trim();

                if (decimal.TryParse(txtToptanciyaOlanBorcunuz.Text, out decimal borc))
                {
                    ToptanciyaOlanBorcunuz = borc;
                }

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
            if (string.IsNullOrWhiteSpace(txtToptanciAdi.Text))
            {
                MessageBox.Show("Toptancı adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtToptanciAdi.Focus();
                return false;
            }

            // Email validation (if provided)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Geçerli bir e-mail adresi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
