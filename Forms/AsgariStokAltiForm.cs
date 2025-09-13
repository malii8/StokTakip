using System;
using System.Data;
using System.Windows.Forms;
using StokTakip.Data;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace StokTakip.Forms
{
    public partial class AsgariStokAltiForm : Form
    {
        private readonly StokTakipDbContext _context;
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private int currentRow = 0;

        public AsgariStokAltiForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            LoadProductGroups(); // Load groups first
            LoadLowStockProducts(); // Then load products
            SetupEventHandlers();

            // Setup print document
            printDocument.PrintPage += PrintDocument_PrintPage;
            printPreviewDialog.Document = printDocument;
        }

        private void SetupEventHandlers()
        {
            txtUrunAra.TextChanged += TxtUrunAra_TextChanged;
            cmbUrunGrubu.SelectedIndexChanged += CmbUrunGrubu_SelectedIndexChanged;
            btnYazdir.Click += BtnYazdir_Click;
            btnExcelAktar.Click += BtnExcelAktar_Click;
        }

        private void LoadProductGroups()
        {
            cmbUrunGrubu.Items.Clear();
            cmbUrunGrubu.Items.Add("Tümü");
            try
            {
                var groups = _context.ProductGroups.OrderBy(g => g.Name).ToList();
                foreach (var group in groups)
                {
                    cmbUrunGrubu.Items.Add(group.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün grupları yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmbUrunGrubu.SelectedIndex = 0;
        }

        private void LoadLowStockProducts()
        {
            dgvAsgariStokAlti.Rows.Clear();

            try
            {
                var lowStockProducts = _context.Products
                    .Include(p => p.ProductGroup)
                    .Where(p => p.CurrentStock <= p.MinimumStock && p.IsActive)
                    .ToList();

                foreach (var product in lowStockProducts)
                {
                    dgvAsgariStokAlti.Rows.Add(
                        product.BarcodeNo, // Barkod No
                        product.Name, // Ürünün Adı
                        product.MinimumStock.ToString("F1"), // Asgari Stok
                        product.CurrentStock.ToString("F1"), // Mevcut Stok
                        product.Unit, // Ölçü Birimi
                        product.PurchasePrice.ToString("F2"), // Alış Fiyatı
                        product.SalePrice.ToString("F2"), // Satış Fiyatı
                        product.ProductGroup?.Name ?? "BELİRTİLMEDİ"  // Ürün Grubu
                    );
                }

                UpdateRecordCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Asgari stok altındaki ürünler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRecordCount()
        {
            int visibleRowCount = 0;
            foreach (DataGridViewRow row in dgvAsgariStokAlti.Rows)
            {
                if (!row.IsNewRow && row.Visible)
                {
                    visibleRowCount++;
                }
            }
            lblListelenenKayitSayisi.Text = visibleRowCount.ToString();
        }

        private void BtnYenile_Click(object? sender, EventArgs e)
        {
            LoadLowStockProducts();
            txtUrunAra.Clear();
            cmbUrunGrubu.SelectedIndex = 0;
        }

        private void TxtUrunAra_TextChanged(object? sender, EventArgs e)
        {
            FilterData();
        }

        private void CmbUrunGrubu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            string searchText = txtUrunAra.Text.ToUpper();
            string? selectedGroup = cmbUrunGrubu.SelectedItem?.ToString();

            foreach (DataGridViewRow row in dgvAsgariStokAlti.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = true;

                // Filter by search text
                if (!string.IsNullOrEmpty(searchText))
                {
                    string barkod = row.Cells["colBarkodNo"].Value?.ToString()?.ToUpper() ?? "";
                    string urunAdi = row.Cells["colUrunAdi"].Value?.ToString()?.ToUpper() ?? "";
                    string urunGrubu = row.Cells["colUrunGrubu"].Value?.ToString()?.ToUpper() ?? "";

                    if (!(barkod.Contains(searchText) || urunAdi.Contains(searchText) || urunGrubu.Contains(searchText)))
                    {
                        visible = false;
                    }
                }

                // Filter by product group
                if (visible && selectedGroup != "Tümü" && !string.IsNullOrEmpty(selectedGroup))
                {
                    string rowGroup = row.Cells["colUrunGrubu"].Value?.ToString() ?? "";
                    if (!rowGroup.ToUpper().Contains(selectedGroup.ToUpper()))
                    {
                        visible = false;
                    }
                }

                row.Visible = visible;
            }

            UpdateRecordCount();
        }

        private void BtnYazdir_Click(object? sender, EventArgs e)
        {
            try
            {
                currentRow = 0;
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yazdırma işleminde hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcelAktar_Click(object? sender, EventArgs e)
        {
            try
            {
                ExportToExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excel'e aktarma işleminde hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
            System.Drawing.Font headerFont = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            System.Drawing.Font dataFont = new System.Drawing.Font("Arial", 9);

            Brush blackBrush = Brushes.Black;

            int yPos = 50;
            int leftMargin = 50;

            // Title
            e.Graphics?.DrawString("ASGARİ STOK ALTINDAKİ ÜRÜNLER", titleFont, blackBrush, leftMargin, yPos);
            yPos += 40;

            // Date
            e.Graphics?.DrawString($"Rapor Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}", dataFont, blackBrush, leftMargin, yPos);
            yPos += 30;

            // Headers
            int[] columnWidths = { 80, 200, 80, 80, 60, 80, 80, 100 };
            string[] headers = { "Barkod", "Ürün Adı", "Asgari", "Mevcut", "Birim", "Alış", "Satış", "Grup" };

            int xPos = leftMargin;
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics?.DrawString(headers[i], headerFont, blackBrush, xPos, yPos);
                xPos += columnWidths[i];
            }
            yPos += 25;

            // Data rows
            int rowsPerPage = 25;
            int endRow = Math.Min(currentRow + rowsPerPage, dgvAsgariStokAlti.Rows.Count);

            for (int i = currentRow; i < endRow; i++)
            {
                if (dgvAsgariStokAlti.Rows[i].IsNewRow || !dgvAsgariStokAlti.Rows[i].Visible) continue;

                xPos = leftMargin;
                for (int j = 0; j < dgvAsgariStokAlti.Columns.Count && j < columnWidths.Length; j++)
                {
                    string cellValue = dgvAsgariStokAlti.Rows[i].Cells[j].Value?.ToString() ?? "";
                    e.Graphics?.DrawString(cellValue, dataFont, blackBrush, xPos, yPos);
                    xPos += columnWidths[j];
                }
                yPos += 20;
            }

            currentRow = endRow;
            e.HasMorePages = currentRow < dgvAsgariStokAlti.Rows.Count;
        }

        private void ExportToExcel()
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV Dosyaları (*.csv)|*.csv|Excel Dosyaları (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Asgari Stok Altındaki Ürünleri Kaydet";
                    saveFileDialog.FileName = $"AsgariStokAlti_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportToCSV(saveFileDialog.FileName);
                        MessageBox.Show($"Veriler başarıyla kaydedildi:\n{saveFileDialog.FileName}", 
                                      "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Dosyayı açmak isteyip istemediğini sor
                        if (MessageBox.Show("Kaydedilen dosyayı açmak ister misiniz?", "Dosyayı Aç", 
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = saveFileDialog.FileName,
                                UseShellExecute = true
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Dosya kaydetme hatası: {ex.Message}");
            }
        }

        private void ExportToCSV(string filePath)
        {
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Title
                writer.WriteLine("ASGARİ STOK ALTINDAKİ ÜRÜNLER");
                writer.WriteLine($"Rapor Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}");
                writer.WriteLine(); // Empty line

                // Headers
                var headers = new List<string> 
                { 
                    "Barkod No", "Ürün Adı", "Asgari Stok", "Mevcut Stok", 
                    "Ölçü Birimi", "Alış Fiyatı", "Satış Fiyatı", "Ürün Grubu" 
                };
                writer.WriteLine(string.Join(",", headers.Select(h => $"\"{h}\"")));

                // Data
                foreach (DataGridViewRow row in dgvAsgariStokAlti.Rows)
                {
                    if (row.IsNewRow || !row.Visible) continue;

                    var values = new List<string>();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        var cellValue = row.Cells[i].Value?.ToString()?.Replace("\"", "\"\"") ?? "";
                        values.Add($"\"{cellValue}\"");
                    }
                    writer.WriteLine(string.Join(",", values));
                }
            }
        }
    }
}
