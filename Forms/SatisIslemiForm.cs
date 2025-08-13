using Microsoft.Extensions.DependencyInjection;
using StokTakip.Models;
using StokTakip.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.Forms
{
    public partial class SatisIslemiForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;
        private Customer? _selectedCustomer;

        public SatisIslemiForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _serviceProvider = serviceProvider;

            // Event handler'ları bağla
            btnMusteriSec.Click += BtnMusteriSec_Click;
            btnEskiFisler.Click += BtnEskiFisler_Click;
            btnSatisIptal.Click += BtnSatisIptal_Click;
            btnUrunAra.Click += BtnUrunAra_Click;
            txtBarkod.KeyDown += TxtBarkod_KeyDown; // Corrected control name
            dgvSatisListesi.CellEndEdit += DgvSatisListesi_CellEndEdit; // For quantity/price changes

            // Payment buttons
            btnNakit.Click += (s, e) => BtnSatisYap_Click(s, e, "Nakit");
            btnKrediKarti.Click += (s, e) => BtnSatisYap_Click(s, e, "Kredi Kartı");
            btnVeresiye.Click += (s, e) => BtnSatisYap_Click(s, e, "Veresiye");
            btnHavale.Click += (s, e) => BtnSatisYap_Click(s, e, "Havale");
            btnNakitKredi.Click += (s, e) => BtnSatisYap_Click(s, e, "Nakit + Kredi Kartı");

            // Other buttons
            // btnUrunEkle.Click += BtnUrunEkle_Click; // This button is not in designer, using barcode input instead
            // btnYeniSatis.Click += BtnYeniSatis_Click; // Using btnSatisIptal for new sale
        }

        private void BtnMusteriSec_Click(object? sender, EventArgs e)
        {
            var musteriBulForm = _serviceProvider.GetRequiredService<MusteriBulForm>();
            if (musteriBulForm.ShowDialog() == DialogResult.OK)
            {
                _selectedCustomer = musteriBulForm.SelectedCustomer;
                if (_selectedCustomer != null)
                {
                    // lblMusteriAdi.Text = _selectedCustomer.Name; // Assuming lblMusteriAdi exists
                    MessageBox.Show($"Seçilen müşteri: {_selectedCustomer.Name}", "Müşteri Seçildi");
                }
            }
        }

        private void BtnEskiFisler_Click(object? sender, EventArgs e)
        {
            using (var eskiFislerForm = _serviceProvider.GetRequiredService<EskiFislerForm>())
            {
                eskiFislerForm.ShowDialog();
            }
        }

        private void BtnUrunEkle_Click(object? sender, EventArgs e)
        {
            // This method is not directly used as product is added via barcode input
        }

        private void TxtBarkod_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddProductToSale(txtBarkod.Text); // Corrected control name
                txtBarkod.Clear(); // Corrected control name
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void AddProductToSale(string barcodeNo)
        {
            if (string.IsNullOrWhiteSpace(barcodeNo)) return;

            var product = _context.Products.FirstOrDefault(p => p.BarcodeNo == barcodeNo);
            if (product == null)
            {
                MessageBox.Show("Ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if product already in list, if so, increase quantity
            foreach (DataGridViewRow row in dgvSatisListesi.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["colBarkodNo"].Value?.ToString() == barcodeNo)
                {
                    decimal currentQuantity = decimal.TryParse(row.Cells["colMiktar"].Value?.ToString(), out decimal q) ? q : 0;
                    row.Cells["colMiktar"].Value = currentQuantity + 1;
                    UpdateRowTotal(row);
                    CalculateTotals();
                    return;
                }
            }

            // Add new product to grid
            dgvSatisListesi.Rows.Add(
                product.BarcodeNo,
                product.Name,
                product.SalePrice.ToString("F2"),
                1, // Default quantity
                product.Unit,
                product.SalePrice.ToString("F2"), // Initial total
                product.VatRate.ToString("F0"),
                product.Id // Hidden product ID
            );
            CalculateTotals();
        }

        private void DgvSatisListesi_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSatisListesi.Columns["colMiktar"].Index ||
                e.ColumnIndex == dgvSatisListesi.Columns["colSatisFiyati"].Index) // Assuming colSatisFiyati is editable
            {
                UpdateRowTotal(dgvSatisListesi.Rows[e.RowIndex]);
                CalculateTotals();
            }
        }

        private void UpdateRowTotal(DataGridViewRow row)
        {
            decimal quantity = decimal.TryParse(row.Cells["colMiktar"].Value?.ToString(), out decimal q) ? q : 0;
            decimal unitPrice = decimal.TryParse(row.Cells["colSatisFiyati"].Value?.ToString(), out decimal up) ? up : 0; // Corrected column name
            row.Cells["colToplamTutar"].Value = (quantity * unitPrice).ToString("F2");
        }

        private void CalculateTotals()
        {
            decimal subTotal = 0;
            decimal totalVat = 0;
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dgvSatisListesi.Rows)
            {
                if (row.IsNewRow) continue;

                decimal quantity = decimal.TryParse(row.Cells["colMiktar"].Value?.ToString(), out decimal q) ? q : 0;
                decimal unitPrice = decimal.TryParse(row.Cells["colSatisFiyati"].Value?.ToString(), out decimal up) ? up : 0; // Corrected column name
                decimal vatRate = decimal.TryParse(row.Cells["colKdvOrani"].Value?.ToString(), out decimal vr) ? vr : 0;

                decimal itemTotal = quantity * unitPrice;
                decimal itemVat = itemTotal * (vatRate / 100);

                subTotal += itemTotal;
                totalVat += itemVat;
                grandTotal += itemTotal + itemVat;
            }

            // Assuming lblToplam is the main total label
            lblToplam.Text = $"{grandTotal:F2} TL";
            // If you have separate labels for subtotal and VAT, uncomment and assign:
            // lblAraToplam.Text = $"{subTotal:F2} TL";
            // lblKdvToplam.Text = $"{totalVat:F2} TL";
        }

        private void BtnSatisYap_Click(object? sender, EventArgs e, string paymentMethod)
        {
            if (dgvSatisListesi.Rows.Count == 0 || (dgvSatisListesi.Rows.Count == 1 && dgvSatisListesi.Rows[0].IsNewRow))
            {
                MessageBox.Show("Satış listesi boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Create SalesReceipt
                var salesReceipt = new SalesReceipt
                {
                    ReceiptNumber = GenerateReceiptNumber(),
                    ReceiptDate = DateTime.Now,
                    CustomerId = _selectedCustomer?.Id,
                    PaymentType = paymentMethod,
                    SubTotal = GetDecimalFromLabel(lblToplam.Text), // Assuming lblToplam holds grand total, adjust if separate subtotal/vat labels exist
                    VatAmount = 0, // Calculate VAT based on items or add a separate label
                    Total = GetDecimalFromLabel(lblToplam.Text),
                    Discount = 0, // Assuming no discount for now
                    Status = "Tamamlandı",
                    CashierName = "Admin", // Placeholder
                    Notes = "", // Optional notes
                    CreatedDate = DateTime.Now
                };
                _context.SalesReceipts.Add(salesReceipt);

                // Add SalesReceiptDetails and update product stock
                foreach (DataGridViewRow row in dgvSatisListesi.Rows)
                {
                    if (row.IsNewRow) continue;

                    int productId = Convert.ToInt32(row.Cells["colProductId"].Value);
                    var product = _context.Products.Find(productId);

                    if (product != null)
                    {
                        decimal quantity = decimal.TryParse(row.Cells["colMiktar"].Value?.ToString(), out decimal q) ? q : 0;
                        decimal unitPrice = decimal.TryParse(row.Cells["colBirimFiyati"].Value?.ToString(), out decimal up) ? up : 0;
                        decimal vatRate = decimal.TryParse(row.Cells["colKdvOrani"].Value?.ToString(), out decimal vr) ? vr : 0;
                        decimal total = decimal.TryParse(row.Cells["colToplamTutar"].Value?.ToString(), out decimal t) ? t : 0;

                        var salesReceiptDetail = new SalesReceiptDetail
                        {
                            SalesReceiptId = salesReceipt.Id,
                            ProductId = productId,
                            Quantity = quantity,
                            UnitPrice = unitPrice,
                            VatRate = vatRate,
                            Total = total,
                            Discount = 0,
                            CreatedDate = DateTime.Now
                        };
                        _context.SalesReceiptDetails.Add(salesReceiptDetail);

                        // Update product stock
                        product.CurrentStock -= quantity;

                        // Record stock movement
                        var stockMovement = new StockMovement
                        {
                            ProductId = product.Id,
                            MovementType = "Satış",
                            Quantity = quantity,
                            UnitPrice = unitPrice,
                            Total = total,
                            MovementDate = DateTime.Now,
                            SalesReceiptId = salesReceipt.Id,
                            Notes = $"Satış: {product.Name} ({quantity} {product.Unit})"
                        };
                        _context.StockMovements.Add(stockMovement);
                    }
                }

                // Handle cash movement if not veresiye
                if (paymentMethod != "Veresiye")
                {
                    var cashMovement = new CashMovement
                    {
                        MovementType = "Gelir",
                        Amount = salesReceipt.Total,
                        MovementDate = DateTime.Now,
                        Description = $"Satış geliri - Fiş No: {salesReceipt.ReceiptNumber}",
                        PaymentMethod = paymentMethod,
                        SalesReceiptId = salesReceipt.Id
                    };
                    _context.CashMovements.Add(cashMovement);
                }
                else // If veresiye, update customer debt
                {
                    if (_selectedCustomer != null)
                    {
                        _selectedCustomer.Debt += salesReceipt.Total;
                        var debtMovement = new CustomerDebtMovement
                        {
                            CustomerId = _selectedCustomer.Id,
                            Amount = salesReceipt.Total,
                            MovementType = "Borç Ekleme",
                            MovementDate = DateTime.Now,
                            Description = $"Veresiye satış - Fiş No: {salesReceipt.ReceiptNumber}",
                            SalesReceiptId = salesReceipt.Id
                        };
                        _context.CustomerDebtMovements.Add(debtMovement);
                    }
                }

                _context.SaveChanges();

                MessageBox.Show("Satış başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSaleForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Satış işlemi sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetDecimalFromLabel(string labelText)
        {
            decimal value = 0;
            decimal.TryParse(labelText.Replace(" TL", "").Replace(",", "."), out value);
            return value;
        }

        private string GenerateReceiptNumber()
        {
            // Simple receipt number generation: YYYYMMDDHHmmss
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void ClearSaleForm()
        {
            _selectedCustomer = null;
            // lblMusteriAdi.Text = "Perakende Satış"; // Reset customer label
            txtBarkod.Clear(); // Corrected control name
            dgvSatisListesi.Rows.Clear();
            CalculateTotals(); // Reset totals to 0
        }

        private void BtnSatisIptal_Click(object? sender, EventArgs e)
        {
            ClearSaleForm();
            MessageBox.Show("Satış iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUrunAra_Click(object? sender, EventArgs e)
        {
            var urunAramaForm = _serviceProvider.GetRequiredService<UrunAramaForm>();
            if (urunAramaForm.ShowDialog() == DialogResult.OK)
            {
                if (urunAramaForm.SelectedProduct != null)
                {
                    AddProductToSale(urunAramaForm.SelectedProduct.BarcodeNo);
                }
            }
        }
    }
}
