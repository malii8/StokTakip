using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using StokTakip.Models;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.Forms
{
    public partial class EskiFislerForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public EskiFislerForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            InitializeForm();
            SetupEventHandlers();
            LoadSalesReceipts(); // Load data from DB
        }

        private void InitializeForm()
        {
            // Set default date range to last 30 days
            dtpBaslangicTarihi.Value = DateTime.Now.AddDays(-30);
            dtpBitisTarihi.Value = DateTime.Now;

            // Set default payment type filter
            cmbOdemeTuru.SelectedIndex = 0; // "Tümü"

            // Apply filters on load
            ApplyFilters();
        }

        private void SetupEventHandlers()
        {
            btnAra.Click += BtnAra_Click;
            btnFisDetayi.Click += BtnFisDetayi_Click;
            btnFisIptal.Click += BtnFisIptal_Click;
            btnYazdir.Click += BtnYazdir_Click;
            btnExcel.Click += BtnExcel_Click;
            dgvEskiFisler.SelectionChanged += DgvEskiFisler_SelectionChanged;

            // Date change events
            dtpBaslangicTarihi.ValueChanged += DateFilter_Changed;
            dtpBitisTarihi.ValueChanged += DateFilter_Changed;
            cmbOdemeTuru.SelectedIndexChanged += Filter_Changed;
            txtMusteriAdi.TextChanged += Filter_Changed;
        }

        private void LoadSalesReceipts()
        {
            dgvEskiFisler.Rows.Clear();

            try
            {
                var salesReceipts = _context.SalesReceipts
                    .Include(sr => sr.Customer)
                    .OrderByDescending(sr => sr.ReceiptDate)
                    .ToList();

                foreach (var receipt in salesReceipts)
                {
                    dgvEskiFisler.Rows.Add(
                        receipt.ReceiptNumber, // Fiş No
                        receipt.ReceiptDate.ToShortDateString(), // Tarih
                        receipt.ReceiptDate.ToShortTimeString(), // Saat
                        receipt.PaymentType, // Corrected to PaymentType
                        receipt.Customer?.Name ?? "Perakende", // Müşteri Adı
                        receipt.Total.ToString("F2"), // Corrected to Total
                        receipt.Status // Durum
                    );
                }
                UpdateSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eski fişler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSummary()
        {
            decimal toplamTutar = 0;
            int fisAdet = 0;
            int iptalFisAdet = 0;

            foreach (DataGridViewRow row in dgvEskiFisler.Rows)
            {
                if (row.IsNewRow || !row.Visible) continue;

                fisAdet++;
                string durum = row.Cells["colDurum"].Value?.ToString() ?? "";

                if (durum == "İptal")
                {
                    iptalFisAdet++;
                }
                else if (decimal.TryParse(row.Cells["colTutar"].Value?.ToString(), out decimal tutar))
                {
                    toplamTutar += tutar;
                }
            }

            lblToplamFis.Text = $"Toplam Fiş: {fisAdet}";
            lblIptalFis.Text = $"İptal Fiş: {iptalFisAdet}";
            lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar:F2} TL";
        }

        private void ApplyFilters()
        {
            DateTime baslangic = dtpBaslangicTarihi.Value.Date;
            DateTime bitis = dtpBitisTarihi.Value.Date.AddDays(1).AddSeconds(-1);
            string musteriFilter = txtMusteriAdi.Text.Trim().ToLower();
            string odemeFilter = cmbOdemeTuru.SelectedItem?.ToString() ?? "";

            // Re-load data from DB based on filters, or filter existing data in grid
            // For simplicity, let's re-load from DB for now. For large datasets, client-side filtering might be better.
            dgvEskiFisler.Rows.Clear();

            try
            {
                var query = _context.SalesReceipts.Include(sr => sr.Customer).AsQueryable();

                // Date filter
                query = query.Where(sr => sr.ReceiptDate >= baslangic && sr.ReceiptDate <= bitis);

                // Customer filter
                if (!string.IsNullOrEmpty(musteriFilter))
                {
                    query = query.Where(sr => (sr.Customer != null && sr.Customer.Name.ToLower().Contains(musteriFilter)) ||
                                                (sr.Customer == null && "perakende".Contains(musteriFilter)));
                }

                // Payment type filter
                if (!string.IsNullOrEmpty(odemeFilter) && odemeFilter != "Tümü")
                {
                    query = query.Where(sr => sr.PaymentType == odemeFilter); // Corrected to PaymentType
                }

                var filteredReceipts = query.OrderByDescending(sr => sr.ReceiptDate).ToList();

                foreach (var receipt in filteredReceipts)
                {
                    dgvEskiFisler.Rows.Add(
                        receipt.ReceiptNumber, // Fiş No
                        receipt.ReceiptDate.ToShortDateString(), // Tarih
                        receipt.ReceiptDate.ToShortTimeString(), // Saat
                        receipt.PaymentType, // Corrected to PaymentType
                        receipt.Customer?.Name ?? "Perakende", // Müşteri Adı
                        receipt.Total.ToString("F2"), // Corrected to Total
                        receipt.Status // Durum
                    );
                }
                UpdateSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fişler filtrelenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DateFilter_Changed(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void Filter_Changed(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void BtnAra_Click(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void BtnFisDetayi_Click(object? sender, EventArgs e)
        {
            if (dgvEskiFisler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEskiFisler.SelectedRows[0];
                string fisNo = selectedRow.Cells["colFisNo"].Value?.ToString() ?? "";

                var salesReceipt = _context.SalesReceipts.FirstOrDefault(sr => sr.ReceiptNumber == fisNo);

                if (salesReceipt != null)
                {
                    using (var detayForm = _serviceProvider.GetRequiredService<FisDetayiForm>())
                    {
                        detayForm.SetSalesReceipt(salesReceipt);
                        detayForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen fiş bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir fiş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnFisIptal_Click(object? sender, EventArgs e)
        {
            if (dgvEskiFisler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEskiFisler.SelectedRows[0];
                string fisNo = selectedRow.Cells["colFisNo"].Value?.ToString() ?? "";

                var salesReceipt = _context.SalesReceipts.FirstOrDefault(sr => sr.ReceiptNumber == fisNo);

                if (salesReceipt != null)
                {
                    if (salesReceipt.Status == "İptal")
                    {
                        MessageBox.Show("Bu fiş zaten iptal edilmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show($"Fiş No: {fisNo}\n\nBu fişi iptal etmek istediğinizden emin misiniz?",
                        "Fiş İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        salesReceipt.Status = "İptal";
                        _context.SaveChanges();

                        selectedRow.Cells["colDurum"].Value = "İptal";
                        selectedRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

                        UpdateSummary();
                        MessageBox.Show("Fiş başarıyla iptal edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen fiş bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir fiş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnYazdir_Click(object? sender, EventArgs e)
        {
            if (dgvEskiFisler.SelectedRows.Count > 0)
            {
                // Show print preview dialog
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir fiş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (e.Graphics == null) return;
            if (dgvEskiFisler.SelectedRows.Count == 0) return;

            DataGridViewRow selectedRow = dgvEskiFisler.SelectedRows[0];
            string fisNo = selectedRow.Cells["colFisNo"].Value?.ToString() ?? "";
            string tarih = selectedRow.Cells["colTarih"].Value?.ToString() ?? "";
            string saat = selectedRow.Cells["colSaat"].Value?.ToString() ?? "";
            string odemeTuru = selectedRow.Cells["colOdemeTuru"].Value?.ToString() ?? "";
            string musteriAdi = selectedRow.Cells["colMusteriAdi"].Value?.ToString() ?? "";
            string tutar = selectedRow.Cells["colTutar"].Value?.ToString() ?? "";
            string durum = selectedRow.Cells["colDurum"].Value?.ToString() ?? "";

            int y = 40;
            int lineHeight = 30;
            var font = new System.Drawing.Font("Arial", 12);
            var boldFont = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);

            e.Graphics.DrawString("Fiş Bilgileri", boldFont, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            e.Graphics.DrawString($"Fiş No: {fisNo}", font, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            e.Graphics.DrawString($"Tarih: {tarih}", font, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            e.Graphics.DrawString($"Saat: {saat}", font, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            e.Graphics.DrawString($"Ödeme Türü: {odemeTuru}", font, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            e.Graphics.DrawString($"Müşteri Adı: {musteriAdi}", font, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            e.Graphics.DrawString($"Tutar: {tutar}", font, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            e.Graphics.DrawString($"Durum: {durum}", font, System.Drawing.Brushes.Black, 40, y);
        }

        private void BtnExcel_Click(object? sender, EventArgs e)
        {
            if (dgvEskiFisler.Rows.Count == 0)
            {
                MessageBox.Show("Dışa aktarılacak veri bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyası (*.csv)|*.csv";
            saveFileDialog.Title = "Excel'e Aktar";
            saveFileDialog.FileName = "EskiFisler_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // Başlıkları yaz
                        for (int i = 0; i < dgvEskiFisler.Columns.Count; i++)
                        {
                            sw.Write(dgvEskiFisler.Columns[i].HeaderText);
                            if (i < dgvEskiFisler.Columns.Count - 1)
                            {
                                sw.Write(";");
                            }
                        }
                        sw.WriteLine();

                        // Satırları yaz
                        foreach (DataGridViewRow row in dgvEskiFisler.Rows)
                        {
                            if (row.IsNewRow) continue;

                            for (int i = 0; i < dgvEskiFisler.Columns.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value?.ToString() ?? "");
                                if (i < dgvEskiFisler.Columns.Count - 1)
                                {
                                    sw.Write(";");
                                }
                            }
                            sw.WriteLine();
                        }
                    }
                    MessageBox.Show("Veriler Excel'e başarıyla aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veriler Excel'e aktarılırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvEskiFisler_SelectionChanged(object? sender, EventArgs e)
        {
            bool hasSelection = dgvEskiFisler.SelectedRows.Count > 0;
            btnFisDetayi.Enabled = hasSelection;
            btnFisIptal.Enabled = hasSelection;
            btnYazdir.Enabled = hasSelection;
        }
    }
}
