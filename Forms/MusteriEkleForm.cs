using System;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class MusteriEkleForm : Form
    {
        private readonly StokTakipDbContext _context;

        public MusteriEkleForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            btnKaydet.Click += BtnKaydet_Click;
            btnVazgec.Click += BtnVazgec_Click;
            btnTemizle.Click += BtnTemizle_Click;
            txtKrediLimiti.KeyPress += TxtNumeric_KeyPress;
            txtGsmTelefonu.KeyPress += TxtNumeric_KeyPress;
            txtVergiNoTCN.KeyPress += TxtNumeric_KeyPress;
        }

        private void TxtNumeric_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Sadece rakam, virgül ve backspace tuşlarına izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Sadece bir virgül olmasına izin ver
            if ((e.KeyChar == ',') && ((sender as TextBox)?.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnKaydet_Click(object? sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    var newCustomer = new Customer
                    {
                        Name = txtAdiSoyadi.Text,
                        CompanyName = txtTicariUnvani.Text,
                        Phone = "", // Assuming no separate phone field, use GsmTelefonu
                        MobilePhone = txtGsmTelefonu.Text,
                        Email = txtEmail.Text,
                        Address = txtAdres.Text,
                        TaxOffice = txtVergiDairesi.Text,
                        TaxNumber = txtVergiNoTCN.Text,
                        Notes = txtOzelNotlar.Text,
                        Debt = 0, // New customer starts with 0 debt
                        IsActive = true,
                        CreatedDate = DateTime.Now
                    };

                    _context.Customers.Add(newCustomer);
                    _context.SaveChanges();

                    MessageBox.Show("Müşteri başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Müşteri eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnVazgec_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnTemizle_Click(object? sender, EventArgs e)
        {
            txtAdiSoyadi.Clear();
            txtTicariUnvani.Clear();
            txtGsmTelefonu.Clear();
            txtVergiDairesi.Clear();
            txtVergiNoTCN.Clear();
            txtAdres.Clear();
            // İl / İlçe alanı için varsayılan değer veya temizleme
            // Ülke alanı için varsayılan değer veya temizleme
            txtEmail.Clear();
            txtOzelNotlar.Clear();
            txtKrediLimiti.Text = "0,00"; // Kredi limiti için varsayılan değer
            txtAdiSoyadi.Focus();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtAdiSoyadi.Text))
            {
                MessageBox.Show("Adı Soyadı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdiSoyadi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGsmTelefonu.Text))
            {
                MessageBox.Show("Gsm Telefonu boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGsmTelefonu.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTicariUnvani.Text))
            {
                MessageBox.Show("Ticari Ünvanı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTicariUnvani.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtVergiDairesi.Text))
            {
                MessageBox.Show("Vergi Dairesi boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVergiDairesi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtVergiNoTCN.Text))
            {
                MessageBox.Show("Vergi No/TCN boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVergiNoTCN.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAdres.Text))
            {
                MessageBox.Show("Adres boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdres.Focus();
                return false;
            }

            // Kredi Limiti için sayısal kontrol zaten KeyPress olayında yapılıyor, ancak burada da bir kontrol ekleyebiliriz.
            if (!string.IsNullOrWhiteSpace(txtKrediLimiti.Text) && txtKrediLimiti.Text != "Limitsiz")
            {
                if (!decimal.TryParse(txtKrediLimiti.Text, out _))
                {
                    MessageBox.Show("Geçerli bir Kredi Limiti değeri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKrediLimiti.Focus();
                    return false;
                }
            }

            return true;
        }
    }
}
