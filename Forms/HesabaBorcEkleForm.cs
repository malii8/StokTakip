using System;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class HesabaBorcEkleForm : Form
    {
        private readonly StokTakipDbContext _context;
        private Customer? _customer;

        public HesabaBorcEkleForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            InitializeForm();
        }

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
            txtMusterininAdi.Text = _customer.Name;
            txtToplamBorc.Text = $"{_customer.Debt:F2} TL";
        }

        private void InitializeForm()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtSaat.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnOnayGreenTick_Click(object? sender, EventArgs e)
        {
            if (ValidateInput() && _customer != null)
            {
                decimal eklenecekTutar = decimal.TryParse(txtEklenecekTutar.Text, out decimal val) ? val : 0;
                string aciklama = txtAciklama.Text;

                try
                {
                    // Update customer debt
                    _customer.Debt += eklenecekTutar;

                    // Record customer debt movement
                    var debtMovement = new CustomerDebtMovement
                    {
                        CustomerId = _customer.Id,
                        Amount = eklenecekTutar,
                        MovementType = "Borç Ekleme",
                        MovementDate = DateTime.Parse(txtTarih.Text).Date + DateTime.Parse(txtSaat.Text).TimeOfDay,
                        Description = aciklama
                    };
                    _context.CustomerDebtMovements.Add(debtMovement);

                    _context.SaveChanges();

                    MessageBox.Show("Borç başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Borç eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVazgecRedX_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateInput()
        {
            if (_customer == null)
            {
                MessageBox.Show("Müşteri bilgisi yüklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txtEklenecekTutar.Text, out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Eklenecek tutar 0'dan büyük olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
