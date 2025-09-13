using System;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;
using Microsoft.EntityFrameworkCore;
using ClosedXML.Excel; // Use ClosedXML for Excel export

namespace StokTakip.Forms
{
    public partial class MusteriBorcListesiForm : Form
    {
        private readonly StokTakipDbContext _context;

        public MusteriBorcListesiForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            SetupEventHandlers();
            LoadCustomerDebts(); // Call after setting up event handlers
        }

        private void SetupEventHandlers()
        {
            txtMusteriAra.TextChanged += TxtMusteriAra_TextChanged;
            btnTabloExcel.Click += BtnExcelAktar_Click;
            rbAdaGoreSirala.CheckedChanged += SortRadioButtons_CheckedChanged;
            rbSonIslemTarihineGoreSirala.CheckedChanged += SortRadioButtons_CheckedChanged;
            rbBorcMiktarinaGoreSirala.CheckedChanged += SortRadioButtons_CheckedChanged;
            chkBorcuSifirTLOlanlar.CheckedChanged += ChkBorcuSifirTLOlanlar_CheckedChanged;
        }

        private void LoadCustomerDebts()
        {
            dgvMusteriler.Rows.Clear();
            try
            {
                IQueryable<Customer> query = _context.Customers;

                if (!chkBorcuSifirTLOlanlar.Checked)
                {
                    query = query.Where(c => c.Debt > 0);
                }

                // Apply sorting based on selected radio button
                if (rbAdaGoreSirala.Checked)
                {
                    query = query.OrderBy(c => c.Name);
                }
                else if (rbSonIslemTarihineGoreSirala.Checked)
                {
                    // Assuming Customer model has a LastTransactionDate property
                    // If not, you might need to adjust this or add it to the model
                    query = query.OrderByDescending(c => c.LastTransactionDate);
                }
                else if (rbBorcMiktarinaGoreSirala.Checked)
                {
                    query = query.OrderByDescending(c => c.Debt);
                }
                else
                {
                    query = query.OrderBy(c => c.Name); // Default sort
                }

                var customers = query.ToList();

                foreach (var customer in customers)
                {
                    dgvMusteriler.Rows.Add(
                        customer.Id,
                        customer.Name,
                        customer.Debt.ToString("F2"),
                        customer.LastTransactionDate?.ToString("dd.MM.yyyy") ?? "", // Format date
                        customer.Phone ?? customer.MobilePhone ?? "",
                        customer.Address ?? "" // Populate Address column
                    );
                }
                UpdateSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri borçları yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SortRadioButtons_CheckedChanged(object? sender, EventArgs e)
        {
            LoadCustomerDebts(); // Reload and re-sort when a radio button is checked
        }

        private void ChkBorcuSifirTLOlanlar_CheckedChanged(object? sender, EventArgs e)
        {
            LoadCustomerDebts(); // Reload when checkbox state changes
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

            lblToplamTutar.Text = $"Toplam Borç: {totalDebt:F2} TL";
        }

        private void TxtMusteriAra_TextChanged(object? sender, EventArgs e)
        {
            FilterCustomers();
        }

        private void FilterCustomers()
        {
            string searchText = txtMusteriAra.Text.ToUpper();

            foreach (DataGridViewRow row in dgvMusteriler.Rows)
            {
                if (row.IsNewRow) continue;

                string customerName = row.Cells["colMusterininAdiSoyadi"].Value?.ToString()?.ToUpper() ?? "";
                string address = row.Cells["colAdres"].Value?.ToString()?.ToUpper() ?? ""; // Get Address for filtering

                bool visible = string.IsNullOrEmpty(searchText) ||
                               customerName.Contains(searchText) ||
                               address.Contains(searchText); // Filter by Address

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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyası|*.xlsx";
            saveFileDialog.Title = "Excel'e Aktar";
            saveFileDialog.FileName = "MusteriBorcListesi.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Müşteri Borç Listesi");

                        // Add headers
                        for (int i = 0; i < dgvMusteriler.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvMusteriler.Columns[i].HeaderText;
                        }

                        // Add data
                        for (int i = 0; i < dgvMusteriler.Rows.Count; i++)
                        {
                            if (dgvMusteriler.Rows[i].IsNewRow) continue;
                            for (int j = 0; j < dgvMusteriler.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dgvMusteriler.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Müşteri borç listesi Excel'e başarıyla aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Excel'e aktarılırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
