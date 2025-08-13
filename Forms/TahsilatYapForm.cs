using System;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class TahsilatYapForm : Form
    {
        private readonly StokTakipDbContext _context;
        private Customer? _customer;

        public decimal TahsilatTutari { get; private set; }
        public string Aciklama { get; private set; } = string.Empty;
        public string OdemeSekli { get; private set; } = string.Empty;

        public TahsilatYapForm(StokTakipDbContext context)
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

            // Default payment method
            rbNakit.Checked = true;
            OdemeSekli = "Nakit";
        }

        private void btnOnayla_Click(object? sender, EventArgs e)
        {
            if (ValidateInput() && _customer != null)
            {
                TahsilatTutari = Convert.ToDecimal(txtOdemeTutari.Text);
                Aciklama = txtAciklama.Text;

                if (rbNakit.Checked) OdemeSekli = "Nakit";
                else if (rbKrediKarti.Checked) OdemeSekli = "Kredi Kartı";
                else if (rbHavale.Checked) OdemeSekli = "Havale";

                try
                {
                    // Update customer debt
                    _customer.Debt -= TahsilatTutari;

                    // Record customer debt movement
                    var debtMovement = new CustomerDebtMovement
                    {
                        CustomerId = _customer.Id,
                        Amount = TahsilatTutari,
                        MovementType = "Tahsilat",
                        MovementDate = DateTime.Parse(txtTarih.Text).Date + DateTime.Parse(txtSaat.Text).TimeOfDay,
                        Description = Aciklama
                    };
                    _context.CustomerDebtMovements.Add(debtMovement);

                    // Record cash movement (Gelir)
                    var cashMovement = new CashMovement
                    {
                        MovementType = "Gelir",
                        Amount = TahsilatTutari,
                        MovementDate = DateTime.Parse(txtTarih.Text).Date + DateTime.Parse(txtSaat.Text).TimeOfDay,
                        Description = $"Müşteri tahsilatı: {_customer.Name}",
                        PaymentMethod = OdemeSekli,
                        Notes = Aciklama
                    };
                    _context.CashMovements.Add(cashMovement);

                    _context.SaveChanges();

                    MessageBox.Show("Tahsilat başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Tahsilat kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVazgec_Click(object? sender, EventArgs e)
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

            if (string.IsNullOrWhiteSpace(txtOdemeTutari.Text))
            {
                MessageBox.Show("Tahsilat tutarı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOdemeTutari.Focus();
                return false;
            }

            if (!decimal.TryParse(txtOdemeTutari.Text, out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Geçerli bir tahsilat tutarı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOdemeTutari.Focus();
                return false;
            }

            if (tutar > _customer.Debt)
            {
                MessageBox.Show("Tahsilat tutarı mevcut borçtan fazla olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOdemeTutari.Focus();
                return false;
            }

            return true;
        }

        private void rbOdemeSekli_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                OdemeSekli = rb.Text;
            }
        }
    }
}
