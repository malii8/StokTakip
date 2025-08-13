using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using StokTakip.Models;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.Forms
{
    public partial class VeresiyeDefteri : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;
        private Customer? _customer;

        public VeresiyeDefteri(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            // Event handler'ları bağla
            btnTahsilatYap.Click += BtnTahsilatYap_Click;
            btnHesabaBorcEkle.Click += BtnHesabaBorcEkle_Click;
        }

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
            LoadCustomerDetails();
            LoadDebtMovements();
        }

        private void LoadCustomerDetails()
        {
            if (_customer == null) return;

            txtMusterininAdi.Text = _customer.Name;
            lblBorcMiktariValue.Text = $"{_customer.Debt:F2} TL";

            // Set debt status color
            if (_customer.Debt > 0)
            {
                lblBorcMiktariValue.ForeColor = System.Drawing.Color.Red;
                // Assuming lblBorcDurumu exists in designer
                // lblBorcDurumu.Text = "BORÇLU";
                // lblBorcDurumu.ForeColor = System.Drawing.Color.Red;
            }
            else if (_customer.Debt < 0)
            {
                lblBorcMiktariValue.ForeColor = System.Drawing.Color.Green;
                // lblBorcDurumu.Text = "ALACAKLI";
                // lblBorcDurumu.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblBorcMiktariValue.ForeColor = System.Drawing.Color.Black;
                // lblBorcDurumu.Text = "BORÇ YOK";
                // lblBorcDurumu.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void LoadDebtMovements()
        {
            dgvBorcDetayi.Rows.Clear();

            if (_customer == null) return;

            try
            {
                var movements = _context.CustomerDebtMovements
                    .Where(m => m.CustomerId == _customer.Id)
                    .OrderByDescending(m => m.MovementDate)
                    .ToList();

                foreach (var movement in movements)
                {
                    string borc = "0,00";
                    string tahsilat = "0,00";

                    if (movement.MovementType == "Borç Ekleme")
                    {
                        borc = movement.Amount.ToString("F2");
                    }
                    else if (movement.MovementType == "Tahsilat")
                    {
                        tahsilat = movement.Amount.ToString("F2");
                    }

                    dgvBorcDetayi.Rows.Add(
                        movement.Id, // Assuming a column for Sira No
                        movement.MovementDate.ToShortDateString(),
                        movement.MovementType,
                        "0,00", // Onceki Bakiye - This would require more complex logic
                        movement.Amount.ToString("F2"), // Islem Tutari
                        _customer.Debt.ToString("F2"), // Kalan Borc - This will be current debt
                        movement.Description ?? ""
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Borç hareketleri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTahsilatYap_Click(object? sender, EventArgs e)
        {
            if (_customer == null) return;

            var tahsilatYapForm = _serviceProvider.GetRequiredService<TahsilatYapForm>();
            tahsilatYapForm.SetCustomer(_customer);
            if (tahsilatYapForm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomerDetails(); // Refresh customer details
                LoadDebtMovements(); // Refresh movements
            }
        }

        private void BtnHesabaBorcEkle_Click(object? sender, EventArgs e)
        {
            if (_customer == null) return;

            var hesabaBorcEkleForm = _serviceProvider.GetRequiredService<HesabaBorcEkleForm>();
            hesabaBorcEkleForm.SetCustomer(_customer);
            if (hesabaBorcEkleForm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomerDetails(); // Refresh customer details
                LoadDebtMovements(); // Refresh movements
            }
        }
    }
}
