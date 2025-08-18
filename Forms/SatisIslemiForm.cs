using Microsoft.Extensions.DependencyInjection;
using StokTakip.Models;
using StokTakip.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;

namespace StokTakip.Forms
{
    public partial class SatisIslemiForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;
        private Customer? _selectedCustomer;
        private const int QUICK_SALE_BUTTON_COUNT = 21; // Number of quick sale buttons
        private Button[] _quickSaleButtons; // Array to hold quick sale buttons

        public SatisIslemiForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            // Set the current thread's culture to InvariantCulture to ensure consistent decimal parsing and formatting
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

            InitializeComponent();
            _context = context;
            _serviceProvider = serviceProvider;

            SetupDataGridView(); // Ensure columns are set up immediately

            _quickSaleButtons = new Button[QUICK_SALE_BUTTON_COUNT];
            InitializeQuickSaleButtons();
            LoadQuickSaleButtons();

            // Event handler'ları bağla
            this.Load += SatisIslemiForm_Load; // Keep Load event for other initializations if needed
            btnMusteriSec.Click += BtnMusteriSec_Click;
            btnEskiFisler.Click += BtnEskiFisler_Click;
            btnSatisIptal.Click += BtnSatisIptal_Click;
            btnUrunAra.Click += BtnUrunAra_Click;
            txtBarkod.KeyDown += TxtBarkod_KeyDown; // Corrected control name
            dgvSatisListesi.CellEndEdit += DgvSatisListesi_CellEndEdit; // For quantity/price changes
            chkKarGoster.CheckedChanged += ChkKarGoster_CheckedChanged; // Add event handler for profit checkbox
            txtAlinanPara.TextChanged += TxtAlinanPara_TextChanged;

            // Payment buttons
            btnNakit.Click += (s, e) => BtnSatisYap_Click(s, e, "Nakit");
            btnKrediKarti.Click += (s, e) => BtnSatisYap_Click(s, e, "Kredi Kartı");
            btnVeresiye.Click += (s, e) => BtnSatisYap_Click(s, e, "Veresiye");
            btnHavale.Click += (s, e) => BtnSatisYap_Click(s, e, "Havale");
            btnNakitKredi.Click += (s, e) => BtnSatisYap_Click(s, e, "Nakit + Kredi Kartı");

            // Quick Sales Buttons
            btnTuslariSil.Click += BtnTuslariSil_Click;
            btnTuslariDegistir.Click += BtnTuslariDegistir_Click;

            // Other buttons
            // btnUrunEkle.Click += BtnUrunEkle_Click; // This button is not in designer, using barcode input instead
            // btnYeniSatis.Click += BtnYeniSatis_Click; // Using btnSatisIptal for new sale

            // Form Closing event
            this.FormClosing += SatisIslemiForm_FormClosing;

            // Stoksuz satış button event
            btnStoksuzSatis.Click += BtnStoksuzSatis_Click;

