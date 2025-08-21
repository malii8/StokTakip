using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.Forms
{
    public partial class MusterilerForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly StokTakipDbContext _context;

        public MusterilerForm(IServiceProvider serviceProvider, StokTakipDbContext context)
        {
            _serviceProvider = serviceProvider;
            _context = context;
            InitializeComponent();

            // Event handler'ları bağla
            btnMusteriBorcDetayi.Click += BtnMusteriBorcDetayi_Click;
            btnHesabaBorcEkle.Click += BtnHesabaBorcEkle_Click;
            btnTahsilatYap.Click += BtnTahsilatYap_Click;
            btnMusteriEkle.Click += BtnMusteriEkle_Click;
            btnMusteriBilgileriDuzenle.Click += BtnMusteriBilgileriDuzenle_Click;
            btnMusteriIade.Click += BtnMusteriIade_Click;
            btnMusteriBorcListesi.Click += BtnMusteriBorcListesi_Click;
            dgvMusteriler.CellDoubleClick += dgvMusteriler_CellDoubleClick; // Event handler for double click

            LoadCustomerData(); // Initial load
        }

        private void LoadCustomerData()
        {
            dgvMusteriler.Rows.Clear();
            try
            {
                var customers = _context.Customers.Where(c => c.IsActive).ToList();
                int siraNo = 1;
                foreach (var customer in customers)
                {
                    dgvMusteriler.Rows.Add(
                        siraNo++, // colSiraNo
                        customer.Name, // colMusterininAdi
                        customer.Debt.ToString("F2"), // colBorcu
                        customer.Id // colId (hidden)
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri verileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMusteriBorcDetayi_Click(object? sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMusteriler.SelectedRows[0];
                int customerId = Convert.ToInt32(selectedRow.Cells["colId"].Value);
                var customer = _context.Customers.Find(customerId);

                if (customer != null)
                {
                    var veresiyeDefteri = _serviceProvider.GetRequiredService<VeresiyeDefteri>();
                    veresiyeDefteri.SetCustomer(customer);
                    veresiyeDefteri.ShowDialog();
                    LoadCustomerData(); // Refresh data after form closes
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnHesabaBorcEkle_Click(object? sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMusteriler.SelectedRows[0];
                int customerId = Convert.ToInt32(selectedRow.Cells["colId"].Value);
                var customer = _context.Customers.Find(customerId);

                if (customer != null)
                {
                    var hesabaBorcEkleForm = _serviceProvider.GetRequiredService<HesabaBorcEkleForm>();
                    hesabaBorcEkleForm.SetCustomer(customer);
                    hesabaBorcEkleForm.ShowDialog();
                    LoadCustomerData(); // Refresh customer data after debt added
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnTahsilatYap_Click(object? sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMusteriler.SelectedRows[0];
                int customerId = Convert.ToInt32(selectedRow.Cells["colId"].Value);
                var customer = _context.Customers.Find(customerId);

                if (customer != null)
                {
                    var tahsilatYapForm = _serviceProvider.GetRequiredService<TahsilatYapForm>();
                    tahsilatYapForm.SetCustomer(customer);
                    tahsilatYapForm.ShowDialog();
                    LoadCustomerData(); // Refresh data after payment
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnMusteriEkle_Click(object? sender, EventArgs e)
        {
            var musteriEkleForm = _serviceProvider.GetRequiredService<MusteriEkleForm>();
            if (musteriEkleForm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomerData(); // Refresh data after new customer added
            }
        }

        private void BtnMusteriBilgileriDuzenle_Click(object? sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMusteriler.SelectedRows[0];
                int customerId = Convert.ToInt32(selectedRow.Cells["colId"].Value);
                var customer = _context.Customers.Find(customerId);

                if (customer != null)
                {
                    var musteriBilgileriDuzenleForm = _serviceProvider.GetRequiredService<MusteriBilgileriDuzenleForm>();
                    musteriBilgileriDuzenleForm.SetCustomer(customer);
                    if (musteriBilgileriDuzenleForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadCustomerData(); // Refresh data after customer updated
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz müşteriyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnMusteriIade_Click(object? sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMusteriler.SelectedRows[0];
                int customerId = Convert.ToInt32(selectedRow.Cells["colId"].Value);
                var customer = _context.Customers.Find(customerId);

                if (customer != null)
                {
                    var musteriIadeForm = _serviceProvider.GetRequiredService<MusteriIadeForm>();
                    musteriIadeForm.SetCustomer(customer);
                    if (musteriIadeForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadCustomerData(); // Refresh data after return
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnMusteriBorcListesi_Click(object? sender, EventArgs e)
        {
            var musteriBorcListesiForm = _serviceProvider.GetRequiredService<MusteriBorcListesiForm>();
            musteriBorcListesiForm.ShowDialog();
        }

        private void dgvMusteriler_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMusteriler.Rows[e.RowIndex];
                // The customer ID is now correctly stored in the colId column (which is hidden)
                int customerId = Convert.ToInt32(row.Cells["colId"].Value);
                var customer = _context.Customers.Find(customerId);

                if (customer != null)
                {
                    txtAdiSoyadi.Text = customer.Name;
                    txtTicariUnvani.Text = customer.CompanyName;
                    txtGsmTelefonu.Text = customer.Phone;
                    txtVergiDairesi.Text = customer.TaxOffice;
                    txtVergiNoTCN.Text = customer.TaxNumber;
                    txtAdres.Text = customer.Address;
                    txtEmail.Text = customer.Email;
                    txtOzelNotlar.Text = customer.Notes;
                    txtVeresiyeTop.Text = customer.Debt.ToString("F2");
                    // The following fields do not have direct mappings in the Customer model
                    // txtIlIlce.Text = customer.CityDistrict;
                    // txtBelirLenen.Text = customer.CreditLimit.ToString("F2");
                    // txtKalanTakTop.Text = customer.RemainingInstallmentAmount.ToString("F2");
                    // txtToplamBorc.Text = customer.TotalDebt.ToString("F2");
                }
            }
        }
    }
}
