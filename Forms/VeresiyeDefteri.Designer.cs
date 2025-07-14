namespace StokTakip.Forms
{
    partial class VeresiyeDefteri
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
            this.lblTarihAraligini = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.btnTaksitler = new System.Windows.Forms.Button();
            this.btnHesabaBorcEkle = new System.Windows.Forms.Button();
            this.btnTahsilatYap = new System.Windows.Forms.Button();
            this.lblBorcDetayi = new System.Windows.Forms.Label();
            this.lblMusterininAdi = new System.Windows.Forms.Label();
            this.txtMusterininAdi = new System.Windows.Forms.TextBox();
            this.lblVeresiyeBorcMiktari = new System.Windows.Forms.Label();
            this.lblBorcMiktariValue = new System.Windows.Forms.Label();
            this.lblKalanTaksitTutarToplami = new System.Windows.Forms.Label();
            this.lblKalanTaksitValue = new System.Windows.Forms.Label();
            this.lblOdemesiGerekenTaksitTutari = new System.Windows.Forms.Label();
            this.lblOdemesiGerekenValue = new System.Windows.Forms.Label();
            this.dgvBorcDetayi = new System.Windows.Forms.DataGridView();
            this.colSiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIslemTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOncekiBakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIslemTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKalanBorc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAlisverisDetayi = new System.Windows.Forms.Label();
            this.dgvAlisverisDetayi = new System.Windows.Forms.DataGridView();
            this.colSiraNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarih2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirimFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplamTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOdemeSekli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTabloExcelAktar = new System.Windows.Forms.Button();
            this.btnTabloExcelAktar2 = new System.Windows.Forms.Button();
            this.btnSeciUrunSatisFisiniGoster = new System.Windows.Forms.Button();
            this.btnEFaturayaAktar = new System.Windows.Forms.Button();
            this.lblUrunToplami = new System.Windows.Forms.Label();
            this.txtUrunToplami = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorcDetayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlisverisDetayi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTarihAraligini
            // 
            this.lblTarihAraligini.AutoSize = true;
            this.lblTarihAraligini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihAraligini.ForeColor = System.Drawing.Color.Blue;
            this.lblTarihAraligini.Location = new System.Drawing.Point(20, 20);
            this.lblTarihAraligini.Name = "lblTarihAraligini";
            this.lblTarihAraligini.Size = new System.Drawing.Size(106, 13);
            this.lblTarihAraligini.TabIndex = 0;
            this.lblTarihAraligini.Text = "Tarih Aralığını Seçin";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(20, 40);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(120, 20);
            this.dtpBaslangic.TabIndex = 1;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(150, 40);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(120, 20);
            this.dtpBitis.TabIndex = 2;
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.Location = new System.Drawing.Point(290, 35);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(80, 30);
            this.btnRaporAl.TabIndex = 3;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.UseVisualStyleBackColor = true;
            // 
            // btnTaksitler
            // 
            this.btnTaksitler.Location = new System.Drawing.Point(380, 35);
            this.btnTaksitler.Name = "btnTaksitler";
            this.btnTaksitler.Size = new System.Drawing.Size(80, 30);
            this.btnTaksitler.TabIndex = 4;
            this.btnTaksitler.Text = "Taksitler";
            this.btnTaksitler.UseVisualStyleBackColor = true;
            // 
            // btnHesabaBorcEkle
            // 
            this.btnHesabaBorcEkle.Location = new System.Drawing.Point(470, 35);
            this.btnHesabaBorcEkle.Name = "btnHesabaBorcEkle";
            this.btnHesabaBorcEkle.Size = new System.Drawing.Size(80, 30);
            this.btnHesabaBorcEkle.TabIndex = 5;
            this.btnHesabaBorcEkle.Text = "Hesaba\nBorç Ekle";
            this.btnHesabaBorcEkle.UseVisualStyleBackColor = true;
            // 
            // btnTahsilatYap
            // 
            this.btnTahsilatYap.Location = new System.Drawing.Point(560, 35);
            this.btnTahsilatYap.Name = "btnTahsilatYap";
            this.btnTahsilatYap.Size = new System.Drawing.Size(80, 30);
            this.btnTahsilatYap.TabIndex = 6;
            this.btnTahsilatYap.Text = "Tahsilat Yap";
            this.btnTahsilatYap.UseVisualStyleBackColor = true;
            // 
            // lblBorcDetayi
            // 
            this.lblBorcDetayi.AutoSize = true;
            this.lblBorcDetayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBorcDetayi.ForeColor = System.Drawing.Color.Blue;
            this.lblBorcDetayi.Location = new System.Drawing.Point(20, 85);
            this.lblBorcDetayi.Name = "lblBorcDetayi";
            this.lblBorcDetayi.Size = new System.Drawing.Size(71, 13);
            this.lblBorcDetayi.TabIndex = 7;
            this.lblBorcDetayi.Text = "Borç Detayı";
            // 
            // lblMusterininAdi
            // 
            this.lblMusterininAdi.AutoSize = true;
            this.lblMusterininAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusterininAdi.ForeColor = System.Drawing.Color.Blue;
            this.lblMusterininAdi.Location = new System.Drawing.Point(100, 85);
            this.lblMusterininAdi.Name = "lblMusterininAdi";
            this.lblMusterininAdi.Size = new System.Drawing.Size(73, 13);
            this.lblMusterininAdi.TabIndex = 8;
            this.lblMusterininAdi.Text = "Müşterinin Adı";
            // 
            // txtMusterininAdi
            // 
            this.txtMusterininAdi.Location = new System.Drawing.Point(180, 82);
            this.txtMusterininAdi.Name = "txtMusterininAdi";
            this.txtMusterininAdi.ReadOnly = true;
            this.txtMusterininAdi.Size = new System.Drawing.Size(200, 20);
            this.txtMusterininAdi.TabIndex = 9;
            this.txtMusterininAdi.Text = "BİLAL";
            // 
            // lblVeresiyeBorcMiktari
            // 
            this.lblVeresiyeBorcMiktari.AutoSize = true;
            this.lblVeresiyeBorcMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeresiyeBorcMiktari.ForeColor = System.Drawing.Color.Blue;
            this.lblVeresiyeBorcMiktari.Location = new System.Drawing.Point(400, 85);
            this.lblVeresiyeBorcMiktari.Name = "lblVeresiyeBorcMiktari";
            this.lblVeresiyeBorcMiktari.Size = new System.Drawing.Size(106, 13);
            this.lblVeresiyeBorcMiktari.TabIndex = 10;
            this.lblVeresiyeBorcMiktari.Text = "Veresiye Borç Miktarı";
            // 
            // lblBorcMiktariValue
            // 
            this.lblBorcMiktariValue.BackColor = System.Drawing.Color.Red;
            this.lblBorcMiktariValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBorcMiktariValue.ForeColor = System.Drawing.Color.White;
            this.lblBorcMiktariValue.Location = new System.Drawing.Point(520, 80);
            this.lblBorcMiktariValue.Name = "lblBorcMiktariValue";
            this.lblBorcMiktariValue.Size = new System.Drawing.Size(100, 25);
            this.lblBorcMiktariValue.TabIndex = 11;
            this.lblBorcMiktariValue.Text = "0,00 TL";
            this.lblBorcMiktariValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKalanTaksitTutarToplami
            // 
            this.lblKalanTaksitTutarToplami.AutoSize = true;
            this.lblKalanTaksitTutarToplami.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanTaksitTutarToplami.ForeColor = System.Drawing.Color.Blue;
            this.lblKalanTaksitTutarToplami.Location = new System.Drawing.Point(20, 120);
            this.lblKalanTaksitTutarToplami.Name = "lblKalanTaksitTutarToplami";
            this.lblKalanTaksitTutarToplami.Size = new System.Drawing.Size(135, 13);
            this.lblKalanTaksitTutarToplami.TabIndex = 12;
            this.lblKalanTaksitTutarToplami.Text = "Kalan Taksit Tutar Toplamı";
            // 
            // lblKalanTaksitValue
            // 
            this.lblKalanTaksitValue.BackColor = System.Drawing.Color.Orange;
            this.lblKalanTaksitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanTaksitValue.Location = new System.Drawing.Point(160, 115);
            this.lblKalanTaksitValue.Name = "lblKalanTaksitValue";
            this.lblKalanTaksitValue.Size = new System.Drawing.Size(80, 25);
            this.lblKalanTaksitValue.TabIndex = 13;
            this.lblKalanTaksitValue.Text = "0,00 TL";
            this.lblKalanTaksitValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOdemesiGerekenTaksitTutari
            // 
            this.lblOdemesiGerekenTaksitTutari.AutoSize = true;
            this.lblOdemesiGerekenTaksitTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemesiGerekenTaksitTutari.ForeColor = System.Drawing.Color.Blue;
            this.lblOdemesiGerekenTaksitTutari.Location = new System.Drawing.Point(280, 120);
            this.lblOdemesiGerekenTaksitTutari.Name = "lblOdemesiGerekenTaksitTutari";
            this.lblOdemesiGerekenTaksitTutari.Size = new System.Drawing.Size(146, 13);
            this.lblOdemesiGerekenTaksitTutari.TabIndex = 14;
            this.lblOdemesiGerekenTaksitTutari.Text = "Ödemesi Gereken Taksit Tutarı";
            // 
            // lblOdemesiGerekenValue
            // 
            this.lblOdemesiGerekenValue.BackColor = System.Drawing.Color.Orange;
            this.lblOdemesiGerekenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemesiGerekenValue.Location = new System.Drawing.Point(430, 115);
            this.lblOdemesiGerekenValue.Name = "lblOdemesiGerekenValue";
            this.lblOdemesiGerekenValue.Size = new System.Drawing.Size(80, 25);
            this.lblOdemesiGerekenValue.TabIndex = 15;
            this.lblOdemesiGerekenValue.Text = "0,00 TL";
            this.lblOdemesiGerekenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvBorcDetayi
            // 
            this.dgvBorcDetayi.BackgroundColor = System.Drawing.Color.Orange;
            this.dgvBorcDetayi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorcDetayi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSiraNo,
            this.colTarih,
            this.colIslemTuru,
            this.colOncekiBakiye,
            this.colIslemTutari,
            this.colKalanBorc});
            this.dgvBorcDetayi.Location = new System.Drawing.Point(20, 160);
            this.dgvBorcDetayi.Name = "dgvBorcDetayi";
            this.dgvBorcDetayi.Size = new System.Drawing.Size(620, 150);
            this.dgvBorcDetayi.TabIndex = 16;
            // 
            // colSiraNo
            // 
            this.colSiraNo.HeaderText = "Sıra No";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.Width = 60;
            // 
            // colTarih
            // 
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Width = 90;
            // 
            // colIslemTuru
            // 
            this.colIslemTuru.HeaderText = "İşlem Türü";
            this.colIslemTuru.Name = "colIslemTuru";
            this.colIslemTuru.Width = 120;
            // 
            // colOncekiBakiye
            // 
            this.colOncekiBakiye.HeaderText = "Önceki Bakiye";
            this.colOncekiBakiye.Name = "colOncekiBakiye";
            this.colOncekiBakiye.Width = 100;
            // 
            // colIslemTutari
            // 
            this.colIslemTutari.HeaderText = "İşlem Tutarı";
            this.colIslemTutari.Name = "colIslemTutari";
            this.colIslemTutari.Width = 100;
            // 
            // colKalanBorc
            // 
            this.colKalanBorc.HeaderText = "Kalan Borç";
            this.colKalanBorc.Name = "colKalanBorc";
            this.colKalanBorc.Width = 100;
            // 
            // lblAlisverisDetayi
            // 
            this.lblAlisverisDetayi.AutoSize = true;
            this.lblAlisverisDetayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlisverisDetayi.ForeColor = System.Drawing.Color.Blue;
            this.lblAlisverisDetayi.Location = new System.Drawing.Point(20, 330);
            this.lblAlisverisDetayi.Name = "lblAlisverisDetayi";
            this.lblAlisverisDetayi.Size = new System.Drawing.Size(94, 13);
            this.lblAlisverisDetayi.TabIndex = 17;
            this.lblAlisverisDetayi.Text = "Alışveriş Detayı";
            // 
            // dgvAlisverisDetayi
            // 
            this.dgvAlisverisDetayi.BackgroundColor = System.Drawing.Color.Orange;
            this.dgvAlisverisDetayi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlisverisDetayi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSiraNo2,
            this.colTarih2,
            this.colUrunAdi,
            this.colBirimFiyati,
            this.colMiktari,
            this.colToplamTutari,
            this.colOdemeSekli});
            this.dgvAlisverisDetayi.Location = new System.Drawing.Point(20, 355);
            this.dgvAlisverisDetayi.Name = "dgvAlisverisDetayi";
            this.dgvAlisverisDetayi.Size = new System.Drawing.Size(700, 180);
            this.dgvAlisverisDetayi.TabIndex = 18;
            // 
            // colSiraNo2
            // 
            this.colSiraNo2.HeaderText = "Sıra No";
            this.colSiraNo2.Name = "colSiraNo2";
            this.colSiraNo2.Width = 60;
            // 
            // colTarih2
            // 
            this.colTarih2.HeaderText = "Tarih";
            this.colTarih2.Name = "colTarih2";
            this.colTarih2.Width = 90;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.HeaderText = "Ürün Adı";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Width = 150;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.HeaderText = "Birim Fiyatı";
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.Width = 80;
            // 
            // colMiktari
            // 
            this.colMiktari.HeaderText = "Miktarı";
            this.colMiktari.Name = "colMiktari";
            this.colMiktari.Width = 60;
            // 
            // colToplamTutari
            // 
            this.colToplamTutari.HeaderText = "Toplam Tutarı";
            this.colToplamTutari.Name = "colToplamTutari";
            this.colToplamTutari.Width = 90;
            // 
            // colOdemeSekli
            // 
            this.colOdemeSekli.HeaderText = "Ödeme Şekli";
            this.colOdemeSekli.Name = "colOdemeSekli";
            this.colOdemeSekli.Width = 80;
            // 
            // btnTabloExcelAktar
            // 
            this.btnTabloExcelAktar.Location = new System.Drawing.Point(670, 280);
            this.btnTabloExcelAktar.Name = "btnTabloExcelAktar";
            this.btnTabloExcelAktar.Size = new System.Drawing.Size(80, 30);
            this.btnTabloExcelAktar.TabIndex = 19;
            this.btnTabloExcelAktar.Text = "Tabloyu\nExcel'e Aktar";
            this.btnTabloExcelAktar.UseVisualStyleBackColor = true;
            // 
            // btnTabloExcelAktar2
            // 
            this.btnTabloExcelAktar2.Location = new System.Drawing.Point(750, 380);
            this.btnTabloExcelAktar2.Name = "btnTabloExcelAktar2";
            this.btnTabloExcelAktar2.Size = new System.Drawing.Size(80, 30);
            this.btnTabloExcelAktar2.TabIndex = 20;
            this.btnTabloExcelAktar2.Text = "Tabloyu\nExcel'e Aktar";
            this.btnTabloExcelAktar2.UseVisualStyleBackColor = true;
            // 
            // btnSeciUrunSatisFisiniGoster
            // 
            this.btnSeciUrunSatisFisiniGoster.Location = new System.Drawing.Point(750, 420);
            this.btnSeciUrunSatisFisiniGoster.Name = "btnSeciUrunSatisFisiniGoster";
            this.btnSeciUrunSatisFisiniGoster.Size = new System.Drawing.Size(80, 30);
            this.btnSeciUrunSatisFisiniGoster.TabIndex = 21;
            this.btnSeciUrunSatisFisiniGoster.Text = "Seçil Ürünün\nSATIŞ FİŞİNİ\nGöster";
            this.btnSeciUrunSatisFisiniGoster.UseVisualStyleBackColor = true;
            // 
            // btnEFaturayaAktar
            // 
            this.btnEFaturayaAktar.BackColor = System.Drawing.Color.Red;
            this.btnEFaturayaAktar.ForeColor = System.Drawing.Color.White;
            this.btnEFaturayaAktar.Location = new System.Drawing.Point(750, 460);
            this.btnEFaturayaAktar.Name = "btnEFaturayaAktar";
            this.btnEFaturayaAktar.Size = new System.Drawing.Size(80, 30);
            this.btnEFaturayaAktar.TabIndex = 22;
            this.btnEFaturayaAktar.Text = "E-Faturaya\nAktar";
            this.btnEFaturayaAktar.UseVisualStyleBackColor = false;
            // 
            // lblUrunToplami
            // 
            this.lblUrunToplami.AutoSize = true;
            this.lblUrunToplami.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunToplami.ForeColor = System.Drawing.Color.Blue;
            this.lblUrunToplami.Location = new System.Drawing.Point(500, 550);
            this.lblUrunToplami.Name = "lblUrunToplami";
            this.lblUrunToplami.Size = new System.Drawing.Size(75, 13);
            this.lblUrunToplami.TabIndex = 23;
            this.lblUrunToplami.Text = "Ürün Toplamı";
            // 
            // txtUrunToplami
            // 
            this.txtUrunToplami.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunToplami.Location = new System.Drawing.Point(590, 545);
            this.txtUrunToplami.Name = "txtUrunToplami";
            this.txtUrunToplami.ReadOnly = true;
            this.txtUrunToplami.Size = new System.Drawing.Size(100, 26);
            this.txtUrunToplami.TabIndex = 24;
            this.txtUrunToplami.Text = "15000.00";
            this.txtUrunToplami.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VeresiyeDefteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.txtUrunToplami);
            this.Controls.Add(this.lblUrunToplami);
            this.Controls.Add(this.btnEFaturayaAktar);
            this.Controls.Add(this.btnSeciUrunSatisFisiniGoster);
            this.Controls.Add(this.btnTabloExcelAktar2);
            this.Controls.Add(this.btnTabloExcelAktar);
            this.Controls.Add(this.dgvAlisverisDetayi);
            this.Controls.Add(this.lblAlisverisDetayi);
            this.Controls.Add(this.dgvBorcDetayi);
            this.Controls.Add(this.lblOdemesiGerekenValue);
            this.Controls.Add(this.lblOdemesiGerekenTaksitTutari);
            this.Controls.Add(this.lblKalanTaksitValue);
            this.Controls.Add(this.lblKalanTaksitTutarToplami);
            this.Controls.Add(this.lblBorcMiktariValue);
            this.Controls.Add(this.lblVeresiyeBorcMiktari);
            this.Controls.Add(this.txtMusterininAdi);
            this.Controls.Add(this.lblMusterininAdi);
            this.Controls.Add(this.lblBorcDetayi);
            this.Controls.Add(this.btnTahsilatYap);
            this.Controls.Add(this.btnHesabaBorcEkle);
            this.Controls.Add(this.btnTaksitler);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.lblTarihAraligini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VeresiyeDefteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VERESİYE DEFTERİ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorcDetayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlisverisDetayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarihAraligini;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Button btnRaporAl;
        private System.Windows.Forms.Button btnTaksitler;
        private System.Windows.Forms.Button btnHesabaBorcEkle;
        private System.Windows.Forms.Button btnTahsilatYap;
        private System.Windows.Forms.Label lblBorcDetayi;
        private System.Windows.Forms.Label lblMusterininAdi;
        private System.Windows.Forms.TextBox txtMusterininAdi;
        private System.Windows.Forms.Label lblVeresiyeBorcMiktari;
        private System.Windows.Forms.Label lblBorcMiktariValue;
        private System.Windows.Forms.Label lblKalanTaksitTutarToplami;
        private System.Windows.Forms.Label lblKalanTaksitValue;
        private System.Windows.Forms.Label lblOdemesiGerekenTaksitTutari;
        private System.Windows.Forms.Label lblOdemesiGerekenValue;
        private System.Windows.Forms.DataGridView dgvBorcDetayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIslemTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOncekiBakiye;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIslemTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKalanBorc;
        private System.Windows.Forms.Label lblAlisverisDetayi;
        private System.Windows.Forms.DataGridView dgvAlisverisDetayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiraNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirimFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplamTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOdemeSekli;
        private System.Windows.Forms.Button btnTabloExcelAktar;
        private System.Windows.Forms.Button btnTabloExcelAktar2;
        private System.Windows.Forms.Button btnSeciUrunSatisFisiniGoster;
        private System.Windows.Forms.Button btnEFaturayaAktar;
        private System.Windows.Forms.Label lblUrunToplami;
        private System.Windows.Forms.TextBox txtUrunToplami;
    }
}
