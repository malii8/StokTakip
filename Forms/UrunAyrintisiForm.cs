using System;
using System.Data;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Drawing;
using System.Drawing.Printing;

namespace StokTakip.Forms
{
    public partial class UrunAyrintisiForm : Form
    {
        private readonly StokTakipDbContext _context;
        private Product? _product;

        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private int currentRow = 0;

        public UrunAyrintisiForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            InitializeDateRanges(); // Set dates first
            SetupEventHandlers(); // Then setup event handlers

            printDocument.PrintPage += PrintDocument_PrintPage;
            printPreviewDialog.Document = printDocument;
        }

        public void SetProduct(Product product)
        {
            _product = product;
            LoadProductDetails();
            LoadProductMovements();
        }

        private void InitializeDateRanges()
        {
            // Set default date range
            dtpBaslangic.Value = new DateTime(2023, 1, 1); // Set to 01.01.2023
            dtpBitis.Value = DateTime.Now.AddDays(1); // Set to next day

            // Set default radio button selection
            rbSadeceSatislar.Checked = true;
        }

        private void SetupEventHandlers()
        {
            btnYazdir.Click += BtnYazdir_Click;
            btnExcelAktar.Click += BtnExcelAktar_Click;
            rbSadeceAlislar.CheckedChanged += RaporTuru_CheckedChanged;
            rbSadeceSatislar.CheckedChanged += RaporTuru_CheckedChanged;
            rbSadeceIadeAlinanlar.CheckedChanged += RaporTuru_CheckedChanged;
            rbSadeceIadeEdilenler.CheckedChanged += RaporTuru_CheckedChanged;

            dtpBaslangic.ValueChanged += DateFilter_Changed;
            dtpBitis.ValueChanged += DateFilter_Changed;
        }

        private void LoadProductDetails()
        {
            if (_product == null) return;

            // Assuming these labels exist in the designer. If not, they need to be added.
            // lblUrunAdi.Text = _product.Name;
            // lblBarkodNo.Text = _product.BarcodeNo;
            // lblStokKodu.Text = _product.StockCode;
            // lblMevcutStok.Text = _product.CurrentStock.ToString("F1");
            // lblAsgariStok.Text = _product.MinimumStock.ToString("F1");
            // lblAlisFiyati.Text = _product.PurchasePrice.ToString("F2");
            // lblSatisFiyati.Text = _product.SalePrice.ToString("F2");
            // lblKdvOrani.Text = _product.VatRate.ToString("F0");
            // lblOlcuBirimi.Text = _product.Unit;
            // lblUrunGrubu.Text = _product.ProductGroup?.Name ?? "BELİRTİLMEDİ";
        }

