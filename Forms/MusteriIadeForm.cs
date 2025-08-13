using System;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.Forms
{
    public partial class MusteriIadeForm : Form
    {
        private readonly StokTakipDbContext _context;
        private Customer? _customer;

        public MusteriIadeForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            SetupEventHandlers();
        }

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
            // Assuming there are labels for customer name and current debt in the form
            // If not, these controls need to be added in the designer.
            // lblMusteriAdi.Text = _customer.Name;
            // lblMevcutBorc.Text = $"{_customer.Debt:F2} TL";
            LoadProducts();
        }

        private void SetupEventHandlers()
        {
            // Buttons for handling return payment method
            btnMusteriNakitOdendi.Click += BtnMusteriNakitOdendi_Click;
            btnKrediKartindan.Click += BtnKrediKartindan_Click;
            btnMusteriBorcundan.Click += BtnMusteriBorcundan_Click;

            // Other buttons
            btnAra.Click += BtnAra_Click;
            btnVazgec.Click += BtnVazgec_Click;
            btnIskontoUygula.Click += BtnIskontoUygula_Click; // Assuming this button exists and has a purpose

            // Text changed and selection changed events
            txtMiktar.TextChanged += CalculateTotal; // Assuming txtMiktar is used for quantity
            txtBarkodNo.TextChanged += TxtBarkodNo_TextChanged; // Assuming txtBarkodNo is used for barcode
            dgvUrunler.SelectionChanged += DgvUrunler_SelectionChanged;
        }

        private void LoadProducts()
        {
            dgvUrunler.Rows.Clear();

            if (_customer == null) return;

            try
            {
                // Load products from sales receipts for this customer
                var salesDetails = _context.SalesReceiptDetails
                    .Include(srd => srd.Product)
                    .Include(srd => srd.SalesReceipt)
                    .Where(srd => srd.SalesReceipt.CustomerId == _customer.Id && srd.SalesReceipt.Status == "Tamamlandı")
                    .ToList();

                foreach (var detail in salesDetails)
                {
                    dgvUrunler.Rows.Add(
                        detail.Product?.BarcodeNo ?? "",
                        detail.Product?.Name ?? "",
                        detail.Product?.CurrentStock.ToString() ?? "0", // Kalan Stok
                        detail.Product?.MinimumStock.ToString() ?? "0", // Asgari Stok
                        detail.UnitPrice.ToString("F2"), // Satış Fiyatı (Birim Fiyatı)
                        detail.Quantity.ToString(), // Miktar
                        detail.Product?.Unit ?? "Adet", // Ölçü Birimi
                        detail.Total.ToString("F2") // Toplam Tutar
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri ürünleri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotal(object? sender, EventArgs e)
        {
            if (decimal.TryParse(txtMiktar.Text, out decimal miktar) &&
                decimal.TryParse(dgvUrunler.CurrentRow?.Cells["colSatisFiyati"].Value?.ToString(), out decimal birimFiyat))
            {
                decimal toplamTutar = birimFiyat * miktar;
                lblToplamTutar.Text = $"{toplamTutar:F2} TL";
            }
            else
            {
                lblToplamTutar.Text = "0,00 TL";
            }
        }

        private void BtnMusteriNakitOdendi_Click(object? sender, EventArgs e)
        {
            ProcessReturn("Nakit");
        }

        private void BtnKrediKartindan_Click(object? sender, EventArgs e)
        {
            ProcessReturn("Kredi Kartı");
        }

        private void BtnMusteriBorcundan_Click(object? sender, EventArgs e)
        {
            ProcessReturn("Borçtan Düşüldü");
        }

        private void ProcessReturn(string paymentMethod)
        {
            if (_customer == null) return;

            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen iade edilecek ürünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvUrunler.SelectedRows[0];
            string barcodeNo = selectedRow.Cells["colBarkodNo"].Value?.ToString() ?? "";
            string urunAdi = selectedRow.Cells["colUrunAdi"].Value?.ToString() ?? "";
            decimal birimFiyat = decimal.TryParse(selectedRow.Cells["colSatisFiyati"].Value?.ToString(), out decimal bf) ? bf : 0;
            decimal miktar = decimal.TryParse(txtMiktar.Text, out decimal m) ? m : 0;

            if (miktar <= 0)
            {
                MessageBox.Show("İade miktarı 0'dan büyük olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal toplamIadeTutari = birimFiyat * miktar;

            DialogResult result = MessageBox.Show(
                $"İade Bilgileri:\n\n" +
                $"Müşteri: {_customer.Name}\n" +
                $"Ürün: {urunAdi}\n" +
                $"Miktar: {miktar} adet\n" +
                $"Birim Fiyat: {birimFiyat:F2} TL\n" +
                $"Toplam İade Tutarı: {toplamIadeTutari:F2} TL\n" +
                $"Ödeme Şekli: {paymentMethod}\n\n" +
                $"İade işlemini onaylıyor musunuz?",
                "İade Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Update customer debt if applicable
                    if (paymentMethod == "Borçtan Düşüldü")
                    {
                        _customer.Debt -= toplamIadeTutari;
                    }

                    // Record customer debt movement if applicable
                    if (paymentMethod == "Borçtan Düşüldü")
                    {
                        var debtMovement = new CustomerDebtMovement
                        {
                            CustomerId = _customer.Id,
                            Amount = toplamIadeTutari,
                            MovementType = "İade",
                            MovementDate = DateTime.Now,
                            Description = $"Müşteri iadesi - Borçtan düşüldü: {urunAdi} ({miktar} adet)"
                        };
                        _context.CustomerDebtMovements.Add(debtMovement);
                    }

                    // Update product stock (increase stock)
                    var productToUpdate = _context.Products.FirstOrDefault(p => p.BarcodeNo == barcodeNo);
                    if (productToUpdate != null)
                    {
                        productToUpdate.CurrentStock += miktar;
                        // Record stock movement
                        var stockMovement = new StockMovement
                        {
                            ProductId = productToUpdate.Id,
                            MovementType = "Giriş", // İade olduğu için giriş
                            Quantity = miktar,
                            MovementDate = DateTime.Now,
                            Notes = $"Müşteriden iade alınan ürün: {productToUpdate.Name}",
                            SalesReceiptId = null // No specific sales receipt for return
                        };
                        _context.StockMovements.Add(stockMovement);
                    }

                    // Record cash movement if cash refund
                    if (paymentMethod == "Nakit")
                    {
                        var cashMovement = new CashMovement
                        {
                            MovementType = "Gider", // Nakit iade olduğu için gider
                            Amount = toplamIadeTutari,
                            MovementDate = DateTime.Now,
                            Description = $"Müşteri iadesi - Nakit ödeme: {urunAdi} ({miktar} adet)",
                            PaymentMethod = "Nakit"
                        };
                        _context.CashMovements.Add(cashMovement);
                    }

                    _context.SaveChanges();

                    MessageBox.Show("Ürün iadesi başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ürün iadesi kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAra_Click(object? sender, EventArgs e)
        {
            // This button might trigger a product search form or filter the current grid.
            // For now, let's assume it filters the current grid based on txtBarkodNo.
            FilterProducts();
        }

        private void TxtBarkodNo_TextChanged(object? sender, EventArgs e)
        {
            FilterProducts();
        }

        private void FilterProducts()
        {
            string searchText = txtBarkodNo.Text.ToUpper();

            foreach (DataGridViewRow row in dgvUrunler.Rows)
            {
                if (row.IsNewRow) continue;

                string barkod = row.Cells["colBarkodNo"].Value?.ToString()?.ToUpper() ?? "";
                string urunAdi = row.Cells["colUrunAdi"].Value?.ToString()?.ToUpper() ?? "";

                bool visible = string.IsNullOrEmpty(searchText) ||
                               barkod.Contains(searchText) ||
                               urunAdi.Contains(searchText);

                row.Visible = visible;
            }
        }

        private void BtnIskontoUygula_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("İskonto uygulama işlemi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnVazgec_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DgvUrunler_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUrunler.SelectedRows[0];

                // Assuming these controls exist in the designer
                // txtUrunAdi.Text = selectedRow.Cells["colUrunAdi"].Value?.ToString() ?? "";
                // txtBarkod.Text = selectedRow.Cells["colBarkodNo"].Value?.ToString() ?? "";

                // if (decimal.TryParse(selectedRow.Cells["colSatisFiyati"].Value?.ToString(), out decimal birimFiyat))
                // {
                //     txtBirimFiyat.Text = birimFiyat.ToString("F2");
                // }

                // if (int.TryParse(selectedRow.Cells["colMiktar"].Value?.ToString(), out int mevcutMiktar))
                // {
                //     nudMiktar.Maximum = mevcutMevcutMiktar;
                //     lblMevcutStok.Text = $"Mevcut Stok: {mevcutMevcutMiktar} adet";
                // }

                CalculateTotal(null, EventArgs.Empty);
            }
        }
    }
}
