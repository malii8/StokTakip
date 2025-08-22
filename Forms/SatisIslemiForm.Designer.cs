namespace StokTakip.Forms
{
    partial class SatisIslemiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.pnlBarkod = new System.Windows.Forms.Panel();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.lblSelectedCustomerName = new System.Windows.Forms.Label();
            this.lblSelectedCustomerDebt = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvSatisListesi = new System.Windows.Forms.DataGridView();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlHizliSatis = new System.Windows.Forms.Panel();
            this.btnStoksuzSatis = new System.Windows.Forms.Button();
            this.lblHizliSatis = new System.Windows.Forms.Label();
            this.btnTuslariSil = new System.Windows.Forms.Button();
            this.btnTuslariDegistir = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlKasa = new System.Windows.Forms.Panel();
            this.txtKar = new System.Windows.Forms.TextBox();
            this.lblKar = new System.Windows.Forms.Label();
            this.chkKarGoster = new System.Windows.Forms.CheckBox();
            this.txtParaUstu = new System.Windows.Forms.TextBox();
            this.lblParaUstu = new System.Windows.Forms.Label();
            this.txtAlinanPara = new System.Windows.Forms.TextBox();
            this.lblAlinanPara = new System.Windows.Forms.Label();
            this.lblIsletmeSahibi = new System.Windows.Forms.Label();
            this.lblKasiyer = new System.Windows.Forms.Label();
            this.pnlFis = new System.Windows.Forms.Panel();
            this.btnSatisBilgisiYazdir = new System.Windows.Forms.Button();
            this.btnEskiFisler = new System.Windows.Forms.Button();
            this.pnlToplam = new System.Windows.Forms.Panel();
            this.lblToplam = new System.Windows.Forms.Label();
            this.pnlSatisOnaylama = new System.Windows.Forms.Panel();
            this.btnHavale = new System.Windows.Forms.Button();
            this.btnNakitKredi = new System.Windows.Forms.Button();
            this.btnKrediKarti = new System.Windows.Forms.Button();
            this.btnVeresiye = new System.Windows.Forms.Button();
            this.btnNakit = new System.Windows.Forms.Button();
            this.lblSatisOnaylama = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlTop.SuspendLayout();
            this.pnlBarkod.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisListesi)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlHizliSatis.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlKasa.SuspendLayout();
            this.pnlFis.SuspendLayout();
            this.pnlToplam.SuspendLayout();
            this.pnlSatisOnaylama.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnSatisIptal);
            this.pnlTop.Controls.Add(this.btnUrunAra);
            this.pnlTop.Controls.Add(this.pnlBarkod);
            this.pnlTop.Controls.Add(this.btnMusteriSec);
            this.pnlTop.Controls.Add(this.lblSelectedCustomerName);
            this.pnlTop.Controls.Add(this.lblSelectedCustomerDebt);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1400, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Location = new System.Drawing.Point(640, 35);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(100, 60);
            this.btnSatisIptal.TabIndex = 5;
            this.btnSatisIptal.Text = "Satışı İptal Et";
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.Location = new System.Drawing.Point(530, 35);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(100, 60);
            this.btnUrunAra.TabIndex = 4;
            this.btnUrunAra.Text = "Ürün Adı İle Arama (F2)";
            this.btnUrunAra.UseVisualStyleBackColor = true;
            // 
            // pnlBarkod
            // 
            this.pnlBarkod.Controls.Add(this.txtMiktar);
            this.pnlBarkod.Controls.Add(this.lblMiktar);
            this.pnlBarkod.Controls.Add(this.txtBarkod);
            this.pnlBarkod.Controls.Add(this.lblBarkod);
            this.pnlBarkod.Location = new System.Drawing.Point(160, 35);
            this.pnlBarkod.Name = "pnlBarkod";
            this.pnlBarkod.Size = new System.Drawing.Size(250, 60);
            this.pnlBarkod.TabIndex = 2;
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.Color.Turquoise;
            this.txtMiktar.Location = new System.Drawing.Point(4, 30);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(50, 20);
            this.txtMiktar.TabIndex = 3;
            this.txtMiktar.Text = "1";
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(4, 10);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(60, 13);
            this.lblMiktar.TabIndex = 2;
            this.lblMiktar.Text = "Miktarı (F3)";
            // 
            // txtBarkod
            // 
            this.txtBarkod.BackColor = System.Drawing.Color.Yellow;
            this.txtBarkod.Location = new System.Drawing.Point(60, 30);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(180, 20);
            this.txtBarkod.TabIndex = 1;
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(60, 10);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(83, 13);
            this.lblBarkod.TabIndex = 0;
            this.lblBarkod.Text = "Barkod Okutun";
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.Location = new System.Drawing.Point(12, 35);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(140, 60);
            this.btnMusteriSec.TabIndex = 3;
            this.btnMusteriSec.Text = "Müşteri Seç (F8)";
            this.btnMusteriSec.UseVisualStyleBackColor = true;
            // 
            // lblSelectedCustomerName
            // 
            this.lblSelectedCustomerName.AutoSize = true;
            this.lblSelectedCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelectedCustomerName.ForeColor = System.Drawing.Color.Green;
            this.lblSelectedCustomerName.Location = new System.Drawing.Point(160, 10);
            this.lblSelectedCustomerName.Name = "lblSelectedCustomerName";
            this.lblSelectedCustomerName.Size = new System.Drawing.Size(144, 20);
            this.lblSelectedCustomerName.TabIndex = 6;
            this.lblSelectedCustomerName.Text = "Perakende Satış";
            // 
            // lblSelectedCustomerDebt
            // 
            this.lblSelectedCustomerDebt.AutoSize = true;
            this.lblSelectedCustomerDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelectedCustomerDebt.ForeColor = System.Drawing.Color.Red;
            this.lblSelectedCustomerDebt.Location = new System.Drawing.Point(350, 10);
            this.lblSelectedCustomerDebt.Name = "lblSelectedCustomerDebt";
            this.lblSelectedCustomerDebt.Size = new System.Drawing.Size(49, 20);
            this.lblSelectedCustomerDebt.TabIndex = 7;
            this.lblSelectedCustomerDebt.Text = "0,00";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvSatisListesi);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1100, 481);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvSatisListesi
            // 
            this.dgvSatisListesi.BackgroundColor = System.Drawing.Color.Orange;
            this.dgvSatisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatisListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSatisListesi.Location = new System.Drawing.Point(0, 0);
            this.dgvSatisListesi.Name = "dgvSatisListesi";
            this.dgvSatisListesi.Size = new System.Drawing.Size(964, 481);
            this.dgvSatisListesi.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlHizliSatis);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(964, 100);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(300, 481);
            this.pnlRight.TabIndex = 2;
            // 
            // pnlHizliSatis
            // 
            this.pnlHizliSatis.Controls.Add(this.btnTuslariDegistir);
            this.pnlHizliSatis.Controls.Add(this.btnTuslariSil);
            this.pnlHizliSatis.Controls.Add(this.btnStoksuzSatis);
            this.pnlHizliSatis.Controls.Add(this.lblHizliSatis);
            this.pnlHizliSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHizliSatis.Location = new System.Drawing.Point(0, 0);
            this.pnlHizliSatis.Name = "pnlHizliSatis";
            this.pnlHizliSatis.Size = new System.Drawing.Size(300, 481);
            this.pnlHizliSatis.TabIndex = 0;
            // 
            // btnStoksuzSatis
            // 
            this.btnStoksuzSatis.Location = new System.Drawing.Point(10, 30);
            this.btnStoksuzSatis.Name = "btnStoksuzSatis";
            this.btnStoksuzSatis.Size = new System.Drawing.Size(120, 35);
            this.btnStoksuzSatis.TabIndex = 2;
            this.btnStoksuzSatis.Text = "STOKSUZ ÜRÜN SAT";
            this.btnStoksuzSatis.UseVisualStyleBackColor = true;
            // 
            // lblHizliSatis
            // 
            this.lblHizliSatis.AutoSize = true;
            this.lblHizliSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHizliSatis.Location = new System.Drawing.Point(70, 5);
            this.lblHizliSatis.Name = "lblHizliSatis";
            this.lblHizliSatis.Size = new System.Drawing.Size(167, 20);
            this.lblHizliSatis.TabIndex = 0;
            this.lblHizliSatis.Text = "HIZLI SATIŞ TUŞLARI";
            // 
            // btnTuslariSil
            // 
            this.btnTuslariSil.Image = global::StokTakip.Properties.Resources.delete_button;
            this.btnTuslariSil.Location = new System.Drawing.Point(190, 440);
            this.btnTuslariSil.Name = "btnTuslariSil";
            this.btnTuslariSil.Size = new System.Drawing.Size(100, 35);
            this.btnTuslariSil.TabIndex = 3;
            this.btnTuslariSil.Text = "Tuşları Sil";
            this.btnTuslariSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTuslariSil.UseVisualStyleBackColor = true;
            // 
            // btnTuslariDegistir
            // 
            this.btnTuslariDegistir.Image = global::StokTakip.Properties.Resources.refresh_button;
            this.btnTuslariDegistir.Location = new System.Drawing.Point(10, 440);
            this.btnTuslariDegistir.Name = "btnTuslariDegistir";
            this.btnTuslariDegistir.Size = new System.Drawing.Size(100, 35);
            this.btnTuslariDegistir.TabIndex = 4;
            this.btnTuslariDegistir.Text = "Tuşları Değiştir";
            this.btnTuslariDegistir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTuslariDegistir.UseVisualStyleBackColor = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlKasa);
            this.pnlBottom.Controls.Add(this.pnlFis);
            this.pnlBottom.Controls.Add(this.pnlToplam);
            this.pnlBottom.Controls.Add(this.pnlSatisOnaylama);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 581);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1400, 100);
            this.pnlBottom.TabIndex = 3;
            // 
            // pnlKasa
            // 
            this.pnlKasa.Controls.Add(this.txtKar);
            this.pnlKasa.Controls.Add(this.lblKar);
            this.pnlKasa.Controls.Add(this.chkKarGoster);
            this.pnlKasa.Controls.Add(this.txtParaUstu);
            this.pnlKasa.Controls.Add(this.lblParaUstu);
            this.pnlKasa.Controls.Add(this.txtAlinanPara);
            this.pnlKasa.Controls.Add(this.lblAlinanPara);
            this.pnlKasa.Controls.Add(this.lblIsletmeSahibi);
            this.pnlKasa.Controls.Add(this.lblKasiyer);
            this.pnlKasa.Location = new System.Drawing.Point(830, 6);
            this.pnlKasa.Name = "pnlKasa";
            this.pnlKasa.Size = new System.Drawing.Size(420, 90);
            this.pnlKasa.TabIndex = 3;
            // 
            // txtKar
            // 
            this.txtKar.BackColor = System.Drawing.Color.Yellow;
            this.txtKar.Location = new System.Drawing.Point(310, 60);
            this.txtKar.Name = "txtKar";
            this.txtKar.ReadOnly = true;
            this.txtKar.Size = new System.Drawing.Size(100, 20);
            this.txtKar.TabIndex = 8;
            // 
            // lblKar
            // 
            this.lblKar.AutoSize = true;
            this.lblKar.Location = new System.Drawing.Point(180, 65);
            this.lblKar.Name = "lblKar";
            this.lblKar.Size = new System.Drawing.Size(126, 13);
            this.lblKar.TabIndex = 7;
            this.lblKar.Text = "Bu Satıştan Elde Edilecek Kâr";
            // 
            // chkKarGoster
            // 
            this.chkKarGoster.AutoSize = true;
            this.chkKarGoster.Location = new System.Drawing.Point(120, 40);
            this.chkKarGoster.Name = "chkKarGoster";
            this.chkKarGoster.Size = new System.Drawing.Size(89, 17);
            this.chkKarGoster.TabIndex = 6;
            this.chkKarGoster.Text = "KÂR Görünsün";
            this.chkKarGoster.UseVisualStyleBackColor = true;
            // 
            // txtParaUstu
            // 
            this.txtParaUstu.BackColor = System.Drawing.Color.Blue;
            this.txtParaUstu.ForeColor = System.Drawing.Color.White;
            this.txtParaUstu.Location = new System.Drawing.Point(310, 35);
            this.txtParaUstu.Name = "txtParaUstu";
            this.txtParaUstu.ReadOnly = true;
            this.txtParaUstu.Size = new System.Drawing.Size(100, 20);
            this.txtParaUstu.TabIndex = 5;
            // 
            // lblParaUstu
            // 
            this.lblParaUstu.AutoSize = true;
            this.lblParaUstu.Location = new System.Drawing.Point(250, 40);
            this.lblParaUstu.Name = "lblParaUstu";
            this.lblParaUstu.Size = new System.Drawing.Size(54, 13);
            this.lblParaUstu.TabIndex = 4;
            this.lblParaUstu.Text = "Para Üstü";
            // 
            // txtAlinanPara
            // 
            this.txtAlinanPara.BackColor = System.Drawing.Color.Lime;
            this.txtAlinanPara.Location = new System.Drawing.Point(310, 10);
            this.txtAlinanPara.Name = "txtAlinanPara";
            this.txtAlinanPara.Size = new System.Drawing.Size(100, 20);
            this.txtAlinanPara.TabIndex = 3;
            // 
            // lblAlinanPara
            // 
            this.lblAlinanPara.AutoSize = true;
            this.lblAlinanPara.Location = new System.Drawing.Point(220, 15);
            this.lblAlinanPara.Name = "lblAlinanPara";
            this.lblAlinanPara.Size = new System.Drawing.Size(84, 13);
            this.lblAlinanPara.TabIndex = 2;
            this.lblAlinanPara.Text = "Alınan Para (F5)";
            // 
            // lblIsletmeSahibi
            // 
            this.lblIsletmeSahibi.AutoSize = true;
            this.lblIsletmeSahibi.Location = new System.Drawing.Point(100, 15);
            this.lblIsletmeSahibi.Name = "lblIsletmeSahibi";
            this.lblIsletmeSahibi.Size = new System.Drawing.Size(89, 13);
            this.lblIsletmeSahibi.TabIndex = 1;
            this.lblIsletmeSahibi.Text = "İŞLETME SAHİBİ";
            // 
            // lblKasiyer
            // 
            this.lblKasiyer.AutoSize = true;
            this.lblKasiyer.Location = new System.Drawing.Point(10, 15);
            this.lblKasiyer.Name = "lblKasiyer";
            this.lblKasiyer.Size = new System.Drawing.Size(41, 13);
            this.lblKasiyer.TabIndex = 0;
            this.lblKasiyer.Text = "Kasiyer";
            // 
            // pnlFis
            // 
            this.pnlFis.Controls.Add(this.btnSatisBilgisiYazdir);
            this.pnlFis.Controls.Add(this.btnEskiFisler);
            this.pnlFis.Location = new System.Drawing.Point(630, 6);
            this.pnlFis.Name = "pnlFis";
            this.pnlFis.Size = new System.Drawing.Size(190, 90);
            this.pnlFis.TabIndex = 2;
            // 
            // btnSatisBilgisiYazdir
            // 
            this.btnSatisBilgisiYazdir.Location = new System.Drawing.Point(10, 50);
            this.btnSatisBilgisiYazdir.Name = "btnSatisBilgisiYazdir";
            this.btnSatisBilgisiYazdir.Size = new System.Drawing.Size(170, 35);
            this.btnSatisBilgisiYazdir.TabIndex = 1;
            this.btnSatisBilgisiYazdir.Text = "Satış Bilgisi Yazdır";
            this.btnSatisBilgisiYazdir.UseVisualStyleBackColor = true;
            // 
            // btnEskiFisler
            // 
            this.btnEskiFisler.Location = new System.Drawing.Point(10, 10);
            this.btnEskiFisler.Name = "btnEskiFisler";
            this.btnEskiFisler.Size = new System.Drawing.Size(170, 35);
            this.btnEskiFisler.TabIndex = 0;
            this.btnEskiFisler.Text = "Eski Fişler";
            this.btnEskiFisler.UseVisualStyleBackColor = true;
            // 
            // pnlToplam
            // 
            this.pnlToplam.BackColor = System.Drawing.Color.Turquoise;
            this.pnlToplam.Controls.Add(this.lblToplam);
            this.pnlToplam.Location = new System.Drawing.Point(420, 6);
            this.pnlToplam.Name = "pnlToplam";
            this.pnlToplam.Size = new System.Drawing.Size(200, 90);
            this.pnlToplam.TabIndex = 1;
            // 
            // lblToplam
            // 
            this.lblToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(0, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(200, 90);
            this.lblToplam.TabIndex = 0;
            this.lblToplam.Text = "0,00";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSatisOnaylama
            // 
            this.pnlSatisOnaylama.Controls.Add(this.btnHavale);
            this.pnlSatisOnaylama.Controls.Add(this.btnNakitKredi);
            this.pnlSatisOnaylama.Controls.Add(this.btnKrediKarti);
            this.pnlSatisOnaylama.Controls.Add(this.btnVeresiye);
            this.pnlSatisOnaylama.Controls.Add(this.btnNakit);
            this.pnlSatisOnaylama.Controls.Add(this.lblSatisOnaylama);
            this.pnlSatisOnaylama.Location = new System.Drawing.Point(20, 6);
            this.pnlSatisOnaylama.Name = "pnlSatisOnaylama";
            this.pnlSatisOnaylama.Size = new System.Drawing.Size(600, 90);
            this.pnlSatisOnaylama.TabIndex = 0;
            // 
            // btnHavale
            // 
            this.btnHavale.Location = new System.Drawing.Point(280, 26);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(110, 40);
            this.btnHavale.TabIndex = 5;
            this.btnHavale.Text = "Havale İle Satış";
            this.btnHavale.UseVisualStyleBackColor = true;
            // 
            // btnNakitKredi
            // 
            this.btnNakitKredi.Location = new System.Drawing.Point(140, 65);
            this.btnNakitKredi.Name = "btnNakitKredi";
            this.btnNakitKredi.Size = new System.Drawing.Size(130, 35);
            this.btnNakitKredi.TabIndex = 4;
            this.btnNakitKredi.Text = "Nakit + Kredi Kartı (F10)";
            this.btnNakitKredi.UseVisualStyleBackColor = true;
            // 
            // btnKrediKarti
            // 
            this.btnKrediKarti.Location = new System.Drawing.Point(4, 65);
            this.btnKrediKarti.Name = "btnKrediKarti";
            this.btnKrediKarti.Size = new System.Drawing.Size(130, 35);
            this.btnKrediKarti.TabIndex = 3;
            this.btnKrediKarti.Text = "Kredi Kartı (F9)";
            this.btnKrediKarti.UseVisualStyleBackColor = true;
            // 
            // btnVeresiye
            // 
            this.btnVeresiye.Location = new System.Drawing.Point(140, 26);
            this.btnVeresiye.Name = "btnVeresiye";
            this.btnVeresiye.Size = new System.Drawing.Size(130, 35);
            this.btnVeresiye.TabIndex = 2;
            this.btnVeresiye.Text = "Veresiye Satış (F6)";
            this.btnVeresiye.UseVisualStyleBackColor = true;
            // 
            // btnNakit
            // 
            this.btnNakit.Location = new System.Drawing.Point(4, 26);
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.Size = new System.Drawing.Size(130, 35);
            this.btnNakit.TabIndex = 1;
            this.btnNakit.Text = "Nakit Satış (F1)";
            this.btnNakit.UseVisualStyleBackColor = true;
            // 
            // lblSatisOnaylama
            // 
            this.lblSatisOnaylama.AutoSize = true;
            this.lblSatisOnaylama.BackColor = System.Drawing.Color.Green;
            this.lblSatisOnaylama.ForeColor = System.Drawing.Color.White;
            this.lblSatisOnaylama.Location = new System.Drawing.Point(4, 4);
            this.lblSatisOnaylama.Name = "lblSatisOnaylama";
            this.lblSatisOnaylama.Size = new System.Drawing.Size(98, 13);
            this.lblSatisOnaylama.TabIndex = 0;
            this.lblSatisOnaylama.Text = "SATIŞI ONAYLAMA";
            // 
            // SatisIslemiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "SatisIslemiForm";
            this.Text = "SATIŞ İŞLEMİ";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBarkod.ResumeLayout(false);
            this.pnlBarkod.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisListesi)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlHizliSatis.ResumeLayout(false);
            this.pnlHizliSatis.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlKasa.ResumeLayout(false);
            this.pnlKasa.PerformLayout();
            this.pnlFis.ResumeLayout(false);
            this.pnlFis.PerformLayout();
            this.pnlToplam.ResumeLayout(false);
            this.pnlSatisOnaylama.ResumeLayout(false);
            this.pnlSatisOnaylama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.Panel pnlBarkod;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Label lblSelectedCustomerName;
        private System.Windows.Forms.Label lblSelectedCustomerDebt;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvSatisListesi;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlHizliSatis;
        private System.Windows.Forms.Label lblHizliSatis;
        private System.Windows.Forms.Button btnStoksuzSatis;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlSatisOnaylama;
        private System.Windows.Forms.Label lblSatisOnaylama;
        private System.Windows.Forms.Button btnNakit;
        private System.Windows.Forms.Button btnVeresiye;
        private System.Windows.Forms.Button btnKrediKarti;
        private System.Windows.Forms.Button btnNakitKredi;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.Panel pnlToplam;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.CheckBox chkKarGoster;
        private System.Windows.Forms.Panel pnlFis;
        private System.Windows.Forms.Button btnSatisBilgisiYazdir;
        private System.Windows.Forms.Button btnEskiFisler;
        private System.Windows.Forms.Panel pnlKasa;
        private System.Windows.Forms.Label lblKasiyer;
        private System.Windows.Forms.Label lblIsletmeSahibi;
        private System.Windows.Forms.Label lblAlinanPara;
        private System.Windows.Forms.TextBox txtAlinanPara;
        private System.Windows.Forms.Label lblParaUstu;
        private System.Windows.Forms.TextBox txtParaUstu;
        private System.Windows.Forms.Label lblKar;
        private System.Windows.Forms.TextBox txtKar;
        private System.Windows.Forms.Button btnTuslariSil;
        private System.Windows.Forms.Button btnTuslariDegistir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
