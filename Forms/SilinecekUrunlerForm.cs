using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StokTakip.Data;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class SilinecekUrunlerForm : Form
    {
        private readonly StokTakipDbContext _context;

        public SilinecekUrunlerForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            LoadProducts(); // Load data from DB
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            // Search functionality
            txtUrunAdi.TextChanged += TxtUrunAdi_TextChanged;

            // Button events
            btnSilineceklerTablosuna.Click += BtnSilineceklerTablosuna_Click;
            btnSilinecekleriTemizle.Click += BtnSilinecekleriTemizle_Click;
            btnTablodakiUrunleriSil.Click += BtnTablodakiUrunleriSil_Click;

            // Checkbox event
            chkSadeceStokMiktari.CheckedChanged += ChkSadeceStokMiktari_CheckedChanged;

            // Combo box event
            cmbUrunGrubu.SelectedIndexChanged += CmbUrunGrubu_SelectedIndexChanged;
        }

        private void LoadProducts()
        {
            dgvUrunler.Rows.Clear();
            try
            {
                var products = _context.Products.Where(p => p.IsActive).ToList();
                foreach (var product in products)
                {
                    dgvUrunler.Rows.Add(
                        product.BarcodeNo,
                        product.Name,
                        product.CurrentStock.ToString("F1"),
                        product.Id // Hidden ID for deletion
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürünler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxes()
        {
            cmbUrunGrubu.Items.Clear();
            cmbUrunGrubu.Items.Add("Tümü");
            var productGroups = _context.ProductGroups.Select(g => g.Name).ToList();
            foreach (var groupName in productGroups)
            {
                cmbUrunGrubu.Items.Add(groupName);
            }
            cmbUrunGrubu.SelectedIndex = 0; // Select "Tümü" by default
        }

        private void TxtUrunAdi_TextChanged(object? sender, EventArgs e)
        {
            FilterProducts();
        }

        private void CmbUrunGrubu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FilterProducts();
        }

        private void FilterProducts()
        {
            string searchText = txtUrunAdi.Text.ToLower();
            string selectedGroup = cmbUrunGrubu.SelectedItem?.ToString() ?? "Tümü";

            foreach (DataGridViewRow row in dgvUrunler.Rows)
            {
                if (row.IsNewRow) continue;

                string productName = row.Cells["colUrunAdi"].Value?.ToString()?.ToLower() ?? "";
                string barcodeNo = row.Cells["colBarkodNo"].Value?.ToString()?.ToLower() ?? "";
                string urunGrubu = _context.Products.Find(Convert.ToInt32(row.Cells["colId"].Value))?.ProductGroup?.Name?.ToLower() ?? "belirtilmedi";

                bool visible = (productName.Contains(searchText) || barcodeNo.Contains(searchText));

                // Apply product group filter
                if (selectedGroup != "Tümü" && urunGrubu != selectedGroup.ToLower())
                {
                    visible = false;
                }

                // Apply stock filter if checkbox is checked
                if (chkSadeceStokMiktari.Checked)
                {
                    decimal currentStock = decimal.TryParse(row.Cells["colMevcutStok"].Value?.ToString(), out decimal stock) ? stock : 0;
                    if (currentStock != 0)
                    {
                        visible = false;
                    }
                }
                row.Visible = visible;
            }
        }

        private void BtnSilineceklerTablosuna_Click(object? sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dgvUrunler.SelectedRows)
                {
                    string barcodeNo = selectedRow.Cells["colBarkodNo"].Value?.ToString() ?? "";
                    string urunAdi = selectedRow.Cells["colUrunAdi"].Value?.ToString() ?? "";
                    string mevcutStok = selectedRow.Cells["colMevcutStok"].Value?.ToString() ?? "";
                    int productId = Convert.ToInt32(selectedRow.Cells["colId"].Value);

                    // Check if already added to dgvSilinecekler
                    bool alreadyAdded = false;
                    foreach (DataGridViewRow row in dgvSilinecekler.Rows)
                    {
                        if (row.IsNewRow) continue;
                        if (Convert.ToInt32(row.Cells["colSilId"].Value) == productId)
                        {
                            alreadyAdded = true;
                            break;
                        }
                    }

                    if (!alreadyAdded)
                    {
                        dgvSilinecekler.Rows.Add(barcodeNo, urunAdi, productId);
                    }
                }
            }
        }

        private void BtnSilinecekleriTemizle_Click(object? sender, EventArgs e)
        {
            dgvSilinecekler.Rows.Clear();
        }

        private void BtnTablodakiUrunleriSil_Click(object? sender, EventArgs e)
        {
            if (dgvSilinecekler.Rows.Count == 0 || (dgvSilinecekler.Rows.Count == 1 && dgvSilinecekler.Rows[0].IsNewRow))
            {
                MessageBox.Show("Silinecek ürün bulunmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Silinecek listesindeki {dgvSilinecekler.Rows.Count - (dgvSilinecekler.AllowUserToAddRows ? 1 : 0)} ürünü silmek istediğinizden emin misiniz? (Ürünler veritabanından tamamen silinmeyecek, pasif hale getirilecektir.)",
                "Ürünleri Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dgvSilinecekler.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int productId = Convert.ToInt32(row.Cells["colSilId"].Value);
                        var productToMarkInactive = _context.Products.Find(productId);

                        if (productToMarkInactive != null)
                        {
                            productToMarkInactive.IsActive = false;
                            productToMarkInactive.UpdatedDate = DateTime.Now;
                        }
                    }
                    _context.SaveChanges();

                    MessageBox.Show("Seçilen ürünler başarıyla pasif hale getirildi.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts(); // Refresh the main product list
                    dgvSilinecekler.Rows.Clear(); // Clear the deletion list
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ürünler silinirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChkSadeceStokMiktari_CheckedChanged(object? sender, EventArgs e)
        {
            FilterProducts();
        }
    }
}
