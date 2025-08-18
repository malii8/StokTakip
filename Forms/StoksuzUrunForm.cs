using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class StoksuzUrunForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public decimal SalePrice { get; private set; }
        public decimal PurchasePrice { get; private set; }
        public string EnteredProductName { get; private set; }

        public StoksuzUrunForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _serviceProvider = serviceProvider;
            txtUrunAdi.Text = "STOKSUZ ÜRÜN";
            EnteredProductName = "STOKSUZ ÜRÜN"; // Initialize the property
            btnEkle.Click += BtnEkle_Click;
            btnVazgec.Click += BtnVazgec_Click;
        }

        private void BtnEkle_Click(object? sender, EventArgs e)
        {
            if (decimal.TryParse(txtSatisTutari.Text, out decimal salePrice) &&
                decimal.TryParse(txtAlisFiyati.Text, out decimal purchasePrice))
            {
                SalePrice = salePrice;
                PurchasePrice = purchasePrice;
                EnteredProductName = txtUrunAdi.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli satış ve alış fiyatları girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnVazgec_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
