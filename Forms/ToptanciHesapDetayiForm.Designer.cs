namespace StokTakip.Forms
{
    partial class ToptanciHesapDetayiForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlToptanciBilgileri = new System.Windows.Forms.Panel();
            this.lblToptanciAdi = new System.Windows.Forms.Label();
            this.lblMevcutBorc = new System.Windows.Forms.Label();
            this.lblBorcDurumu = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblVergiDairesi = new System.Windows.Forms.Label();
            this.lblVergiNo = new System.Windows.Forms.Label();
            this.lblSonOdemeTarihi = new System.Windows.Forms.Label();
            this.lblSonIslemTarihi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlFiltreler = new System.Windows.Forms.Panel();
            this.chkTarihFiltresi = new System.Windows.Forms.CheckBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.rbTumHareketler = new System.Windows.Forms.RadioButton();
            this.rbSadeceOdemeler = new System.Windows.Forms.RadioButton();
            this.rbSadeceBorclar = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvHareketler = new System.Windows.Forms.DataGridView();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIslemTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBelgeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlacak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOzet = new System.Windows.Forms.Panel();
            this.lblToplamBorcIslem = new System.Windows.Forms.Label();
            this.lblToplamOdemeIslem = new System.Windows.Forms.Label();
            this.lblNetHareket = new System.Windows.Forms.Label();
            this.lblToplamIslem = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.btnBorcEkle = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.pnlToptanciBilgileri.SuspendLayout();
            this.pnlFiltreler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).BeginInit();
            this.pnlOzet.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Orange;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1060, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TOPTANCI HESAP DETAYI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlToptanciBilgileri
            // 
            this.pnlToptanciBilgileri.BackColor = System.Drawing.Color.LightBlue;
            this.pnlToptanciBilgileri.Controls.Add(this.label9);
            this.pnlToptanciBilgileri.Controls.Add(this.label8);
            this.pnlToptanciBilgileri.Controls.Add(this.label7);
            this.pnlToptanciBilgileri.Controls.Add(this.label6);
            this.pnlToptanciBilgileri.Controls.Add(this.label5);
            this.pnlToptanciBilgileri.Controls.Add(this.label4);
            this.pnlToptanciBilgileri.Controls.Add(this.label3);
            this.pnlToptanciBilgileri.Controls.Add(this.label2);
            this.pnlToptanciBilgileri.Controls.Add(this.label1);
            this.pnlToptanciBilgileri.Controls.Add(this.lblSonIslemTarihi);
            this.pnlToptanciBilgileri.Controls.Add(this.lblSonOdemeTarihi);
            this.pnlToptanciBilgileri.Controls.Add(this.lblVergiNo);
            this.pnlToptanciBilgileri.Controls.Add(this.lblVergiDairesi);
            this.pnlToptanciBilgileri.Controls.Add(this.lblEmail);
            this.pnlToptanciBilgileri.Controls.Add(this.lblAdres);
            this.pnlToptanciBilgileri.Controls.Add(this.lblTelefon);
            this.pnlToptanciBilgileri.Controls.Add(this.lblBorcDurumu);
            this.pnlToptanciBilgileri.Controls.Add(this.lblMevcutBorc);
            this.pnlToptanciBilgileri.Controls.Add(this.lblToptanciAdi);
            this.pnlToptanciBilgileri.Location = new System.Drawing.Point(12, 65);
            this.pnlToptanciBilgileri.Name = "pnlToptanciBilgileri";
            this.pnlToptanciBilgileri.Size = new System.Drawing.Size(1060, 120);
            this.pnlToptanciBilgileri.TabIndex = 1;
            // 
            // lblToptanciAdi
            // 
            this.lblToptanciAdi.AutoSize = true;
            this.lblToptanciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblToptanciAdi.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblToptanciAdi.Location = new System.Drawing.Point(150, 15);
            this.lblToptanciAdi.Name = "lblToptanciAdi";
            this.lblToptanciAdi.Size = new System.Drawing.Size(135, 20);
            this.lblToptanciAdi.TabIndex = 0;
            this.lblToptanciAdi.Text = "Toptancı Adı";
            // 
            // lblMevcutBorc
            // 
            this.lblMevcutBorc.AutoSize = true;
            this.lblMevcutBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblMevcutBorc.Location = new System.Drawing.Point(650, 15);
            this.lblMevcutBorc.Name = "lblMevcutBorc";
            this.lblMevcutBorc.Size = new System.Drawing.Size(66, 24);
            this.lblMevcutBorc.TabIndex = 1;
            this.lblMevcutBorc.Text = "0,00 TL";
            // 
            // lblBorcDurumu
            // 
            this.lblBorcDurumu.AutoSize = true;
            this.lblBorcDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblBorcDurumu.Location = new System.Drawing.Point(800, 20);
            this.lblBorcDurumu.Name = "lblBorcDurumu";
            this.lblBorcDurumu.Size = new System.Drawing.Size(86, 17);
            this.lblBorcDurumu.TabIndex = 2;
            this.lblBorcDurumu.Text = "BORÇ YOK";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTelefon.Location = new System.Drawing.Point(150, 45);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(53, 15);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAdres.Location = new System.Drawing.Point(150, 65);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(39, 15);
            this.lblAdres.TabIndex = 4;
            this.lblAdres.Text = "Adres";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEmail.Location = new System.Drawing.Point(150, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail";
            // 
            // lblVergiDairesi
            // 
            this.lblVergiDairesi.AutoSize = true;
            this.lblVergiDairesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblVergiDairesi.Location = new System.Drawing.Point(650, 50);
            this.lblVergiDairesi.Name = "lblVergiDairesi";
            this.lblVergiDairesi.Size = new System.Drawing.Size(78, 15);
            this.lblVergiDairesi.TabIndex = 6;
            this.lblVergiDairesi.Text = "Vergi Dairesi";
            // 
            // lblVergiNo
            // 
            this.lblVergiNo.AutoSize = true;
            this.lblVergiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblVergiNo.Location = new System.Drawing.Point(650, 70);
            this.lblVergiNo.Name = "lblVergiNo";
            this.lblVergiNo.Size = new System.Drawing.Size(56, 15);
            this.lblVergiNo.TabIndex = 7;
            this.lblVergiNo.Text = "Vergi No";
            // 
            // lblSonOdemeTarihi
            // 
            this.lblSonOdemeTarihi.AutoSize = true;
            this.lblSonOdemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSonOdemeTarihi.Location = new System.Drawing.Point(650, 90);
            this.lblSonOdemeTarihi.Name = "lblSonOdemeTarihi";
            this.lblSonOdemeTarihi.Size = new System.Drawing.Size(103, 15);
            this.lblSonOdemeTarihi.TabIndex = 8;
            this.lblSonOdemeTarihi.Text = "Son Ödeme Tarihi";
            // 
            // lblSonIslemTarihi
            // 
            this.lblSonIslemTarihi.AutoSize = true;
            this.lblSonIslemTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSonIslemTarihi.Location = new System.Drawing.Point(950, 50);
            this.lblSonIslemTarihi.Name = "lblSonIslemTarihi";
            this.lblSonIslemTarihi.Size = new System.Drawing.Size(94, 15);
            this.lblSonIslemTarihi.TabIndex = 9;
            this.lblSonIslemTarihi.Text = "Son İşlem Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Toptancı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(520, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mevcut Borç:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(15, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(520, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vergi Dairesi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(520, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vergi No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(520, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Son Ödeme Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(830, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Son İşlem Tarihi:";
            // 
            // pnlFiltreler
            // 
            this.pnlFiltreler.BackColor = System.Drawing.Color.LightGray;
            this.pnlFiltreler.Controls.Add(this.label11);
            this.pnlFiltreler.Controls.Add(this.label10);
            this.pnlFiltreler.Controls.Add(this.rbSadeceBorclar);
            this.pnlFiltreler.Controls.Add(this.rbSadeceOdemeler);
            this.pnlFiltreler.Controls.Add(this.rbTumHareketler);
            this.pnlFiltreler.Controls.Add(this.dtpBitis);
            this.pnlFiltreler.Controls.Add(this.dtpBaslangic);
            this.pnlFiltreler.Controls.Add(this.chkTarihFiltresi);
            this.pnlFiltreler.Location = new System.Drawing.Point(12, 200);
            this.pnlFiltreler.Name = "pnlFiltreler";
            this.pnlFiltreler.Size = new System.Drawing.Size(1060, 60);
            this.pnlFiltreler.TabIndex = 2;
            // 
            // chkTarihFiltresi
            // 
            this.chkTarihFiltresi.AutoSize = true;
            this.chkTarihFiltresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.chkTarihFiltresi.Location = new System.Drawing.Point(15, 20);
            this.chkTarihFiltresi.Name = "chkTarihFiltresi";
            this.chkTarihFiltresi.Size = new System.Drawing.Size(108, 19);
            this.chkTarihFiltresi.TabIndex = 0;
            this.chkTarihFiltresi.Text = "Tarih Filtresi:";
            this.chkTarihFiltresi.UseVisualStyleBackColor = true;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Enabled = false;
            this.dtpBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(140, 18);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(100, 21);
            this.dtpBaslangic.TabIndex = 1;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Enabled = false;
            this.dtpBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(280, 18);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(100, 21);
            this.dtpBitis.TabIndex = 2;
            // 
            // rbTumHareketler
            // 
            this.rbTumHareketler.AutoSize = true;
            this.rbTumHareketler.Checked = true;
            this.rbTumHareketler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbTumHareketler.Location = new System.Drawing.Point(550, 20);
            this.rbTumHareketler.Name = "rbTumHareketler";
            this.rbTumHareketler.Size = new System.Drawing.Size(110, 19);
            this.rbTumHareketler.TabIndex = 3;
            this.rbTumHareketler.TabStop = true;
            this.rbTumHareketler.Text = "Tüm Hareketler";
            this.rbTumHareketler.UseVisualStyleBackColor = true;
            // 
            // rbSadeceOdemeler
            // 
            this.rbSadeceOdemeler.AutoSize = true;
            this.rbSadeceOdemeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbSadeceOdemeler.Location = new System.Drawing.Point(680, 20);
            this.rbSadeceOdemeler.Name = "rbSadeceOdemeler";
            this.rbSadeceOdemeler.Size = new System.Drawing.Size(119, 19);
            this.rbSadeceOdemeler.TabIndex = 4;
            this.rbSadeceOdemeler.Text = "Sadece Ödemeler";
            this.rbSadeceOdemeler.UseVisualStyleBackColor = true;
            // 
            // rbSadeceBorclar
            // 
            this.rbSadeceBorclar.AutoSize = true;
            this.rbSadeceBorclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbSadeceBorclar.Location = new System.Drawing.Point(820, 20);
            this.rbSadeceBorclar.Name = "rbSadeceBorclar";
            this.rbSadeceBorclar.Size = new System.Drawing.Size(105, 19);
            this.rbSadeceBorclar.TabIndex = 5;
            this.rbSadeceBorclar.Text = "Sadece Borçlar";
            this.rbSadeceBorclar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.Location = new System.Drawing.Point(250, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = " - ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(430, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "İşlem Filtresi:";
            // 
            // dgvHareketler
            // 
            this.dgvHareketler.AllowUserToAddRows = false;
            this.dgvHareketler.AllowUserToDeleteRows = false;
            this.dgvHareketler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHareketler.BackgroundColor = System.Drawing.Color.White;
            this.dgvHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHareketler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTarih,
            this.colIslemTuru,
            this.colBelgeNo,
            this.colBorc,
            this.colAlacak,
            this.colBakiye,
            this.colAciklama});
            this.dgvHareketler.Location = new System.Drawing.Point(12, 275);
            this.dgvHareketler.MultiSelect = false;
            this.dgvHareketler.Name = "dgvHareketler";
            this.dgvHareketler.ReadOnly = true;
            this.dgvHareketler.RowHeadersVisible = false;
            this.dgvHareketler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHareketler.Size = new System.Drawing.Size(1060, 300);
            this.dgvHareketler.TabIndex = 3;
            // 
            // colTarih
            // 
            this.colTarih.FillWeight = 80F;
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.ReadOnly = true;
            // 
            // colIslemTuru
            // 
            this.colIslemTuru.FillWeight = 100F;
            this.colIslemTuru.HeaderText = "İşlem Türü";
            this.colIslemTuru.Name = "colIslemTuru";
            this.colIslemTuru.ReadOnly = true;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.FillWeight = 100F;
            this.colBelgeNo.HeaderText = "Belge No";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.ReadOnly = true;
            // 
            // colBorc
            // 
            this.colBorc.FillWeight = 80F;
            this.colBorc.HeaderText = "Borç (TL)";
            this.colBorc.Name = "colBorc";
            this.colBorc.ReadOnly = true;
            // 
            // colAlacak
            // 
            this.colAlacak.FillWeight = 80F;
            this.colAlacak.HeaderText = "Alacak (TL)";
            this.colAlacak.Name = "colAlacak";
            this.colAlacak.ReadOnly = true;
            // 
            // colBakiye
            // 
            this.colBakiye.FillWeight = 80F;
            this.colBakiye.HeaderText = "Bakiye (TL)";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.ReadOnly = true;
            // 
            // colAciklama
            // 
            this.colAciklama.FillWeight = 150F;
            this.colAciklama.HeaderText = "Açıklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.ReadOnly = true;
            // 
            // pnlOzet
            // 
            this.pnlOzet.BackColor = System.Drawing.Color.Cyan;
            this.pnlOzet.Controls.Add(this.lblToplamIslem);
            this.pnlOzet.Controls.Add(this.lblNetHareket);
            this.pnlOzet.Controls.Add(this.lblToplamOdemeIslem);
            this.pnlOzet.Controls.Add(this.lblToplamBorcIslem);
            this.pnlOzet.Location = new System.Drawing.Point(12, 590);
            this.pnlOzet.Name = "pnlOzet";
            this.pnlOzet.Size = new System.Drawing.Size(1060, 50);
            this.pnlOzet.TabIndex = 4;
            // 
            // lblToplamBorcIslem
            // 
            this.lblToplamBorcIslem.AutoSize = true;
            this.lblToplamBorcIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamBorcIslem.ForeColor = System.Drawing.Color.Red;
            this.lblToplamBorcIslem.Location = new System.Drawing.Point(15, 15);
            this.lblToplamBorcIslem.Name = "lblToplamBorcIslem";
            this.lblToplamBorcIslem.Size = new System.Drawing.Size(170, 17);
            this.lblToplamBorcIslem.TabIndex = 0;
            this.lblToplamBorcIslem.Text = "Toplam Borç: 0 TL (0)";
            // 
            // lblToplamOdemeIslem
            // 
            this.lblToplamOdemeIslem.AutoSize = true;
            this.lblToplamOdemeIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamOdemeIslem.ForeColor = System.Drawing.Color.Green;
            this.lblToplamOdemeIslem.Location = new System.Drawing.Point(250, 15);
            this.lblToplamOdemeIslem.Name = "lblToplamOdemeIslem";
            this.lblToplamOdemeIslem.Size = new System.Drawing.Size(182, 17);
            this.lblToplamOdemeIslem.TabIndex = 1;
            this.lblToplamOdemeIslem.Text = "Toplam Ödeme: 0 TL (0)";
            // 
            // lblNetHareket
            // 
            this.lblNetHareket.AutoSize = true;
            this.lblNetHareket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblNetHareket.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNetHareket.Location = new System.Drawing.Point(500, 15);
            this.lblNetHareket.Name = "lblNetHareket";
            this.lblNetHareket.Size = new System.Drawing.Size(136, 17);
            this.lblNetHareket.TabIndex = 2;
            this.lblNetHareket.Text = "Net Hareket: 0 TL";
            // 
            // lblToplamIslem
            // 
            this.lblToplamIslem.AutoSize = true;
            this.lblToplamIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamIslem.ForeColor = System.Drawing.Color.Black;
            this.lblToplamIslem.Location = new System.Drawing.Point(700, 15);
            this.lblToplamIslem.Name = "lblToplamIslem";
            this.lblToplamIslem.Size = new System.Drawing.Size(115, 17);
            this.lblToplamIslem.TabIndex = 3;
            this.lblToplamIslem.Text = "Toplam İşlem: 0";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.LightGray;
            this.pnlButtons.Controls.Add(this.btnKapat);
            this.pnlButtons.Controls.Add(this.btnExcel);
            this.pnlButtons.Controls.Add(this.btnYazdir);
            this.pnlButtons.Controls.Add(this.btnYenile);
            this.pnlButtons.Controls.Add(this.btnBorcEkle);
            this.pnlButtons.Controls.Add(this.btnOdemeYap);
            this.pnlButtons.Location = new System.Drawing.Point(12, 655);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1060, 60);
            this.pnlButtons.TabIndex = 5;
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.BackColor = System.Drawing.Color.Green;
            this.btnOdemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnOdemeYap.ForeColor = System.Drawing.Color.White;
            this.btnOdemeYap.Location = new System.Drawing.Point(15, 15);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(120, 30);
            this.btnOdemeYap.TabIndex = 0;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = false;
            // 
            // btnBorcEkle
            // 
            this.btnBorcEkle.BackColor = System.Drawing.Color.Red;
            this.btnBorcEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBorcEkle.ForeColor = System.Drawing.Color.White;
            this.btnBorcEkle.Location = new System.Drawing.Point(150, 15);
            this.btnBorcEkle.Name = "btnBorcEkle";
            this.btnBorcEkle.Size = new System.Drawing.Size(120, 30);
            this.btnBorcEkle.TabIndex = 1;
            this.btnBorcEkle.Text = "Borç Ekle";
            this.btnBorcEkle.UseVisualStyleBackColor = false;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.Orange;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(700, 15);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(90, 30);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.Blue;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(810, 15);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(90, 30);
            this.btnYazdir.TabIndex = 3;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(920, 15);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(120, 30);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Excel'e Aktar";
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Gray;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(590, 15);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 30);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            // 
            // ToptanciHesapDetayiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1084, 727);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlOzet);
            this.Controls.Add(this.dgvHareketler);
            this.Controls.Add(this.pnlFiltreler);
            this.Controls.Add(this.pnlToptanciBilgileri);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToptanciHesapDetayiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Toptancı Hesap Detayı";
            this.pnlToptanciBilgileri.ResumeLayout(false);
            this.pnlToptanciBilgileri.PerformLayout();
            this.pnlFiltreler.ResumeLayout(false);
            this.pnlFiltreler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).EndInit();
            this.pnlOzet.ResumeLayout(false);
            this.pnlOzet.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToptanciBilgileri;
        private System.Windows.Forms.Label lblToptanciAdi;
        private System.Windows.Forms.Label lblMevcutBorc;
        private System.Windows.Forms.Label lblBorcDurumu;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblVergiDairesi;
        private System.Windows.Forms.Label lblVergiNo;
        private System.Windows.Forms.Label lblSonOdemeTarihi;
        private System.Windows.Forms.Label lblSonIslemTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlFiltreler;
        private System.Windows.Forms.CheckBox chkTarihFiltresi;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.RadioButton rbTumHareketler;
        private System.Windows.Forms.RadioButton rbSadeceOdemeler;
        private System.Windows.Forms.RadioButton rbSadeceBorclar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvHareketler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIslemTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBelgeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlacak;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBakiye;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
        private System.Windows.Forms.Panel pnlOzet;
        private System.Windows.Forms.Label lblToplamBorcIslem;
        private System.Windows.Forms.Label lblToplamOdemeIslem;
        private System.Windows.Forms.Label lblNetHareket;
        private System.Windows.Forms.Label lblToplamIslem;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Button btnBorcEkle;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnKapat;
    }
}
