namespace StokTakip.Forms
{
    partial class UrunAyrintisiForm
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
            this.gbRaporTuru = new System.Windows.Forms.GroupBox();
            this.rbSadeceAlislar = new System.Windows.Forms.RadioButton();
            this.rbSadeceSatislar = new System.Windows.Forms.RadioButton();
            this.rbSadeceIadeAlinanlar = new System.Windows.Forms.RadioButton();
            this.rbSadeceIadeEdilenler = new System.Windows.Forms.RadioButton();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.gbUrunGirisi = new System.Windows.Forms.GroupBox();
            this.lblUrunGirisiTutar = new System.Windows.Forms.Label();
            this.lblUrunGirisiAdet = new System.Windows.Forms.Label();
            this.lblToplamTutarUG = new System.Windows.Forms.Label();
            this.lblToplamAdetUG = new System.Windows.Forms.Label();
            this.gbSatislar = new System.Windows.Forms.GroupBox();
            this.lblSatislarTutar = new System.Windows.Forms.Label();
            this.lblSatislarAdet = new System.Windows.Forms.Label();
            this.lblToplamTutarS = new System.Windows.Forms.Label();
            this.lblToplamAdetS = new System.Windows.Forms.Label();
            this.gbIadeEdilen = new System.Windows.Forms.GroupBox();
            this.lblIadeEdilenTutar = new System.Windows.Forms.Label();
            this.lblIadeEdilenAdet = new System.Windows.Forms.Label();
            this.lblToplamTutarIE = new System.Windows.Forms.Label();
            this.lblToplamAdetIE = new System.Windows.Forms.Label();
            this.gbIadeAlinan = new System.Windows.Forms.GroupBox();
            this.lblIadeAlinanTutar = new System.Windows.Forms.Label();
            this.lblIadeAlinanAdet = new System.Windows.Forms.Label();
            this.lblToplamTutarIA = new System.Windows.Forms.Label();
            this.lblToplamAdetIA = new System.Windows.Forms.Label();
            this.dgvHareketler = new System.Windows.Forms.DataGridView();
            this.colSiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHareketTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCariHesapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSatisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRaporTuru.SuspendLayout();
            this.gbUrunGirisi.SuspendLayout();
            this.gbSatislar.SuspendLayout();
            this.gbIadeEdilen.SuspendLayout();
            this.gbIadeAlinan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTarihAraliklari
            // 
            this.lblTarihAraliklari.AutoSize = true;
            this.lblTarihAraliklari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTarihAraliklari.Location = new System.Drawing.Point(20, 20);
            this.lblTarihAraliklari.Name = "lblTarihAraliklari";
            this.lblTarihAraliklari.Size = new System.Drawing.Size(98, 15);
            this.lblTarihAraliklari.TabIndex = 0;
            this.lblTarihAraliklari.Text = "Tarih Aralıkları";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(25, 45);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(100, 20);
            this.dtpBaslangic.TabIndex = 1;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(140, 45);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(100, 20);
            this.dtpBitis.TabIndex = 2;
            // 
            // gbRaporTuru
            // 
            this.gbRaporTuru.Controls.Add(this.rbSadeceIadeEdilenler);
            this.gbRaporTuru.Controls.Add(this.rbSadeceIadeAlinanlar);
            this.gbRaporTuru.Controls.Add(this.rbSadeceSatislar);
            this.gbRaporTuru.Controls.Add(this.rbSadeceAlislar);
            this.gbRaporTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbRaporTuru.Location = new System.Drawing.Point(290, 20);
            this.gbRaporTuru.Name = "gbRaporTuru";
            this.gbRaporTuru.Size = new System.Drawing.Size(200, 120);
            this.gbRaporTuru.TabIndex = 3;
            this.gbRaporTuru.TabStop = false;
            this.gbRaporTuru.Text = "Rapor Türü";
            // 
            // rbSadeceAlislar
            // 
            this.rbSadeceAlislar.AutoSize = true;
            this.rbSadeceAlislar.ForeColor = System.Drawing.Color.Blue;
            this.rbSadeceAlislar.Location = new System.Drawing.Point(10, 25);
            this.rbSadeceAlislar.Name = "rbSadeceAlislar";
            this.rbSadeceAlislar.Size = new System.Drawing.Size(118, 17);
            this.rbSadeceAlislar.TabIndex = 0;
            this.rbSadeceAlislar.Text = "Sadece Satışlar";
            this.rbSadeceAlislar.UseVisualStyleBackColor = true;
            // 
            // rbSadeceSatislar
            // 
            this.rbSadeceSatislar.AutoSize = true;
            this.rbSadeceSatislar.ForeColor = System.Drawing.Color.Blue;
            this.rbSadeceSatislar.Location = new System.Drawing.Point(10, 45);
            this.rbSadeceSatislar.Name = "rbSadeceSatislar";
            this.rbSadeceSatislar.Size = new System.Drawing.Size(114, 17);
            this.rbSadeceSatislar.TabIndex = 1;
            this.rbSadeceSatislar.Text = "Sadece Alışlar";
            this.rbSadeceSatislar.UseVisualStyleBackColor = true;
            // 
            // rbSadeceIadeAlinanlar
            // 
            this.rbSadeceIadeAlinanlar.AutoSize = true;
            this.rbSadeceIadeAlinanlar.ForeColor = System.Drawing.Color.Blue;
            this.rbSadeceIadeAlinanlar.Location = new System.Drawing.Point(10, 65);
            this.rbSadeceIadeAlinanlar.Name = "rbSadeceIadeAlinanlar";
            this.rbSadeceIadeAlinanlar.Size = new System.Drawing.Size(162, 17);
            this.rbSadeceIadeAlinanlar.TabIndex = 2;
            this.rbSadeceIadeAlinanlar.Text = "Sadece İade Alınanlar";
            this.rbSadeceIadeAlinanlar.UseVisualStyleBackColor = true;
            // 
            // rbSadeceIadeEdilenler
            // 
            this.rbSadeceIadeEdilenler.AutoSize = true;
            this.rbSadeceIadeEdilenler.ForeColor = System.Drawing.Color.Blue;
            this.rbSadeceIadeEdilenler.Location = new System.Drawing.Point(10, 85);
            this.rbSadeceIadeEdilenler.Name = "rbSadeceIadeEdilenler";
            this.rbSadeceIadeEdilenler.Size = new System.Drawing.Size(156, 17);
            this.rbSadeceIadeEdilenler.TabIndex = 3;
            this.rbSadeceIadeEdilenler.Text = "Sadece İade Edilenler";
            this.rbSadeceIadeEdilenler.UseVisualStyleBackColor = true;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.LightGray;
            this.btnYazdir.Location = new System.Drawing.Point(20, 160);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(80, 40);
            this.btnYazdir.TabIndex = 4;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.BackColor = System.Drawing.Color.LightGreen;
            this.btnExcelAktar.Location = new System.Drawing.Point(110, 160);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(80, 40);
            this.btnExcelAktar.TabIndex = 5;
            this.btnExcelAktar.Text = "Excel'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = false;
            // 
            // gbUrunGirisi
            // 
            this.gbUrunGirisi.BackColor = System.Drawing.Color.Red;
            this.gbUrunGirisi.Controls.Add(this.lblToplamAdetUG);
            this.gbUrunGirisi.Controls.Add(this.lblToplamTutarUG);
            this.gbUrunGirisi.Controls.Add(this.lblUrunGirisiAdet);
            this.gbUrunGirisi.Controls.Add(this.lblUrunGirisiTutar);
            this.gbUrunGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbUrunGirisi.ForeColor = System.Drawing.Color.White;
            this.gbUrunGirisi.Location = new System.Drawing.Point(700, 50);
            this.gbUrunGirisi.Name = "gbUrunGirisi";
            this.gbUrunGirisi.Size = new System.Drawing.Size(150, 80);
            this.gbUrunGirisi.TabIndex = 6;
            this.gbUrunGirisi.TabStop = false;
            this.gbUrunGirisi.Text = "ÜRÜN GİRİŞİ";
            // 
            // lblUrunGirisiTutar
            // 
            this.lblUrunGirisiTutar.BackColor = System.Drawing.Color.Red;
            this.lblUrunGirisiTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrunGirisiTutar.ForeColor = System.Drawing.Color.White;
            this.lblUrunGirisiTutar.Location = new System.Drawing.Point(75, 20);
            this.lblUrunGirisiTutar.Name = "lblUrunGirisiTutar";
            this.lblUrunGirisiTutar.Size = new System.Drawing.Size(70, 20);
            this.lblUrunGirisiTutar.TabIndex = 0;
            this.lblUrunGirisiTutar.Text = "0.00 TL";
            this.lblUrunGirisiTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUrunGirisiAdet
            // 
            this.lblUrunGirisiAdet.BackColor = System.Drawing.Color.Red;
            this.lblUrunGirisiAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrunGirisiAdet.ForeColor = System.Drawing.Color.White;
            this.lblUrunGirisiAdet.Location = new System.Drawing.Point(75, 50);
            this.lblUrunGirisiAdet.Name = "lblUrunGirisiAdet";
            this.lblUrunGirisiAdet.Size = new System.Drawing.Size(70, 20);
            this.lblUrunGirisiAdet.TabIndex = 1;
            this.lblUrunGirisiAdet.Text = "0";
            this.lblUrunGirisiAdet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblToplamTutarUG
            // 
            this.lblToplamTutarUG.AutoSize = true;
            this.lblToplamTutarUG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamTutarUG.Location = new System.Drawing.Point(10, 24);
            this.lblToplamTutarUG.Name = "lblToplamTutarUG";
            this.lblToplamTutarUG.Size = new System.Drawing.Size(78, 13);
            this.lblToplamTutarUG.TabIndex = 2;
            this.lblToplamTutarUG.Text = "Toplam Tutar";
            // 
            // lblToplamAdetUG
            // 
            this.lblToplamAdetUG.AutoSize = true;
            this.lblToplamAdetUG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamAdetUG.Location = new System.Drawing.Point(10, 54);
            this.lblToplamAdetUG.Name = "lblToplamAdetUG";
            this.lblToplamAdetUG.Size = new System.Drawing.Size(73, 13);
            this.lblToplamAdetUG.TabIndex = 3;
            this.lblToplamAdetUG.Text = "Toplam Adet";
            // 
            // gbSatislar
            // 
            this.gbSatislar.BackColor = System.Drawing.Color.Red;
            this.gbSatislar.Controls.Add(this.lblToplamAdetS);
            this.gbSatislar.Controls.Add(this.lblToplamTutarS);
            this.gbSatislar.Controls.Add(this.lblSatislarAdet);
            this.gbSatislar.Controls.Add(this.lblSatislarTutar);
            this.gbSatislar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSatislar.ForeColor = System.Drawing.Color.White;
            this.gbSatislar.Location = new System.Drawing.Point(950, 50);
            this.gbSatislar.Name = "gbSatislar";
            this.gbSatislar.Size = new System.Drawing.Size(150, 80);
            this.gbSatislar.TabIndex = 7;
            this.gbSatislar.TabStop = false;
            this.gbSatislar.Text = "SATIŞLAR";
            // 
            // lblSatislarTutar
            // 
            this.lblSatislarTutar.BackColor = System.Drawing.Color.Red;
            this.lblSatislarTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSatislarTutar.ForeColor = System.Drawing.Color.White;
            this.lblSatislarTutar.Location = new System.Drawing.Point(75, 20);
            this.lblSatislarTutar.Name = "lblSatislarTutar";
            this.lblSatislarTutar.Size = new System.Drawing.Size(70, 20);
            this.lblSatislarTutar.TabIndex = 0;
            this.lblSatislarTutar.Text = "0.00 TL";
            this.lblSatislarTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSatislarAdet
            // 
            this.lblSatislarAdet.BackColor = System.Drawing.Color.Red;
            this.lblSatislarAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSatislarAdet.ForeColor = System.Drawing.Color.White;
            this.lblSatislarAdet.Location = new System.Drawing.Point(75, 50);
            this.lblSatislarAdet.Name = "lblSatislarAdet";
            this.lblSatislarAdet.Size = new System.Drawing.Size(70, 20);
            this.lblSatislarAdet.TabIndex = 1;
            this.lblSatislarAdet.Text = "0";
            this.lblSatislarAdet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblToplamTutarS
            // 
            this.lblToplamTutarS.AutoSize = true;
            this.lblToplamTutarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamTutarS.Location = new System.Drawing.Point(10, 24);
            this.lblToplamTutarS.Name = "lblToplamTutarS";
            this.lblToplamTutarS.Size = new System.Drawing.Size(78, 13);
            this.lblToplamTutarS.TabIndex = 2;
            this.lblToplamTutarS.Text = "Toplam Tutar";
            // 
            // lblToplamAdetS
            // 
            this.lblToplamAdetS.AutoSize = true;
            this.lblToplamAdetS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamAdetS.Location = new System.Drawing.Point(10, 54);
            this.lblToplamAdetS.Name = "lblToplamAdetS";
            this.lblToplamAdetS.Size = new System.Drawing.Size(73, 13);
            this.lblToplamAdetS.TabIndex = 3;
            this.lblToplamAdetS.Text = "Toplam Adet";
            // 
            // gbIadeEdilen
            // 
            this.gbIadeEdilen.BackColor = System.Drawing.Color.Red;
            this.gbIadeEdilen.Controls.Add(this.lblToplamAdetIE);
            this.gbIadeEdilen.Controls.Add(this.lblToplamTutarIE);
            this.gbIadeEdilen.Controls.Add(this.lblIadeEdilenAdet);
            this.gbIadeEdilen.Controls.Add(this.lblIadeEdilenTutar);
            this.gbIadeEdilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbIadeEdilen.ForeColor = System.Drawing.Color.White;
            this.gbIadeEdilen.Location = new System.Drawing.Point(700, 150);
            this.gbIadeEdilen.Name = "gbIadeEdilen";
            this.gbIadeEdilen.Size = new System.Drawing.Size(150, 80);
            this.gbIadeEdilen.TabIndex = 8;
            this.gbIadeEdilen.TabStop = false;
            this.gbIadeEdilen.Text = "İADE EDİLEN";
            // 
            // lblIadeEdilenTutar
            // 
            this.lblIadeEdilenTutar.BackColor = System.Drawing.Color.Red;
            this.lblIadeEdilenTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIadeEdilenTutar.ForeColor = System.Drawing.Color.White;
            this.lblIadeEdilenTutar.Location = new System.Drawing.Point(75, 20);
            this.lblIadeEdilenTutar.Name = "lblIadeEdilenTutar";
            this.lblIadeEdilenTutar.Size = new System.Drawing.Size(70, 20);
            this.lblIadeEdilenTutar.TabIndex = 0;
            this.lblIadeEdilenTutar.Text = "0.00 TL";
            this.lblIadeEdilenTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIadeEdilenAdet
            // 
            this.lblIadeEdilenAdet.BackColor = System.Drawing.Color.Red;
            this.lblIadeEdilenAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIadeEdilenAdet.ForeColor = System.Drawing.Color.White;
            this.lblIadeEdilenAdet.Location = new System.Drawing.Point(75, 50);
            this.lblIadeEdilenAdet.Name = "lblIadeEdilenAdet";
            this.lblIadeEdilenAdet.Size = new System.Drawing.Size(70, 20);
            this.lblIadeEdilenAdet.TabIndex = 1;
            this.lblIadeEdilenAdet.Text = "0";
            this.lblIadeEdilenAdet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblToplamTutarIE
            // 
            this.lblToplamTutarIE.AutoSize = true;
            this.lblToplamTutarIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamTutarIE.Location = new System.Drawing.Point(10, 24);
            this.lblToplamTutarIE.Name = "lblToplamTutarIE";
            this.lblToplamTutarIE.Size = new System.Drawing.Size(78, 13);
            this.lblToplamTutarIE.TabIndex = 2;
            this.lblToplamTutarIE.Text = "Toplam Tutar";
            // 
            // lblToplamAdetIE
            // 
            this.lblToplamAdetIE.AutoSize = true;
            this.lblToplamAdetIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamAdetIE.Location = new System.Drawing.Point(10, 54);
            this.lblToplamAdetIE.Name = "lblToplamAdetIE";
            this.lblToplamAdetIE.Size = new System.Drawing.Size(73, 13);
            this.lblToplamAdetIE.TabIndex = 3;
            this.lblToplamAdetIE.Text = "Toplam Adet";
            // 
            // gbIadeAlinan
            // 
            this.gbIadeAlinan.BackColor = System.Drawing.Color.Red;
            this.gbIadeAlinan.Controls.Add(this.lblToplamAdetIA);
            this.gbIadeAlinan.Controls.Add(this.lblToplamTutarIA);
            this.gbIadeAlinan.Controls.Add(this.lblIadeAlinanAdet);
            this.gbIadeAlinan.Controls.Add(this.lblIadeAlinanTutar);
            this.gbIadeAlinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbIadeAlinan.ForeColor = System.Drawing.Color.White;
            this.gbIadeAlinan.Location = new System.Drawing.Point(950, 150);
            this.gbIadeAlinan.Name = "gbIadeAlinan";
            this.gbIadeAlinan.Size = new System.Drawing.Size(150, 80);
            this.gbIadeAlinan.TabIndex = 9;
            this.gbIadeAlinan.TabStop = false;
            this.gbIadeAlinan.Text = "İADE ALINAN";
            // 
            // lblIadeAlinanTutar
            // 
            this.lblIadeAlinanTutar.BackColor = System.Drawing.Color.Red;
            this.lblIadeAlinanTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIadeAlinanTutar.ForeColor = System.Drawing.Color.White;
            this.lblIadeAlinanTutar.Location = new System.Drawing.Point(75, 20);
            this.lblIadeAlinanTutar.Name = "lblIadeAlinanTutar";
            this.lblIadeAlinanTutar.Size = new System.Drawing.Size(70, 20);
            this.lblIadeAlinanTutar.TabIndex = 0;
            this.lblIadeAlinanTutar.Text = "0.00 TL";
            this.lblIadeAlinanTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIadeAlinanAdet
            // 
            this.lblIadeAlinanAdet.BackColor = System.Drawing.Color.Red;
            this.lblIadeAlinanAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIadeAlinanAdet.ForeColor = System.Drawing.Color.White;
            this.lblIadeAlinanAdet.Location = new System.Drawing.Point(75, 50);
            this.lblIadeAlinanAdet.Name = "lblIadeAlinanAdet";
            this.lblIadeAlinanAdet.Size = new System.Drawing.Size(70, 20);
            this.lblIadeAlinanAdet.TabIndex = 1;
            this.lblIadeAlinanAdet.Text = "0";
            this.lblIadeAlinanAdet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblToplamTutarIA
            // 
            this.lblToplamTutarIA.AutoSize = true;
            this.lblToplamTutarIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamTutarIA.Location = new System.Drawing.Point(10, 24);
            this.lblToplamTutarIA.Name = "lblToplamTutarIA";
            this.lblToplamTutarIA.Size = new System.Drawing.Size(78, 13);
            this.lblToplamTutarIA.TabIndex = 2;
            this.lblToplamTutarIA.Text = "Toplam Tutar";
            // 
            // lblToplamAdetIA
            // 
            this.lblToplamAdetIA.AutoSize = true;
            this.lblToplamAdetIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamAdetIA.Location = new System.Drawing.Point(10, 54);
            this.lblToplamAdetIA.Name = "lblToplamAdetIA";
            this.lblToplamAdetIA.Size = new System.Drawing.Size(73, 13);
            this.lblToplamAdetIA.TabIndex = 3;
            this.lblToplamAdetIA.Text = "Toplam Adet";
            // 
            // dgvHareketler
            // 
            this.dgvHareketler.AllowUserToAddRows = false;
            this.dgvHareketler.AllowUserToDeleteRows = false;
            this.dgvHareketler.BackgroundColor = System.Drawing.Color.White;
            this.dgvHareketler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSiraNo,
            this.colHareketTuru,
            this.colCariHesapAdi,
            this.colTarih,
            this.colSaat,
            this.colUrunAdi,
            this.colAlisFiyati,
            this.colSatisFiyati,
            this.colMiktar,
            this.colKDV,
            this.colDurum,
            this.colToplamTutar});
            this.dgvHareketler.Location = new System.Drawing.Point(12, 250);
            this.dgvHareketler.Name = "dgvHareketler";
            this.dgvHareketler.ReadOnly = true;
            this.dgvHareketler.RowHeadersVisible = false;
            this.dgvHareketler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHareketler.Size = new System.Drawing.Size(1160, 350);
            this.dgvHareketler.TabIndex = 10;
            // 
            // colSiraNo
            // 
            this.colSiraNo.HeaderText = "Sıra No";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.ReadOnly = true;
            this.colSiraNo.Width = 60;
            // 
            // colHareketTuru
            // 
            this.colHareketTuru.HeaderText = "Hareket Türü";
            this.colHareketTuru.Name = "colHareketTuru";
            this.colHareketTuru.ReadOnly = true;
            this.colHareketTuru.Width = 100;
            // 
            // colCariHesapAdi
            // 
            this.colCariHesapAdi.HeaderText = "Cari Hesap Adı";
            this.colCariHesapAdi.Name = "colCariHesapAdi";
            this.colCariHesapAdi.ReadOnly = true;
            this.colCariHesapAdi.Width = 150;
            // 
            // colTarih
            // 
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.ReadOnly = true;
            this.colTarih.Width = 80;
            // 
            // colSaat
            // 
            this.colSaat.HeaderText = "Saat";
            this.colSaat.Name = "colSaat";
            this.colSaat.ReadOnly = true;
            this.colSaat.Width = 60;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.HeaderText = "Ürün Adı";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.ReadOnly = true;
            this.colUrunAdi.Width = 200;
            // 
            // colAlisFiyati
            // 
            this.colAlisFiyati.HeaderText = "Alış Fiyatı";
            this.colAlisFiyati.Name = "colAlisFiyati";
            this.colAlisFiyati.ReadOnly = true;
            this.colAlisFiyati.Width = 80;
            // 
            // colSatisFiyati
            // 
            this.colSatisFiyati.HeaderText = "Satış Fiyatı";
            this.colSatisFiyati.Name = "colSatisFiyati";
            this.colSatisFiyati.ReadOnly = true;
            this.colSatisFiyati.Width = 80;
            // 
            // colMiktar
            // 
            this.colMiktar.HeaderText = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.ReadOnly = true;
            this.colMiktar.Width = 70;
            // 
            // colKDV
            // 
            this.colKDV.HeaderText = "KDV";
            this.colKDV.Name = "colKDV";
            this.colKDV.ReadOnly = true;
            this.colKDV.Width = 50;
            // 
            // colDurum
            // 
            this.colDurum.HeaderText = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.ReadOnly = true;
            this.colDurum.Width = 80;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.HeaderText = "Toplam Tutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.ReadOnly = true;
            this.colToplamTutar.Width = 100;
            // 
            // UrunAyrintisiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1184, 620);
            this.Controls.Add(this.dgvHareketler);
            this.Controls.Add(this.gbIadeAlinan);
            this.Controls.Add(this.gbIadeEdilen);
            this.Controls.Add(this.gbSatislar);
            this.Controls.Add(this.gbUrunGirisi);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.gbRaporTuru);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.lblTarihAraliklari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunAyrintisiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Ayrıntısı";
            this.gbRaporTuru.ResumeLayout(false);
            this.gbRaporTuru.PerformLayout();
            this.gbUrunGirisi.ResumeLayout(false);
            this.gbUrunGirisi.PerformLayout();
            this.gbSatislar.ResumeLayout(false);
            this.gbSatislar.PerformLayout();
            this.gbIadeEdilen.ResumeLayout(false);
            this.gbIadeEdilen.PerformLayout();
            this.gbIadeAlinan.ResumeLayout(false);
            this.gbIadeAlinan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTarihAraliklari;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.GroupBox gbRaporTuru;
        private System.Windows.Forms.RadioButton rbSadeceAlislar;
        private System.Windows.Forms.RadioButton rbSadeceSatislar;
        private System.Windows.Forms.RadioButton rbSadeceIadeAlinanlar;
        private System.Windows.Forms.RadioButton rbSadeceIadeEdilenler;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnExcelAktar;
        private System.Windows.Forms.GroupBox gbUrunGirisi;
        private System.Windows.Forms.Label lblUrunGirisiTutar;
        private System.Windows.Forms.Label lblUrunGirisiAdet;
        private System.Windows.Forms.Label lblToplamTutarUG;
        private System.Windows.Forms.Label lblToplamAdetUG;
        private System.Windows.Forms.GroupBox gbSatislar;
        private System.Windows.Forms.Label lblSatislarTutar;
        private System.Windows.Forms.Label lblSatislarAdet;
        private System.Windows.Forms.Label lblToplamTutarS;
        private System.Windows.Forms.Label lblToplamAdetS;
        private System.Windows.Forms.GroupBox gbIadeEdilen;
        private System.Windows.Forms.Label lblIadeEdilenTutar;
        private System.Windows.Forms.Label lblIadeEdilenAdet;
        private System.Windows.Forms.Label lblToplamTutarIE;
        private System.Windows.Forms.Label lblToplamAdetIE;
        private System.Windows.Forms.GroupBox gbIadeAlinan;
        private System.Windows.Forms.Label lblIadeAlinanTutar;
        private System.Windows.Forms.Label lblIadeAlinanAdet;
        private System.Windows.Forms.Label lblToplamTutarIA;
        private System.Windows.Forms.Label lblToplamAdetIA;
        private System.Windows.Forms.DataGridView dgvHareketler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHareketTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCariHesapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSatisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplamTutar;
    }
}
