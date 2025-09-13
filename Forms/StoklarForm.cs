using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using StokTakip.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Globalization;

namespace StokTakip.Forms
{
    public partial class StoklarForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public StoklarForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _serviceProvider = serviceProvider;
            LoadProductData();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            // Search functionality
            txtUrunArama.TextChanged += TxtUrunArama_TextChanged;

            // Button click events
            btnUrunDuzenle.Click += BtnUrunDuzenle_Click;
            btnUrunSil.Click += BtnUrunSil_Click;
            btnUrunEkle.Click += BtnUrunEkle_Click;
            btnTopluUrunSil.Click += BtnTopluUrunSil_Click;
            btnUrunGruplan.Click += BtnUrunGruplan_Click;
            btnTopluUrunFiyatiDegistirme.Click += BtnTopluUrunFiyatiDegistirme_Click;
            btnUrunDetayi.Click += BtnUrunDetayi_Click;
            btnBarkodYazdir.Click += BtnBarkodYazdir_Click;
            btnSayim.Click += BtnSayim_Click;
            btnAsgariStokAlti.Click += BtnAsgariStokAlti_Click;

            // Export buttons
            btnTerazye.Click += BtnTerazye_Click;
            btnExcelKayitAl.Click += BtnExcelKayitAl_Click;
            btnExcelKayitVer.Click += BtnExcelKayitVer_Click;

            // Combo box event handlers
            cmbUrunGrubu.SelectedIndexChanged += cmbUrunGrubu_SelectedIndexChanged;
            cmbSiralamaOlcutu.SelectedIndexChanged += cmbSiralamaOlcutu_SelectedIndexChanged;

            // Populate combo boxes
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            // Populate cmbUrunGrubu
            cmbUrunGrubu.Items.Clear();
            cmbUrunGrubu.Items.Add("Tümü");
            var productGroups = _context.ProductGroups.Select(g => g.Name).ToList();
            foreach (var groupName in productGroups)
            {
                cmbUrunGrubu.Items.Add(groupName);
            }
            cmbUrunGrubu.SelectedIndex = 0; // Select "Tümü" by default

