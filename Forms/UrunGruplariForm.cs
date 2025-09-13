using System;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace StokTakip.Forms
{
    public partial class UrunGruplariForm : Form
    {
        private readonly StokTakipDbContext _context;

        public UrunGruplariForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            LoadProductGroups(); // Load data from DB
            LoadProducts(); // Load all products
            PopulateProductGroupComboBoxes(); // Populate comboboxes
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            btnSecilenUrunGrubunuSil.Click += BtnSecilenUrunGrubunuSil_Click;
            btnYeniUrunGrubuEkle.Click += BtnYeniUrunGrubuEkle_Click;
            txtUrunGrubuAdi.TextChanged += TxtUrunGrubuAdi_TextChanged;
            btnUrunGrubuDegisecekEkle.Click += BtnUrunGrubuDegisecekEkle_Click;
            btnUrunGrubuDegisecekTemizle.Click += BtnUrunGrubuDegisecekTemizle_Click;
            btnTablodakiUrunlerinGrubunuDegistir.Click += BtnTablodakiUrunlerinGrubunuDegistir_Click;
            txtUrunAdi.TextChanged += FilterProducts;
            cmbUrunGrubuFilter.SelectedIndexChanged += FilterProducts;
        }

        private void LoadProductGroups()
        {
            dgvUrunGruplari.Rows.Clear();
            try
            {
                var groups = _context.ProductGroups.OrderBy(g => g.Name).ToList();
                foreach (var group in groups)
                {
                    dgvUrunGruplari.Rows.Add(
                        group.Id,
                        group.Name
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün grupları yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            dgvUrunler.Rows.Clear();
            try
            {
                var products = _context.Products.Include(p => p.ProductGroup).OrderBy(p => p.Name).ToList();
                foreach (var product in products)
                {
                    dgvUrunler.Rows.Add(
                        product.BarcodeNo,
                        product.Name,
                        product.ProductGroup?.Name ?? "Belirtilmemiş"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürünler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateProductGroupComboBoxes()
        {
            var groups = _context.ProductGroups.OrderBy(g => g.Name).ToList();

            // Add "Tümü" option for filtering
            cmbUrunGrubuFilter.Items.Add("Tümü");
            foreach (var group in groups)
            {
                cmbUrunGrubuFilter.Items.Add(group.Name);
            }
            cmbUrunGrubuFilter.SelectedIndex = 0; // Select "Tümü" by default

            // Populate cmbYeniUrunGrubu
            cmbYeniUrunGrubu.DisplayMember = "Name";
            cmbYeniUrunGrubu.ValueMember = "Id";
            cmbYeniUrunGrubu.DataSource = groups;
        }

        private void TxtUrunGrubuAdi_TextChanged(object? sender, EventArgs e)
        {
            FilterGroups();
        }

        private void FilterGroups()
        {
            string searchText = txtUrunGrubuAdi.Text.ToLower();

            foreach (DataGridViewRow row in dgvUrunGruplari.Rows)
            {
                if (row.IsNewRow) continue;

                string groupName = row.Cells["colUrunGrubuAdi"].Value?.ToString()?.ToLower() ?? "";
                row.Visible = groupName.Contains(searchText);
            }
        }

        private void FilterProducts(object? sender, EventArgs e)
        {
            string urunAdiSearchText = txtUrunAdi.Text.ToLower();
            string selectedGroupFilter = cmbUrunGrubuFilter.SelectedItem?.ToString() ?? "Tümü";

            foreach (DataGridViewRow row in dgvUrunler.Rows)
            {
                if (row.IsNewRow) continue;

                string urunAdi = row.Cells["colUrunAdi"].Value?.ToString()?.ToLower() ?? "";
                string urunGrubu = row.Cells["colUrunGrubu"].Value?.ToString()?.ToLower() ?? "";

                bool matchesUrunAdi = string.IsNullOrEmpty(urunAdiSearchText) || urunAdi.Contains(urunAdiSearchText);
                bool matchesUrunGrubu = (selectedGroupFilter == "Tümü") || (urunGrubu == selectedGroupFilter.ToLower());

                row.Visible = matchesUrunAdi && matchesUrunGrubu;
            }
        }

        private void BtnSecilenUrunGrubunuSil_Click(object? sender, EventArgs e)
        {
            if (dgvUrunGruplari.SelectedRows.Count > 0)
            {
                // Corrected column name from "colId" to "colSiraNo"
                int groupId = Convert.ToInt32(dgvUrunGruplari.SelectedRows[0].Cells["colSiraNo"].Value);
                var groupToDelete = _context.ProductGroups.Find(groupId);

                if (groupToDelete != null)
                {
                    // Check if there are any products associated with this group
                    var associatedProducts = _context.Products.Where(p => p.ProductGroupId == groupId).ToList();
                    if (associatedProducts.Any())
                    {
                        var confirmResult = MessageBox.Show("Bu ürün grubuna bağlı ürünler bulunmaktadır. Bu grubu silerseniz, bağlı ürünlerin ürün grubu bilgisi kaldırılacaktır. Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirmResult == DialogResult.No)
                        {
                            return;
                        }

                        foreach (var product in associatedProducts)
                        {
                            product.ProductGroupId = null; // Set ProductGroupId to null
                        }
                    }

                    var result = MessageBox.Show($"Seçili ürün grubunu ({groupToDelete.Name}) silmek istediğinizden emin misiniz?",
                        "Grup Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            _context.ProductGroups.Remove(groupToDelete);
                            _context.SaveChanges();
                            LoadProductGroups(); // Refresh data
                            MessageBox.Show("Ürün grubu başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ürün grubu silinirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek grubu seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnYeniUrunGrubuEkle_Click(object? sender, EventArgs e)
        {
            string newGroupName = Microsoft.VisualBasic.Interaction.InputBox(
                "Yeni ürün grubu adını girin:",
                "Yeni Grup Ekle",
                "");

            if (!string.IsNullOrWhiteSpace(newGroupName))
            {
                try
                {
                    // Check if group already exists
                    if (_context.ProductGroups.Any(g => g.Name == newGroupName))
                    {
                        MessageBox.Show("Bu ürün grubu zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var newGroup = new ProductGroup
                    {
                        Name = newGroupName,
                        Description = $"{newGroupName} ürün grubu",
                        CreatedDate = DateTime.Now
                    };

                    _context.ProductGroups.Add(newGroup);
                    _context.SaveChanges();

                    LoadProductGroups(); // Refresh data
                    MessageBox.Show("Ürün grubu başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ürün grubu eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnUrunGrubuDegisecekEkle_Click(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dgvUrunler.SelectedRows)
            {
                string barkodNo = selectedRow.Cells["colBarkodNo"].Value?.ToString() ?? "";
                string urunAdi = selectedRow.Cells["colUrunAdi"].Value?.ToString() ?? "";

                bool alreadyAdded = false;
                foreach (DataGridViewRow row in dgvDegisecekUrunler.Rows)
                {
                    if (row.Cells["colDegisecekBarkodNo"].Value?.ToString() == barkodNo)
                    {
                        alreadyAdded = true;
                        break;
                    }
                }

                if (!alreadyAdded)
                {
                    dgvDegisecekUrunler.Rows.Add(barkodNo, urunAdi);
                }
            }
        }

        private void BtnUrunGrubuDegisecekTemizle_Click(object? sender, EventArgs e)
        {
            dgvDegisecekUrunler.Rows.Clear();
        }

        private void BtnTablodakiUrunlerinGrubunuDegistir_Click(object? sender, EventArgs e)
        {
            if (dgvDegisecekUrunler.Rows.Count == 0)
            {
                MessageBox.Show("Lütfen ürün grubu değiştirilecek ürünleri tabloya ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbYeniUrunGrubu.SelectedItem == null)
            {
                MessageBox.Show("Lütfen yeni bir ürün grubu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedNewGroup = (ProductGroup)cmbYeniUrunGrubu.SelectedItem;
            int newProductGroupId = selectedNewGroup.Id;
            string newProductGroupName = selectedNewGroup.Name;

            var result = MessageBox.Show($"{dgvDegisecekUrunler.Rows.Count} adet ürünün grubunu '{newProductGroupName}' olarak değiştirmek istediğinizden emin misiniz?",
                "Toplu Grup Değişikliği Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dgvDegisecekUrunler.Rows)
                    {
                        string barkodNo = row.Cells["colDegisecekBarkodNo"].Value?.ToString() ?? "";
                        var productToUpdate = _context.Products.FirstOrDefault(p => p.BarcodeNo == barkodNo);
                        if (productToUpdate != null)
                        {
                            productToUpdate.ProductGroupId = newProductGroupId;
                        }
                    }
                    _context.SaveChanges();

                    MessageBox.Show("Ürün grupları başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDegisecekUrunler.Rows.Clear();
                    LoadProducts(); // Refresh the main product list
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ürün grupları güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvUrunler_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvUrunler.Rows[e.RowIndex];
                string barkodNo = selectedRow.Cells["colBarkodNo"].Value?.ToString() ?? "";
                string urunAdi = selectedRow.Cells["colUrunAdi"].Value?.ToString() ?? "";

                // Check if the product is already in dgvDegisecekUrunler
                bool alreadyAdded = false;
                foreach (DataGridViewRow row in dgvDegisecekUrunler.Rows)
                {
                    if (row.Cells["colDegisecekBarkodNo"].Value?.ToString() == barkodNo)
                    {
                        alreadyAdded = true;
                        break;
                    }
                }

                if (!alreadyAdded)
                {
                    dgvDegisecekUrunler.Rows.Add(barkodNo, urunAdi);
                }
            }
        }
    }
}
