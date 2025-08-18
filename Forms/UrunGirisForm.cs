using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class UrunGirisForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;
        private Product? _currentProduct; // To hold the product being edited
        private bool _isEditMode = false;

        public UrunGirisForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            LoadProductGroups();
            SetupEventHandlers();
            ClearForm(); // Initialize form for new entry
        }

        public void LoadProductForEdit(Product product)
        {
            _currentProduct = product;
            _isEditMode = true;
            btnKaydet.Text = "Güncelle"; // Change button text
            lblZorunluAlanlar.Visible = false; // Hide mandatory fields label in edit mode

            // Populate form fields with product data
            txtBarkodNo.Text = product.BarcodeNo;
            txtBarkodNo.ReadOnly = true; // Barcode should not be editable in edit mode
            btnOtomatikBarkod.Enabled = false; // Disable automatic barcode generation in edit mode

            txtUrunAdi.Text = product.Name;
            txtUrunKodu.Text = product.StockCode;
            cmbUrunGrubu.SelectedItem = product.ProductGroup?.Name; // Set selected item by name
            txtAlisFiyatiKdvDahil.Text = product.PurchasePrice.ToString("F2"); // Assuming this is the default
            txtAlisFiyatiKdvHaric.Text = (product.PurchasePrice / (1 + (product.VatRate / 100))).ToString("F2");
            txtSatisFiyati.Text = product.SalePrice.ToString("F2");
            txtKdvOrani.Text = product.VatRate.ToString("F0");
            txtMevcutStok.Text = product.CurrentStock.ToString("F1");
            cmbOlcuBirimi.SelectedItem = product.Unit; // Change from txtOlcuBirimi.Text
            txtAsgariStok.Text = product.MinimumStock.ToString("F1");

            // Set KDV radio buttons based on how prices are stored or preferred for display
            rbKdvDahil.Checked = true; // Default to Kdv Dahil for display
            RbKdvDahil_CheckedChanged(rbKdvDahil, EventArgs.Empty);

            // Load wholesaler and payment type if available
            if (product.Notes != null && product.Notes.Contains("Toptancı:"))
            {
                string wholesalerName = product.Notes.Split(new string[] { "Toptancı:" }, StringSplitOptions.None)[1].Split(new char[] { ',' })[0].Trim();
                cmbToptanci.SelectedItem = wholesalerName;
            }
            // Payment method is not directly stored in Product, so it won't be loaded here.
        }

        private void LoadProductGroups()
        {
            try
            {
                var groups = _context.ProductGroups.OrderBy(g => g.Name).ToList();
                cmbUrunGrubu.Items.Clear();
                foreach (var group in groups)
                {
                    cmbUrunGrubu.Items.Add(group.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün grupları yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupEventHandlers()
        {
            btnYeniToptanci.Click += new EventHandler(btnYeniToptanci_Click);
            btnYeniUrunGrubu.Click += new EventHandler(btnYeniUrunGrubu_Click);
            btnUrunAra.Click += new EventHandler(btnUrunAra_Click);
            btnFaturaliGiris.Click += new EventHandler(btnFaturaliGiris_Click);
            btnOtomatikBarkod.Click += new EventHandler(btnOtomatikBarkod_Click);
            btnKaydet.Click += new EventHandler(btnKaydet_Click);
            btnYeniOlcuBirimi.Click += new EventHandler(btnYeniOlcuBirimi_Click); // Add this line
            btnVazgec.Click += new EventHandler(btnVazgec_Click);

            // Fiyat hesaplama event'leri
            txtAlisFiyatiKdvDahil.TextChanged += new EventHandler(txtAlisFiyatiKdvDahil_TextChanged);
            txtAlisFiyatiKdvHaric.TextChanged += new EventHandler(txtAlisFiyatiKdvHaric_TextChanged);
            txtKdvOrani.TextChanged += new EventHandler(txtKdvOrani_TextChanged);

            // Ödeme şekli ve toptancı combo'larını yükle
            LoadWholesalers();
            LoadPaymentTypes();
            LoadUnits(); // Add this line

            rbKdvDahil.CheckedChanged += RbKdvDahil_CheckedChanged;
            rbKdvHaric.CheckedChanged += RbKdvHaric_CheckedChanged;

            // Initial state
            RbKdvDahil_CheckedChanged(rbKdvDahil, EventArgs.Empty);
        }

        private void btnOtomatikBarkod_Click(object? sender, EventArgs e)
        {
            try
            {
                string newBarcode = GenerateNewBarcode();
                txtBarkodNo.Text = newBarcode;
                MessageBox.Show($"Otomatik barkod üretildi: {newBarcode}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Barkod üretilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateNewBarcode()
        {
            Random random = new Random();
            string newBarcode;
            bool isUnique = false;

            do
            {
                // Generate a random 12-digit number
                long randomNumber = (long)(random.NextDouble() * 1000000000000L); // 12-digit random number
                newBarcode = randomNumber.ToString("D12");

                // Check if the generated barcode already exists in the database
                if (!_context.Products.Any(p => p.BarcodeNo == newBarcode))
                {
                    isUnique = true;
                }
            } while (!isUnique);

            return newBarcode;
        }

        private void btnFaturaliGiris_Click(object? sender, EventArgs e)
        {
            var alisFaturasiForm = _serviceProvider.GetRequiredService<AlisFaturasiForm>();
            alisFaturasiForm.ShowDialog();
        }

        private void btnUrunAra_Click(object? sender, EventArgs e)
        {
            var urunAramaForm = _serviceProvider.GetRequiredService<UrunAramaForm>();
            if (urunAramaForm.ShowDialog() == DialogResult.OK)
            {
                if (urunAramaForm.SelectedProduct != null)
                {
                    LoadProductForEdit(urunAramaForm.SelectedProduct);
                }
            }
        }

        private void btnYeniToptanci_Click(object? sender, EventArgs e)
        {
            try
            {
                var toptanciYeniKayitForm = _serviceProvider.GetRequiredService<ToptanciYeniKayitForm>();
                DialogResult result = toptanciYeniKayitForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Toptancı başarıyla eklendiyse combo'yu yeniden yükle
                    LoadWholesalers();
                    MessageBox.Show("Toptancı başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Toptancı kayıt formu açılırken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYeniUrunGrubu_Click(object? sender, EventArgs e)
        {
            string yeniGrup = Interaction.InputBox("Yeni ürün grubunu girin:", "Ürün Grubu Ekle", "");
            if (!string.IsNullOrWhiteSpace(yeniGrup))
            {
                try
                {
                    // Veritabanında aynı isimde grup var mı kontrol et
                    var existingGroup = _context.ProductGroups.FirstOrDefault(g => g.Name == yeniGrup);
                    if (existingGroup != null)
                    {
                        MessageBox.Show("Bu ürün grubu zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Yeni ürün grubunu veritabanına ekle
                    var newGroup = new ProductGroup
                    {
                        Name = yeniGrup,
                        Description = $"{yeniGrup} ürün grubu",
                        CreatedDate = DateTime.Now
                    };

                    _context.ProductGroups.Add(newGroup);
                    _context.SaveChanges();

                    // ComboBox'ı yeniden yükle
                    LoadProductGroups();
                    cmbUrunGrubu.SelectedItem = yeniGrup;

                    MessageBox.Show("Ürün grubu başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ürün grubu eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKaydet_Click(object? sender, EventArgs e)
        {
            try
            {
                // Gerekli alanları kontrol et
                if (string.IsNullOrWhiteSpace(txtBarkodNo.Text))
                {
                    MessageBox.Show("Barkod numarası boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBarkodNo.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
                {
                    MessageBox.Show("Ürün adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUrunAdi.Focus();
                    return;
                }

                ProductGroup? selectedGroup = null;
                if (cmbUrunGrubu.SelectedItem != null)
                {
                    selectedGroup = _context.ProductGroups.FirstOrDefault(g => g.Name == cmbUrunGrubu.SelectedItem.ToString());
                }

                Wholesaler? selectedWholesaler = null;
                if (cmbToptanci.SelectedItem != null && !string.IsNullOrEmpty(cmbToptanci.SelectedItem.ToString()))
                {
                    selectedWholesaler = _context.Wholesalers.FirstOrDefault(w => w.Name == cmbToptanci.SelectedItem.ToString());
                }

                if (_isEditMode && _currentProduct != null)
                {
                    // Update existing product
                    _currentProduct.Name = txtUrunAdi.Text;
                    _currentProduct.StockCode = txtUrunKodu.Text;
                    _currentProduct.ProductGroupId = selectedGroup?.Id;
                    _currentProduct.PurchasePrice = decimal.TryParse(txtAlisFiyatiKdvHaric.Text, out decimal purchasePrice) ? purchasePrice : 0;
                    _currentProduct.SalePrice = decimal.TryParse(txtSatisFiyati.Text, out decimal salePrice) ? salePrice : 0;
                    _currentProduct.CurrentStock = decimal.TryParse(txtMevcutStok.Text, out decimal currentStock) ? currentStock : 0;
                    _currentProduct.MinimumStock = decimal.TryParse(txtAsgariStok.Text, out decimal minStock) ? minStock : 0;
                    _currentProduct.Unit = cmbOlcuBirimi.SelectedItem?.ToString() ?? "Adet";
                    _currentProduct.VatRate = decimal.TryParse(txtKdvOrani.Text, out decimal vatRate) ? vatRate : 10;
                    _currentProduct.Notes = $"Toptancı: {selectedWholesaler?.Name ?? "Belirtilmemiş"}, Ödeme: {cmbOdemeSekli.SelectedItem?.ToString() ?? "Belirtilmemiş"}";
                    _currentProduct.UpdatedDate = DateTime.Now;

                    _context.Products.Update(_currentProduct);
                    MessageBox.Show("Ürün başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Barkod numarası benzersiz mi kontrol et
                    var existingProduct = _context.Products.FirstOrDefault(p => p.BarcodeNo == txtBarkodNo.Text);
                    if (existingProduct != null)
                    {
                        MessageBox.Show("Bu barkod numarası zaten kullanılıyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBarkodNo.Focus();
                        return;
                    }

                    // Yeni ürün oluştur
                    var newProduct = new Product
                    {
                        BarcodeNo = txtBarkodNo.Text,
                        Name = txtUrunAdi.Text,
                        StockCode = txtUrunKodu.Text,
                        ProductGroupId = selectedGroup?.Id,
                        PurchasePrice = decimal.TryParse(txtAlisFiyatiKdvHaric.Text, out decimal purchasePrice) ? purchasePrice : 0,
                        SalePrice = decimal.TryParse(txtSatisFiyati.Text, out decimal salePrice) ? salePrice : 0,
                        CurrentStock = decimal.TryParse(txtMevcutStok.Text, out decimal currentStock) ? currentStock : 0,
                        MinimumStock = decimal.TryParse(txtAsgariStok.Text, out decimal minStock) ? minStock : 0,
                        Unit = cmbOlcuBirimi.SelectedItem?.ToString() ?? "Adet", // Change from txtOlcuBirimi.Text
                        VatRate = decimal.TryParse(txtKdvOrani.Text, out decimal vatRate) ? vatRate : 10,
                        Notes = $"Toptancı: {selectedWholesaler?.Name ?? "Belirtilmemiş"}, Ödeme: {cmbOdemeSekli.SelectedItem?.ToString() ?? "Belirtilmemiş"}",
                        IsActive = true,
                        CreatedDate = DateTime.Now
                    };

                    _context.Products.Add(newProduct);
                    MessageBox.Show("Ürün başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _context.SaveChanges();

                // Formu temizle ve yeni giriş moduna dön
                ClearForm();
                _isEditMode = false;
                _currentProduct = null;
                btnKaydet.Text = "Kaydet (F1)"; // Reset button text
                txtBarkodNo.ReadOnly = false; // Enable barcode editing for new entry
                btnOtomatikBarkod.Enabled = true; // Enable automatic barcode generation
                lblZorunluAlanlar.Visible = true; // Show mandatory fields label
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün kaydedilirken/güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtBarkodNo.Clear();
            txtUrunAdi.Clear();
            txtUrunKodu.Clear();
            cmbUrunGrubu.SelectedIndex = -1;
            txtAlisFiyatiKdvHaric.Clear();
            txtAlisFiyatiKdvDahil.Clear();
            txtSatisFiyati.Clear();
            txtMevcutStok.Text = "0";
            txtAsgariStok.Text = "0";
            cmbOlcuBirimi.SelectedIndex = 0; // Set to first item, e.g., "Adet"
            txtKdvOrani.Text = "10";
            cmbToptanci.SelectedIndex = -1;
            cmbOdemeSekli.SelectedIndex = -1;
        }

        private void LoadWholesalers()
        {
            try
            {
                var wholesalers = _context.Wholesalers.OrderBy(w => w.Name).ToList();
                cmbToptanci.Items.Clear();
                cmbToptanci.Items.Add(""); // Boş seçenek
                foreach (var wholesaler in wholesalers)
                {
                    cmbToptanci.Items.Add(wholesaler.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Toptancılar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPaymentTypes()
        {
            cmbOdemeSekli.Items.Clear();
            cmbOdemeSekli.Items.Add("Nakit");
            cmbOdemeSekli.Items.Add("Kredi Kartı");
            cmbOdemeSekli.Items.Add("Havale/EFT");
            cmbOdemeSekli.Items.Add("Çek");
            cmbOdemeSekli.Items.Add("Veresiye");
            cmbOdemeSekli.SelectedIndex = 0; // Varsayılan olarak "Nakit"
        }

        private void LoadUnits()
        {
            try
            {
                var units = _context.Units.OrderBy(u => u.Name).ToList();
                cmbOlcuBirimi.Items.Clear();
                foreach (var unit in units)
                {
                    cmbOlcuBirimi.Items.Add(unit.Name);
                }
                if (cmbOlcuBirimi.Items.Count > 0)
                {
                    cmbOlcuBirimi.SelectedIndex = 0; // Select the first item by default
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ölçü birimleri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fiyat hesaplama metodları
        private void txtAlisFiyatiKdvDahil_TextChanged(object? sender, EventArgs e)
        {
            CalculatePriceFromKdvDahil();
        }

        private void txtAlisFiyatiKdvHaric_TextChanged(object? sender, EventArgs e)
        {
            CalculatePriceFromKdvHaric();
        }

        private void txtKdvOrani_TextChanged(object? sender, EventArgs e)
        {
            CalculatePriceFromKdvHaric();
        }

        private void CalculatePriceFromKdvDahil()
        {
            if (decimal.TryParse(txtAlisFiyatiKdvDahil.Text, out decimal kdvDahilFiyat) &&
                decimal.TryParse(txtKdvOrani.Text, out decimal kdvOrani))
            {
                if (kdvOrani >= 0)
                {
                    decimal kdvHaricFiyat = kdvDahilFiyat / (1 + (kdvOrani / 100));
                    txtAlisFiyatiKdvHaric.TextChanged -= txtAlisFiyatiKdvHaric_TextChanged;
                    txtAlisFiyatiKdvHaric.Text = kdvHaricFiyat.ToString("F2");
                    txtAlisFiyatiKdvHaric.TextChanged += txtAlisFiyatiKdvHaric_TextChanged;
                }
            }
        }

        private void CalculatePriceFromKdvHaric()
        {
            if (decimal.TryParse(txtAlisFiyatiKdvHaric.Text, out decimal kdvHaricFiyat) &&
                decimal.TryParse(txtKdvOrani.Text, out decimal kdvOrani))
            {
                if (kdvOrani >= 0)
                {
                    decimal kdvDahilFiyat = kdvHaricFiyat * (1 + (kdvOrani / 100));
                    txtAlisFiyatiKdvDahil.TextChanged -= txtAlisFiyatiKdvDahil_TextChanged;
                    txtAlisFiyatiKdvDahil.Text = kdvDahilFiyat.ToString("F2");
                    txtAlisFiyatiKdvDahil.TextChanged += txtAlisFiyatiKdvDahil_TextChanged;
                }
            }
        }

        private void RbKdvDahil_CheckedChanged(object? sender, EventArgs e)
        {
            if (rbKdvDahil.Checked)
            {
                txtAlisFiyatiKdvDahil.Enabled = true;
                txtAlisFiyatiKdvHaric.Enabled = false;
                txtAlisFiyatiKdvHaric.Text = ""; // Clear the other field
                txtKdvOrani.Enabled = false; // Disable KDV Oranı when Kdv Dahil is checked
            }
        }

        private void RbKdvHaric_CheckedChanged(object? sender, EventArgs e)
        {
            if (rbKdvHaric.Checked)
            {
                txtAlisFiyatiKdvDahil.Enabled = false;
                txtAlisFiyatiKdvHaric.Enabled = true;
                txtAlisFiyatiKdvDahil.Text = ""; // Clear the other field
                txtKdvOrani.Enabled = true; // Enable KDV Oranı when Kdv Haric is checked
            }
        }

        private void btnYeniOlcuBirimi_Click(object? sender, EventArgs e)
        {
            string yeniOlcuBirimi = Interaction.InputBox("Yeni ölçü birimini girin:", "Ölçü Birimi Ekle", "");
            if (!string.IsNullOrWhiteSpace(yeniOlcuBirimi))
            {
                try
                {
                    var existingUnit = _context.Units.FirstOrDefault(u => u.Name == yeniOlcuBirimi);
                    if (existingUnit != null)
                    {
                        MessageBox.Show("Bu ölçü birimi zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var newUnit = new Unit
                    {
                        Name = yeniOlcuBirimi,
                        Description = $"{yeniOlcuBirimi} ölçü birimi",
                        CreatedDate = DateTime.Now
                    };

                    _context.Units.Add(newUnit);
                    _context.SaveChanges();

                    LoadUnits(); // Reload units into combobox
                    cmbOlcuBirimi.SelectedItem = yeniOlcuBirimi; // Select the newly added unit

                    MessageBox.Show("Ölçü birimi başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ölçü birimi eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVazgec_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
