using System;
using System.Data;
using System.Windows.Forms;
using StokTakip.Data;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace StokTakip.Forms
{
    public partial class RaporlarForm : Form
    {
        private readonly StokTakipDbContext _context;

        public RaporlarForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            InitializeDateRanges();
            InitializeComboBoxes();
            SetupEventHandlers();
            LoadReportData(); // Changed from LoadSampleData
        }

        private void InitializeDateRanges()
        {
            // Set default date range to current month
            dtpBaslangic.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpBitis.Value = DateTime.Now;
        }

        private void InitializeComboBoxes()
        {
            // İşlem Yapan dropdown - Gerçek kullanıcı isimlerini veritabanından al
            cmbIslemYapan.Items.Clear();
            cmbIslemYapan.Items.Add("Tümü");

            try
            {
                // Satış fişlerinden farklı kasiyer isimlerini al
                var cashierNames = _context.SalesReceipts
                    .Where(sr => !string.IsNullOrEmpty(sr.CashierName))
                    .Select(sr => sr.CashierName)
                    .Distinct()
                    .OrderBy(name => name)
                    .ToList();

                foreach (var cashierName in cashierNames)
                {
                    if (!cmbIslemYapan.Items.Contains(cashierName))
                        cmbIslemYapan.Items.Add(cashierName);
                }

                // Stok hareketlerinden farklı kullanıcı isimlerini al
                var userNames = _context.StockMovements
                    .Where(sm => !string.IsNullOrEmpty(sm.UserName))
                    .Select(sm => sm.UserName)
                    .Distinct()
                    .OrderBy(name => name)
                    .ToList();

                foreach (var userName in userNames)
                {
                    if (!cmbIslemYapan.Items.Contains(userName))
                        cmbIslemYapan.Items.Add(userName);
                }

                // Eğer hiç kullanıcı bulunamazsa varsayılan değerleri ekle
                if (cmbIslemYapan.Items.Count == 1) // Sadece "Tümü" varsa
                {
                    cmbIslemYapan.Items.Add("Bilal Üner");
                    cmbIslemYapan.Items.Add("Admin");
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda varsayılan değerleri ekle
                cmbIslemYapan.Items.Add("Bilal Üner");
                cmbIslemYapan.Items.Add("Admin");
                MessageBox.Show($"Kullanıcı isimleri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cmbIslemYapan.SelectedIndex = 0;

            // Ürün Grubu dropdown
            cmbUrunGrubu.Items.Clear();
            cmbUrunGrubu.Items.Add("Tümü");
            try
            {
                var groups = _context.ProductGroups.OrderBy(g => g.Name).ToList();
                foreach (var group in groups)
                {
                    cmbUrunGrubu.Items.Add(group.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün grupları yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmbUrunGrubu.SelectedIndex = 0;

            // Ürün Adı textbox'ı için placeholder text
            txtUrunAdi.Text = "";
            txtUrunAdi.PlaceholderText = "Ürün adı girin...";
        }

        private void SetupEventHandlers()
        {
            // Report type radio buttons
            rbTumu.CheckedChanged += RaporTuru_CheckedChanged;
            rbSadeceSatislar.CheckedChanged += RaporTuru_CheckedChanged;
            rbSadeceAlislar.CheckedChanged += RaporTuru_CheckedChanged;
            rbSadeceIadeAlinanlar.CheckedChanged += RaporTuru_CheckedChanged;
            rbSadeceIadeEdilenler.CheckedChanged += RaporTuru_CheckedChanged;

            // Payment method buttons
            btnAktifKaydi.Click += BtnAktifKaydi_Click;
            btnSayfayiYenile.Click += BtnSayfayiYenile_Click;
            btnBankaKarti.Click += BtnBankaKarti_Click;

            // Export buttons
            btnOzetRaporYazdir.Click += BtnOzetRaporYazdir_Click;
            btnExcelTekTekUrun.Click += BtnExcelTekTekUrun_Click;
            btnExcelBirlestirilmisKayit.Click += BtnExcelBirlestirilmisKayit_Click;

            // Date and combo change events
            dtpBaslangic.ValueChanged += FilterData;
            dtpBitis.ValueChanged += FilterData;
            cmbIslemYapan.SelectedIndexChanged += FilterData;
            cmbUrunGrubu.SelectedIndexChanged += FilterData;

            // Ürün adı filtreleme
            txtUrunAdi.TextChanged += FilterData;
        }

        private void LoadReportData()
        {
            dgvRaporlar.Rows.Clear();

            try
            {
                // 1. Load SalesReceipts (Satış işlemleri)
                var salesReceipts = _context.SalesReceipts
                    .Include(sr => sr.Customer)
                    .Include(sr => sr.Details)
                        .ThenInclude(srd => srd.Product)
                            .ThenInclude(p => p.ProductGroup)
                    .Where(sr => sr.ReceiptDate >= dtpBaslangic.Value.Date && sr.ReceiptDate <= dtpBitis.Value.Date)
                    .ToList();

                foreach (var receipt in salesReceipts)
                {
                    foreach (var detail in receipt.Details)
                    {
                        dgvRaporlar.Rows.Add(
                            receipt.Id, // S.No (0)
                            "Satış", // Hareket Türü (1)
                            receipt.ReceiptDate.ToShortDateString(), // Tarih (2)
                            receipt.ReceiptDate.ToShortTimeString(), // Saat (3)
                            detail.Product?.BarcodeNo ?? "", // Barkod No (4)
                            detail.Product?.Name ?? "", // Ürün Adı (5)
                            detail.Product?.PurchasePrice.ToString("F2") ?? "0.00", // Alış Fiyatı (6)
                            detail.UnitPrice.ToString("F2"), // Satış Fiyatı (7)
                            detail.Quantity, // Miktar (8)
                            (detail.Total - (detail.Quantity * (detail.Product?.PurchasePrice ?? 0))).ToString("F2"), // KAR (9) - resimde 56.00, 60.00
                            detail.VatRate.ToString("F0"), // KDV (10) - resimde 20, 18
                            "Aktif", // Durum (11) - resimde Aktif
                            detail.Total.ToString("F2"), // Toplam (12) - resimde 140.00, 160.00
                            "Bilal ÜNER", // Cari Hesap Adı (13) - resimde görünen
                            receipt.CashierName ?? "Admin" // İşlem Yapan (14) - resimde Admin
                        );
                    }
                }

                // 2. Load StockMovements (Stok Giriş işlemleri)
                var stockMovements = _context.StockMovements
                    .Include(sm => sm.Product)
                        .ThenInclude(p => p.ProductGroup)
                    .Include(sm => sm.Wholesaler)
                    .Where(sm => sm.MovementDate >= dtpBaslangic.Value.Date && sm.MovementDate <= dtpBitis.Value.Date)
                    .Where(sm => sm.MovementType == "Giriş")
                    .ToList();

                foreach (var movement in stockMovements)
                {
                    dgvRaporlar.Rows.Add(
                        movement.Id, // S.No (0)
                        "Giriş", // Hareket Türü (1)
                        movement.MovementDate.ToShortDateString(), // Tarih (2)
                        movement.MovementDate.ToShortTimeString(), // Saat (3)
                        movement.Product?.BarcodeNo ?? "", // Barkod No (4)
                        movement.Product?.Name ?? "", // Ürün Adı (5)
                        movement.UnitPrice.ToString("F2"), // Alış Fiyatı (6)
                        movement.Product?.SalePrice.ToString("F2") ?? "0.00", // Satış Fiyatı (7)
                        movement.Quantity, // Miktar (8)
                        "0.00", // KAR (9)
                        "0", // KDV (10)
                        "Aktif", // Durum (11)
                        (movement.Quantity * movement.UnitPrice).ToString("F2"), // Toplam (12)
                        movement.Wholesaler?.Name ?? "Tedarikçi", // Cari Hesap Adı (13)
                        movement.UserName ?? "Admin" // İşlem Yapan (14)
                    );
                }

                // 3. Load Return/Refund transactions (İade işlemleri)
                // Customer returns (Müşteriden iade alınanlar) - Status değeri ile tanımlanabilir
                var customerReturns = _context.SalesReceipts
                    .Include(sr => sr.Customer)
                    .Include(sr => sr.Details)
                        .ThenInclude(srd => srd.Product)
                    .Where(sr => sr.ReceiptDate >= dtpBaslangic.Value.Date && sr.ReceiptDate <= dtpBitis.Value.Date)
                    .Where(sr => sr.Status == "İade" || sr.Status == "Refund") // Status üzerinden iade kontrolü
                    .ToList();

                foreach (var returnReceipt in customerReturns)
                {
                    foreach (var detail in returnReceipt.Details)
                    {
                        dgvRaporlar.Rows.Add(
                            returnReceipt.Id, // S.No (0)
                            "İade Alınan", // Hareket Türü (1)
                            returnReceipt.ReceiptDate.ToShortDateString(), // Tarih (2)
                            returnReceipt.ReceiptDate.ToShortTimeString(), // Saat (3)
                            detail.Product?.BarcodeNo ?? "", // Barkod No (4)
                            detail.Product?.Name ?? "", // Ürün Adı (5)
                            detail.Product?.PurchasePrice.ToString("F2") ?? "0.00", // Alış Fiyatı (6)
                            detail.UnitPrice.ToString("F2"), // Satış Fiyatı (7)
                            detail.Quantity, // Miktar (8)
                            "0.00", // KAR (9)
                            detail.VatRate.ToString("F0"), // KDV (10)
                            "Pasif", // Durum (11)
                            detail.Total.ToString("F2"), // Toplam (12)
                            returnReceipt.Customer?.Name ?? "Müşteri", // Cari Hesap Adı (13)
                            returnReceipt.CashierName ?? "Admin" // İşlem Yapan (14)
                        );
                    }
                }

                // 4. Load Wholesaler returns (Toptancıya iade edilenler)
                var wholesalerReturns = _context.StockMovements
                    .Include(sm => sm.Product)
                    .Include(sm => sm.Wholesaler)
                    .Where(sm => sm.MovementDate >= dtpBaslangic.Value.Date && sm.MovementDate <= dtpBitis.Value.Date)
                    .Where(sm => sm.MovementType == "İade")
                    .ToList();

                foreach (var returnMovement in wholesalerReturns)
                {
                    dgvRaporlar.Rows.Add(
                        returnMovement.Id, // S.No (0)
                        "İade Edilen", // Hareket Türü (1)
                        returnMovement.MovementDate.ToShortDateString(), // Tarih (2)
                        returnMovement.MovementDate.ToShortTimeString(), // Saat (3)
                        returnMovement.Product?.BarcodeNo ?? "", // Barkod No (4)
                        returnMovement.Product?.Name ?? "", // Ürün Adı (5)
                        returnMovement.UnitPrice.ToString("F2"), // Alış Fiyatı (6)
                        returnMovement.Product?.SalePrice.ToString("F2") ?? "0.00", // Satış Fiyatı (7)
                        returnMovement.Quantity, // Miktar (8)
                        "0.00", // KAR (9)
                        "0", // KDV (10)
                        "Pasif", // Durum (11)
                        (returnMovement.Quantity * returnMovement.UnitPrice).ToString("F2"), // Toplam (12)
                        returnMovement.Wholesaler?.Name ?? "Toptancı", // Cari Hesap Adı (13)
                        returnMovement.UserName ?? "Admin" // İşlem Yapan (14)
                    );
                }

                UpdateSummaryLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rapor verileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSummaryLabels()
        {
            // Calculate all summary values based on visible rows
            double veresiyeSatis = 0, nakitSatis = 0, havaleIleSatis = 0, krediKartiSatis = 0;
            double nakitKrediKartiSatis = 0, taksitliSatis = 0, taksitliSatisPesinati = 0;
            double satislaranEdilenKar = 0, toplamKdv = 0, musteriOdememesiNakit = 0;
            double musteriOdememesiKKarti = 0, musteriOdememesiHavale = 0;
            double toptancijaOdemeNakit = 0, toptancijaOdemeKKarti = 0, toptancijaOdemeHavale = 0;
            double toptancijaOdemeBorclar = 0, urunGirisiNakit = 0, urunGirisiKrediKarti = 0;
            double urunGirisiHavale = 0, urunGirisiToptanciyaBorc = 0;
            double iadeEdilenNakitOdendi = 0, iadeEdilenBorctanDusuldu = 0;
            double iadeAlinanNakitOdendi = 0, iadeAlinanBorctanDusuldu = 0, iadeAlinanKrediKarti = 0;

            int urunAdetSayisi = 0, satisFisiSayisi = 0;

            foreach (DataGridViewRow row in dgvRaporlar.Rows)
            {
                if (row.IsNewRow || !row.Visible) continue;

                // Resme göre DOĞRU sütun sıralaması:
                // 0:S.No, 1:Hareket Türü, 2:Tarih, 3:Saat, 4:Barkod No, 5:Ürün Adı
                // 6:Alış Fiyatı, 7:Satış Fiyatı, 8:Miktar, 9:KAR, 10:KDV, 11:Durum, 12:Toplam, 13:Cari Hesap Adı, 14:İşlem Yapan

                string hareketTuru = "";
                if (row.Cells.Count > 1 && row.Cells[1].Value != null)
                    hareketTuru = row.Cells[1].Value.ToString() ?? "";

                double tutar = 0;
                if (row.Cells.Count > 12 && row.Cells[12].Value != null) // Toplam sütunu (indeks 12)
                    double.TryParse(row.Cells[12].Value.ToString()?.Replace(",", "."), out tutar);

                int miktar = 0;
                if (row.Cells.Count > 8 && row.Cells[8].Value != null) // Miktar sütunu (indeks 8)
                {
                    string miktarStr = row.Cells[8].Value.ToString()?.Replace(",", ".") ?? "";
                    if (double.TryParse(miktarStr, out double miktarDouble))
                    {
                        miktar = (int)Math.Round(miktarDouble);
                    }
                }

                double kar = 0;
                if (row.Cells.Count > 9 && row.Cells[9].Value != null) // KAR sütunu (indeks 9)
                    double.TryParse(row.Cells[9].Value.ToString()?.Replace(",", "."), out kar);

                double kdv = 0;
                if (row.Cells.Count > 10 && row.Cells[10].Value != null) // KDV sütunu (indeks 10)
                    double.TryParse(row.Cells[10].Value.ToString()?.Replace(",", "."), out kdv);

                string durum = "";
                if (row.Cells.Count > 11 && row.Cells[11].Value != null) // Durum sütunu (indeks 11)
                    durum = row.Cells[11].Value.ToString() ?? "";

                urunAdetSayisi += miktar;
                satislaranEdilenKar += kar;
                toplamKdv += kdv;

                // Hareket türüne göre dağılım
                switch (hareketTuru.ToLower())
                {
                    case "satış":
                        if (durum == "Aktif")
                        {
                            nakitSatis += tutar;
                            satisFisiSayisi++;
                        }
                        break;
                    case "giriş":
                        if (durum == "Aktif")
                        {
                            urunGirisiNakit += tutar;
                        }
                        break;
                    case "iade alınan":
                        if (durum == "Pasif")
                        {
                            iadeAlinanNakitOdendi += tutar;
                        }
                        break;
                    case "iade edilen":
                        if (durum == "Pasif")
                        {
                            iadeEdilenNakitOdendi += tutar;
                        }
                        break;
                }
            }

            // Sağ taraftaki tüm özet etiketlerini güncelle
            try
            {
                if (lblVeresiyeSatis != null) lblVeresiyeSatis.Text = $"{veresiyeSatis:F2} TL";
                if (lblNakitSatis != null) lblNakitSatis.Text = $"{nakitSatis:F2} TL";
                if (lblHavaleIleSatis != null) lblHavaleIleSatis.Text = $"{havaleIleSatis:F2} TL";
                if (lblKrediKartiSatis != null) lblKrediKartiSatis.Text = $"{krediKartiSatis:F2} TL";
                if (lblNakitKrediKartiSatis != null) lblNakitKrediKartiSatis.Text = $"{nakitKrediKartiSatis:F2} TL";
                if (lblTaksitliSatis != null) lblTaksitliSatis.Text = $"{taksitliSatis:F2} TL";
                if (lblTaksitliSatisPesinati != null) lblTaksitliSatisPesinati.Text = $"{taksitliSatisPesinati:F2} TL";
                if (lblSatislaranEdilenKar != null) lblSatislaranEdilenKar.Text = $"{satislaranEdilenKar:F2} TL";
                if (lblToplamKdv != null) lblToplamKdv.Text = $"{toplamKdv:F2} TL";
                if (lblMusteriOdememesiNakit != null) lblMusteriOdememesiNakit.Text = $"{musteriOdememesiNakit:F2} TL";
                if (lblMusteriOdememesiKKarti != null) lblMusteriOdememesiKKarti.Text = $"{musteriOdememesiKKarti:F2} TL";
                if (lblMusteriOdememesiHavale != null) lblMusteriOdememesiHavale.Text = $"{musteriOdememesiHavale:F2} TL";
                if (lblToptancijaOdemeNakit != null) lblToptancijaOdemeNakit.Text = $"{toptancijaOdemeNakit:F2} TL";
                if (lblToptancijaOdemeKKarti != null) lblToptancijaOdemeKKarti.Text = $"{toptancijaOdemeKKarti:F2} TL";
                if (lblToptancijaOdemeHavale != null) lblToptancijaOdemeHavale.Text = $"{toptancijaOdemeHavale:F2} TL";
                if (lblToptancijaOdemeBorclar != null) lblToptancijaOdemeBorclar.Text = $"{toptancijaOdemeBorclar:F2} TL";
                if (lblUrunGirisiNakit != null) lblUrunGirisiNakit.Text = $"{urunGirisiNakit:F2} TL";
                if (lblUrunGirisiKrediKarti != null) lblUrunGirisiKrediKarti.Text = $"{urunGirisiKrediKarti:F2} TL";
                if (lblUrunGirisiHavale != null) lblUrunGirisiHavale.Text = $"{urunGirisiHavale:F2} TL";
                if (lblUrunGirisiToptanciyaBorc != null) lblUrunGirisiToptanciyaBorc.Text = $"{urunGirisiToptanciyaBorc:F2} TL";
                if (lblIadeEdilenNakitOdendi != null) lblIadeEdilenNakitOdendi.Text = $"{iadeEdilenNakitOdendi:F2} TL";
                if (lblIadeEdilenBorctanDusuldu != null) lblIadeEdilenBorctanDusuldu.Text = $"{iadeEdilenBorctanDusuldu:F2} TL";
                if (lblIadeAlinanNakitOdendi != null) lblIadeAlinanNakitOdendi.Text = $"{iadeAlinanNakitOdendi:F2} TL";
                if (lblIadeAlinanBorctanDusuldu != null) lblIadeAlinanBorctanDusuldu.Text = $"{iadeAlinanBorctanDusuldu:F2} TL";
                if (lblIadeAlinanKrediKarti != null) lblIadeAlinanKrediKarti.Text = $"{iadeAlinanKrediKarti:F2} TL";

                if (lblUrunAdetSayisi != null) lblUrunAdetSayisi.Text = urunAdetSayisi.ToString();
                if (lblSatisFisiSayisi != null) lblSatisFisiSayisi.Text = satisFisiSayisi.ToString();
            }
            catch (Exception ex)
            {
                // Hata durumunda sessizce devam et
                System.Diagnostics.Debug.WriteLine($"UpdateSummaryLabels hatası: {ex.Message}");
            }
        }

        private void RaporTuru_CheckedChanged(object? sender, EventArgs e)
        {
            FilterData(sender, e);
        }

        private void FilterData(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRaporlar.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = true;

                // Filter by report type
                if (!rbTumu.Checked)
                {
                    string hareketTuru = "";
                    if (row.Cells.Count > 1 && row.Cells[1].Value != null)
                        hareketTuru = row.Cells[1].Value.ToString() ?? "";

                    if (rbSadeceSatislar.Checked && hareketTuru != "Satış")
                        visible = false;
                    else if (rbSadeceAlislar.Checked && hareketTuru != "Giriş")
                        visible = false;
                    else if (rbSadeceIadeAlinanlar.Checked && hareketTuru != "İade Alınan")
                        visible = false;
                    else if (rbSadeceIadeEdilenler.Checked && hareketTuru != "İade Edilen")
                        visible = false;
                }

                // Filter by date range
                if (row.Cells.Count > 2 && row.Cells[2].Value != null)
                {
                    if (DateTime.TryParse(row.Cells[2].Value.ToString(), out DateTime rowDate))
                    {
                        if (rowDate < dtpBaslangic.Value.Date || rowDate > dtpBitis.Value.Date)
                            visible = false;
                    }
                }

                // Filter by işlem yapan
                if (cmbIslemYapan.SelectedItem?.ToString() != "Tümü")
                {
                    string islemYapan = "";
                    if (row.Cells.Count > 14 && row.Cells[14].Value != null) // İşlem Yapan sütunu (indeks 14)
                        islemYapan = row.Cells[14].Value.ToString() ?? "";

                    if (islemYapan != cmbIslemYapan.SelectedItem?.ToString())
                        visible = false;
                }

                // Filter by ürün grubu
                if (cmbUrunGrubu.SelectedItem?.ToString() != "Tümü" && !string.IsNullOrEmpty(cmbUrunGrubu.SelectedItem?.ToString()))
                {
                    // Ürün grubunu kontrol et - bu bilgi Load metodunda ürün detaylarıyla birlikte gelir
                    // Şimdilik basit bir kontrol yapalım
                    bool hasMatchingGroup = false;

                    // DataGridView'da ürün grubu bilgisi yoksa, veritabanından kontrol edelim
                    try
                    {
                        string urunAdi = "";
                        if (row.Cells.Count > 5 && row.Cells[5].Value != null) // Ürün Adı sütunu
                            urunAdi = row.Cells[5].Value.ToString() ?? "";

                        if (!string.IsNullOrEmpty(urunAdi))
                        {
                            var product = _context.Products.Include(p => p.ProductGroup)
                                .FirstOrDefault(p => p.Name == urunAdi);

                            if (product?.ProductGroup?.Name == cmbUrunGrubu.SelectedItem?.ToString())
                                hasMatchingGroup = true;
                        }
                    }
                    catch
                    {
                        // Hata durumunda tüm ürünleri göster
                        hasMatchingGroup = true;
                    }

                    if (!hasMatchingGroup)
                        visible = false;
                }

                // Filter by ürün adı
                if (!string.IsNullOrEmpty(txtUrunAdi.Text))
                {
                    string urunAdi = "";
                    if (row.Cells.Count > 5 && row.Cells[5].Value != null) // Ürün Adı sütunu
                        urunAdi = row.Cells[5].Value.ToString() ?? "";

                    if (!urunAdi.ToLower().Contains(txtUrunAdi.Text.ToLower()))
                        visible = false;
                }

                row.Visible = visible;
            }

            UpdateSummaryLabels();
        }

        private void BtnAktifKaydi_Click(object? sender, EventArgs e)
        {
            try
            {
                // Seçili satırı sil
                if (dgvRaporlar.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Seçili kaydı silmek istediğinizden emin misiniz?",
                                                "Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Burada gerçek veritabanı silme işlemi yapılabilir
                        foreach (DataGridViewRow row in dgvRaporlar.SelectedRows)
                        {
                            if (!row.IsNewRow)
                            {
                                dgvRaporlar.Rows.Remove(row);
                            }
                        }
                        UpdateSummaryLabels();
                        MessageBox.Show("Seçili kayıtlar başarıyla silindi.", "Başarılı",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kaydı seçin.", "Uyarı",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt silme işleminde hata oluştu: {ex.Message}", "Hata",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSayfayiYenile_Click(object? sender, EventArgs e)
        {
            try
            {
                // Sayfayı yenile ve verileri tekrar yükle
                LoadReportData();
                UpdateSummaryLabels();

                // Filtreleri uygula
                FilterData(sender, e);

                MessageBox.Show("Sayfa başarıyla yenilendi.", "Bilgi",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sayfa yenileme işleminde hata oluştu: {ex.Message}", "Hata",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBankaKarti_Click(object? sender, EventArgs e)
        {
            try
            {
                // Kredi kartı hesaplamaları yap
                decimal toplamKrediKarti = 0;
                int krediKartiIslemSayisi = 0;

                foreach (DataGridViewRow row in dgvRaporlar.Rows)
                {
                    if (row.IsNewRow || !row.Visible) continue;

                    // Ödeme yöntemi kontrolü (varsayılan olarak tüm satırları kredi kartı olarak say)
                    if (row.Cells.Count > 8) // Miktar sütunu
                    {
                        if (decimal.TryParse(row.Cells[8].Value?.ToString(), out decimal miktar))
                        {
                            if (decimal.TryParse(row.Cells[7].Value?.ToString(), out decimal satisFiyati)) // Satış fiyatı
                            {
                                toplamKrediKarti += miktar * satisFiyati;
                                krediKartiIslemSayisi++;
                            }
                        }
                    }
                }

                string mesaj = $"Kredi Kartı Hesaplama Sonuçları:\n\n" +
                              $"Toplam İşlem Sayısı: {krediKartiIslemSayisi}\n" +
                              $"Toplam Tutar: {toplamKrediKarti:F2} TL\n" +
                              $"Ortalama İşlem Tutarı: {(krediKartiIslemSayisi > 0 ? toplamKrediKarti / krediKartiIslemSayisi : 0):F2} TL";

                MessageBox.Show(mesaj, "Kredi Kartı Hesaplama",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kredi kartı hesaplama işleminde hata oluştu: {ex.Message}", "Hata",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPaymentMethod_Click(object? sender, EventArgs e)
        {
            Button? btn = sender as Button;
            MessageBox.Show($"{btn?.Text} işlemi gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOzetRaporYazdir_Click(object? sender, EventArgs e)
        {
            try
            {
                // Özet raporu oluştur ve göster
                CreateSummaryReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Özet rapor oluşturulurken hata oluştu: {ex.Message}", "Hata",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateSummaryReport()
        {
            // Yeni form oluştur
            var reportForm = new Form
            {
                Text = "Özet Rapor",
                Size = new Size(800, 600),
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.White
            };

            // TextBox oluştur
            var txtReport = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Fill,
                Font = new Font("Courier New", 10),
                ScrollBars = ScrollBars.Both,
                BackColor = Color.White
            };

            // Rapor içeriğini oluştur
            var reportContent = GenerateReportContent();
            txtReport.Text = reportContent;

            // Yazdır butonu
            var btnPrint = new Button
            {
                Text = "Yazdır",
                Size = new Size(100, 30),
                Location = new Point(10, 10),
                BackColor = Color.LightBlue
            };

            btnPrint.Click += (s, e) =>
            {
                try
                {
                    // Basit yazdırma işlemi
                    var printDialog = new System.Windows.Forms.PrintDialog();
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Rapor yazıcıya gönderildi.", "Yazdır",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Yazdırma hatası: {ex.Message}", "Hata",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // Kaydet butonu
            var btnSave = new Button
            {
                Text = "Kaydet",
                Size = new Size(100, 30),
                Location = new Point(120, 10),
                BackColor = Color.LightGreen
            };

            btnSave.Click += (s, e) =>
            {
                SaveReportToFile(reportContent);
            };

            // Panel oluştur (butonlar için)
            var pnlButtons = new Panel
            {
                Height = 50,
                Dock = DockStyle.Top,
                BackColor = Color.LightGray
            };

            pnlButtons.Controls.Add(btnPrint);
            pnlButtons.Controls.Add(btnSave);

            // TextBox'ı altta yerleştir
            var pnlContent = new Panel
            {
                Dock = DockStyle.Fill
            };
            pnlContent.Controls.Add(txtReport);

            reportForm.Controls.Add(pnlContent);
            reportForm.Controls.Add(pnlButtons);

            reportForm.ShowDialog();
        }

        private string GenerateReportContent()
        {
            var sb = new StringBuilder();

            // Başlık
            sb.AppendLine("XXXX Market");
            sb.AppendLine("XXXX Mahallesi XXXX Sokak No:1");
            sb.AppendLine("Lev İş Merkezi");
            sb.AppendLine();
            sb.AppendLine($"Tarikh: {DateTime.Now:dd.MM.yyyy}");
            sb.AppendLine();
            sb.AppendLine("TÜM KULLANICILAR");
            sb.AppendLine();

            // Satış toplamları hesapla
            decimal satisToplami = 0, urunGirisiToplami = 0, iadeEdilenToplami = 0, iadeAlinanToplami = 0;
            decimal musteriOdemesi = 0, toptanciyaOdeme = 0;
            decimal nakitSatis = 0, krediKarti = 0, veresiyeSatis = 0, havaleIleSatis = 0;

            foreach (DataGridViewRow row in dgvRaporlar.Rows)
            {
                if (row.IsNewRow || !row.Visible) continue;

                string hareketTuru = "";
                if (row.Cells.Count > 1 && row.Cells[1].Value != null)
                    hareketTuru = row.Cells[1].Value.ToString() ?? "";

                decimal tutar = 0;
                if (row.Cells.Count > 10 && row.Cells[10].Value != null) // Toplam sütunu
                    decimal.TryParse(row.Cells[10].Value.ToString()?.Replace(",", "."), out tutar);

                switch (hareketTuru.ToLower())
                {
                    case "satış":
                        satisToplami += tutar;
                        nakitSatis += tutar; // Basitleştirilmiş
                        break;
                    case "giriş":
                        urunGirisiToplami += tutar;
                        break;
                    case "iade":
                        iadeAlinanToplami += tutar;
                        break;
                }
            }

            // TÜM KULLANICILAR bölümü
            sb.AppendLine($"Satış Toplamı                {satisToplami:F2}");
            sb.AppendLine($"Ürün Girişi Toplamı          {urunGirisiToplami:F2}");
            sb.AppendLine($"İade Edilen Toplamı          {iadeEdilenToplami:F2}");
            sb.AppendLine($"İade Alınan Toplamı          {iadeAlinanToplami:F2}");
            sb.AppendLine();
            sb.AppendLine($"Müşteri Ödemesi              {musteriOdemesi:F2}");
            sb.AppendLine($"Toptancıya Ödeme             {toptanciyaOdeme:F2}");
            sb.AppendLine();
            sb.AppendLine($"Nakit Satış                  {nakitSatis:F2}");
            sb.AppendLine($"Kredi Kartı                  {krediKarti:F2}");
            sb.AppendLine($"Veresiye Satış               {veresiyeSatis:F2}");
            sb.AppendLine($"Havale ile Satış             {havaleIleSatis:F2}");
            sb.AppendLine($"TOPLAM SATIŞ                 {satisToplami:F2}");
            sb.AppendLine();
            sb.AppendLine();

            // BİLAL bölümü (seçili kullanıcıya göre)
            string secilenKullanici = cmbIslemYapan.SelectedItem?.ToString() ?? "Admin";
            sb.AppendLine($"{secilenKullanici.ToUpper()}");
            sb.AppendLine();

            // Seçili kullanıcıya özel hesaplamalar
            decimal kullaniciSatisToplami = 0, kullaniciUrunGirisi = 0, kullaniciIadeEdilen = 0, kullaniciIadeAlinan = 0;
            decimal kullaniciMusteriOdemesi = 0, kullaniciToptanciyaOdeme = 0;
            decimal kullaniciNakitSatis = 0, kullaniciKrediKarti = 0, kullaniciVeresiye = 0, kullaniciHavale = 0;

            foreach (DataGridViewRow row in dgvRaporlar.Rows)
            {
                if (row.IsNewRow || !row.Visible) continue;

                string islemYapan = "";
                if (row.Cells.Count > 12 && row.Cells[12].Value != null) // İşlem Yapan sütunu
                    islemYapan = row.Cells[12].Value.ToString() ?? "";

                if (secilenKullanici == "Tümü" || islemYapan == secilenKullanici)
                {
                    string hareketTuru = "";
                    if (row.Cells.Count > 1 && row.Cells[1].Value != null)
                        hareketTuru = row.Cells[1].Value.ToString() ?? "";

                    decimal tutar = 0;
                    if (row.Cells.Count > 10 && row.Cells[10].Value != null)
                        decimal.TryParse(row.Cells[10].Value.ToString()?.Replace(",", "."), out tutar);

                    switch (hareketTuru.ToLower())
                    {
                        case "satış":
                            kullaniciSatisToplami += tutar;
                            kullaniciNakitSatis += tutar;
                            break;
                        case "giriş":
                            kullaniciUrunGirisi += tutar;
                            break;
                        case "iade":
                            kullaniciIadeAlinan += tutar;
                            break;
                    }
                }
            }

            sb.AppendLine($"Satış Toplamı                {kullaniciSatisToplami:F2}");
            sb.AppendLine($"Ürün Girişi Toplamı          {kullaniciUrunGirisi:F2}");
            sb.AppendLine($"İade Edilen Toplamı          {kullaniciIadeEdilen:F2}");
            sb.AppendLine($"İade Alınan Toplamı          {kullaniciIadeAlinan:F2}");
            sb.AppendLine();
            sb.AppendLine($"Müşteri Ödemesi              {kullaniciMusteriOdemesi:F2}");
            sb.AppendLine($"Toptancıya Ödeme             {kullaniciToptanciyaOdeme:F2}");
            sb.AppendLine();
            sb.AppendLine($"Nakit Satış                  {kullaniciNakitSatis:F2}");
            sb.AppendLine($"Kredi Kartı                  {kullaniciKrediKarti:F2}");
            sb.AppendLine($"Veresiye Satış               {kullaniciVeresiye:F2}");
            sb.AppendLine($"Havale ile Satış             {kullaniciHavale:F2}");
            sb.AppendLine($"TOPLAM SATIŞ                 {kullaniciSatisToplami:F2}");
            sb.AppendLine();
            sb.AppendLine();

            // İŞLETME SAHİBİ bölümü
            sb.AppendLine("İŞLETME SAHİBİ");
            sb.AppendLine();
            sb.AppendLine($"Satış Toplamı                {satisToplami:F2}");
            sb.AppendLine($"Ürün Girişi Toplamı          {urunGirisiToplami:F2}");
            sb.AppendLine($"İade Edilen Toplamı          {iadeEdilenToplami:F2}");
            sb.AppendLine($"İade Alınan Toplamı          {iadeAlinanToplami:F2}");
            sb.AppendLine();
            sb.AppendLine($"Müşteri Ödemesi              {musteriOdemesi:F2}");
            sb.AppendLine($"Toptancıya Ödeme             {toptanciyaOdeme:F2}");
            sb.AppendLine();
            sb.AppendLine($"Nakit Satış                  {nakitSatis:F2}");
            sb.AppendLine($"Kredi Kartı                  {krediKarti:F2}");
            sb.AppendLine($"Veresiye Satış               {veresiyeSatis:F2}");
            sb.AppendLine($"Havale ile Satış             {havaleIleSatis:F2}");
            sb.AppendLine($"TOPLAM SATIŞ                 {satisToplami:F2}");

            return sb.ToString();
        }

        private void SaveReportToFile(string content)
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
                    saveFileDialog.Title = "Özet Raporu Kaydet";
                    saveFileDialog.FileName = $"OzetRapor_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, content, Encoding.UTF8);
                        MessageBox.Show($"Rapor başarıyla kaydedildi:\n{saveFileDialog.FileName}",
                                      "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Dosyayı açmak isteyip istemediğini sor
                        if (MessageBox.Show("Kaydedilen dosyayı açmak ister misiniz?", "Dosyayı Aç",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = saveFileDialog.FileName,
                                UseShellExecute = true
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dosya kaydetme hatası: {ex.Message}", "Hata",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcelTekTekUrun_Click(object? sender, EventArgs e)
        {
            try
            {
                ExportToCSV("TekTekUrun");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dosya kaydetme işleminde hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcelBirlestirilmisKayit_Click(object? sender, EventArgs e)
        {
            try
            {
                ExportToCSV("BirlestirilmisKayit");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dosya kaydetme işleminde hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToCSV(string reportType)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Dosyaları (*.csv)|*.csv|Excel Dosyaları (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Rapor Verilerini Kaydet";
                saveFileDialog.FileName = $"SatisRaporu_{reportType}_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (reportType == "TekTekUrun")
                    {
                        ExportDetailedReportToCSV(saveFileDialog.FileName);
                    }
                    else
                    {
                        ExportSummaryReportToCSV(saveFileDialog.FileName);
                    }

                    MessageBox.Show($"Rapor başarıyla kaydedildi:\n{saveFileDialog.FileName}",
                                  "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Dosyayı açmak isteyip istemediğini sor
                    if (MessageBox.Show("Kaydedilen dosyayı açmak ister misiniz?", "Dosyayı Aç",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            UseShellExecute = true
                        });
                    }
                }
            }
        }

        private void ExportDetailedReportToCSV(string filePath)
        {
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Title
                writer.WriteLine("DETAYLI SATIŞ RAPORU");
                writer.WriteLine($"Tarih Aralığı: {dtpBaslangic.Value:dd.MM.yyyy} - {dtpBitis.Value:dd.MM.yyyy}");
                writer.WriteLine($"Rapor Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}");
                writer.WriteLine(); // Empty line

                // Headers
                var headers = new List<string>
                {
                    "S.No", "Hareket", "Tarih", "Saat", "Barkod No", "Ürün Adı",
                    "Alış Fiyatı", "Satış Fiyatı", "Miktar", "Kar", "KDV", "Durum", "Toplam", "Cari Hesap Adı", "İşlem Yapan"
                };
                writer.WriteLine(string.Join(",", headers.Select(h => $"\"{h}\"")));

                // Data from DataGridView
                int rowNumber = 1;
                foreach (DataGridViewRow row in dgvRaporlar.Rows)
                {
                    if (row.IsNewRow || !row.Visible) continue;

                    var values = new List<string>();
                    values.Add($"\"{rowNumber}\""); // S.No

                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        var cellValue = row.Cells[i].Value?.ToString()?.Replace("\"", "\"\"") ?? "";
                        values.Add($"\"{cellValue}\"");
                    }
                    writer.WriteLine(string.Join(",", values));
                    rowNumber++;
                }
            }
        }

        private void ExportSummaryReportToCSV(string filePath)
        {
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Title
                writer.WriteLine("ÖZETLENMİŞ SATIŞ RAPORU");
                writer.WriteLine($"Tarih Aralığı: {dtpBaslangic.Value:dd.MM.yyyy} - {dtpBitis.Value:dd.MM.yyyy}");
                writer.WriteLine($"Rapor Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}");
                writer.WriteLine(); // Empty line

                // Summary Statistics
                writer.WriteLine("ÖZET BİLGİLER");
                writer.WriteLine($"Toplam Satış Adedi: {lblSatisFisiSayisi.Text}");
                writer.WriteLine(); // Empty line

                // Financial Summary from right panel
                writer.WriteLine("FİNANSAL ÖZET");

                // Get all labels from the right panel that show financial data
                var financialData = new Dictionary<string, string>
                {
                    {"Versinye Satış", "0,00 TL"},
                    {"Toplanceya Ödeme Nakit", "0,00 TL"},
                    {"Nakit Satış", "0,00 TL"},
                    {"Toplanceya Ödeme K.Kartı", "0,00 TL"},
                    {"Havale ile Satış", "0,00 TL"},
                    {"Toplanceya Ödeme Havale", "0,00 TL"},
                    {"Kredi Kartı Satış", "0,00 TL"},
                    {"Dışn Girş (Nakit)", "0,00 TL"},
                    {"Nakit + Kredi Kartı Satış", "0,00 TL"},
                    {"Dışn Girş (Kredi Kartı)", "0,00 TL"},
                    {"Takezili Satış", "0,00 TL"},
                    {"Dışn Girş (Havale)", "0,00 TL"},
                    {"Takezili Satış Peşinaat", "0,00 TL"},
                    {"Dışn Girş (Toplanceya Borc)", "0,00 TL"},
                    {"Satışlardan Edilen KAH", "0,00 TL"},
                    {"İade Edilen (Nakit Ödendi)", "0,00 TL"},
                    {"Toplam KDV", "0,00 TL"},
                    {"İade Edilen (Borçtan", "0,00 TL"},
                    {"Müşteri Ödemesi Nakit", "0,00 TL"},
                    {"İade Alınan (Nakit Ödendi)", "0,00 TL"},
                    {"Müşteri Ödemesi K.Kartı", "0,00 TL"},
                    {"İade Alınan (Borçtan", "0,00 TL"},
                    {"Müşteri Ödemesi Havale", "0,00 TL"},
                    {"İade Alınan (Kredi Kartı)", "0,00 TL"}
                };

                foreach (var item in financialData)
                {
                    writer.WriteLine($"{item.Key},{item.Value}");
                }

                writer.WriteLine(); // Empty line

                // Detailed data
                writer.WriteLine("DETAYLI VERİLER");
                var headers = new List<string>
                {
                    "S.No", "Hareket", "Tarih", "Saat", "Barkod No", "Ürün Adı",
                    "Alış Fiyatı", "Satış Fiyatı", "Miktar", "Kar", "KDV", "Durum", "Toplam", "Cari Hesap Adı", "İşlem Yapan"
                };
                writer.WriteLine(string.Join(",", headers.Select(h => $"\"{h}\"")));

                // Data from DataGridView (same as detailed report)
                int rowNumber = 1;
                foreach (DataGridViewRow row in dgvRaporlar.Rows)
                {
                    if (row.IsNewRow || !row.Visible) continue;

                    var values = new List<string>();
                    values.Add($"\"{rowNumber}\""); // S.No

                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        var cellValue = row.Cells[i].Value?.ToString()?.Replace("\"", "\"\"") ?? "";
                        values.Add($"\"{cellValue}\"");
                    }
                    writer.WriteLine(string.Join(",", values));
                    rowNumber++;
                }
            }
        }
    }
}
