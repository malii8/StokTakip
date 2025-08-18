using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using StokTakip.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace StokTakip.Forms
{
    public partial class HizliTusDegistirForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;
        private const int QUICK_SALE_BUTTON_COUNT = 21;
        private Button[] _quickSaleButtons;
        private int _selectedButtonIndex = -1;
        private Dictionary<int, int?> buttonProductMap = new Dictionary<int, int?>();

        public HizliTusDegistirForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _serviceProvider = serviceProvider;

            _quickSaleButtons = new Button[QUICK_SALE_BUTTON_COUNT];
            InitializeQuickSaleButtons();
            LoadQuickSaleButtons();
            LoadProducts();

            dgvProducts.CellDoubleClick += DgvProducts_CellDoubleClick;
            btnSave.Click += BtnSave_Click;
        }

        private void InitializeQuickSaleButtons()
        {
            int buttonWidth = 90;
            int buttonHeight = 40;
            int startX = 10;
            int startY = 10;
            int paddingX = 10;
            int paddingY = 10;
            int columns = 3;

            for (int i = 0; i < QUICK_SALE_BUTTON_COUNT; i++)
            {
                Button btn = new Button();
                btn.Width = buttonWidth;
                btn.Height = buttonHeight;
                btn.Text = "BOŞ";
                btn.Tag = i + 1; // Store button index (1-based)
                btn.Click += QuickSaleButton_Click;
                btn.BackColor = Color.LightBlue;
                btn.ForeColor = Color.DarkBlue;
                btn.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.DarkBlue;
                btn.FlatAppearance.BorderSize = 1;

                int row = i / columns;
                int col = i % columns;

                btn.Left = startX + col * (buttonWidth + paddingX);
                btn.Top = startY + row * (buttonHeight + paddingY);

                pnlButtons.Controls.Add(btn);
                _quickSaleButtons[i] = btn;
            }
        }

        private void LoadQuickSaleButtons()
        {
            var configs = _context.QuickSaleButtonConfigs.ToList();
            buttonProductMap.Clear();
            for (int i = 0; i < QUICK_SALE_BUTTON_COUNT; i++)
            {
                var config = configs.FirstOrDefault(c => c.ButtonIndex == (i + 1));
                _quickSaleButtons[i].Tag = i + 1; // Always store button index
                if (config != null)
                {
                    _quickSaleButtons[i].Text = config.ProductName;
                    buttonProductMap[i + 1] = config.ProductId;
                }
                else
                {
                    _quickSaleButtons[i].Text = "BOŞ";
                    buttonProductMap[i + 1] = null;
                }
            }
        }

        private void LoadProducts(string searchText = "")
        {
            try
            {
                var products = _context.Products
                    .Include(p => p.ProductGroup)
                    .Where(p => string.IsNullOrEmpty(searchText) || p.Name.Contains(searchText) || p.BarcodeNo.Contains(searchText))
                    .ToList();

                dgvProducts.DataSource = products;
                dgvProducts.AutoGenerateColumns = false;
                dgvProducts.Columns.Clear();
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "BarcodeNo", HeaderText = "Barkod No" });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Ürün Adı" });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SalePrice", HeaderText = "Satış Fiyatı" });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CurrentStock", HeaderText = "Stok" });
                foreach (DataGridViewColumn column in dgvProducts.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürünler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuickSaleButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                if (clickedButton.Tag is int buttonIndex)
                {
                    foreach (var btn in _quickSaleButtons)
                    {
                        btn.BackColor = Color.LightBlue;
                    }
                    clickedButton.BackColor = Color.Orange;
                    _selectedButtonIndex = buttonIndex - 1;
                }
            }
        }

        private void DgvProducts_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _selectedButtonIndex != -1)
            {
                var selectedProduct = dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;
                if (selectedProduct != null)
                {
                    var buttonIndex = _selectedButtonIndex + 1;
                    _quickSaleButtons[_selectedButtonIndex].Text = selectedProduct.Name;
                    buttonProductMap[buttonIndex] = selectedProduct.Id;

                    var config = _context.QuickSaleButtonConfigs.FirstOrDefault(c => c.ButtonIndex == buttonIndex);
                    if (config == null)
                    {
                        config = new QuickSaleButtonConfig
                        {
                            ButtonIndex = buttonIndex,
                            ProductId = selectedProduct.Id,
                            ProductName = selectedProduct.Name,
                            BarcodeNo = selectedProduct.BarcodeNo
                        };
                        _context.QuickSaleButtonConfigs.Add(config);
                    }
                    else
                    {
                        config.ProductId = selectedProduct.Id;
                        config.ProductName = selectedProduct.Name;
                        config.BarcodeNo = selectedProduct.BarcodeNo;
                        _context.QuickSaleButtonConfigs.Update(config);
                    }
                    _context.SaveChanges();

                    MessageBox.Show($"{selectedProduct.Name} ürünü hızlı tuşa atandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (_selectedButtonIndex == -1)
            {
                MessageBox.Show("Lütfen önce bir hızlı tuş seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < QUICK_SALE_BUTTON_COUNT; i++)
                {
                    int buttonIndex = i + 1;
                    int? productId = buttonProductMap.ContainsKey(buttonIndex) ? buttonProductMap[buttonIndex] : null;
                    var config = _context.QuickSaleButtonConfigs.FirstOrDefault(c => c.ButtonIndex == buttonIndex);
                    if (productId.HasValue && productId.Value > 0)
                    {
                        var product = _context.Products.Find(productId.Value);
                        if (config == null)
                        {
                            config = new QuickSaleButtonConfig
                            {
                                ButtonIndex = buttonIndex,
                                ProductId = productId.Value,
                                ProductName = product?.Name,
                                BarcodeNo = product?.BarcodeNo
                            };
                            _context.QuickSaleButtonConfigs.Add(config);
                        }
                        else
                        {
                            config.ProductId = productId.Value;
                            config.ProductName = product?.Name;
                            config.BarcodeNo = product?.BarcodeNo;
                            _context.QuickSaleButtonConfigs.Update(config);
                        }
                    }
                    else
                    {
                        if (config != null)
                        {
                            _context.QuickSaleButtonConfigs.Remove(config);
                        }
                    }
                }
                _context.SaveChanges();
                MessageBox.Show("Hızlı tuş ayarları başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ayarlar kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
