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

        public UrunGirisForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            LoadProductGroups();
            SetupEventHandlers();
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

            // Fiyat hesaplama event'leri
            txtAlisFiyatiKdvDahil.TextChanged += new EventHandler(txtAlisFiyatiKdvDahil_TextChanged);
            txtAlisFiyatiKdvHaric.TextChanged += new EventHandler(txtAlisFiyatiKdvHaric_TextChanged);
            txtKdvOrani.TextChanged += new EventHandler(txtKdvOrani_TextChanged);

            // Ödeme şekli ve toptancı combo'larını yükle
            LoadWholesalers();
            LoadPaymentTypes();
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
            // Primary key tabanlı otomatik barkod - bir sonraki ID'yi al
            var nextId = _context.Products.Any() ? _context.Products.Max(p => p.Id) + 1 : 1;

            // 8690 ile başlayan 13 haneli barkod oluştur (8690 + 9 haneli ID)
            return $"8690{nextId:D9}";
        }

        private void btnFaturaliGiris_Click(object? sender, EventArgs e)
        {
            var alisFaturasiForm = _serviceProvider.GetRequiredService<AlisFaturasiForm>();
            alisFaturasiForm.ShowDialog();
        }

        private void btnUrunAra_Click(object? sender, EventArgs e)
        {
            var urunAramaForm = _serviceProvider.GetRequiredService<UrunAramaForm>();
            urunAramaForm.ShowDialog();
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

                // Barkod numarası benzersiz mi kontrol et
                var existingProduct = _context.Products.FirstOrDefault(p => p.BarcodeNo == txtBarkodNo.Text);
                if (existingProduct != null)
                {
                    MessageBox.Show("Bu barkod numarası zaten kullanılıyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBarkodNo.Focus();
                    return;
                }

                // Ürün grubunu bul
                ProductGroup? selectedGroup = null;
                if (cmbUrunGrubu.SelectedItem != null)
                {
                    selectedGroup = _context.ProductGroups.FirstOrDefault(g => g.Name == cmbUrunGrubu.SelectedItem.ToString());
                }

                // Toptancıyı bul
                Wholesaler? selectedWholesaler = null;
                if (cmbToptanci.SelectedItem != null && !string.IsNullOrEmpty(cmbToptanci.SelectedItem.ToString()))
                {
                    selectedWholesaler = _context.Wholesalers.FirstOrDefault(w => w.Name == cmbToptanci.SelectedItem.ToString());
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
                    Unit = txtOlcuBirimi.Text ?? "Adet",
                    VatRate = decimal.TryParse(txtKdvOrani.Text, out decimal vatRate) ? vatRate : 10,
                    Notes = $"Toptancı: {selectedWholesaler?.Name ?? "Belirtilmemiş"}, Ödeme: {cmbOdemeSekli.SelectedItem?.ToString() ?? "Belirtilmemiş"}",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                };

                _context.Products.Add(newProduct);
                _context.SaveChanges();

                MessageBox.Show("Ürün başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu temizle
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtOlcuBirimi.Text = "Adet";
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
    }
}
