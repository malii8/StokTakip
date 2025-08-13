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

            // Add more validation as needed

            return true;
        }
    }
}