        private void LoadProductMovements()
        {
            dgvHareketler.Rows.Clear();

            if (_product == null)
            {
                MessageBox.Show("Ürün bilgisi yüklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var movements = _context.StockMovements
                    .Include(sm => sm.Wholesaler)
                    .Include(sm => sm.SalesReceipt)
                        .ThenInclude(sr => sr!.Customer) // Ensure Customer is loaded
                    .Where(sm => sm.ProductId == _product.Id &&
                                 sm.MovementDate >= dtpBaslangic.Value.Date &&
                                 sm.MovementDate <= dtpBitis.Value.Date)
                    .OrderByDescending(sm => sm.MovementDate)
                    .ToList();

                foreach (var movement in movements)
                {
                    string cariHesapAdi = "";
                    string hareketTuru = movement.MovementType;

                    // Check Notes to identify returns
                    bool isMusteriIade = !string.IsNullOrEmpty(movement.Notes) && movement.Notes.Contains("Müşteriden iade alınan");
                    bool isToptanciIade = !string.IsNullOrEmpty(movement.Notes) && movement.Notes.Contains("Toptancıdan iade alınan");

                    if (isMusteriIade)
                    {
                        hareketTuru = "İade Alınan"; // Customer returned the product
                        cariHesapAdi = movement.SalesReceipt?.Customer?.Name ?? "Perakende";
                    }
                    else if (isToptanciIade)
                    {
                        hareketTuru = "İade Edilen"; // Returned to supplier (but recorded as entry)
                        cariHesapAdi = movement.Wholesaler?.Name ?? "Toptancı";
                    }
                    else
                    {
                        // Regular movements
                        if (movement.MovementType == "Giriş" && movement.Wholesaler != null)
                        {
                            cariHesapAdi = movement.Wholesaler.Name;
                        }
                        else if (movement.MovementType == "Satış" && movement.SalesReceipt?.Customer != null)
                        {
                            cariHesapAdi = movement.SalesReceipt.Customer.Name;
                        }
                        else if (movement.MovementType == "Satış" && movement.SalesReceipt?.Customer == null)
                        {
                            cariHesapAdi = "Perakende";
                        }
                        else if (movement.MovementType == "İade") // Handle return movements
                        {
                            if (movement.Total > 0) // Assuming positive total for customer returns
                            {
                                cariHesapAdi = "Müşteri İadesi";
                            }
                            else // Assuming negative total for supplier returns
                            {
                                cariHesapAdi = "Toptancı İadesi";
                            }
                        }
                    }

                    dgvHareketler.Rows.Add(
                        movement.Id, // Sıra No
                        hareketTuru, // Hareket Türü (updated to show returns)
                        cariHesapAdi, // Cari Hesap Adı
                        movement.MovementDate.ToShortDateString(), // Tarih
                        movement.MovementDate.ToShortTimeString(), // Saat
                        _product.Name, // Ürün Adı
                        movement.UnitPrice.ToString("F2"), // Alış Fiyatı
                        movement.Total.ToString("F2"), // Satış Fiyatı
                        movement.Quantity.ToString("F1"), // Miktar
                        _product.VatRate.ToString("F0"), // KDV
                        "Aktif", // Durum
                        movement.Total.ToString("F2") // Toplam Tutar
                    );
                }
                UpdateSummaryBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün hareketleri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DateFilter_Changed(object? sender, EventArgs e)
        {
            LoadProductMovements(); // Reload data when date range changes
        }

        private void UpdateSummaryBoxes()
        {
            // Calculate summary values based on current data
            double urunGirisiToplam = 0;
            double satislarToplam = 0;
            double iadeEdilenToplam = 0;
            double iadeAlinanToplam = 0;

            int urunGirisiAdet = 0;
            int satislarAdet = 0;
            int iadeEdilenAdet = 0;
            int iadeAlinanAdet = 0;

            foreach (DataGridViewRow row in dgvHareketler.Rows)
            {
                if (row.IsNewRow || !row.Visible) continue; // Only process visible rows

                string hareketTuru = row.Cells["colHareketTuru"].Value?.ToString() ?? "";
                double tutar = double.TryParse(row.Cells["colToplamTutar"].Value?.ToString(), out double t) ? t : 0;
                int miktar = int.TryParse(row.Cells["colMiktar"].Value?.ToString(), out int m) ? m : 0;

                switch (hareketTuru.ToUpper())
                {
                    case "GİRİŞ":
                        urunGirisiToplam += tutar;
                        urunGirisiAdet += miktar;
                        break;
                    case "SATIŞ":
                        satislarToplam += tutar;
                        satislarAdet += miktar;
                        break;
                    case "İADE ALINAN":
                        iadeAlinanToplam += tutar;
                        iadeAlinanAdet += miktar;
                        break;
                    case "İADE EDILEN":
                        iadeEdilenToplam += tutar;
                        iadeEdilenAdet += miktar;
                        break;
                    case "İADE": // Eski iade kayıtları için
                        string cariHesapAdi = row.Cells["colCariHesapAdi"].Value?.ToString()?.ToUpper() ?? "";
                        if (cariHesapAdi == "MÜŞTERİ İADESİ")
                        {
                            iadeAlinanToplam += tutar;
                            iadeAlinanAdet += miktar;
                        }
                        else if (cariHesapAdi == "TOPTANCI İADESİ")
                        {
                            iadeEdilenToplam += Math.Abs(tutar);
                            iadeEdilenAdet += miktar;
                        }
                        break;
                }
            }

            // Update summary labels
            lblUrunGirisiTutar.Text = $"{urunGirisiToplam:F2} TL";
            lblUrunGirisiAdet.Text = urunGirisiAdet.ToString();

            lblSatislarTutar.Text = $"{satislarToplam:F2} TL";
            lblSatislarAdet.Text = satislarAdet.ToString();

            lblIadeEdilenTutar.Text = $"{iadeEdilenToplam:F2} TL";
            lblIadeEdilenAdet.Text = iadeEdilenAdet.ToString();

            lblIadeAlinanTutar.Text = $"{iadeAlinanToplam:F2} TL";
            lblIadeAlinanAdet.Text = iadeAlinanAdet.ToString();
        }

        private void RaporTuru_CheckedChanged(object? sender, EventArgs e)
        {
            FilterDataByReportType();
        }

        private void FilterDataByReportType()
        {
            foreach (DataGridViewRow row in dgvHareketler.Rows)
            {
                if (row.IsNewRow) continue;

                string hareketTuru = row.Cells["colHareketTuru"].Value?.ToString()?.ToUpper() ?? "";
                bool visible = true;

                if (rbSadeceAlislar.Checked && hareketTuru != "GİRİŞ")
                    visible = false;
                else if (rbSadeceSatislar.Checked && hareketTuru != "SATIŞ")
                    visible = false;
                else if (rbSadeceIadeAlinanlar.Checked && hareketTuru != "İADE ALINAN")
                    visible = false;
                else if (rbSadeceIadeEdilenler.Checked && hareketTuru != "İADE EDILEN")
                    visible = false;

                row.Visible = visible;
            }
            UpdateSummaryBoxes();
        }

        private void BtnYazdir_Click(object? sender, EventArgs e)
        {
            currentRow = 0; // Reset for each print job
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object? sender, PrintPageEventArgs e)
        {
            // Print header
            e.Graphics!.DrawString("Ürün Hareket Raporu", new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Black, 100, 100);

            int y = 150;
            int x = 100;
            int rowHeight = 0;

            if (dgvHareketler.Rows.Count > 0)
            {
                rowHeight = dgvHareketler.Rows[0].Height;
            }
            else
            {
                e.HasMorePages = false;
                return;
            }

            // Print column headers
            for (int i = 0; i < dgvHareketler.Columns.Count; i++)
            {
                e.Graphics.DrawString(dgvHareketler.Columns[i].HeaderText, new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Black, x, y);
                x += dgvHareketler.Columns[i].Width + 20; // Adjust spacing
            }
            y += rowHeight;

            // Print rows
            while (currentRow < dgvHareketler.Rows.Count)
            {
                x = 100;
                if (y + rowHeight > e.MarginBounds.Height) // Check if new page is needed
                {
                    e.HasMorePages = true;
                    return;
                }

                DataGridViewRow row = dgvHareketler.Rows[currentRow];
                for (int i = 0; i < dgvHareketler.Columns.Count; i++)
                {
                    e.Graphics.DrawString(row.Cells[i].Value?.ToString() ?? "", new System.Drawing.Font("Arial", 10), System.Drawing.Brushes.Black, x, y);
                    x += dgvHareketler.Columns[i].Width + 20;
                }
                y += rowHeight;
                currentRow++;
            }
            e.HasMorePages = false;
        }

        private void BtnExcelAktar_Click(object? sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Dosyaları (*.csv)|*.csv";
            saveFileDialog.Title = "Excel'e Aktar";
            saveFileDialog.FileName = "UrunHareketleri.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // Write header row
                        for (int i = 0; i < dgvHareketler.Columns.Count; i++)
                        {
                            sw.Write(dgvHareketler.Columns[i].HeaderText);
                            if (i < dgvHareketler.Columns.Count - 1)
                            {
                                sw.Write(";");
                            }
                        }
                        sw.WriteLine();

                        // Write data rows
                        foreach (DataGridViewRow row in dgvHareketler.Rows)
                        {
                            if (row.IsNewRow) continue;

                            for (int i = 0; i < dgvHareketler.Columns.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value?.ToString() ?? "");
                                if (i < dgvHareketler.Columns.Count - 1)
                                {
                                    sw.Write(";");
                                }
                            }
                            sw.WriteLine();
                        }
                    }
                    MessageBox.Show("Ürün hareketleri Excel'e başarıyla aktarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Excel'e aktarılırken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
