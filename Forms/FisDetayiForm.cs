using System;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.Forms
{
    public partial class FisDetayiForm : Form
    {
        private SalesReceipt? _salesReceipt;
        private readonly StokTakipDbContext _context;

        public FisDetayiForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void SetSalesReceipt(SalesReceipt salesReceipt)
        {
            _salesReceipt = salesReceipt;
            LoadFisData();
            LoadProductData();
        }

        private void LoadFisData()
        {
            if (_salesReceipt == null) return;

            lblFisNoValue.Text = _salesReceipt.ReceiptNumber;
            lblTarihValue.Text = $"{_salesReceipt.ReceiptDate.ToShortDateString()} {_salesReceipt.ReceiptDate.ToShortTimeString()}";
            lblOdemeTuruValue.Text = _salesReceipt.PaymentType;
            lblMusteriAdiValue.Text = string.IsNullOrEmpty(_salesReceipt.Customer?.Name) ? "Perakende Satış" : _salesReceipt.Customer.Name;
            lblToplamTutarValue.Text = $"{_salesReceipt.Total:F2} TL";
            lblDurumValue.Text = _salesReceipt.Status;

            // Set status color
            if (_salesReceipt.Status == "İptal")
            {
                lblDurumValue.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblDurumValue.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void LoadProductData()
        {
            dgvUrunler.Rows.Clear();

            if (_salesReceipt == null) return;

            try
            {
                var details = _context.SalesReceiptDetails
                    .Include(srd => srd.Product)
                    .Where(srd => srd.SalesReceiptId == _salesReceipt.Id)
                    .ToList();

                foreach (var detail in details)
                {
                    dgvUrunler.Rows.Add(
                        detail.Product?.BarcodeNo ?? "",
                        detail.Product?.Name ?? "",
                        detail.Quantity.ToString(),
                        detail.UnitPrice.ToString("F2"),
                        detail.Total.ToString("F2")
                    );
                }
                CalculateTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün detayları yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotals()
        {
            decimal araToplam = 0;
            int toplamUrun = 0;

            foreach (DataGridViewRow row in dgvUrunler.Rows)
            {
                if (row.IsNewRow) continue;

                if (int.TryParse(row.Cells["colMiktar"].Value?.ToString(), out int miktar))
                {
                    toplamUrun += miktar;
                }

                if (decimal.TryParse(row.Cells["colToplam"].Value?.ToString(), out decimal toplam))
                {
                    araToplam += toplam;
                }
            }

            decimal kdv = araToplam * 0.10m; // %10 KDV
            decimal genelToplam = araToplam + kdv;

            lblToplamUrunValue.Text = toplamUrun.ToString();
            lblAraToplamValue.Text = $"{araToplam:F2} TL";
            lblKdvValue.Text = $"{kdv:F2} TL";
            lblGenelToplamValue.Text = $"{genelToplam:F2} TL";
        }
    }
}
