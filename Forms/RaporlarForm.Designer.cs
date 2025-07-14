namespace StokTakip.Forms
{
    partial class RaporlarForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTarihAraliklari = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.lblSaat1 = new System.Windows.Forms.Label();
            this.lblSaat2 = new System.Windows.Forms.Label();
            this.nudSaat1 = new System.Windows.Forms.NumericUpDown();
            this.nudSaat2 = new System.Windows.Forms.NumericUpDown();
            this.lblHareketTuru = new System.Windows.Forms.Label();
            this.rbTumu = new System.Windows.Forms.RadioButton();
            this.rbSadeceSatislar = new System.Windows.Forms.RadioButton();
            this.rbSadeceAlislar = new System.Windows.Forms.RadioButton();
            this.rbSadeceIadeAlinanlar = new System.Windows.Forms.RadioButton();
            this.rbSadeceIadeEdilenler = new System.Windows.Forms.RadioButton();
            this.gbToplamlar = new System.Windows.Forms.GroupBox();
            this.lblSatisToplamText = new System.Windows.Forms.Label();
            this.lblSatisToplami = new System.Windows.Forms.Label();
            this.lblUrunGirisText = new System.Windows.Forms.Label();
            this.lblUrunGirisi = new System.Windows.Forms.Label();
            this.lblIadeEdToplamText = new System.Windows.Forms.Label();
            this.lblIadeEdToplami = new System.Windows.Forms.Label();
            this.lblIadeAlinanToplamText = new System.Windows.Forms.Label();
            this.lblIadeAlinanToplami = new System.Windows.Forms.Label();
            this.lblMusteriOdemesiText = new System.Windows.Forms.Label();
            this.lblMusteriOdemesi = new System.Windows.Forms.Label();
            this.lblToptanciyaOdemeText = new System.Windows.Forms.Label();
            this.lblToptanciyaOdeme = new System.Windows.Forms.Label();
            this.gbDigerGelirler = new System.Windows.Forms.GroupBox();
            this.lblDigerGelirlerTutar = new System.Windows.Forms.Label();
            this.gbDigerGiderler = new System.Windows.Forms.GroupBox();
            this.lblDigerGiderlerTutar = new System.Windows.Forms.Label();
            this.lblIslemYapan = new System.Windows.Forms.Label();
            this.cmbIslemYapan = new System.Windows.Forms.ComboBox();
            this.lblUrunGrubu = new System.Windows.Forms.Label();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnAktifKaydi = new System.Windows.Forms.Button();
            this.btnSayfayiYenile = new System.Windows.Forms.Button();
            this.btnBankaKarti = new System.Windows.Forms.Button();

            // Summary panels - Left side
            this.pnlVeresiyeSatis = new System.Windows.Forms.Panel();
            this.lblVeresiyeSatisText = new System.Windows.Forms.Label();
            this.lblVeresiyeSatis = new System.Windows.Forms.Label();
            this.pnlNakitSatis = new System.Windows.Forms.Panel();
            this.lblNakitSatisText = new System.Windows.Forms.Label();
            this.lblNakitSatis = new System.Windows.Forms.Label();
            this.pnlHavaleIleSatis = new System.Windows.Forms.Panel();
            this.lblHavaleIleSatisText = new System.Windows.Forms.Label();
            this.lblHavaleIleSatis = new System.Windows.Forms.Label();
            this.pnlKrediKartiSatis = new System.Windows.Forms.Panel();
            this.lblKrediKartiSatisText = new System.Windows.Forms.Label();
            this.lblKrediKartiSatis = new System.Windows.Forms.Label();
            this.pnlNakitKrediKartiSatis = new System.Windows.Forms.Panel();
            this.lblNakitKrediKartiSatisText = new System.Windows.Forms.Label();
            this.lblNakitKrediKartiSatis = new System.Windows.Forms.Label();
            this.pnlTaksitliSatis = new System.Windows.Forms.Panel();
            this.lblTaksitliSatisText = new System.Windows.Forms.Label();
            this.lblTaksitliSatis = new System.Windows.Forms.Label();
            this.pnlTaksitliSatisPesinati = new System.Windows.Forms.Panel();
            this.lblTaksitliSatisPesinatiText = new System.Windows.Forms.Label();
            this.lblTaksitliSatisPesinati = new System.Windows.Forms.Label();
            this.pnlSatislaranEdilenKar = new System.Windows.Forms.Panel();
            this.lblSatislaranEdilenKarText = new System.Windows.Forms.Label();
            this.lblSatislaranEdilenKar = new System.Windows.Forms.Label();
            this.pnlToplamKdv = new System.Windows.Forms.Panel();
            this.lblToplamKdvText = new System.Windows.Forms.Label();
            this.lblToplamKdv = new System.Windows.Forms.Label();
            this.pnlMusteriOdememesiNakit = new System.Windows.Forms.Panel();
            this.lblMusteriOdememesiNakitText = new System.Windows.Forms.Label();
            this.lblMusteriOdememesiNakit = new System.Windows.Forms.Label();
            this.pnlMusteriOdememesiKKarti = new System.Windows.Forms.Panel();
            this.lblMusteriOdememesiKKartiText = new System.Windows.Forms.Label();
            this.lblMusteriOdememesiKKarti = new System.Windows.Forms.Label();
            this.pnlMusteriOdememesiHavale = new System.Windows.Forms.Panel();
            this.lblMusteriOdememesiHavaleText = new System.Windows.Forms.Label();
            this.lblMusteriOdememesiHavale = new System.Windows.Forms.Label();

            // Summary panels - Right side
            this.pnlToptancijaOdemeNakit = new System.Windows.Forms.Panel();
            this.lblToptancijaOdemeNakitText = new System.Windows.Forms.Label();
            this.lblToptancijaOdemeNakit = new System.Windows.Forms.Label();
            this.pnlToptancijaOdemeKKarti = new System.Windows.Forms.Panel();
            this.lblToptancijaOdemeKKartiText = new System.Windows.Forms.Label();
            this.lblToptancijaOdemeKKarti = new System.Windows.Forms.Label();
            this.pnlToptancijaOdemeHavale = new System.Windows.Forms.Panel();
            this.lblToptancijaOdemeHavaleText = new System.Windows.Forms.Label();
            this.lblToptancijaOdemeHavale = new System.Windows.Forms.Label();
            this.pnlToptancijaOdemeBorclar = new System.Windows.Forms.Panel();
            this.lblToptancijaOdemeBorclarText = new System.Windows.Forms.Label();
            this.lblToptancijaOdemeBorclar = new System.Windows.Forms.Label();
            this.pnlUrunGirisiNakit = new System.Windows.Forms.Panel();
            this.lblUrunGirisiNakitText = new System.Windows.Forms.Label();
            this.lblUrunGirisiNakit = new System.Windows.Forms.Label();
            this.pnlUrunGirisiKrediKarti = new System.Windows.Forms.Panel();
            this.lblUrunGirisiKrediKartiText = new System.Windows.Forms.Label();
            this.lblUrunGirisiKrediKarti = new System.Windows.Forms.Label();
            this.pnlUrunGirisiHavale = new System.Windows.Forms.Panel();
            this.lblUrunGirisiHavaleText = new System.Windows.Forms.Label();
            this.lblUrunGirisiHavale = new System.Windows.Forms.Label();
            this.pnlUrunGirisiToptanciyaBorc = new System.Windows.Forms.Panel();
            this.lblUrunGirisiToptanciyaBorcText = new System.Windows.Forms.Label();
            this.lblUrunGirisiToptanciyaBorc = new System.Windows.Forms.Label();
            this.pnlIadeEdilenNakitOdendi = new System.Windows.Forms.Panel();
            this.lblIadeEdilenNakitOdendiText = new System.Windows.Forms.Label();
            this.lblIadeEdilenNakitOdendi = new System.Windows.Forms.Label();
            this.pnlIadeEdilenBorctanDusuldu = new System.Windows.Forms.Panel();
            this.lblIadeEdilenBorctanDusulduText = new System.Windows.Forms.Label();
            this.lblIadeEdilenBorctanDusuldu = new System.Windows.Forms.Label();
            this.pnlIadeAlinanNakitOdendi = new System.Windows.Forms.Panel();
            this.lblIadeAlinanNakitOdendiText = new System.Windows.Forms.Label();
            this.lblIadeAlinanNakitOdendi = new System.Windows.Forms.Label();
            this.pnlIadeAlinanBorctanDusuldu = new System.Windows.Forms.Panel();
            this.lblIadeAlinanBorctanDusulduText = new System.Windows.Forms.Label();
            this.lblIadeAlinanBorctanDusuldu = new System.Windows.Forms.Label();
            this.pnlIadeAlinanKrediKarti = new System.Windows.Forms.Panel();
            this.lblIadeAlinanKrediKartiText = new System.Windows.Forms.Label();
            this.lblIadeAlinanKrediKarti = new System.Windows.Forms.Label();

            this.dgvRaporlar = new System.Windows.Forms.DataGridView();
            this.colSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHareketTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSatisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCariHesapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIslemYapan = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.btnOzetRaporYazdir = new System.Windows.Forms.Button();
            this.btnExcelTekTekUrun = new System.Windows.Forms.Button();
            this.btnExcelBirlestirilmisKayit = new System.Windows.Forms.Button();
            this.pnlUrunAdetSayisi = new System.Windows.Forms.Panel();
            this.lblUrunAdetSayisiText = new System.Windows.Forms.Label();
            this.lblUrunAdetSayisi = new System.Windows.Forms.Label();
            this.pnlSatisFisiSayisi = new System.Windows.Forms.Panel();
            this.lblSatisFisiSayisiText = new System.Windows.Forms.Label();
            this.lblSatisFisiSayisi = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.nudSaat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaat2)).BeginInit();
            this.gbToplamlar.SuspendLayout();
            this.gbDigerGelirler.SuspendLayout();
            this.gbDigerGiderler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTarihAraliklari
            // 
            this.lblTarihAraliklari.AutoSize = true;
            this.lblTarihAraliklari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTarihAraliklari.Location = new System.Drawing.Point(20, 20);
            this.lblTarihAraliklari.Name = "lblTarihAraliklari";
            this.lblTarihAraliklari.Size = new System.Drawing.Size(98, 15);
            this.lblTarihAraliklari.Text = "Tarih Aralıkları";

            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(20, 40);
            this.dtpBaslangic.Size = new System.Drawing.Size(100, 20);

            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(20, 70);
            this.dtpBitis.Size = new System.Drawing.Size(100, 20);

            // Setup all the summary panels with cyan backgrounds
            this.SetupSummaryPanel(this.pnlVeresiyeSatis, this.lblVeresiyeSatisText, this.lblVeresiyeSatis, "Veresiye Satış", "0,00 TL", 580, 40);
            this.SetupSummaryPanel(this.pnlNakitSatis, this.lblNakitSatisText, this.lblNakitSatis, "Nakit Satış", "0,00 TL", 580, 70);
            this.SetupSummaryPanel(this.pnlHavaleIleSatis, this.lblHavaleIleSatisText, this.lblHavaleIleSatis, "Havale İle Satış", "0,00 TL", 580, 100);
            this.SetupSummaryPanel(this.pnlKrediKartiSatis, this.lblKrediKartiSatisText, this.lblKrediKartiSatis, "Kredi Kartı Satış", "0,00 TL", 580, 130);
            this.SetupSummaryPanel(this.pnlNakitKrediKartiSatis, this.lblNakitKrediKartiSatisText, this.lblNakitKrediKartiSatis, "Nakit + Kredi Kartı Satış", "0,00 TL", 580, 160);
            this.SetupSummaryPanel(this.pnlTaksitliSatis, this.lblTaksitliSatisText, this.lblTaksitliSatis, "Taksitli Satış", "0,00 TL", 580, 190);
            this.SetupSummaryPanel(this.pnlTaksitliSatisPesinati, this.lblTaksitliSatisPesinatiText, this.lblTaksitliSatisPesinati, "Taksitli Satış Peşinatı", "0,00 TL", 580, 220);
            this.SetupSummaryPanel(this.pnlSatislaranEdilenKar, this.lblSatislaranEdilenKarText, this.lblSatislaranEdilenKar, "Satışlardan Edilen KAR", "0,00 TL", 580, 250);
            this.SetupSummaryPanel(this.pnlToplamKdv, this.lblToplamKdvText, this.lblToplamKdv, "Toplam KDV", "0,00 TL", 580, 280);
            this.SetupSummaryPanel(this.pnlMusteriOdememesiNakit, this.lblMusteriOdememesiNakitText, this.lblMusteriOdememesiNakit, "Müşteri Ödemesi Nakit", "0,00 TL", 580, 310);
            this.SetupSummaryPanel(this.pnlMusteriOdememesiKKarti, this.lblMusteriOdememesiKKartiText, this.lblMusteriOdememesiKKarti, "Müşteri Ödemesi K.Kartı", "0,00 TL", 580, 340);
            this.SetupSummaryPanel(this.pnlMusteriOdememesiHavale, this.lblMusteriOdememesiHavaleText, this.lblMusteriOdememesiHavale, "Müşteri Ödemesi Havale", "0,00 TL", 580, 370);

            // Right side summary panels
            this.SetupSummaryPanel(this.pnlToptancijaOdemeNakit, this.lblToptancijaOdemeNakitText, this.lblToptancijaOdemeNakit, "Toptancıya Ödeme Nakit", "0,00 TL", 880, 40);
            this.SetupSummaryPanel(this.pnlToptancijaOdemeKKarti, this.lblToptancijaOdemeKKartiText, this.lblToptancijaOdemeKKarti, "Toptancıya Ödeme K.Kartı", "0,00 TL", 880, 70);
            this.SetupSummaryPanel(this.pnlToptancijaOdemeHavale, this.lblToptancijaOdemeHavaleText, this.lblToptancijaOdemeHavale, "Toptancıya Ödeme Havale", "0,00 TL", 880, 100);
            this.SetupSummaryPanel(this.pnlToptancijaOdemeBorclar, this.lblToptancijaOdemeBorclarText, this.lblToptancijaOdemeBorclar, "Ürün Girişi (Nakit)", "0,00 TL", 880, 130);
            this.SetupSummaryPanel(this.pnlUrunGirisiNakit, this.lblUrunGirisiNakitText, this.lblUrunGirisiNakit, "Ürün Girişi (Kredi Kartı)", "0,00 TL", 880, 160);
            this.SetupSummaryPanel(this.pnlUrunGirisiKrediKarti, this.lblUrunGirisiKrediKartiText, this.lblUrunGirisiKrediKarti, "Ürün Girişi (Havale)", "0,00 TL", 880, 190);
            this.SetupSummaryPanel(this.pnlUrunGirisiHavale, this.lblUrunGirisiHavaleText, this.lblUrunGirisiHavale, "Ürün Girişi (Toptancıya Borç)", "0,00 TL", 880, 220);
            this.SetupSummaryPanel(this.pnlUrunGirisiToptanciyaBorc, this.lblUrunGirisiToptanciyaBorcText, this.lblUrunGirisiToptanciyaBorc, "İade Edilen (Nakit Ödendi)", "0,00 TL", 880, 250);
            this.SetupSummaryPanel(this.pnlIadeEdilenNakitOdendi, this.lblIadeEdilenNakitOdendiText, this.lblIadeEdilenNakitOdendi, "İade Edilen (Borçtan Düşüldü)", "0,00 TL", 880, 280);
            this.SetupSummaryPanel(this.pnlIadeEdilenBorctanDusuldu, this.lblIadeEdilenBorctanDusulduText, this.lblIadeEdilenBorctanDusuldu, "İade Alınan (Nakit Ödendi)", "0,00 TL", 880, 310);
            this.SetupSummaryPanel(this.pnlIadeAlinanNakitOdendi, this.lblIadeAlinanNakitOdendiText, this.lblIadeAlinanNakitOdendi, "İade Alınan (Borçtan Düşüldü)", "0,00 TL", 880, 340);
            this.SetupSummaryPanel(this.pnlIadeAlinanBorctanDusuldu, this.lblIadeAlinanBorctanDusulduText, this.lblIadeAlinanBorctanDusuldu, "İade Alınan (Kredi Kartı)", "0,00 TL", 880, 370);
            this.SetupSummaryPanel(this.pnlIadeAlinanKrediKarti, this.lblIadeAlinanKrediKartiText, this.lblIadeAlinanKrediKarti, "İade Alınan (Kredi Kartı)", "0,00 TL", 880, 370);

            // 
            // lblHareketTuru
            // 
            this.lblHareketTuru.AutoSize = true;
            this.lblHareketTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblHareketTuru.Location = new System.Drawing.Point(20, 110);
            this.lblHareketTuru.Text = "Hareket Türü";

            // Radio buttons setup
            this.rbTumu.AutoSize = true;
            this.rbTumu.Checked = true;
            this.rbTumu.Location = new System.Drawing.Point(20, 130);
            this.rbTumu.Text = "Tümü";
            this.rbTumu.UseVisualStyleBackColor = true;

            this.rbSadeceSatislar.AutoSize = true;
            this.rbSadeceSatislar.ForeColor = System.Drawing.Color.Blue;
            this.rbSadeceSatislar.Location = new System.Drawing.Point(20, 150);
            this.rbSadeceSatislar.Text = "Sadece Satışlar";
            this.rbSadeceSatislar.UseVisualStyleBackColor = true;

            this.rbSadeceAlislar.AutoSize = true;
            this.rbSadeceAlislar.ForeColor = System.Drawing.Color.Blue;
            this.rbSadeceAlislar.Location = new System.Drawing.Point(20, 170);
            this.rbSadeceAlislar.Text = "Sadece Alışlar";
            this.rbSadeceAlislar.UseVisualStyleBackColor = true;

            this.rbSadeceIadeAlinanlar.AutoSize = true;
            this.rbSadeceIadeAlinanlar.ForeColor = System.Drawing.Color.Blue;
            this.rbSadeceIadeAlinanlar.Location = new System.Drawing.Point(20, 190);
            this.rbSadeceIadeAlinanlar.Text = "Sadece İade Alınanlar";
            this.rbSadeceIadeAlinanlar.UseVisualStyleBackColor = true;

            this.rbSadeceIadeEdilenler.AutoSize = true;
            this.rbSadeceIadeEdilenler.ForeColor = System.Drawing.Color.Blue;
            this.rbSadeceIadeEdilenler.Location = new System.Drawing.Point(20, 210);
            this.rbSadeceIadeEdilenler.Text = "Sadece İade Edilenler";
            this.rbSadeceIadeEdilenler.UseVisualStyleBackColor = true;

            // İşlem Yapan
            this.lblIslemYapan.AutoSize = true;
            this.lblIslemYapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemYapan.ForeColor = System.Drawing.Color.Red;
            this.lblIslemYapan.Location = new System.Drawing.Point(250, 20);
            this.lblIslemYapan.Text = "İşlem Yapan";

            this.cmbIslemYapan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemYapan.Location = new System.Drawing.Point(250, 40);
            this.cmbIslemYapan.Size = new System.Drawing.Size(120, 21);

            // Ürün Grubu
            this.lblUrunGrubu.AutoSize = true;
            this.lblUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblUrunGrubu.ForeColor = System.Drawing.Color.Red;
            this.lblUrunGrubu.Location = new System.Drawing.Point(250, 70);
            this.lblUrunGrubu.Text = "Ürün Grubu";

            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(250, 90);
            this.cmbUrunGrubu.Size = new System.Drawing.Size(120, 21);

            // Ürün Adı
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblUrunAdi.ForeColor = System.Drawing.Color.Red;
            this.lblUrunAdi.Location = new System.Drawing.Point(250, 120);
            this.lblUrunAdi.Text = "Ürün Adı";

            this.txtUrunAdi.Location = new System.Drawing.Point(250, 140);
            this.txtUrunAdi.Size = new System.Drawing.Size(120, 20);

            // Action buttons
            this.btnAktifKaydi.BackColor = System.Drawing.Color.Red;
            this.btnAktifKaydi.ForeColor = System.Drawing.Color.White;
            this.btnAktifKaydi.Location = new System.Drawing.Point(400, 40);
            this.btnAktifKaydi.Size = new System.Drawing.Size(60, 60);
            this.btnAktifKaydi.Text = "Aktif Kaydı Rapordan Sil";
            this.btnAktifKaydi.UseVisualStyleBackColor = false;

            this.btnSayfayiYenile.BackColor = System.Drawing.Color.Green;
            this.btnSayfayiYenile.ForeColor = System.Drawing.Color.White;
            this.btnSayfayiYenile.Location = new System.Drawing.Point(470, 40);
            this.btnSayfayiYenile.Size = new System.Drawing.Size(60, 60);
            this.btnSayfayiYenile.Text = "Sayfayı Yenile";
            this.btnSayfayiYenile.UseVisualStyleBackColor = false;

            this.btnBankaKarti.BackColor = System.Drawing.Color.Blue;
            this.btnBankaKarti.ForeColor = System.Drawing.Color.White;
            this.btnBankaKarti.Location = new System.Drawing.Point(480, 120);
            this.btnBankaKarti.Size = new System.Drawing.Size(60, 40);
            this.btnBankaKarti.Text = "Banka Kartı Hesapları";
            this.btnBankaKarti.UseVisualStyleBackColor = false;

            // 
            // dgvRaporlar
            // 
            this.dgvRaporlar.AllowUserToAddRows = false;
            this.dgvRaporlar.AllowUserToDeleteRows = false;
            this.dgvRaporlar.BackgroundColor = System.Drawing.Color.White;
            this.dgvRaporlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSNo, this.colHareketTuru, this.colTarih, this.colSaat, this.colBarkodNo,
            this.colUrunAdi, this.colAlisFiyati, this.colSatisFiyati, this.colMiktar, this.colKar,
            this.colKDV, this.colDurum, this.colToplamTutar, this.colCariHesapAdi, this.colIslemYapan});
            this.dgvRaporlar.Location = new System.Drawing.Point(12, 410);
            this.dgvRaporlar.Name = "dgvRaporlar";
            this.dgvRaporlar.ReadOnly = true;
            this.dgvRaporlar.RowHeadersVisible = false;
            this.dgvRaporlar.Size = new System.Drawing.Size(1150, 200);

            // Setup columns
            this.colSNo.HeaderText = "S.No";
            this.colSNo.Width = 50;
            this.colHareketTuru.HeaderText = "Hareket Türü";
            this.colHareketTuru.Width = 80;
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.Width = 70;
            this.colSaat.HeaderText = "Saat";
            this.colSaat.Width = 50;
            this.colBarkodNo.HeaderText = "Barkod No";
            this.colBarkodNo.Width = 90;
            this.colUrunAdi.HeaderText = "Ürün Adı";
            this.colUrunAdi.Width = 200;
            this.colAlisFiyati.HeaderText = "Alış Fiyatı";
            this.colAlisFiyati.Width = 70;
            this.colSatisFiyati.HeaderText = "Satış Fiyatı";
            this.colSatisFiyati.Width = 70;
            this.colMiktar.HeaderText = "Miktar";
            this.colMiktar.Width = 60;
            this.colKar.HeaderText = "Kar";
            this.colKar.Width = 60;
            this.colKDV.HeaderText = "KDV";
            this.colKDV.Width = 50;
            this.colDurum.HeaderText = "Durum";
            this.colDurum.Width = 70;
            this.colToplamTutar.HeaderText = "Toplam Tutar";
            this.colToplamTutar.Width = 80;
            this.colCariHesapAdi.HeaderText = "Cari Hesap Adı";
            this.colCariHesapAdi.Width = 120;
            this.colIslemYapan.HeaderText = "İşlem Yapan";
            this.colIslemYapan.Width = 80;

            // Export buttons
            this.btnOzetRaporYazdir.BackColor = System.Drawing.Color.LightGray;
            this.btnOzetRaporYazdir.Location = new System.Drawing.Point(320, 720);
            this.btnOzetRaporYazdir.Size = new System.Drawing.Size(100, 40);
            this.btnOzetRaporYazdir.Text = "Özet Rapor Yazdır";
            this.btnOzetRaporYazdir.UseVisualStyleBackColor = false;

            this.btnExcelTekTekUrun.BackColor = System.Drawing.Color.LightGreen;
            this.btnExcelTekTekUrun.Location = new System.Drawing.Point(480, 720);
            this.btnExcelTekTekUrun.Size = new System.Drawing.Size(100, 40);
            this.btnExcelTekTekUrun.Text = "Excel'e Aktar (Tek Tek Ürün)";
            this.btnExcelTekTekUrun.UseVisualStyleBackColor = false;

            this.btnExcelBirlestirilmisKayit.BackColor = System.Drawing.Color.LightGreen;
            this.btnExcelBirlestirilmisKayit.Location = new System.Drawing.Point(650, 720);
            this.btnExcelBirlestirilmisKayit.Size = new System.Drawing.Size(100, 40);
            this.btnExcelBirlestirilmisKayit.Text = "Excel'e Aktar (Birleştirilmiş Kayıt)";
            this.btnExcelBirlestirilmisKayit.UseVisualStyleBackColor = false;

            // Bottom right counters
            this.SetupSummaryPanel(this.pnlUrunAdetSayisi, this.lblUrunAdetSayisiText, this.lblUrunAdetSayisi, "ÜRÜN ADET SAYISI", "0", 1000, 720, System.Drawing.Color.Green);
            this.SetupSummaryPanel(this.pnlSatisFisiSayisi, this.lblSatisFisiSayisiText, this.lblSatisFisiSayisi, "SATIŞ FİŞİ SAYISI", "0", 1000, 760, System.Drawing.Color.Green);

            // 
            // RaporlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1180, 800);
            this.Controls.Add(this.lblTarihAraliklari);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.lblHareketTuru);
            this.Controls.Add(this.rbTumu);
            this.Controls.Add(this.rbSadeceSatislar);
            this.Controls.Add(this.rbSadeceAlislar);
            this.Controls.Add(this.rbSadeceIadeAlinanlar);
            this.Controls.Add(this.rbSadeceIadeEdilenler);
            this.Controls.Add(this.lblIslemYapan);
            this.Controls.Add(this.cmbIslemYapan);
            this.Controls.Add(this.lblUrunGrubu);
            this.Controls.Add(this.cmbUrunGrubu);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.btnAktifKaydi);
            this.Controls.Add(this.btnSayfayiYenile);
            this.Controls.Add(this.btnBankaKarti);
            this.Controls.Add(this.dgvRaporlar);
            this.Controls.Add(this.btnOzetRaporYazdir);
            this.Controls.Add(this.btnExcelTekTekUrun);
            this.Controls.Add(this.btnExcelBirlestirilmisKayit);

            // Add all summary panels
            this.Controls.Add(this.pnlVeresiyeSatis);
            this.Controls.Add(this.pnlNakitSatis);
            this.Controls.Add(this.pnlHavaleIleSatis);
            this.Controls.Add(this.pnlKrediKartiSatis);
            this.Controls.Add(this.pnlNakitKrediKartiSatis);
            this.Controls.Add(this.pnlTaksitliSatis);
            this.Controls.Add(this.pnlTaksitliSatisPesinati);
            this.Controls.Add(this.pnlSatislaranEdilenKar);
            this.Controls.Add(this.pnlToplamKdv);
            this.Controls.Add(this.pnlMusteriOdememesiNakit);
            this.Controls.Add(this.pnlMusteriOdememesiKKarti);
            this.Controls.Add(this.pnlMusteriOdememesiHavale);
            this.Controls.Add(this.pnlToptancijaOdemeNakit);
            this.Controls.Add(this.pnlToptancijaOdemeKKarti);
            this.Controls.Add(this.pnlToptancijaOdemeHavale);
            this.Controls.Add(this.pnlToptancijaOdemeBorclar);
            this.Controls.Add(this.pnlUrunGirisiNakit);
            this.Controls.Add(this.pnlUrunGirisiKrediKarti);
            this.Controls.Add(this.pnlUrunGirisiHavale);
            this.Controls.Add(this.pnlUrunGirisiToptanciyaBorc);
            this.Controls.Add(this.pnlIadeEdilenNakitOdendi);
            this.Controls.Add(this.pnlIadeEdilenBorctanDusuldu);
            this.Controls.Add(this.pnlIadeAlinanNakitOdendi);
            this.Controls.Add(this.pnlIadeAlinanBorctanDusuldu);
            this.Controls.Add(this.pnlIadeAlinanKrediKarti);
            this.Controls.Add(this.pnlUrunAdetSayisi);
            this.Controls.Add(this.pnlSatisFisiSayisi);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RaporlarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RAPORLAR";

            ((System.ComponentModel.ISupportInitialize)(this.nudSaat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaat2)).EndInit();
            this.gbToplamlar.ResumeLayout(false);
            this.gbDigerGelirler.ResumeLayout(false);
            this.gbDigerGiderler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetupSummaryPanel(System.Windows.Forms.Panel panel, System.Windows.Forms.Label textLabel, System.Windows.Forms.Label valueLabel, string text, string value, int x, int y, System.Drawing.Color? backColor = null)
        {
            panel.BackColor = backColor ?? System.Drawing.Color.Cyan;
            panel.Location = new System.Drawing.Point(x, y);
            panel.Size = new System.Drawing.Size(250, 25);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            textLabel.Text = text;
            textLabel.Location = new System.Drawing.Point(5, 5);
            textLabel.Size = new System.Drawing.Size(150, 15);
            textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);

            valueLabel.Text = value;
            valueLabel.Location = new System.Drawing.Point(160, 5);
            valueLabel.Size = new System.Drawing.Size(80, 15);
            valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            panel.Controls.Add(textLabel);
            panel.Controls.Add(valueLabel);
        }

        // All the control declarations
        private System.Windows.Forms.Label lblTarihAraliklari;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label lblSaat1;
        private System.Windows.Forms.Label lblSaat2;
        private System.Windows.Forms.NumericUpDown nudSaat1;
        private System.Windows.Forms.NumericUpDown nudSaat2;
        private System.Windows.Forms.Label lblHareketTuru;
        private System.Windows.Forms.RadioButton rbTumu;
        private System.Windows.Forms.RadioButton rbSadeceSatislar;
        private System.Windows.Forms.RadioButton rbSadeceAlislar;
        private System.Windows.Forms.RadioButton rbSadeceIadeAlinanlar;
        private System.Windows.Forms.RadioButton rbSadeceIadeEdilenler;
        private System.Windows.Forms.GroupBox gbToplamlar;
        private System.Windows.Forms.Label lblSatisToplamText;
        private System.Windows.Forms.Label lblSatisToplami;
        private System.Windows.Forms.Label lblUrunGirisText;
        private System.Windows.Forms.Label lblUrunGirisi;
        private System.Windows.Forms.Label lblIadeEdToplamText;
        private System.Windows.Forms.Label lblIadeEdToplami;
        private System.Windows.Forms.Label lblIadeAlinanToplamText;
        private System.Windows.Forms.Label lblIadeAlinanToplami;
        private System.Windows.Forms.Label lblMusteriOdemesiText;
        private System.Windows.Forms.Label lblMusteriOdemesi;
        private System.Windows.Forms.Label lblToptanciyaOdemeText;
        private System.Windows.Forms.Label lblToptanciyaOdeme;
        private System.Windows.Forms.GroupBox gbDigerGelirler;
        private System.Windows.Forms.Label lblDigerGelirlerTutar;
        private System.Windows.Forms.GroupBox gbDigerGiderler;
        private System.Windows.Forms.Label lblDigerGiderlerTutar;
        private System.Windows.Forms.Label lblIslemYapan;
        private System.Windows.Forms.ComboBox cmbIslemYapan;
        private System.Windows.Forms.Label lblUrunGrubu;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnAktifKaydi;
        private System.Windows.Forms.Button btnSayfayiYenile;
        private System.Windows.Forms.Button btnBankaKarti;

        // Summary panels and labels
        private System.Windows.Forms.Panel pnlVeresiyeSatis;
        private System.Windows.Forms.Label lblVeresiyeSatisText;
        private System.Windows.Forms.Label lblVeresiyeSatis;
        private System.Windows.Forms.Panel pnlNakitSatis;
        private System.Windows.Forms.Label lblNakitSatisText;
        private System.Windows.Forms.Label lblNakitSatis;
        private System.Windows.Forms.Panel pnlHavaleIleSatis;
        private System.Windows.Forms.Label lblHavaleIleSatisText;
        private System.Windows.Forms.Label lblHavaleIleSatis;
        private System.Windows.Forms.Panel pnlKrediKartiSatis;
        private System.Windows.Forms.Label lblKrediKartiSatisText;
        private System.Windows.Forms.Label lblKrediKartiSatis;
        private System.Windows.Forms.Panel pnlNakitKrediKartiSatis;
        private System.Windows.Forms.Label lblNakitKrediKartiSatisText;
        private System.Windows.Forms.Label lblNakitKrediKartiSatis;
        private System.Windows.Forms.Panel pnlTaksitliSatis;
        private System.Windows.Forms.Label lblTaksitliSatisText;
        private System.Windows.Forms.Label lblTaksitliSatis;
        private System.Windows.Forms.Panel pnlTaksitliSatisPesinati;
        private System.Windows.Forms.Label lblTaksitliSatisPesinatiText;
        private System.Windows.Forms.Label lblTaksitliSatisPesinati;
        private System.Windows.Forms.Panel pnlSatislaranEdilenKar;
        private System.Windows.Forms.Label lblSatislaranEdilenKarText;
        private System.Windows.Forms.Label lblSatislaranEdilenKar;
        private System.Windows.Forms.Panel pnlToplamKdv;
        private System.Windows.Forms.Label lblToplamKdvText;
        private System.Windows.Forms.Label lblToplamKdv;
        private System.Windows.Forms.Panel pnlMusteriOdememesiNakit;
        private System.Windows.Forms.Label lblMusteriOdememesiNakitText;
        private System.Windows.Forms.Label lblMusteriOdememesiNakit;
        private System.Windows.Forms.Panel pnlMusteriOdememesiKKarti;
        private System.Windows.Forms.Label lblMusteriOdememesiKKartiText;
        private System.Windows.Forms.Label lblMusteriOdememesiKKarti;
        private System.Windows.Forms.Panel pnlMusteriOdememesiHavale;
        private System.Windows.Forms.Label lblMusteriOdememesiHavaleText;
        private System.Windows.Forms.Label lblMusteriOdememesiHavale;
        private System.Windows.Forms.Panel pnlToptancijaOdemeNakit;
        private System.Windows.Forms.Label lblToptancijaOdemeNakitText;
        private System.Windows.Forms.Label lblToptancijaOdemeNakit;
        private System.Windows.Forms.Panel pnlToptancijaOdemeKKarti;
        private System.Windows.Forms.Label lblToptancijaOdemeKKartiText;
        private System.Windows.Forms.Label lblToptancijaOdemeKKarti;
        private System.Windows.Forms.Panel pnlToptancijaOdemeHavale;
        private System.Windows.Forms.Label lblToptancijaOdemeHavaleText;
        private System.Windows.Forms.Label lblToptancijaOdemeHavale;
        private System.Windows.Forms.Panel pnlToptancijaOdemeBorclar;
        private System.Windows.Forms.Label lblToptancijaOdemeBorclarText;
        private System.Windows.Forms.Label lblToptancijaOdemeBorclar;
        private System.Windows.Forms.Panel pnlUrunGirisiNakit;
        private System.Windows.Forms.Label lblUrunGirisiNakitText;
        private System.Windows.Forms.Label lblUrunGirisiNakit;
        private System.Windows.Forms.Panel pnlUrunGirisiKrediKarti;
        private System.Windows.Forms.Label lblUrunGirisiKrediKartiText;
        private System.Windows.Forms.Label lblUrunGirisiKrediKarti;
        private System.Windows.Forms.Panel pnlUrunGirisiHavale;
        private System.Windows.Forms.Label lblUrunGirisiHavaleText;
        private System.Windows.Forms.Label lblUrunGirisiHavale;
        private System.Windows.Forms.Panel pnlUrunGirisiToptanciyaBorc;
        private System.Windows.Forms.Label lblUrunGirisiToptanciyaBorcText;
        private System.Windows.Forms.Label lblUrunGirisiToptanciyaBorc;
        private System.Windows.Forms.Panel pnlIadeEdilenNakitOdendi;
        private System.Windows.Forms.Label lblIadeEdilenNakitOdendiText;
        private System.Windows.Forms.Label lblIadeEdilenNakitOdendi;
        private System.Windows.Forms.Panel pnlIadeEdilenBorctanDusuldu;
        private System.Windows.Forms.Label lblIadeEdilenBorctanDusulduText;
        private System.Windows.Forms.Label lblIadeEdilenBorctanDusuldu;
        private System.Windows.Forms.Panel pnlIadeAlinanNakitOdendi;
        private System.Windows.Forms.Label lblIadeAlinanNakitOdendiText;
        private System.Windows.Forms.Label lblIadeAlinanNakitOdendi;
        private System.Windows.Forms.Panel pnlIadeAlinanBorctanDusuldu;
        private System.Windows.Forms.Label lblIadeAlinanBorctanDusulduText;
        private System.Windows.Forms.Label lblIadeAlinanBorctanDusuldu;
        private System.Windows.Forms.Panel pnlIadeAlinanKrediKarti;
        private System.Windows.Forms.Label lblIadeAlinanKrediKartiText;
        private System.Windows.Forms.Label lblIadeAlinanKrediKarti;

        private System.Windows.Forms.DataGridView dgvRaporlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHareketTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSatisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplamTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCariHesapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIslemYapan;

        private System.Windows.Forms.Button btnOzetRaporYazdir;
        private System.Windows.Forms.Button btnExcelTekTekUrun;
        private System.Windows.Forms.Button btnExcelBirlestirilmisKayit;
        private System.Windows.Forms.Panel pnlUrunAdetSayisi;
        private System.Windows.Forms.Label lblUrunAdetSayisiText;
        private System.Windows.Forms.Label lblUrunAdetSayisi;
        private System.Windows.Forms.Panel pnlSatisFisiSayisi;
        private System.Windows.Forms.Label lblSatisFisiSayisiText;
        private System.Windows.Forms.Label lblSatisFisiSayisi;
    }
}
