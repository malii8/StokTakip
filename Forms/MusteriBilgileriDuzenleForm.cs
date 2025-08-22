using System;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class MusteriBilgileriDuzenleForm : Form
    {
        private readonly StokTakipDbContext _context;
        private Customer? _customer;

        public MusteriBilgileriDuzenleForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            SetupEventHandlers();
        }

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
            LoadCustomerData();
        }

        private void SetupEventHandlers()
        {
            btnKaydet.Click += BtnKaydet_Click;
            btnVazgec.Click += BtnVazgec_Click;
        }

        private void LoadCustomerData()
        {
            if (_customer == null) return;

            txtAdi.Text = _customer.Name;
            txtTicariUnvani.Text = _customer.CompanyName;
            txtGsmTelefonu.Text = _customer.MobilePhone;
            txtEmail.Text = _customer.Email;
            txtAdres.Text = _customer.Address;
            txtVergiDairesi.Text = _customer.TaxOffice;
            txtVergiNumarasi.Text = _customer.TaxNumber;
            txtOzelNotlar.Text = _customer.Notes;
            txtLimitBelirle.Text = _customer.CreditLimit == 0 ? "Limitsiz" : _customer.CreditLimit.ToString("F2");
        }

        private void BtnKaydet_Click(object? sender, EventArgs e)
        {
            if (_customer == null) return;

            try
            {
                _customer.Name = txtAdi.Text;
                _customer.CompanyName = txtTicariUnvani.Text;
                _customer.MobilePhone = txtGsmTelefonu.Text;
                _customer.Email = txtEmail.Text;
                _customer.Address = txtAdres.Text;
                _customer.TaxOffice = txtVergiDairesi.Text;
                _customer.TaxNumber = txtVergiNumarasi.Text;
                _customer.Notes = txtOzelNotlar.Text;

                if (txtLimitBelirle.Text == "Limitsiz")
                {
                    _customer.CreditLimit = 0;
                }
                else
                {
                    if (decimal.TryParse(txtLimitBelirle.Text, out decimal creditLimit))
                    {
                        _customer.CreditLimit = creditLimit;
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir limit değeri giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                _customer.UpdatedDate = DateTime.Now;

                _context.Customers.Update(_customer);
                _context.SaveChanges();

                MessageBox.Show("Müşteri bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri bilgileri güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVazgec_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
