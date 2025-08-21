using System;
using System.Windows.Forms;
using StokTakip.Data;
using Microsoft.Extensions.DependencyInjection;

namespace StokTakip.Forms
{
    public partial class FiyatGorForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public FiyatGorForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            btnUrunAdiIleAra.Click += new EventHandler(btnUrunAdiIleAra_Click);
            btnAra.Click += new EventHandler(btnAra_Click);
        }

        private void btnUrunAdiIleAra_Click(object? sender, EventArgs e)
        {
            var urunAramaForm = _serviceProvider.GetRequiredService<UrunAramaForm>();
            if (urunAramaForm.ShowDialog() == DialogResult.OK && urunAramaForm.SelectedProduct != null)
            {
                SetProductInfo(urunAramaForm.SelectedProduct);
            }
        }

        private void btnAra_Click(object? sender, EventArgs e)
        {
            string barkod = txtBarkodNo.Text.Trim();
            if (string.IsNullOrEmpty(barkod)) return;
            var product = _context.Products.FirstOrDefault(p => p.BarcodeNo == barkod);
            if (product != null)
            {
                SetProductInfo(product);
            }
            else
            {
                MessageBox.Show("Barkod ile ürün bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetProductInfo(StokTakip.Models.Product product)
        {
            lblUrunAdi.Text = product.Name;
            txtMevcutStok.Text = product.CurrentStock.ToString("N2");
            lblSatisFiyatiValue.Text = product.SalePrice.ToString("F2");
        }
    }
}
