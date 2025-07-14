using System;
using System.Data;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class RaporlarForm : Form
    {
        public RaporlarForm()
        {
            InitializeComponent();
            InitializeDateRanges();
            InitializeComboBoxes();
            SetupEventHandlers();
            LoadSampleData(); // Move this to last
        }

        private void InitializeDateRanges()
        {
            // Set default date range to current month
            dtpBaslangic.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpBitis.Value = DateTime.Now;
        }

        private void InitializeComboBoxes()
        {
            // İşlem Yapan dropdown
            cmbIslemYapan.Items.Clear();
            cmbIslemYapan.Items.Add("Tümü");
            cmbIslemYapan.Items.Add("Admin");
            cmbIslemYapan.Items.Add("Kasiyer1");
            cmbIslemYapan.Items.Add("Kasiyer2");
            cmbIslemYapan.SelectedIndex = 0;

            // Ürün Grubu dropdown
            cmbUrunGrubu.Items.Clear();
            cmbUrunGrubu.Items.Add("Tümü");
            cmbUrunGrubu.Items.Add("BİSKÜVİ");
            cmbUrunGrubu.Items.Add("FİLTRE");
            cmbUrunGrubu.Items.Add("SALÇA");
            cmbUrunGrubu.Items.Add("YAĞ");
            cmbUrunGrubu.Items.Add("DETERJAN");
            cmbUrunGrubu.SelectedIndex = 0;
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
            btnAktifKaydi.Click += BtnPaymentMethod_Click;
            btnSayfayiYenile.Click += BtnPaymentMethod_Click;
            btnBankaKarti.Click += BtnPaymentMethod_Click;

            // Export buttons
            btnOzetRaporYazdir.Click += BtnOzetRaporYazdir_Click;
            btnExcelTekTekUrun.Click += BtnExcelTekTekUrun_Click;
            btnExcelBirlestirilmisKayit.Click += BtnExcelBirlestirilmisKayit_Click;

            // Date and combo change events
            dtpBaslangic.ValueChanged += FilterData;
            dtpBitis.ValueChanged += FilterData;
            cmbIslemYapan.SelectedIndexChanged += FilterData;
            cmbUrunGrubu.SelectedIndexChanged += FilterData;
        }

        private void LoadSampleData()
        {
            // Sample transaction data
            dgvRaporlar.Rows.Clear();

            string[] sampleTransactions = {
                "1|Satış|14.07.2025|10:30|8690511010128|ABC ÇAMAŞIR SUYU|70,00|90,00|2|0|180,00|Perakende|Admin",
                "2|Giriş|14.07.2025|09:15|000002|OE 688 PASSAT YAĞ|100,00|150,00|5|0|500,00|Alış|Admin",
                "3|Satış|13.07.2025|16:45|8690504034506|ÜLKER ALBENİ|7,00|10,00|10|0|100,00|Toptan|Kasiyer1",
                "4|İade|13.07.2025|14:20|8690876010016|YUDUM SIVI YAĞ|55,00|75,00|1|0|75,00|Müşteri İade|Admin",
                "5|Satış|12.07.2025|11:30|8690575012519|TAMEK SALÇA|45,00|60,00|3|0|180,00|Perakende|Kasiyer2"
            };

            foreach (string transaction in sampleTransactions)
            {
                string[] parts = transaction.Split('|');
                if (parts.Length >= 13) // Ensure we have enough parts
                {
                    dgvRaporlar.Rows.Add(
                        parts[0],  // S.No
                        parts[1],  // Hareket Türü
                        parts[2],  // Tarih
                        parts[3],  // Saat
                        parts[4],  // Barkod No
                        parts[5],  // Ürün Adı
                        parts[6],  // Alış Fiyatı
                        parts[7],  // Satış Fiyatı
                        parts[8],  // Miktar
                        parts[9],  // KDV
                        parts[10], // Toplam Tutar
                        parts[11], // Cari Hesap Adı
                        parts[12], // İşlem Yapan
                        "Aktif",   // Durum
                        parts[10] // Kar (using Toplam Tutar for now)
                    );
                }
            }

            UpdateSummaryLabels();
        }

        private void UpdateSummaryLabels()
        {
            // Safety check to ensure DataGridView columns are initialized
            if (dgvRaporlar.Columns.Count == 0 || dgvRaporlar.Columns["colHareketTuru"] == null)
            {
                return; // Exit early if columns aren't ready
            }

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

                string hareketTuru = row.Cells["colHareketTuru"].Value?.ToString() ?? "";
                double tutar = double.TryParse(row.Cells["colToplamTutar"].Value?.ToString()?.Replace(",", "."), out double t) ? t : 0;
                int miktar = int.TryParse(row.Cells["colMiktar"].Value?.ToString(), out int m) ? m : 0;

                urunAdetSayisi += miktar;

                if (hareketTuru == "Satış")
                {
                    satisFisiSayisi++;
                    nakitSatis += tutar; // Simplified - in real app would check payment method
                }
            }

            // Update all summary labels
            lblVeresiyeSatis.Text = $"{veresiyeSatis:F2} TL";
            lblNakitSatis.Text = $"{nakitSatis:F2} TL";
            lblHavaleIleSatis.Text = $"{havaleIleSatis:F2} TL";
            lblKrediKartiSatis.Text = $"{krediKartiSatis:F2} TL";
            lblNakitKrediKartiSatis.Text = $"{nakitKrediKartiSatis:F2} TL";
            lblTaksitliSatis.Text = $"{taksitliSatis:F2} TL";
            lblTaksitliSatisPesinati.Text = $"{taksitliSatisPesinati:F2} TL";
            lblSatislaranEdilenKar.Text = $"{satislaranEdilenKar:F2} TL";
            lblToplamKdv.Text = $"{toplamKdv:F2} TL";
            lblMusteriOdememesiNakit.Text = $"{musteriOdememesiNakit:F2} TL";
            lblMusteriOdememesiKKarti.Text = $"{musteriOdememesiKKarti:F2} TL";
            lblMusteriOdememesiHavale.Text = $"{musteriOdememesiHavale:F2} TL";
            lblToptancijaOdemeNakit.Text = $"{toptancijaOdemeNakit:F2} TL";
            lblToptancijaOdemeKKarti.Text = $"{toptancijaOdemeKKarti:F2} TL";
            lblToptancijaOdemeHavale.Text = $"{toptancijaOdemeHavale:F2} TL";
            lblToptancijaOdemeBorclar.Text = $"{toptancijaOdemeBorclar:F2} TL";
            lblUrunGirisiNakit.Text = $"{urunGirisiNakit:F2} TL";
            lblUrunGirisiKrediKarti.Text = $"{urunGirisiKrediKarti:F2} TL";
            lblUrunGirisiHavale.Text = $"{urunGirisiHavale:F2} TL";
            lblUrunGirisiToptanciyaBorc.Text = $"{urunGirisiToptanciyaBorc:F2} TL";
            lblIadeEdilenNakitOdendi.Text = $"{iadeEdilenNakitOdendi:F2} TL";
            lblIadeEdilenBorctanDusuldu.Text = $"{iadeEdilenBorctanDusuldu:F2} TL";
            lblIadeAlinanNakitOdendi.Text = $"{iadeAlinanNakitOdendi:F2} TL";
            lblIadeAlinanBorctanDusuldu.Text = $"{iadeAlinanBorctanDusuldu:F2} TL";
            lblIadeAlinanKrediKarti.Text = $"{iadeAlinanKrediKarti:F2} TL";

            lblUrunAdetSayisi.Text = urunAdetSayisi.ToString();
            lblSatisFisiSayisi.Text = satisFisiSayisi.ToString();
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
                    string hareketTuru = row.Cells["colHareketTuru"].Value?.ToString() ?? "";

                    if (rbSadeceSatislar.Checked && hareketTuru != "Satış")
                        visible = false;
                    else if (rbSadeceAlislar.Checked && hareketTuru != "Giriş")
                        visible = false;
                    else if (rbSadeceIadeAlinanlar.Checked && hareketTuru != "İade")
                        visible = false;
                    else if (rbSadeceIadeEdilenler.Checked && hareketTuru != "İade")
                        visible = false;
                }

                // Filter by date range
                if (DateTime.TryParse(row.Cells["colTarih"].Value?.ToString(), out DateTime rowDate))
                {
                    if (rowDate < dtpBaslangic.Value.Date || rowDate > dtpBitis.Value.Date)
                        visible = false;
                }

                // Filter by işlem yapan
                if (cmbIslemYapan.SelectedItem?.ToString() != "Tümü")
                {
                    string islemYapan = row.Cells["colIslemYapan"].Value?.ToString() ?? "";
                    if (islemYapan != cmbIslemYapan.SelectedItem?.ToString())
                        visible = false;
                }

                row.Visible = visible;
            }

            UpdateSummaryLabels();
        }

        private void BtnPaymentMethod_Click(object? sender, EventArgs e)
        {
            Button? btn = sender as Button;
            MessageBox.Show($"{btn?.Text} işlemi gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOzetRaporYazdir_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Özet rapor yazdırılıyor...", "Yazdır", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExcelTekTekUrun_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Excel'e tek tek ürün aktarılıyor...", "Excel Aktar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExcelBirlestirilmisKayit_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Excel'e birleştirilmiş kayıt aktarılıyor...", "Excel Aktar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
