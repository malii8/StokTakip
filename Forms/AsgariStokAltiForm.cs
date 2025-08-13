using System;
using System.Data;
using System.Windows.Forms;
using StokTakip.Data;
using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class AsgariStokAltiForm : Form
    {
        private readonly StokTakipDbContext _context;

        public AsgariStokAltiForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            LoadProductGroups(); // Load groups first
            LoadLowStockProducts(); // Then load products
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            txtUrunAra.TextChanged += TxtUrunAra_TextChanged;
            cmbUrunGrubu.SelectedIndexChanged += CmbUrunGrubu_SelectedIndexChanged;
            btnYazdir.Click += BtnYazdir_Click;
            btnExcelAktar.Click += BtnExcelAktar_Click;
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

        private void LoadLowStockProducts()
        {
            dgvAsgariStokAlti.Rows.Clear();

            try
            {
                var lowStockProducts = _context.Products
                    .Include(p => p.ProductGroup)
                    .Where(p => p.CurrentStock <= p.MinimumStock && p.IsActive)
                    .ToList();

                foreach (var product in lowStockProducts)
                {
                    dgvAsgariStokAlti.Rows.Add(
                        product.BarcodeNo, // Barkod No
                        product.Name, // Ürünün Adı
                        product.MinimumStock.ToString("F1"), // Asgari Stok
                        product.CurrentStock.ToString("F1"), // Mevcut Stok
                        product.Unit, // Ölçü Birimi
                        product.PurchasePrice.ToString("F2"), // Alış Fiyatı
                        product.SalePrice.ToString("F2"), // Satış Fiyatı
                        product.ProductGroup?.Name ?? "BELİRTİLMEDİ"  // Ürün Grubu
                    );
                }

                UpdateRecordCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Asgari stok altındaki ürünler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRecordCount()
        {
            int visibleRowCount = 0;
            foreach (DataGridViewRow row in dgvAsgariStokAlti.Rows)
            {
                if (!row.IsNewRow && row.Visible)
                {
                    visibleRowCount++;
                }
            }
            lblListelenenKayitSayisi.Text = visibleRowCount.ToString();
        }

        private void BtnYenile_Click(object? sender, EventArgs e)
        {
            LoadLowStockProducts();
            txtUrunAra.Clear();
            cmbUrunGrubu.SelectedIndex = 0;
        }

        private void TxtUrunAra_TextChanged(object? sender, EventArgs e)
        {
            FilterData();
        }

        private void CmbUrunGrubu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            string searchText = txtUrunAra.Text.ToUpper();
            string? selectedGroup = cmbUrunGrubu.SelectedItem?.ToString();

            foreach (DataGridViewRow row in dgvAsgariStokAlti.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = true;

                // Filter by search text
                if (!string.IsNullOrEmpty(searchText))
                {
                    string barkod = row.Cells["colBarkodNo"].Value?.ToString()?.ToUpper() ?? "";
                    string urunAdi = row.Cells["colUrunAdi"].Value?.ToString()?.ToUpper() ?? "";
                    string urunGrubu = row.Cells["colUrunGrubu"].Value?.ToString()?.ToUpper() ?? "";

                    if (!(barkod.Contains(searchText) || urunAdi.Contains(searchText) || urunGrubu.Contains(searchText)))
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

            UpdateRecordCount();
        }

        private void BtnYazdir_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Asgari stok altındaki ürünler raporu yazdırılıyor...", "Yazdır",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExcelAktar_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Asgari stok altındaki ürünler Excel'e aktarılıyor...", "Excel Aktar",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
