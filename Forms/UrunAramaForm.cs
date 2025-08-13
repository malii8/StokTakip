using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class UrunAramaForm : Form
    {
        public Product? SelectedProduct { get; private set; }
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public UrunAramaForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            SetupForm();
            LoadProducts(); // Initial load
        }

        private void SetupForm()
        {
            // Event handlers
            txtArama.TextChanged += TxtArama_TextChanged;
            dataGridView1.CellDoubleClick += DgvUrunler_CellDoubleClick;

            // DataGridView ayarları
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            SetupDataGridViewColumns();
        }

        private void SetupDataGridViewColumns()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50,
                Visible = false
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colBarkod",
                DataPropertyName = "BarcodeNo",
                HeaderText = "Barkod No",
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUrunAdi",
                DataPropertyName = "Name",
                HeaderText = "Ürün Adı",
                Width = 200
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUrunKodu",
                DataPropertyName = "StockCode",
                HeaderText = "Ürün Kodu",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colGrup",
                DataPropertyName = "ProductGroupName",
                HeaderText = "Grup",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSatisFiyati",
                DataPropertyName = "SalePrice",
                HeaderText = "Satış Fiyatı",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStok",
                DataPropertyName = "CurrentStock",
                HeaderText = "Stok",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });
        }

        private void LoadProducts(string searchText = "")
        {
            try
            {
                var query = from p in _context.Products
                            where p.IsActive
                            select new
                            {
                                p.Id,
                                p.BarcodeNo,
                                p.Name,
                                p.StockCode,
                                ProductGroupName = p.ProductGroup != null ? p.ProductGroup.Name : "",
                                p.SalePrice,
                                p.CurrentStock
                            };

                if (!string.IsNullOrEmpty(searchText))
                {
                    query = query.Where(p =>
                        p.Name.Contains(searchText) ||
                        p.BarcodeNo.Contains(searchText) ||
                        p.StockCode.Contains(searchText));
                }

                var products = query.OrderBy(p => p.Name).ToList();
                dataGridView1.DataSource = products;

                // lblSonuc label'ı yoksa konsola yazdır veya title'a ekle
                this.Text = $"Ürün Arama - Toplam {products.Count} ürün bulundu";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürünler yüklenirken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtArama_TextChanged(object? sender, EventArgs e)
        {
            LoadProducts(txtArama.Text);
        }

        private void DgvUrunler_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["colId"].Value);
                SelectedProduct = _context.Products.Find(productId);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnDuzenle_Click(object? sender, EventArgs e)
        {
            OpenProductEdit();
        }

        private void OpenProductEdit()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["colId"].Value);
                    var product = _context.Products.FirstOrDefault(p => p.Id == productId);

                    if (product != null)
                    {
                        using (var editForm = _serviceProvider.GetRequiredService<UrunDuzenleForm>())
                        {
                            editForm.SetProduct(product); // Assuming SetProduct method exists in UrunDuzenleForm
                            if (editForm.ShowDialog() == DialogResult.OK)
                            {
                                LoadProducts(txtArama.Text);
                                MessageBox.Show("Ürün başarıyla güncellendi!", "Başarılı",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnKapat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
