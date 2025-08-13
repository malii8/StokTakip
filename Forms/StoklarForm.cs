using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using StokTakip.Models;
using System;
using System.Linq;
using System.Windows.Forms;

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
                        product.ProductGroup?.Name ?? "BELİRTİLMEDİ"
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
            // Calculate totals
            double totalPurchaseValue = 1908.00;
            double totalSalesValue = 2552.50;
            int totalProducts = 44;

            lblAlisFiyatiDegeri.Text = $"{totalPurchaseValue:F2} TL";
            lblSatisFiyatiDegeri.Text = $"{totalSalesValue:F2} TL";
            lblToplamStokAdedi.Text = totalProducts.ToString();
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
                        using (var editForm = _serviceProvider.GetRequiredService<UrunDuzenleForm>()) // Pass product to the form if needed
                        {
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
                    dgvUrunler.Rows.RemoveAt(dgvUrunler.SelectedRows[0].Index);
                    UpdateTotals();
                }
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
            var urunAyrintisiForm = _serviceProvider.GetRequiredService<UrunAyrintisiForm>();
            urunAyrintisiForm.ShowDialog();
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
            MessageBox.Show("Teraziye aktar işlemi");
        }

        private void BtnExcelKayitAl_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Excel'den kayıt al işlemi");
        }

        private void BtnExcelKayitVer_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Excel'e kayıt ver işlemi");
        }
    }
}
