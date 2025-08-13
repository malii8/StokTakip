using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.Forms
{
    public partial class FiyatDegistirmeForm : Form
    {
        private readonly StokTakipDbContext _context;

        public FiyatDegistirmeForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            LoadProductGroups(); // Load groups first
            LoadProductPrices(); // Then load products
            SetupEventHandlers();
        }

        private void LoadProductGroups()
        {
            cmbUrunGrubu.Items.Clear();
            cmbUrunGrubu.Items.Add("Tümü");
            try
            {
                var groups = _context.ProductGroups.OrderBy(g => g.Name).ToList();
                foreach (var group in groups)
                {
                    cmbUrunGrubu.Items.Add(group.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün grupları yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmbUrunGrubu.SelectedIndex = 0;
        }

        private void LoadProductPrices()
        {
            dgvUrunFiyatlari.Rows.Clear();
            try
            {
                var products = _context.Products.Include(p => p.ProductGroup).ToList();

                foreach (var product in products)
                {
                    dgvUrunFiyatlari.Rows.Add(
                        false, // Checkbox
                        product.Id, // Hidden ID for update
                        product.BarcodeNo, // Barkod
                        product.Name, // Ürün Adı
                        product.PurchasePrice.ToString("F2"), // Alış Fiyatı
                        product.SalePrice.ToString("F2"),  // Satış Fiyatı
                        product.ProductGroup?.Name ?? "BELİRTİLMEDİ" // Ürün Grubu
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün fiyatları yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupEventHandlers()
        {
            // Fiyat değişikliği buttons
            btnYuzde10Artir.Click += (s, e) => UygulaBulkFiyatDegisikligi(1.10);
            btnYuzde20Artir.Click += (s, e) => UygulaBulkFiyatDegisikligi(1.20);
            btnYuzde30Artir.Click += (s, e) => UygulaBulkFiyatDegisikligi(1.30);
            btnYuzde15Azalt.Click += (s, e) => UygulaBulkFiyatDegisikligi(0.85);
            btnYuzde20Azalt.Click += (s, e) => UygulaBulkFiyatDegisikligi(0.80);
            btnYuzde30Azalt.Click += (s, e) => UygulaBulkFiyatDegisikligi(0.70);

            // Diğer buttons
            btnTumunuSec.Click += BtnTumunuSec_Click;
            btnHicbiriniSecme.Click += BtnHicbiriniSecme_Click;
            btnOzelFiyatUygula.Click += BtnOzelFiyatUygula_Click;
            btnKaydet.Click += BtnKaydet_Click;
            btnVazgec.Click += BtnVazgec_Click;

            // Grup filtreleme
            cmbUrunGrubu.SelectedIndexChanged += CmbUrunGrubu_SelectedIndexChanged;

            // Search box
            txtUrunAra.TextChanged += TxtUrunAra_TextChanged;
        }

        private void UygulaBulkFiyatDegisikligi(double carpan)
        {
            foreach (DataGridViewRow row in dgvUrunFiyatlari.Rows)
            {
                if (row.Cells["colSecim"].Value != null && (bool)row.Cells["colSecim"].Value)
                {
                    // Alış fiyatını değiştir
                    if (double.TryParse(row.Cells["colAlisFiyati"].Value?.ToString(), out double alisFiyati))
                    {
                        row.Cells["colAlisFiyati"].Value = (alisFiyati * carpan).ToString("F2");
                    }

                    // Satış fiyatını değiştir
                    if (double.TryParse(row.Cells["colSatisFiyati"].Value?.ToString(), out double satisFiyati))
                    {
                        row.Cells["colSatisFiyati"].Value = (satisFiyati * carpan).ToString("F2");
                    }
                }
            }
        }

        private void BtnTumunuSec_Click(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUrunFiyatlari.Rows)
            {
                row.Cells["colSecim"].Value = true;
            }
        }

        private void BtnHicbiriniSecme_Click(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUrunFiyatlari.Rows)
            {
                row.Cells["colSecim"].Value = false;
            }
        }

        private void BtnOzelFiyatUygula_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOzelFiyat.Text))
            {
                MessageBox.Show("Lütfen özel fiyat değeri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtOzelFiyat.Text, out double ozelFiyat))
            {
                MessageBox.Show("Geçerli bir fiyat değeri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgvUrunFiyatlari.Rows)
            {
                if (row.Cells["colSecim"].Value != null && (bool)row.Cells["colSecim"].Value)
                {
                    row.Cells["colSatisFiyati"].Value = ozelFiyat.ToString("F2");
                }
            }
        }

        private void BtnKaydet_Click(object? sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvUrunFiyatlari.Rows)
                {
                    if (row.Cells["colSecim"].Value != null && (bool)row.Cells["colSecim"].Value)
                    {
                        int productId = Convert.ToInt32(row.Cells["colId"].Value);
                        var product = _context.Products.Find(productId);

                        if (product != null)
                        {
                            if (decimal.TryParse(row.Cells["colAlisFiyati"].Value?.ToString(), out decimal newPurchasePrice))
                            {
                                product.PurchasePrice = newPurchasePrice;
                            }
                            if (decimal.TryParse(row.Cells["colSatisFiyati"].Value?.ToString(), out decimal newSalePrice))
                            {
                                product.SalePrice = newSalePrice;
                            }
                            product.UpdatedDate = DateTime.Now;
                        }
                    }
                }
                _context.SaveChanges();
                MessageBox.Show("Fiyat değişiklikleri başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fiyat değişiklikleri kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVazgec_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CmbUrunGrubu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FilterData();
        }

        private void TxtUrunAra_TextChanged(object? sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            string searchText = txtUrunAra.Text.ToUpper();
            string? selectedGroup = cmbUrunGrubu.SelectedItem?.ToString();

            foreach (DataGridViewRow row in dgvUrunFiyatlari.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = true;

                // Filter by search text
                if (!string.IsNullOrEmpty(searchText))
                {
                    string urunAdi = row.Cells["colUrunAdi"].Value?.ToString()?.ToUpper() ?? "";
                    string barkod = row.Cells["colBarkod"].Value?.ToString()?.ToUpper() ?? "";

                    if (!(urunAdi.Contains(searchText) || barkod.Contains(searchText)))
                    {
                        visible = false;
                    }
                }

                // Filter by product group
                if (visible && selectedGroup != "Tümü" && !string.IsNullOrEmpty(selectedGroup))
                {
                    string rowGroup = row.Cells["colUrunGrubu"].Value?.ToString() ?? "";
                    if (!rowGroup.ToUpper().Contains(selectedGroup.ToUpper()))
                    {
                        visible = false;
                    }
                }

                row.Visible = visible;
            }
        }
    }
}
