using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Data;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class UrunDuzenleForm : Form
    {
        private readonly StokTakipDbContext _context;
        private Product? _product;

        public UrunDuzenleForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            SetupEventHandlers();
        }

        public void SetProduct(Product product)
        {
            _product = product;
            LoadData();
        }

        private void SetupEventHandlers()
        {
            btnKaydet.Click += BtnKaydet_Click;
            btnVazgec.Click += BtnVazgec_Click;

            // Load combo boxes
            LoadProductGroups();
            LoadWholesalers();
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
            try
            {
                var wholesalers = _context.Wholesalers.OrderBy(w => w.Name).ToList();
                // Designer'da tanımlı combo box'ı kullan
                if (cmbUrunGrubu.Parent?.Controls.OfType<ComboBox>().Any(c => c.Name.Contains("Toptanci")) == true)
                {
                    var cmbToptanci = cmbUrunGrubu.Parent.Controls.OfType<ComboBox>().First(c => c.Name.Contains("Toptanci"));
                    cmbToptanci.Items.Clear();

                    foreach (var wholesaler in wholesalers)
                    {
                        cmbToptanci.Items.Add(wholesaler.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Toptancılar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            if (_product == null) return;

            try
            {
                // Load product data into form controls
                txtBarkodNo.Text = _product.BarcodeNo;
                txtUrunAdi.Text = _product.Name;
                txtStokKodu.Text = _product.StockCode ?? "";
                txtAlisFiyati.Text = _product.PurchasePrice.ToString("F2");
                txtSatisFiyati.Text = _product.SalePrice.ToString("F2");
                txtMevcutStok.Text = _product.CurrentStock.ToString();
                txtAsgariStok.Text = _product.MinimumStock.ToString();
                txtKDVOrani.Text = _product.VatRate.ToString("F0");
                cmbOlcuBirimi.Text = _product.Unit;

                // Set combo box selections
                if (_product.ProductGroup != null)
                {
                    cmbUrunGrubu.SelectedItem = _product.ProductGroup.Name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün verileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnKaydet_Click(object? sender, EventArgs e)
        {
            if (_product == null) return;

            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
                {
                    MessageBox.Show("Ürün adı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUrunAdi.Focus();
                    return;
                }

                if (!decimal.TryParse(txtSatisFiyati.Text, out decimal salePrice))
                {
                    MessageBox.Show("Geçerli bir satış fiyatı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSatisFiyati.Focus();
                    return;
                }

                // Get selected group
                ProductGroup? selectedGroup = null;
                if (cmbUrunGrubu.SelectedItem != null)
                {
                    selectedGroup = _context.ProductGroups.FirstOrDefault(g => g.Name == cmbUrunGrubu.SelectedItem.ToString());
                }

                // Update product
                _product.Name = txtUrunAdi.Text.Trim();
                _product.StockCode = txtStokKodu.Text.Trim();
                _product.ProductGroupId = selectedGroup?.Id;
                _product.PurchasePrice = decimal.TryParse(txtAlisFiyati.Text, out decimal purchasePrice) ? purchasePrice : 0;
                _product.SalePrice = salePrice;
                _product.CurrentStock = decimal.TryParse(txtMevcutStok.Text, out decimal currentStock) ? currentStock : 0;
                _product.MinimumStock = decimal.TryParse(txtAsgariStok.Text, out decimal minStock) ? minStock : 0;
                _product.VatRate = decimal.TryParse(txtKDVOrani.Text, out decimal vatRate) ? vatRate : 10;
                _product.Unit = cmbOlcuBirimi.Text;
                _product.UpdatedDate = DateTime.Now;

                _context.SaveChanges();

                MessageBox.Show("Ürün bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVazgec_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CmbUrunGrubu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Handle product group selection
        }
    }
}