            // Populate cmbSiralamaOlcutu
            cmbSiralamaOlcutu.Items.Clear();
            cmbSiralamaOlcutu.Items.AddRange(new object[] { "AD", "ALIŞ FİYATI", "BARKOD NUMARASI", "MEVCUT STOK", "SATIŞ FİYATI", "ÜRÜN GRUBU" });
            cmbSiralamaOlcutu.SelectedIndex = 0; // Select "AD" by default
        }

        private void LoadProductData()
        {
            try
            {
                dgvUrunler.Rows.Clear();

                var products = _context.Products
                    .Include(p => p.ProductGroup)
                    .Where(p => p.IsActive)
                    .ToList();

                foreach (var product in products)
                {
                    dgvUrunler.Rows.Add(
                        product.BarcodeNo,
                        product.Name,
                        product.StockCode ?? "---",
                        product.MinimumStock.ToString("F1"),
                        product.CurrentStock.ToString("F1"),
                        product.Unit,
                        product.PurchasePrice.ToString("F2"),
                        product.SalePrice.ToString("F2"),
                        product.VatRate.ToString("F0"),
                        product.ProductGroup?.Name ?? "BELİRTİLMEDİ",
                        product.Id
                    );
                }

                UpdateTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün verileri yüklenirken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSampleData()
        {
            // This method is kept for backward compatibility but now calls LoadProductData
            LoadProductData();
        }

        private void UpdateTotals()
        {
            try
            {
                // Görünür satırları say ve hesapla
                var visibleProducts = new List<Product>();
                var allProducts = _context.Products.Include(p => p.ProductGroup).Where(p => p.IsActive).ToList();

                // Filtreleme uygula
                var filteredProducts = allProducts.AsQueryable();

                // Ürün grubu filtreleme
                if (cmbUrunGrubu.SelectedItem is string selectedGroup && selectedGroup != "Tümü")
                {
                    filteredProducts = filteredProducts.Where(p => p.ProductGroup != null && p.ProductGroup.Name == selectedGroup);
                }

                // Arama filtreleme
                string searchText = txtUrunArama.Text.ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    filteredProducts = filteredProducts.Where(p =>
                        p.BarcodeNo.ToLower().Contains(searchText) ||
                        p.Name.ToLower().Contains(searchText) ||
                        (p.StockCode != null && p.StockCode.ToLower().Contains(searchText)) ||
                        (p.ProductGroup != null && p.ProductGroup.Name.ToLower().Contains(searchText))
                    );
                }

                var finalProducts = filteredProducts.ToList();

                // Hesaplamalar
                decimal totalPurchaseValue = finalProducts.Sum(p => p.PurchasePrice * p.CurrentStock);
                decimal totalSalesValue = finalProducts.Sum(p => p.SalePrice * p.CurrentStock);
                int totalProducts = finalProducts.Count;
                decimal totalStock = finalProducts.Sum(p => p.CurrentStock);

                // UI güncelleme
                lblAlisFiyatiDegeri.Text = $"{totalPurchaseValue:F2} TL";
                lblSatisFiyatiDegeri.Text = $"{totalSalesValue:F2} TL";
                lblToplamStokAdedi.Text = totalStock.ToString("F0");
                lblListelenenSayisi.Text = totalProducts.ToString();
            }
            catch
            {
                // Hata durumunda varsayılan değerler
                lblAlisFiyatiDegeri.Text = "0,00 TL";
                lblSatisFiyatiDegeri.Text = "0,00 TL";
                lblToplamStokAdedi.Text = "0";
                lblListelenenSayisi.Text = "0";
            }
        }

        private void TxtUrunArama_TextChanged(object? sender, EventArgs e)
        {
            string searchText = txtUrunArama.Text.ToLower();

            foreach (DataGridViewRow row in dgvUrunler.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value?.ToString()?.ToLower().Contains(searchText) == true)
                    {
                        visible = true;
                        break;
                    }
                }
                row.Visible = visible;
            }
        }

        // Button event handlers
        private void BtnUrunDuzenle_Click(object? sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                try
                {
                    int productId = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["colId"].Value);
                    var product = _context.Products
                        .Include(p => p.ProductGroup)
                        .FirstOrDefault(p => p.Id == productId);

                    if (product != null)
                    {
                        using (var editForm = _serviceProvider.GetRequiredService<UrunDuzenleForm>())
                        {
                            editForm.SetProduct(product);
                            if (editForm.ShowDialog() == DialogResult.OK)
                            {
                                LoadProductData(); // Listeyi yenile
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ürün düzenlenirken hata oluştu: {ex.Message}", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz ürünü seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnUrunSil_Click(object? sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Seçili ürünü silmek istediğinizden emin misiniz?",
                    "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int productId = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["colId"].Value);
                        var productToDelete = _context.Products.FirstOrDefault(p => p.Id == productId);

                        if (productToDelete != null)
                        {
                            _context.Products.Remove(productToDelete);
                            _context.SaveChanges();
                            MessageBox.Show("Ürün başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProductData(); // Refresh the list
                        }
                        else
                        {
                            MessageBox.Show("Silinecek ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ürün silinirken hata oluştu: {ex.Message}", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnUrunEkle_Click(object? sender, EventArgs e)
        {
            var urunGirisForm = _serviceProvider.GetRequiredService<UrunGirisForm>();
            urunGirisForm.ShowDialog();
        }

        private void BtnTopluUrunSil_Click(object? sender, EventArgs e)
        {
            var silinecekUrunlerForm = _serviceProvider.GetRequiredService<SilinecekUrunlerForm>();
            silinecekUrunlerForm.ShowDialog();
        }

        private void BtnUrunGruplan_Click(object? sender, EventArgs e)
        {
            var urunGruplariForm = _serviceProvider.GetRequiredService<UrunGruplariForm>();
            urunGruplariForm.ShowDialog();
        }

        private void BtnTopluUrunFiyatiDegistirme_Click(object? sender, EventArgs e)
        {
            var fiyatDegistirmeForm = _serviceProvider.GetRequiredService<FiyatDegistirmeForm>();
            fiyatDegistirmeForm.ShowDialog();
        }

        private void BtnUrunDetayi_Click(object? sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedRow = dgvUrunler.SelectedRows[0];
                    var idCell = selectedRow.Cells["colId"];

                    if (idCell.Value == null)
                    {
                        MessageBox.Show("Seçilen ürünün ID bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int productId = Convert.ToInt32(idCell.Value);

                    var product = _context.Products
                        .Include(p => p.ProductGroup)
                        .FirstOrDefault(p => p.Id == productId);

                    if (product != null)
                    {
                        using (var urunAyrintisiForm = _serviceProvider.GetRequiredService<UrunAyrintisiForm>())
                        {
                            urunAyrintisiForm.SetProduct(product);
                            urunAyrintisiForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ürün detayı gösterilecek ürün bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ürün detayı gösterilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen detayını görmek istediğiniz ürünü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBarkodYazdir_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Barkod yazdır işlemi");
        }

        private void BtnSayim_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Sayım işlemi");
        }

        private void BtnAsgariStokAlti_Click(object? sender, EventArgs e)
        {
            var asgariStokAltiForm = _serviceProvider.GetRequiredService<AsgariStokAltiForm>();
            asgariStokAltiForm.ShowDialog();
        }

        private void BtnTerazye_Click(object? sender, EventArgs e)
        {
            try
            {
                ExportToScale();
                MessageBox.Show("Veriler teraziye başarıyla aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Teraziye aktarma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcelKayitAl_Click(object? sender, EventArgs e)
        {
            try
            {
                ImportFromCSV();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CSV'den kayıt alma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcelKayitVer_Click(object? sender, EventArgs e)
        {
            try
            {
                ExportToCSV();
                MessageBox.Show("Veriler CSV'ye başarıyla aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CSV'ye aktarma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUrunler_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvUrunler.Rows[e.RowIndex];

                txtBarkodNo.Text = row.Cells["colBarkodNo"].Value?.ToString();
                txtUrunAdi.Text = row.Cells["colUrunAdi"].Value?.ToString();
                txtStokKodu.Text = row.Cells["colStokKodu"].Value?.ToString();
                txtUrunGrubu.Text = row.Cells["colUrunGrubu"].Value?.ToString();
                txtSatisFiyati.Text = row.Cells["colSatisFiyati"].Value?.ToString();
                txtAlisFiyati.Text = row.Cells["colAlisFiyati"].Value?.ToString();
                txtMevcutStok.Text = row.Cells["colMevcutStok"].Value?.ToString();
            }
        }

        private void cmbUrunGrubu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FilterAndSortProducts();
        }

        private void cmbSiralamaOlcutu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FilterAndSortProducts();
        }

        private void FilterAndSortProducts()
        {
            dgvUrunler.Rows.Clear();

            var products = _context.Products.Include(p => p.ProductGroup).Where(p => p.IsActive).AsQueryable();

            // Filter by Product Group
            if (cmbUrunGrubu.SelectedItem is string selectedGroup && selectedGroup != "Tümü")
            {
                products = products.Where(p => p.ProductGroup != null && p.ProductGroup.Name == selectedGroup);
            }

            // Sort products
            switch (cmbSiralamaOlcutu.SelectedItem?.ToString())
            {
                case "AD":
                    products = products.OrderBy(p => p.Name);
                    break;
                case "ALIŞ FİYATI":
                    products = products.OrderBy(p => p.PurchasePrice);
                    break;
                case "BARKOD NUMARASI":
                    products = products.OrderBy(p => p.BarcodeNo);
                    break;
                case "MEVCUT STOK":
                    products = products.OrderBy(p => p.CurrentStock);
                    break;
                case "SATIŞ FİYATI":
                    products = products.OrderBy(p => p.SalePrice);
                    break;
                case "ÜRÜN GRUBU":
                    products = products.OrderBy(p => p.ProductGroup != null ? p.ProductGroup.Name : string.Empty);
                    break;
                default:
                    products = products.OrderBy(p => p.Name);
                    break;
            }

            foreach (var product in products.ToList())
            {
                dgvUrunler.Rows.Add(
                    product.BarcodeNo,
                    product.Name,
                    product.StockCode ?? "---",
                    product.MinimumStock.ToString("F1"),
                    product.CurrentStock.ToString("F1"),
                    product.Unit,
                    product.PurchasePrice.ToString("F2"),
                    product.SalePrice.ToString("F2"),
                    product.VatRate.ToString("F0"),
                    product.ProductGroup?.Name ?? "BELİRTİLMEDİ",
                    product.Id
                );
            }
            UpdateTotals();
        }

        private System.Collections.Generic.List<Product> GetFilteredProducts()
        {
            var products = _context.Products.Include(p => p.ProductGroup).Where(p => p.IsActive).AsQueryable();

            // Grup filtreleme
            if (cmbUrunGrubu.SelectedItem is string selectedGroup && selectedGroup != "Tümü")
            {
                products = products.Where(p => p.ProductGroup != null && p.ProductGroup.Name == selectedGroup);
            }

            // Sıralama
            switch (cmbSiralamaOlcutu.SelectedItem?.ToString())
            {
                case "AD":
                    products = products.OrderBy(p => p.Name);
                    break;
                case "ALIŞ FİYATI":
                    products = products.OrderBy(p => p.PurchasePrice);
                    break;
                case "BARKOD NUMARASI":
                    products = products.OrderBy(p => p.BarcodeNo);
                    break;
                case "MEVCUT STOK":
                    products = products.OrderBy(p => p.CurrentStock);
                    break;
                case "SATIŞ FİYATI":
                    products = products.OrderBy(p => p.SalePrice);
                    break;
                case "ÜRÜN GRUBU":
                    products = products.OrderBy(p => p.ProductGroup != null ? p.ProductGroup.Name : string.Empty);
                    break;
                default:
                    products = products.OrderBy(p => p.Name);
                    break;
            }

            return products.ToList();
        }

        private void ExportToScale()
        {
            // Terazi formatında veri aktarımı (PLU dosyası oluşturma)
            var selectedProducts = GetFilteredProducts();

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Text files (*.txt)|*.txt|PLU files (*.plu)|*.plu|All files (*.*)|*.*";
                saveDialog.Title = "Terazi Dosyası Kaydet";
                saveDialog.FileName = $"terazi_verileri_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName, false, Encoding.UTF8))
                    {
                        writer.WriteLine("# Terazi Veri Dosyası - " + DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                        writer.WriteLine("# Format: PLU|Ürün Adı|Fiyat|Barkod");

                        int pluCode = 1;
                        foreach (var product in selectedProducts)
                        {
                            // PLU|Ürün Adı|Kg Fiyatı|Barkod formatında
                            writer.WriteLine($"{pluCode:D4}|{product.Name}|{product.SalePrice:F2}|{product.BarcodeNo}");
                            pluCode++;
                        }
                    }
                }
            }
        }

        private void ImportFromCSV()
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openDialog.Title = "CSV/Metin Dosyası Seç";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(openDialog.FileName, Encoding.UTF8);
                        int importedCount = 0;
                        int updatedCount = 0;

                        // İlk satırı atla (başlık satırı)
                        for (int i = 1; i < lines.Length; i++)
                        {
                            try
                            {
                                string[] values = lines[i].Split(';'); // Noktalı virgül ile ayrılmış

                                if (values.Length < 10) continue;

                                string barkodNo = values[0].Trim().Trim('"');
                                string urunAdi = values[1].Trim().Trim('"');
                                string stokKodu = values[2].Trim().Trim('"');

                                if (string.IsNullOrEmpty(barkodNo) || string.IsNullOrEmpty(urunAdi))
                                    continue;

                                decimal.TryParse(values[3].Trim().Trim('"').Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out decimal asgariStok);
                                decimal.TryParse(values[4].Trim().Trim('"').Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out decimal mevcutStok);
                                string birim = values[5].Trim().Trim('"');
                                if (string.IsNullOrEmpty(birim)) birim = "Adet";
                                decimal.TryParse(values[6].Trim().Trim('"').Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out decimal alisFiyati);
                                decimal.TryParse(values[7].Trim().Trim('"').Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out decimal satisFiyati);
                                decimal.TryParse(values[8].Trim().Trim('"').Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out decimal kdvOrani);
                                string urunGrubu = values[9].Trim().Trim('"');
                                if (string.IsNullOrEmpty(urunGrubu)) urunGrubu = "BELİRTİLMEDİ";

                                // Ürün var mı kontrol et
                                var existingProduct = _context.Products.FirstOrDefault(p => p.BarcodeNo == barkodNo);

                                if (existingProduct != null)
                                {
                                    // Güncelle
                                    existingProduct.Name = urunAdi;
                                    existingProduct.StockCode = stokKodu;
                                    existingProduct.MinimumStock = asgariStok;
                                    existingProduct.CurrentStock = mevcutStok;
                                    existingProduct.Unit = birim;
                                    existingProduct.PurchasePrice = alisFiyati;
                                    existingProduct.SalePrice = satisFiyati;
                                    existingProduct.VatRate = kdvOrani;
                                    updatedCount++;
                                }
                                else
                                {
                                    // Yeni ürün ekle
                                    var productGroup = _context.ProductGroups.FirstOrDefault(g => g.Name == urunGrubu);
                                    if (productGroup == null)
                                    {
                                        productGroup = new ProductGroup { Name = urunGrubu };
                                        _context.ProductGroups.Add(productGroup);
                                        _context.SaveChanges();
                                    }

                                    var newProduct = new Product
                                    {
                                        BarcodeNo = barkodNo,
                                        Name = urunAdi,
                                        StockCode = stokKodu,
                                        MinimumStock = asgariStok,
                                        CurrentStock = mevcutStok,
                                        Unit = birim,
                                        PurchasePrice = alisFiyati,
                                        SalePrice = satisFiyati,
                                        VatRate = kdvOrani,
                                        ProductGroupId = productGroup.Id,
                                        IsActive = true,
                                        CreatedDate = DateTime.Now
                                    };

                                    _context.Products.Add(newProduct);
                                    importedCount++;
                                }
                            }
                            catch
                            {
                                // Satır hatası, devam et
                                continue;
                            }
                        }

                        _context.SaveChanges();
                        LoadProductData();

                        MessageBox.Show($"Dosyadan aktarım tamamlandı.\n" +
                                      $"Yeni ürün: {importedCount}\n" +
                                      $"Güncellenen ürün: {updatedCount}",
                                      "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Dosya okuma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExportToCSV()
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveDialog.Title = "CSV Dosyası Kaydet";
                saveDialog.FileName = $"stok_listesi_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveDialog.FileName, false, Encoding.UTF8))
                        {
                            // BOM ekle (Excel için UTF-8 tanıma)
                            writer.Write('\uFEFF');

                            // Başlıklar
                            writer.WriteLine("Barkod No;Ürün Adı;Stok Kodu;Asgari Stok;Mevcut Stok;Ölçü Birimi;Alış Fiyatı;Satış Fiyatı;KDV Oranı;Ürün Grubu");

                            // Veriler
                            var products = GetFilteredProducts();

                            foreach (var product in products)
                            {
                                writer.WriteLine($"\"{product.BarcodeNo}\";\"{product.Name}\";\"{product.StockCode ?? "---"}\";" +
                                               $"{product.MinimumStock.ToString("F1", CultureInfo.InvariantCulture)};" +
                                               $"{product.CurrentStock.ToString("F1", CultureInfo.InvariantCulture)};" +
                                               $"\"{product.Unit}\";" +
                                               $"{product.PurchasePrice.ToString("F2", CultureInfo.InvariantCulture)};" +
                                               $"{product.SalePrice.ToString("F2", CultureInfo.InvariantCulture)};" +
                                               $"{product.VatRate.ToString("F0", CultureInfo.InvariantCulture)};" +
                                               $"\"{product.ProductGroup?.Name ?? "BELİRTİLMEDİ"}\"");
                            }
                        }

                        MessageBox.Show($"Veriler CSV dosyasına başarıyla aktarıldı.\nDosya: {saveDialog.FileName}",
                                      "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Dosyayı açmak ister misiniz?
                        if (MessageBox.Show("Oluşturulan dosyayı açmak ister misiniz?", "Dosya Aç",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                            {
                                FileName = saveDialog.FileName,
                                UseShellExecute = true
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Dosya yazma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
