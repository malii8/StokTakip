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
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            btnTopluUrunGrubuDegistir.Click += BtnTopluUrunGrubuDegistir_Click;
            btnSecilenUrunGrubunuSil.Click += BtnSecilenUrunGrubunuSil_Click;
            btnYeniUrunGrubuEkle.Click += BtnYeniUrunGrubuEkle_Click;
            txtUrunGrubuAdi.TextChanged += TxtUrunGrubuAdi_TextChanged;
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

        private void BtnTopluUrunGrubuDegistir_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Toplu ürün grubu değiştir işlemi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSecilenUrunGrubunuSil_Click(object? sender, EventArgs e)
        {
            if (dgvUrunGruplari.SelectedRows.Count > 0)
            {
                int groupId = Convert.ToInt32(dgvUrunGruplari.SelectedRows[0].Cells["colId"].Value);
                var groupToDelete = _context.ProductGroups.Find(groupId);

                if (groupToDelete != null)
                {
                    // Check if there are any products associated with this group
                    if (_context.Products.Any(p => p.ProductGroupId == groupId))
                    {
                        MessageBox.Show("Bu ürün grubuna bağlı ürünler bulunmaktadır. Lütfen önce ürünleri başka bir gruba taşıyın veya silin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
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
    }
}
