using StokTakip.Data;
using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class SatisIslemiForm : Form
    {
        private readonly StokTakipDbContext _context;

        public SatisIslemiForm(StokTakipDbContext context)
        {
            InitializeComponent();
            _context = context;

            // Event handler'ları bağla
            btnMusteriSec.Click += BtnMusteriSec_Click;
            btnEskiFisler.Click += BtnEskiFisler_Click;
        }

        private void BtnMusteriSec_Click(object? sender, EventArgs e)
        {
            MusteriBulForm musteriBulForm = new MusteriBulForm();
            if (musteriBulForm.ShowDialog() == DialogResult.OK)
            {
                // Seçilen müşteri bilgilerini kullan
                string selectedCustomer = musteriBulForm.SelectedCustomer;
                // Burada müşteri bilgilerini satış formuna aktarabilirsiniz
                MessageBox.Show($"Seçilen müşteri: {selectedCustomer}", "Müşteri Seçildi");
            }
        }

        private void BtnEskiFisler_Click(object? sender, EventArgs e)
        {
            using (var eskiFislerForm = new EskiFislerForm())
            {
                eskiFislerForm.ShowDialog();
            }
        }
    }
}
