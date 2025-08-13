using System;
using System.Data;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace StokTakip.Forms
{
    public partial class UrunAyrintisiForm : Form
    {
        private readonly StokTakipDbContext _context;
        private Product? _product;

        public UrunAyrintisiForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            SetupEventHandlers();
            InitializeDateRanges();
        }

        public void SetProduct(Product product)
        {
            _product = product;
            LoadProductDetails();
            LoadProductMovements();
        }

        private void InitializeDateRanges()
        {
            // Set default date range to current month
            dtpBaslangic.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpBitis.Value = DateTime.Now;
        }

        private void SetupEventHandlers()
        {
            btnYazdir.Click += BtnYazdir_Click;
            btnExcelAktar.Click += BtnExcelAktar_Click;
            rbSadeceAlislar.CheckedChanged += RaporTuru_CheckedChanged;
            rbSadeceSatislar.CheckedChanged += RaporTuru_CheckedChanged;
            rbSadeceIadeAlinanlar.CheckedChanged += RaporTuru_CheckedChanged;
            rbSadeceIadeEdilenler.CheckedChanged += RaporTuru_CheckedChanged;

            dtpBaslangic.ValueChanged += DateFilter_Changed;
            dtpBitis.ValueChanged += DateFilter_Changed;
        }

        private void LoadProductDetails()
        {
            if (_product == null) return;

            // Assuming these labels exist in the designer. If not, they need to be added.
            // lblUrunAdi.Text = _product.Name;
            // lblBarkodNo.Text = _product.BarcodeNo;
            // lblStokKodu.Text = _product.StockCode;
            // lblMevcutStok.Text = _product.CurrentStock.ToString("F1");
            // lblAsgariStok.Text = _product.MinimumStock.ToString("F1");
            // lblAlisFiyati.Text = _product.PurchasePrice.ToString("F2");
            // lblSatisFiyati.Text = _product.SalePrice.ToString("F2");
            // lblKdvOrani.Text = _product.VatRate.ToString("F0");
            // lblOlcuBirimi.Text = _product.Unit;
            // lblUrunGrubu.Text = _product.ProductGroup?.Name ?? "BELİRTİLMEDİ";
        }

        private void LoadProductMovements()
        {
            dgvHareketler.Rows.Clear();

            if (_product == null) return;

            try
            {
                var movements = _context.StockMovements
                    .Include(sm => sm.Wholesaler)
                    .Include(sm => sm.SalesReceipt)
                    .Where(sm => sm.ProductId == _product.Id &&
                                 sm.MovementDate >= dtpBaslangic.Value.Date &&
                                 sm.MovementDate <= dtpBitis.Value.Date)
                    .OrderByDescending(sm => sm.MovementDate)
                    .ToList();

                foreach (var movement in movements)
                {
                    string cariHesapAdi = "";
                    if (movement.MovementType == "Giriş" && movement.Wholesaler != null)
                    {
                        cariHesapAdi = movement.Wholesaler.Name;
                    }
                    else if (movement.MovementType == "Satış" && movement.SalesReceipt?.Customer != null)
                    {
                        cariHesapAdi = movement.SalesReceipt.Customer.Name;
                    }
                    else if (movement.MovementType == "Satış" && movement.SalesReceipt?.Customer == null)
                    {
                        cariHesapAdi = "Perakende";
                    }

                    dgvHareketler.Rows.Add(
                        movement.Id, // Sıra No
                        movement.MovementType, // Hareket Türü
                        cariHesapAdi, // Cari Hesap Adı
                        movement.MovementDate.ToShortDateString(), // Tarih
                        movement.MovementDate.ToShortTimeString(), // Saat
                        _product.Name, // Ürün Adı
                        movement.UnitPrice.ToString("F2"), // Alış Fiyatı (assuming UnitPrice is relevant)
                        movement.Total.ToString("F2"), // Satış Fiyatı (assuming Total is relevant)
                        movement.Quantity.ToString("F1"), // Miktar
                        _product.VatRate.ToString("F0"), // KDV
                        "Aktif", // Durum (placeholder)
                        movement.Total.ToString("F2") // Toplam Tutar
                    );
                }
                UpdateSummaryBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün hareketleri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DateFilter_Changed(object? sender, EventArgs e)
        {
            LoadProductMovements(); // Reload data when date range changes
        }

        private void UpdateSummaryBoxes()
        {
            // Calculate summary values based on current data
            double urunGirisiToplam = 0;
            double satislarToplam = 0;
            double iadeEdilenToplam = 0;
            double iadeAlinanToplam = 0;

            int urunGirisiAdet = 0;
            int satislarAdet = 0;
            int iadeEdilenAdet = 0;
            int iadeAlinanAdet = 0;

            foreach (DataGridViewRow row in dgvHareketler.Rows)
            {
                if (row.IsNewRow) continue;

                string hareketTuru = row.Cells["colHareketTuru"].Value?.ToString() ?? "";
                double tutar = double.TryParse(row.Cells["colToplamTutar"].Value?.ToString(), out double t) ? t : 0;
                int miktar = int.TryParse(row.Cells["colMiktar"].Value?.ToString(), out int m) ? m : 0;

                switch (hareketTuru.ToUpper())
                {
                    case "GİRİŞ":
                        urunGirisiToplam += tutar;
                        urunGirisiAdet += miktar;
                        break;
                    case "SATIŞ":
                        satislarToplam += tutar;
                        satislarAdet += miktar;
                        break;
                    case "İADE":
                        if (tutar > 0)
                        {
                            iadeAlinanToplam += tutar;
                            iadeAlinanAdet += miktar;
                        }
                        else
                        {
                            iadeEdilenToplam += Math.Abs(tutar);
                            iadeEdilenAdet += miktar;
                        }
                        break;
                }
            }

            // Update summary labels
            lblUrunGirisiTutar.Text = $"{urunGirisiToplam:F2} TL";
            lblUrunGirisiAdet.Text = urunGirisiAdet.ToString();

            lblSatislarTutar.Text = $"{satislarToplam:F2} TL";
            lblSatislarAdet.Text = satislarAdet.ToString();

            lblIadeEdilenTutar.Text = $"{iadeEdilenToplam:F2} TL";
            lblIadeEdilenAdet.Text = iadeEdilenAdet.ToString();

            lblIadeAlinanTutar.Text = $"{iadeAlinanToplam:F2} TL";
            lblIadeAlinanAdet.Text = iadeAlinanAdet.ToString();
        }

        private void RaporTuru_CheckedChanged(object? sender, EventArgs e)
        {
            FilterDataByReportType();
        }

        private void FilterDataByReportType()
        {
            foreach (DataGridViewRow row in dgvHareketler.Rows)
            {
                if (row.IsNewRow) continue;

                string hareketTuru = row.Cells["colHareketTuru"].Value?.ToString()?.ToUpper() ?? "";
                bool visible = true;

                if (rbSadeceAlislar.Checked && hareketTuru != "GİRİŞ")
                    visible = false;
                else if (rbSadeceSatislar.Checked && hareketTuru != "SATIŞ")
                    visible = false;
                else if (rbSadeceIadeAlinanlar.Checked && !(hareketTuru == "GİRİŞ" && (row.Cells["colCariHesapAdi"].Value?.ToString() ?? "").Contains("Müşteri İadesi")))
                    visible = false;
                else if (rbSadeceIadeEdilenler.Checked && !(hareketTuru == "ÇIKIŞ" && (row.Cells["colCariHesapAdi"].Value?.ToString() ?? "").Contains("Toptancı İadesi")))
                    visible = false;

                row.Visible = visible;
            }
            UpdateSummaryBoxes();
        }

        private void BtnYazdir_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Rapor yazdırılıyor...", "Yazdır", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExcelAktar_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Excel'e aktarılıyor...", "Excel Aktar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
