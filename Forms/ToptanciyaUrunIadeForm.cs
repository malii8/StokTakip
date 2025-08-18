using System;
using System.Drawing;
using System.Windows.Forms;
using StokTakip.Models;
using StokTakip.Data;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.Forms
{
    public partial class ToptanciyaUrunIadeForm : Form
    {
        private Wholesaler? _wholesaler;
        private readonly StokTakipDbContext _context;

        public decimal IadeTutari { get; private set; }
        public string IadeAciklamasi { get; private set; } = string.Empty;
        public int IadeEdilecekMiktar { get; private set; }
        public string IadeEdilecekUrun { get; private set; } = string.Empty;

        public ToptanciyaUrunIadeForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            InitializeForm();
            SetupEventHandlers();
        }

        public void SetWholesaler(Wholesaler wholesaler)
        {
            _wholesaler = wholesaler;
            lblToptanciAdi.Text = _wholesaler.Name;
            lblMevcutBorc.Text = $"{_wholesaler.Debt:F2} TL";
            LoadUrunler();
        }

        private void InitializeForm()
        {
            // Set form properties
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Initialize form data
            dtpIadeTarihi.Value = DateTime.Now;

            // Set default values
            nudMiktar.Value = 1;
            txtBirimFiyat.Text = "0,00";
            lblToplamTutar.Text = "0,00 TL";

            UpdateIadeToplamı();
        }

        private void SetupEventHandlers()
        {
            // Button event handlers
            btnIadeEt.Click += BtnIadeEt_Click;
            btnIptal.Click += BtnIptal_Click;
            btnUrunSec.Click += BtnUrunSec_Click;

            // Value change event handlers
            nudMiktar.ValueChanged += CalculateTotal;
            txtBirimFiyat.TextChanged += CalculateTotal;

            // DataGridView event handlers
            dgvUrunler.SelectionChanged += DgvUrunler_SelectionChanged;
        }

        private void LoadUrunler()
        {
            dgvUrunler.Rows.Clear();

            if (_wholesaler == null) return;

            try
            {
                // Load products associated with this wholesaler (e.g., from past purchase receipts)
                // This is a simplified example. A real application might track products purchased from each wholesaler.
                // For now, let's assume we can get all products and filter by wholesaler later if needed.
                var products = _context.Products.ToList(); // Or filter by wholesaler if purchase history is available

                foreach (var product in products)
                {
                    // This is a placeholder. You'd ideally link products to wholesalers via purchase records.
                    // For now, just showing all products.
                    dgvUrunler.Rows.Add(
                        product.Id.ToString(),
                        product.Name,
                        product.StockCode,
                        product.CurrentStock.ToString(),
                        product.PurchasePrice.ToString("F2"),
                        (product.CurrentStock * product.PurchasePrice).ToString("F2"),
                        product.CreatedDate.ToShortDateString()
                    );
                }

                ApplyRowColors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürünler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyRowColors()
        {
            for (int i = 0; i < dgvUrunler.Rows.Count; i++)
            {
                if (dgvUrunler.Rows[i].IsNewRow) continue;

                if (i % 2 == 0)
                {
                    dgvUrunler.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else
                {
                    dgvUrunler.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void DgvUrunler_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUrunler.SelectedRows[0];

                // Load selected product details
                txtUrunAdi.Text = selectedRow.Cells["colUrunAdi"].Value?.ToString() ?? "";
                txtBarkod.Text = selectedRow.Cells["colBarkod"].Value?.ToString() ?? "";

                if (decimal.TryParse(selectedRow.Cells["colBirimFiyat"].Value?.ToString(), out decimal birimFiyat))
                {
                    txtBirimFiyat.Text = birimFiyat.ToString("F2");
                }

                if (int.TryParse(selectedRow.Cells["colMevcut"].Value?.ToString(), out int mevcutMiktar))
                {
                    nudMiktar.Maximum = mevcutMiktar;
                    lblMevcutStok.Text = $"Mevcut Stok: {mevcutMiktar} adet";
                }

                CalculateTotal(null, EventArgs.Empty);
            }
        }

        private void BtnUrunSec_Click(object? sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUrunler.SelectedRows[0];
                txtUrunAdi.Text = selectedRow.Cells["colUrunAdi"].Value?.ToString() ?? "";
                txtBarkod.Text = selectedRow.Cells["colBarkod"].Value?.ToString() ?? "";

                if (decimal.TryParse(selectedRow.Cells["colBirimFiyat"].Value?.ToString(), out decimal birimFiyat))
                {
                    txtBirimFiyat.Text = birimFiyat.ToString("F2");
                }

                CalculateTotal(null, EventArgs.Empty);
                MessageBox.Show("Ürün seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CalculateTotal(object? sender, EventArgs e)
        {
            if (decimal.TryParse(txtBirimFiyat.Text, out decimal birimFiyat))
            {
                decimal toplamTutar = birimFiyat * nudMiktar.Value;
                lblToplamTutar.Text = $"{toplamTutar:F2} TL";
                UpdateIadeToplamı();
            }
        }

        private void UpdateIadeToplamı()
        {
            if (decimal.TryParse(lblToplamTutar.Text.Replace(" TL", ""), out decimal iadeTutari))
            {
                decimal yeniBorc = _wholesaler!.Debt - iadeTutari;
                lblYeniBorc.Text = $"İade Sonrası Borç: {yeniBorc:F2} TL";

                if (yeniBorc < 0)
                {
                    lblYeniBorc.ForeColor = Color.Green;
                }
                else if (yeniBorc > _wholesaler!.Debt)
                {
                    lblYeniBorc.ForeColor = Color.Red;
                }
                else
                {
                    lblYeniBorc.ForeColor = Color.Blue;
                }
            }
        }

        private void BtnIadeEt_Click(object? sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Lütfen iade edilecek ürünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudMiktar.Value <= 0)
            {
                MessageBox.Show("İade miktarı 0'dan büyük olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtBirimFiyat.Text, out decimal birimFiyat) || birimFiyat <= 0)
            {
                MessageBox.Show("Geçerli bir birim fiyat giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIadeNedeni.Text))
            {
                MessageBox.Show("İade nedenini belirtiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmation
            decimal toplamIadeTutari = birimFiyat * nudMiktar.Value;
            DialogResult result = MessageBox.Show(
                $"İade Bilgileri:\n\n" +
                $"Toptancı: {_wholesaler!.Name}\n" +
                $"Ürün: {txtUrunAdi.Text}\n" +
                $"Miktar: {nudMiktar.Value} adet\n" +
                $"Birim Fiyat: {birimFiyat:F2} TL\n" +
                $"Toplam İade Tutarı: {toplamIadeTutari:F2} TL\n" +
                $"İade Nedeni: {txtIadeNedeni.Text}\n\n" +
                $"İade işlemini onaylıyor musunuz?",
                "İade Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes && _wholesaler != null)
            {
                // Set return values
                IadeTutari = toplamIadeTutari;
                IadeAciklamasi = $"{txtUrunAdi.Text} - {nudMiktar.Value} adet - {txtIadeNedeni.Text}";
                IadeEdilecekMiktar = (int)nudMiktar.Value;
                IadeEdilecekUrun = txtUrunAdi.Text;

                // Update wholesaler debt (reduce debt)
                _wholesaler.Debt -= IadeTutari;

                // Record wholesaler debt movement
                var debtMovement = new WholesalerDebtMovement
                {
                    WholesalerId = _wholesaler.Id,
                    Amount = IadeTutari,
                    MovementType = "İade",
                    MovementDate = dtpIadeTarihi.Value.Date,
                    Description = IadeAciklamasi
                };
                _context.WholesalerDebtMovements.Add(debtMovement);

                // Update product stock (increase stock)
                var productToUpdate = _context.Products.FirstOrDefault(p => p.BarcodeNo == txtBarkod.Text);
                if (productToUpdate != null)
                {
                    productToUpdate.CurrentStock += IadeEdilecekMiktar;
                    // Record stock movement
                    var stockMovement = new StockMovement
                    {
                        ProductId = productToUpdate.Id,
                        MovementType = "Giriş", // İade olduğu için giriş
                        Quantity = IadeEdilecekMiktar,
                        MovementDate = dtpIadeTarihi.Value.Date,
                        Notes = $"Toptancıdan iade alınan ürün: {productToUpdate.Name}",
                        WholesalerId = _wholesaler.Id
                    };
                    _context.StockMovements.Add(stockMovement);
                }

                _context.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnIptal_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
