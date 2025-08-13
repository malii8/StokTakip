using System;
using System.Linq;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class ToptanciYeniKayitForm : Form
    {
        private readonly StokTakipDbContext _context;
        private Wholesaler? _currentWholesaler;

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

        public ToptanciYeniKayitForm(StokTakipDbContext context, Wholesaler? wholesaler = null)
        {
            _context = context;
            InitializeComponent();
            _currentWholesaler = wholesaler;
            this.isEditMode = (wholesaler != null);
            InitializeForm();
            if (isEditMode && _currentWholesaler != null)
            {
                LoadToptanciData(_currentWholesaler);
            }
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

        public void LoadToptanciData(Wholesaler wholesaler)
        {
            _currentWholesaler = wholesaler;
            txtToptanciAdi.Text = wholesaler.Name;
            txtSirketYetkisi.Text = wholesaler.ContactPerson;
            txtEmail.Text = wholesaler.Email;
            txtInternetAdresi.Text = wholesaler.Website;
            txtVDaire.Text = wholesaler.TaxOffice;
            txtVNo.Text = wholesaler.TaxNumber;
            txtAdres.Text = wholesaler.Address;
            txtIsTelefonu.Text = wholesaler.BusinessPhone;
            txtGsmTelefonu.Text = wholesaler.MobilePhone;
            txtFax.Text = wholesaler.Fax;
            txtOzelNotlar.Text = wholesaler.Notes;
            txtToptanciyaOlanBorcunuz.Text = wholesaler.Debt.ToString("F2");
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
                try
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

                    if (isEditMode && _currentWholesaler != null)
                    {
                        // Update existing Wholesaler entity
                        _currentWholesaler.Name = ToptanciAdi;
                        _currentWholesaler.ContactPerson = SirketYetkisi;
                        _currentWholesaler.Email = Email;
                        _currentWholesaler.Website = InternetAdresi;
                        _currentWholesaler.TaxOffice = VDaire;
                        _currentWholesaler.TaxNumber = VNo;
                        _currentWholesaler.Address = Adres;
                        _currentWholesaler.BusinessPhone = IsTelefonu;
                        _currentWholesaler.MobilePhone = GsmTelefonu;
                        _currentWholesaler.Fax = Fax;
                        _currentWholesaler.Notes = OzelNotlar;
                        _currentWholesaler.Debt = ToptanciyaOlanBorcunuz;
                        _currentWholesaler.UpdatedDate = DateTime.Now;

                        _context.Wholesalers.Update(_currentWholesaler);
                        MessageBox.Show("Toptancı bilgileri başarıyla güncellendi!", "Başarılı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Check if wholesaler with same name or tax number already exists
                        var existingWholesaler = _context.Wholesalers.FirstOrDefault(w =>
                            w.Name == ToptanciAdi ||
                            (!string.IsNullOrEmpty(VNo) && w.TaxNumber == VNo));

                        if (existingWholesaler != null)
                        {
                            MessageBox.Show("Bu toptancı adı veya vergi numarası zaten kayıtlı!", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Create new Wholesaler entity
                        var newWholesaler = new Wholesaler
                        {
                            Name = ToptanciAdi,
                            ContactPerson = SirketYetkisi,
                            Email = Email,
                            Website = InternetAdresi,
                            TaxOffice = VDaire,
                            TaxNumber = VNo,
                            Address = Adres,
                            BusinessPhone = IsTelefonu,
                            MobilePhone = GsmTelefonu,
                            Fax = Fax,
                            Notes = OzelNotlar,
                            Debt = ToptanciyaOlanBorcunuz,
                            IsActive = true,
                            CreatedDate = DateTime.Now
                        };

                        _context.Wholesalers.Add(newWholesaler);
                        MessageBox.Show("Toptancı başarıyla kaydedildi!", "Başarılı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    _context.SaveChanges();

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Toptancı kaydedilirken hata oluştu: {ex.Message}", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
