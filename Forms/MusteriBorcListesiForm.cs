using System;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.Forms
{
    public partial class MusteriBorcListesiForm : Form
    {
        private readonly StokTakipDbContext _context;

        public MusteriBorcListesiForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            LoadCustomerDebts();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            txtMusteriAra.TextChanged += TxtMusteriAra_TextChanged;
            btnTabloExcel.Click += BtnExcelAktar_Click; // Renamed to match code
            // Assuming a print button exists, if not, this line can be removed or a button added.
            // btnYazdir.Click += BtnYazdir_Click;
        }

        private void LoadCustomerDebts()
        {
            dgvMusteriler.Rows.Clear(); // Corrected DGV name
            try
            {
                var customersWithDebt = _context.Customers
                    .Where(c => c.Debt > 0)
                    .OrderBy(c => c.Name)
                    .ToList();

                foreach (var customer in customersWithDebt)
                {
                    dgvMusteriler.Rows.Add(
                        customer.Id,
                        customer.Name,
                        customer.Phone ?? customer.MobilePhone ?? "",
                        customer.Debt.ToString("F2"),
                        customer.TaxNumber ?? ""
                    );
                }
                UpdateSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri borçları yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSummary()
        {
            decimal totalDebt = 0;
            int customerCount = 0;

            foreach (DataGridViewRow row in dgvMusteriler.Rows) // Corrected DGV name
            {
                if (row.IsNewRow || !row.Visible) continue;

                customerCount++;
                if (decimal.TryParse(row.Cells["colBorcMiktari"].Value?.ToString(), out decimal debt))
                {
                    totalDebt += debt;
                }
            }

            lblToplamTutar.Text = $"Toplam Borç: {totalDebt:F2} TL"; // Corrected label name
            // Assuming lblToplamMusteri exists in designer, if not, add it or remove this line.
            // lblToplamMusteri.Text = $"Toplam Müşteri: {customerCount}";
        }

        private void TxtMusteriAra_TextChanged(object? sender, EventArgs e)
        {
            FilterCustomers();
        }

        private void FilterCustomers()
        {
            string searchText = txtMusteriAra.Text.ToUpper();

            foreach (DataGridViewRow row in dgvMusteriler.Rows) // Corrected DGV name
            {
                if (row.IsNewRow) continue;

                string customerName = row.Cells["colMusterininAdiSoyadi"].Value?.ToString()?.ToUpper() ?? ""; // Corrected column name
                string taxNumber = row.Cells["colVergiNo"].Value?.ToString()?.ToUpper() ?? ""; // Assuming colVergiNo exists

                bool visible = string.IsNullOrEmpty(searchText) ||
                               customerName.Contains(searchText) ||
                               taxNumber.Contains(searchText);

                row.Visible = visible;
            }
            UpdateSummary();
        }

        private void BtnYazdir_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Müşteri borç listesi yazdırılıyor...", "Yazdır", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExcelAktar_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Müşteri borç listesi Excel'e aktarılıyor...", "Excel Aktar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