            // Print button
            btnSatisBilgisiYazdir.Click += BtnSatisBilgisiYazdir_Click;
        }

        private void SatisIslemiForm_Load(object? sender, EventArgs e)
        {
            txtAlinanPara.Text = "0.00";
            txtParaUstu.Text = "0.00";
            txtKar.Text = "0.00";
            CalculateTotals();
        }

        private void BtnMusteriSec_Click(object? sender, EventArgs e)
        {
            var musteriBulForm = _serviceProvider.GetRequiredService<MusteriBulForm>();
            if (musteriBulForm.ShowDialog() == DialogResult.OK)
            {
                _selectedCustomer = musteriBulForm.SelectedCustomer;
                if (_selectedCustomer != null)
                {
                    lblSelectedCustomerName.Text = _selectedCustomer.Name;
                    lblSelectedCustomerDebt.Text = _selectedCustomer.Debt.ToString("F2");
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
                product.SalePrice.ToString("F2", CultureInfo.InvariantCulture),
                1, // Default quantity
                product.Unit,
                (1 * product.SalePrice).ToString("F2", CultureInfo.InvariantCulture), // Initial total (quantity * SalePrice)
                product.VatRate.ToString("F0", CultureInfo.InvariantCulture),
                product.Id, // Hidden product ID
                product.PurchasePrice.ToString("F2", CultureInfo.InvariantCulture),
                product.CurrentStock, // Original Stock
                product.CurrentStock - 1 // Kalan Stok (Original Stock - default quantity)
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
            decimal quantity = decimal.TryParse(row.Cells["colMiktar"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal q) ? q : 0;
            decimal unitPrice = decimal.TryParse(row.Cells["colSatisFiyati"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal up) ? up : 0; // Corrected column name
            row.Cells["colToplamTutar"].Value = (quantity * unitPrice).ToString("F2", CultureInfo.InvariantCulture);
            // Update Kalan Stok column based on original stock and current quantity
            if (row.Cells["colOriginalStock"].Value != null)
            {
                decimal originalStock = decimal.TryParse(row.Cells["colOriginalStock"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal os) ? os : 0;
                row.Cells["colKalanStok"].Value = (originalStock - quantity).ToString("F0", CultureInfo.InvariantCulture);
            }
        }

        private void CalculateTotals()
        {
            decimal subTotal = 0;
            decimal totalVat = 0;
            decimal grandTotal = 0;
            decimal totalProfit = 0;

            foreach (DataGridViewRow row in dgvSatisListesi.Rows)
            {
                if (row.IsNewRow) continue;

                decimal quantity = decimal.TryParse(row.Cells["colMiktar"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal q) ? q : 0;
                decimal unitPrice = decimal.TryParse(row.Cells["colSatisFiyati"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal up) ? up : 0;
                decimal vatRate = decimal.TryParse(row.Cells["colKdvOrani"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal vr) ? vr : 0;
                decimal purchasePrice = decimal.TryParse(row.Cells["colPurchasePrice"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal pp) ? pp : 0;
                decimal kalanStok = decimal.TryParse(row.Cells["colKalanStok"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal ks) ? ks : 0;

                decimal itemTotal = quantity * unitPrice;
                decimal itemVat = itemTotal * (vatRate / 100);
                decimal itemProfit = (unitPrice - purchasePrice) * quantity;

                subTotal += itemTotal;
                totalVat += itemVat;
                grandTotal += itemTotal + itemVat;
                totalProfit += itemProfit;
            }

            lblToplam.Text = subTotal.ToString("F2", CultureInfo.InvariantCulture); // Show only Satış Fiyatı * Miktar
            txtKar.Text = totalProfit.ToString("F2", CultureInfo.InvariantCulture);

            // Recalculate change if amount received is entered
            decimal alinanPara = 0;
            if (decimal.TryParse(txtAlinanPara.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out alinanPara))
            {
                decimal change = alinanPara - subTotal; // Use subTotal for change calculation
                txtParaUstu.Text = Math.Max(0, change).ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                txtParaUstu.Text = "0.00";
            }
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
                using (var transaction = _context.Database.BeginTransaction())
                {
                    // Create SalesReceipt
                    var salesReceipt = new SalesReceipt
                    {
                        ReceiptNumber = GenerateReceiptNumber(),
                        ReceiptDate = DateTime.Now,
                        CustomerId = _selectedCustomer?.Id,
                        PaymentType = paymentMethod,
                        SubTotal = GetDecimalFromLabel(lblToplam.Text),
                        VatAmount = 0, // Calculate VAT based on items or add a separate label
                        Total = GetDecimalFromLabel(lblToplam.Text),
                        Discount = 0, // Assuming no discount for now
                        Status = "Tamamlandı",
                        CashierName = "Admin", // Placeholder
                        Notes = "", // Optional notes
                        CreatedDate = DateTime.Now
                    };
                    _context.SalesReceipts.Add(salesReceipt);
                    _context.SaveChanges(); // Save SalesReceipt to get its ID

                    // Add SalesReceiptDetails and update product stock
                    foreach (DataGridViewRow row in dgvSatisListesi.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int productId = Convert.ToInt32(row.Cells["colProductId"].Value);
                        var product = _context.Products.Find(productId);

                        if (product != null)
                        {
                            decimal quantity = decimal.TryParse(row.Cells["colMiktar"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal q) ? q : 0;
                            decimal unitPrice = decimal.TryParse(row.Cells["colSatisFiyati"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal up) ? up : 0;
                            decimal vatRate = decimal.TryParse(row.Cells["colKdvOrani"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal vr) ? vr : 0;
                            decimal total = decimal.TryParse(row.Cells["colToplamTutar"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal t) ? t : 0;

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

                    _context.SaveChanges(); // Final save for all other changes
                    transaction.Commit(); // Commit the transaction if all operations are successful

                    MessageBox.Show("Satış başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearSaleForm();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Satış işlemi sırasında hata oluştu: {ex.Message}";
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nDetay: {ex.InnerException.Message}";
                }
                MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            lblSelectedCustomerName.Text = "Perakende Satış"; // Reset customer label
            lblSelectedCustomerDebt.Text = "0,00"; // Reset debt label
            txtBarkod.Clear(); // Corrected control name
            dgvSatisListesi.Rows.Clear();
            txtAlinanPara.Text = "0.00"; // Reset alınan para to 0.00
            txtParaUstu.Text = "0.00"; // Reset para üstü to 0.00
            txtKar.Text = "0.00"; // Reset kar to 0.00
            CalculateTotals(); // Reset totals to 0
        }

        private void SetupDataGridView()
        {
            dgvSatisListesi.AutoGenerateColumns = false;
            dgvSatisListesi.Columns.Clear();

            dgvSatisListesi.Columns.Add(new DataGridViewTextBoxColumn { Name = "colBarkodNo", HeaderText = "Barkod No", DataPropertyName = "BarcodeNo" });
            dgvSatisListesi.Columns.Add(new DataGridViewTextBoxColumn { Name = "colUrunAdi", HeaderText = "Ürün Adı", DataPropertyName = "Name" });
            dgvSatisListesi.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSatisFiyati", HeaderText = "Satış Fiyatı", DataPropertyName = "SalePrice" });
            dgvSatisListesi.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMiktar", HeaderText = "Miktar", DataPropertyName = "Quantity" });
            dgvSatisListesi.Columns.Add(new DataGridViewTextBoxColumn { Name = "colBirim", HeaderText = "Birimi", DataPropertyName = "Unit" });
            dgvSatisListesi.Columns.Add(new DataGridViewTextBoxColumn { Name = "colToplamTutar", HeaderText = "Toplam Tutar", DataPropertyName = "Total" });
            dgvSatisListesi.Columns.Add(new DataGridViewTextBoxColumn { Name = "colKdvOrani", HeaderText = "KDV Oranı", DataPropertyName = "VatRate", Visible = false });
            dgvSatisListesi.Columns.Add(new DataGridViewTextBoxColumn { Name = "colProductId", HeaderText = "Product ID", DataPropertyName = "ProductId", Visible = false });
            dgvSatisListesi.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPurchasePrice", HeaderText = "Purchase Price", DataPropertyName = "PurchasePrice", Visible = false });
            dgvSatisListesi.Columns.Add(new DataGridViewTextBoxColumn { Name = "colOriginalStock", HeaderText = "Original Stock", DataPropertyName = "OriginalStock", Visible = false });
            dgvSatisListesi.Columns.Add(new DataGridViewTextBoxColumn { Name = "colKalanStok", HeaderText = "Kalan Stok", DataPropertyName = "CurrentStock" });

            foreach (DataGridViewColumn column in dgvSatisListesi.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void BtnSatisIptal_Click(object? sender, EventArgs e)
        {
            ClearSaleForm();
            MessageBox.Show("Satış iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUrunAra_Click(object? sender, EventArgs e)
        {
            using (var urunAramaForm = _serviceProvider.GetRequiredService<UrunAramaForm>())
            {
                if (urunAramaForm.ShowDialog() == DialogResult.OK)
                {
                    if (urunAramaForm.SelectedProduct != null)
                    {
                        AddProductToSale(urunAramaForm.SelectedProduct.BarcodeNo);
                    }
                }
            }
        }

        private void InitializeQuickSaleButtons()
        {
            int buttonWidth = 100;
            int buttonHeight = 45;
            int paddingX = 12;
            int paddingY = 12;
            int columns = 3; // Number of columns for quick sale buttons
            int rows = (int)Math.Ceiling((double)QUICK_SALE_BUTTON_COUNT / columns);
            int startX = 10; // Moved outside the loop
            int startY = 80; // Moved outside the loop

            for (int i = 0; i < QUICK_SALE_BUTTON_COUNT; i++)
            {
                Button btn = new Button();
                btn.Width = buttonWidth;
                btn.Height = buttonHeight;
                btn.Text = "BOŞ";
                btn.Tag = i + 1; // Store button index (1-based)
                btn.Click += QuickSaleButton_Click;
                btn.BackColor = Color.FromArgb(102, 255, 178); // Soft green
                btn.ForeColor = Color.DarkSlateGray;
                btn.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 96);
                btn.FlatAppearance.BorderSize = 2;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 255, 204);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 204, 102);
                btn.Region = new Region(new GraphicsPath(new[] {
                    new Point(0, 10), new Point(10, 0), new Point(buttonWidth-10, 0), new Point(buttonWidth, 10),
                    new Point(buttonWidth, buttonHeight-10), new Point(buttonWidth-10, buttonHeight), new Point(10, buttonHeight), new Point(0, buttonHeight-10)
                }, new byte[] {
                    (byte)PathPointType.Start, (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line,
                    (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line
                })); // Rounded corners

                int row = i / columns;
                int col = i % columns;

                btn.Left = startX + col * (buttonWidth + paddingX);
                btn.Top = startY + row * (buttonHeight + paddingY);

                pnlHizliSatis.Controls.Add(btn);
                _quickSaleButtons[i] = btn;
            }
        }

        private void LoadQuickSaleButtons()
        {
            var configs = _context.QuickSaleButtonConfigs.ToList();
            for (int i = 0; i < QUICK_SALE_BUTTON_COUNT; i++)
            {
                var config = configs.FirstOrDefault(c => c.ButtonIndex == (i + 1));
                if (config != null)
                {
                    _quickSaleButtons[i].Text = config.ProductName;
                    _quickSaleButtons[i].Tag = config.ProductId;
                }
                else
                {
                    _quickSaleButtons[i].Text = "BOŞ";
                    _quickSaleButtons[i].Tag = null;
                }
            }
        }

        private void ChkKarGoster_CheckedChanged(object? sender, EventArgs e)
        {
            lblKar.Visible = chkKarGoster.Checked;
            txtKar.Visible = chkKarGoster.Checked;
        }

        private void TxtAlinanPara_TextChanged(object? sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void BtnTuslariSil_Click(object? sender, EventArgs e)
        {
            // Implementation for deleting quick sale buttons
            using (var hizliTusSilForm = _serviceProvider.GetRequiredService<HizliTusSilForm>())
            {
                if (hizliTusSilForm.ShowDialog() == DialogResult.OK)
                {
                    LoadQuickSaleButtons(); // Reload buttons after deletion
                }
            }
        }

        private void BtnTuslariDegistir_Click(object? sender, EventArgs e)
        {
            // Implementation for changing quick sale buttons
            using (var hizliTusDegistirForm = _serviceProvider.GetRequiredService<HizliTusDegistirForm>())
            {
                if (hizliTusDegistirForm.ShowDialog() == DialogResult.OK)
                {
                    LoadQuickSaleButtons(); // Reload buttons after changes
                }
            }
        }

        private void QuickSaleButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                // If a product is assigned to this button, add it to the sale
                if (clickedButton.Tag is int productId && productId > 0)
                {
                    var product = _context.Products.Find(productId);
                    if (product != null)
                    {
                        AddProductToSale(product.BarcodeNo);
                    }
                }
                else
                {
                    MessageBox.Show("Bu tuşa atanmış bir ürün yok.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SatisIslemiForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (dgvSatisListesi.Rows.Count > 0 && !(dgvSatisListesi.Rows.Count == 1 && dgvSatisListesi.Rows[0].IsNewRow))
            {
                DialogResult result = MessageBox.Show("Satış listesinde ürünler var. Çıkmak istediğinize emin misiniz? Satış iptal edilecektir.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel closing if user says no
                }
                else
                {
                    ClearSaleForm(); // Clear the sale if user confirms closing
                }
            }
        }

        private void BtnStoksuzSatis_Click(object? sender, EventArgs e)
        {
            var stoksuzUrunForm = _serviceProvider.GetRequiredService<StoksuzUrunForm>();
            if (stoksuzUrunForm.ShowDialog() == DialogResult.OK)
            {
                // Add the out-of-stock product to the sales grid
                dgvSatisListesi.Rows.Add(
                    "STOKSUZ", // Barkod No
                    stoksuzUrunForm.EnteredProductName, // Ürün Adı
                    stoksuzUrunForm.SalePrice.ToString("F2", CultureInfo.InvariantCulture), // Satış Fiyatı
                    1, // Miktar (default to 1 for out-of-stock)
                    "Adet", // Birimi (default to Adet)
                    (1 * stoksuzUrunForm.SalePrice).ToString("F2", CultureInfo.InvariantCulture), // Toplam Tutar
                    0, // KDV Oranı (assuming 0 for out-of-stock unless specified)
                    -1, // Product ID (use -1 or null for non-existent products)
                    stoksuzUrunForm.PurchasePrice.ToString("F2", CultureInfo.InvariantCulture), // Alış Fiyatı
                    0, // Original Stock (0 for out-of-stock)
                    0 // Kalan Stok (0 for out-of-stock)
                );
                CalculateTotals();
            }
        }

        private void BtnSatisBilgisiYazdir_Click(object? sender, EventArgs e)
        {
            if (dgvSatisListesi.Rows.Count == 0 || (dgvSatisListesi.Rows.Count == 1 && dgvSatisListesi.Rows[0].IsNewRow))
            {
                MessageBox.Show("Yazdırılacak satış bilgisi bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            printDocument1.PrintPage += PrintDocument1_PrintPage;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object? sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (e.Graphics == null) return; // Add null check

            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 50;
            int offset = 40;

            graphics.DrawString("--- SATIŞ FİŞİ ---", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY);
            offset += (int)fontHeight + 10;

            graphics.DrawString($"Tarih: {DateTime.Now.ToShortDateString()}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight;
            graphics.DrawString($"Saat: {DateTime.Now.ToShortTimeString()}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 20;

            graphics.DrawString("--------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight;
            graphics.DrawString("Ürün Adı\tMiktar\tFiyat\tToplam", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight;
            graphics.DrawString("--------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight;

            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvSatisListesi.Rows)
            {
                if (row.IsNewRow) continue;

                string productName = row.Cells["colUrunAdi"].Value?.ToString() ?? "";
                string quantity = row.Cells["colMiktar"].Value?.ToString() ?? "0";
                string unitPrice = row.Cells["colSatisFiyati"].Value?.ToString() ?? "0.00";
                string total = row.Cells["colToplamTutar"].Value?.ToString() ?? "0.00";

                graphics.DrawString($"{productName}\t{quantity}\t{unitPrice}\t{total}", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset += (int)fontHeight;

                totalAmount += decimal.TryParse(total, out decimal t) ? t : 0;
            }

            offset += 20;
            graphics.DrawString("--------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight;
            graphics.DrawString($"TOPLAM: {totalAmount.ToString("F2", CultureInfo.InvariantCulture)} TL", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 20;

            graphics.DrawString("Teşekkür ederiz!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }
    }
}
