using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using StokTakip.Models;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.Forms
{
    public partial class MusteriBulForm : Form
    {
        public Customer? SelectedCustomer { get; private set; }
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public MusteriBulForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            LoadCustomers();

            // Event handler'ları bağla
            btnYeniMusteriEkle.Click += BtnYeniMusteriEkle_Click;
            dgvMusteriler.CellDoubleClick += DgvMusteriler_CellDoubleClick;
            txtMusteriAra.TextChanged += TxtMusteriAra_TextChanged;
        }

        private void LoadCustomers()
        {
            dgvMusteriler.Rows.Clear();
            try
            {
                var customers = _context.Customers.Where(c => c.IsActive).OrderBy(c => c.Name).ToList();
                foreach (var customer in customers)
                {
                    dgvMusteriler.Rows.Add(
                        customer.Id,
                        customer.Name,
                        customer.Debt.ToString("F2")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri verileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnYeniMusteriEkle_Click(object? sender, EventArgs e)
        {
            var musteriEkleForm = _serviceProvider.GetRequiredService<MusteriEkleForm>();
            if (musteriEkleForm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers(); // Refresh data after new customer added
            }
        }

        private void DgvMusteriler_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int customerId = Convert.ToInt32(dgvMusteriler.Rows[e.RowIndex].Cells["colId"].Value);
                SelectedCustomer = _context.Customers.Find(customerId);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void TxtMusteriAra_TextChanged(object? sender, EventArgs e)
        {
            string searchText = txtMusteriAra.Text.ToLower();

            foreach (DataGridViewRow row in dgvMusteriler.Rows)
            {
                if (row.IsNewRow) continue;

                string customerName = row.Cells["colMusterininAdiSoyadi"].Value?.ToString()?.ToLower() ?? "";
                row.Visible = customerName.Contains(searchText);
            }
        }
    }
}
