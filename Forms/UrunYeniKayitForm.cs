using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.Forms
{
    public partial class UrunYeniKayitForm : Form
    {
        private readonly StokTakipDbContext _context;

        public UrunYeniKayitForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            SetupEventHandlers();
            LoadProductGroups();
            LoadWholesalers();
        }

        private void SetupEventHandlers()
        {
            btnKaydet.Click += BtnKaydet_Click;
            btnVazgec.Click += BtnVazgec_Click;
            // btnTemizle.Click += BtnTemizle_Click; // btnTemizle does not exist in designer

            // Price calculation events
            txtAlisFiyatiKdvDahil.TextChanged += TxtAlisFiyatiKdvDahil_TextChanged;
            txtAlisFiyatiKdvHaric.TextChanged += TxtAlisFiyatiKdvHaric_TextChanged;
            txtKdvOrani.TextChanged += TxtKdvOrani_TextChanged;
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

        private void LoadWholesalers()
        {
            // cmbToptanci does not exist in designer, so this method is not used.
            // If a wholesaler selection is needed, cmbToptanci needs to be added to the designer.
        }

        private void BtnKaydet_Click(object? sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    // Check for existing barcode or stock code
                    if (_context.Products.Any(p => p.BarcodeNo == txtBarkodNo.Text))
                    {
                        MessageBox.Show("Bu barkod numarası zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBarkodNo.Focus();
                        return;
                    }
                    if (!string.IsNullOrEmpty(txtStokKodu.Text) && _context.Products.Any(p => p.StockCode == txtStokKodu.Text))
                    {
                        MessageBox.Show("Bu ürün kodu zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtStokKodu.Focus();
                        return;
                    }

                    ProductGroup? selectedGroup = null;
                    if (cmbUrunGrubu.SelectedItem != null)
                    {
                        selectedGroup = _context.ProductGroups.FirstOrDefault(g => g.Name == cmbUrunGrubu.SelectedItem.ToString());
                    }

                    // Wholesaler selection is not available in this form based on designer.
                    // Wholesaler? selectedWholesaler = null;
                    // if (cmbToptanci.SelectedItem != null && !string.IsNullOrEmpty(cmbToptanci.SelectedItem.ToString()))
                    // {
                    //     selectedWholesaler = _context.Wholesalers.FirstOrDefault(w => w.Name == cmbToptanci.SelectedItem.ToString());
                    // }

                    var newProduct = new Product
                    {
                        BarcodeNo = txtBarkodNo.Text,
                        Name = txtUrunAdi.Text,
                        StockCode = txtStokKodu.Text,
                        ProductGroupId = selectedGroup?.Id,
                        PurchasePrice = decimal.TryParse(txtAlisFiyatiKdvHaric.Text, out decimal purchasePrice) ? purchasePrice : 0,
                        SalePrice = decimal.TryParse(txtSatisFiyati.Text, out decimal salePrice) ? salePrice : 0,
                        CurrentStock = decimal.TryParse(txtAsgariStok.Text, out decimal currentStock) ? currentStock : 0, // Using txtAsgariStok for current stock
                        MinimumStock = decimal.TryParse(txtAsgariStok.Text, out decimal minStock) ? minStock : 0,
                        Unit = cmbOlcuBirimi.Text,
                        VatRate = decimal.TryParse(txtKdvOrani.Text, out decimal vatRate) ? vatRate : 10,
                        Notes = "", // No wholesaler selection in this form
                        IsActive = true,
                        CreatedDate = DateTime.Now
                    };

                    _context.Products.Add(newProduct);
                    _context.SaveChanges();

                    MessageBox.Show("Ürün başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ürün kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnVazgec_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnTemizle_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtBarkodNo.Clear();
            txtUrunAdi.Clear();
            txtStokKodu.Clear();
            cmbUrunGrubu.SelectedIndex = -1;
            txtAlisFiyatiKdvHaric.Clear();
            txtAlisFiyatiKdvDahil.Clear();
            txtSatisFiyati.Clear();
            txtAsgariStok.Text = "0"; // Using txtAsgariStok for current stock
            cmbOlcuBirimi.SelectedIndex = 0; // Assuming "Adet" is first item
            txtKdvOrani.Text = "10";
            // cmbToptanci.SelectedIndex = -1; // cmbToptanci does not exist
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtBarkodNo.Text))
            {
                MessageBox.Show("Barkod No boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarkodNo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün Adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUrunAdi.Focus();
                return false;
            }
            if (cmbUrunGrubu.SelectedIndex == -1)
            {
                MessageBox.Show("Ürün Grubu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUrunGrubu.Focus();
                return false;
            }
            if (!decimal.TryParse(txtAlisFiyatiKdvHaric.Text, out _) || !decimal.TryParse(txtSatisFiyati.Text, out _))
            {
                MessageBox.Show("Alış veya Satış Fiyatı geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtAsgariStok.Text, out _))
            {
                MessageBox.Show("Asgari Stok geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtKdvOrani.Text, out _))
            {
                MessageBox.Show("KDV Oranı geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Price calculation methods (copied from UrunGirisForm, ensure controls match)
        private void TxtAlisFiyatiKdvDahil_TextChanged(object? sender, EventArgs e)
        {
            CalculatePriceFromKdvDahil();
        }

        private void TxtAlisFiyatiKdvHaric_TextChanged(object? sender, EventArgs e)
        {
            CalculatePriceFromKdvHaric();
        }

        private void TxtKdvOrani_TextChanged(object? sender, EventArgs e)
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
                    txtAlisFiyatiKdvHaric.TextChanged -= TxtAlisFiyatiKdvHaric_TextChanged;
                    txtAlisFiyatiKdvHaric.Text = kdvHaricFiyat.ToString("F2");
                    txtAlisFiyatiKdvHaric.TextChanged += TxtAlisFiyatiKdvHaric_TextChanged;
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
                    txtAlisFiyatiKdvDahil.TextChanged -= TxtAlisFiyatiKdvDahil_TextChanged;
                    txtAlisFiyatiKdvDahil.Text = kdvDahilFiyat.ToString("F2");
                    txtAlisFiyatiKdvDahil.TextChanged += TxtAlisFiyatiKdvDahil_TextChanged;
                }
            }
        }
    }
}
