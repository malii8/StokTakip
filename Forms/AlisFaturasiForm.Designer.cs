namespace StokTakip.Forms
{
    partial class AlisFaturasiForm
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
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblAlisFiyatiKdvDahil = new System.Windows.Forms.Label();
            this.txtAlisFiyatiKdvDahil = new System.Windows.Forms.TextBox();
            this.rbKdvDahil = new System.Windows.Forms.RadioButton();
            this.rbKdvHaric = new System.Windows.Forms.RadioButton();
            this.lblAlisFiyatiKdvHaric = new System.Windows.Forms.Label();
            this.txtAlisFiyatiKdvHaric = new System.Windows.Forms.TextBox();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.lblKdvOrani = new System.Windows.Forms.Label();
            this.txtKdvOrani = new System.Windows.Forms.TextBox();
            this.lblEklenecekMiktar = new System.Windows.Forms.Label();
            this.txtEklenecekMiktar = new System.Windows.Forms.TextBox();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.btnFaturayaEkle = new System.Windows.Forms.Button();
            this.btnFaturayiKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblIndirimTutari = new System.Windows.Forms.Label();
            this.txtIndirimTutari = new System.Windows.Forms.TextBox();
            this.lblNetTutar = new System.Windows.Forms.Label();
            this.txtNetTutar = new System.Windows.Forms.TextBox();
            this.lblKdv = new System.Windows.Forms.Label();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.lblToptanci = new System.Windows.Forms.Label();
            this.cmbToptanci = new System.Windows.Forms.ComboBox();
            this.lblOdemeSekli = new System.Windows.Forms.Label();
            this.cmbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.btnYeniToptanci = new System.Windows.Forms.Button();
            this.btnYeniUrunEkle = new System.Windows.Forms.Button();

            this.lblIskonto = new System.Windows.Forms.Label();
            this.txtIskonto = new System.Windows.Forms.TextBox();
            this.lblBarkodOkutun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(30, 50);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(61, 13);
            this.lblBarkod.TabIndex = 0;
            this.lblBarkod.Text = "Barkod No:";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(150, 47);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(200, 20);
            this.txtBarkod.TabIndex = 1;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(30, 80);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(57, 13);
            this.lblUrunAdi.TabIndex = 2;
            this.lblUrunAdi.Text = "Ürünün Adı:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(150, 77);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(200, 20);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // lblAlisFiyatiKdvDahil
            // 
            this.lblAlisFiyatiKdvDahil.AutoSize = true;
            this.lblAlisFiyatiKdvDahil.Location = new System.Drawing.Point(30, 110);
            this.lblAlisFiyatiKdvDahil.Name = "lblAlisFiyatiKdvDahil";
            this.lblAlisFiyatiKdvDahil.Size = new System.Drawing.Size(99, 13);
            this.lblAlisFiyatiKdvDahil.TabIndex = 4;
            this.lblAlisFiyatiKdvDahil.Text = "Alış Fiyatı (Kdv Dahil)";
            // 
            // txtAlisFiyatiKdvDahil
            // 
            this.txtAlisFiyatiKdvDahil.Location = new System.Drawing.Point(150, 107);
            this.txtAlisFiyatiKdvDahil.Name = "txtAlisFiyatiKdvDahil";
            this.txtAlisFiyatiKdvDahil.Size = new System.Drawing.Size(100, 20);
            this.txtAlisFiyatiKdvDahil.TabIndex = 5;
            // 
            // rbKdvDahil
            // 
            this.rbKdvDahil.AutoSize = true;
            this.rbKdvDahil.Checked = true;
            this.rbKdvDahil.Location = new System.Drawing.Point(260, 108);
            this.rbKdvDahil.Name = "rbKdvDahil";
            this.rbKdvDahil.Size = new System.Drawing.Size(72, 17);
            this.rbKdvDahil.TabIndex = 6;
            this.rbKdvDahil.TabStop = true;
            this.rbKdvDahil.Text = "Kdv Dahil";
            this.rbKdvDahil.UseVisualStyleBackColor = true;
            // 
            // rbKdvHaric
            // 
            this.rbKdvHaric.AutoSize = true;
            this.rbKdvHaric.Location = new System.Drawing.Point(260, 133);
            this.rbKdvHaric.Name = "rbKdvHaric";
            this.rbKdvHaric.Size = new System.Drawing.Size(74, 17);
            this.rbKdvHaric.TabIndex = 7;
            this.rbKdvHaric.Text = "Kdv Hariç";
            this.rbKdvHaric.UseVisualStyleBackColor = true;
            // 
            // lblAlisFiyatiKdvHaric
            // 
            this.lblAlisFiyatiKdvHaric.AutoSize = true;
            this.lblAlisFiyatiKdvHaric.Location = new System.Drawing.Point(30, 140);
            this.lblAlisFiyatiKdvHaric.Name = "lblAlisFiyatiKdvHaric";
            this.lblAlisFiyatiKdvHaric.Size = new System.Drawing.Size(101, 13);
            this.lblAlisFiyatiKdvHaric.TabIndex = 8;
            this.lblAlisFiyatiKdvHaric.Text = "Alış Fiyatı (Kdv Hariç)";
            // 
            // txtAlisFiyatiKdvHaric
            // 
            this.txtAlisFiyatiKdvHaric.Location = new System.Drawing.Point(150, 137);
            this.txtAlisFiyatiKdvHaric.Name = "txtAlisFiyatiKdvHaric";
            this.txtAlisFiyatiKdvHaric.Size = new System.Drawing.Size(100, 20);
            this.txtAlisFiyatiKdvHaric.TabIndex = 9;
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Location = new System.Drawing.Point(30, 170);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(57, 13);
            this.lblSatisFiyati.TabIndex = 10;
            this.lblSatisFiyati.Text = "Satış Fiyatı";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(150, 167);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtSatisFiyati.TabIndex = 11;
            // 
            // lblKdvOrani
            // 
            this.lblKdvOrani.AutoSize = true;
            this.lblKdvOrani.Location = new System.Drawing.Point(30, 200);
            this.lblKdvOrani.Name = "lblKdvOrani";
            this.lblKdvOrani.Size = new System.Drawing.Size(67, 13);
            this.lblKdvOrani.TabIndex = 12;
            this.lblKdvOrani.Text = "KDV Oranı %";
            // 
            // txtKdvOrani
            // 
            this.txtKdvOrani.Location = new System.Drawing.Point(150, 197);
            this.txtKdvOrani.Name = "txtKdvOrani";
            this.txtKdvOrani.Size = new System.Drawing.Size(100, 20);
            this.txtKdvOrani.TabIndex = 13;
            // 
            // lblEklenecekMiktar
            // 
            this.lblEklenecekMiktar.AutoSize = true;
            this.lblEklenecekMiktar.Location = new System.Drawing.Point(30, 230);
            this.lblEklenecekMiktar.Name = "lblEklenecekMiktar";
            this.lblEklenecekMiktar.Size = new System.Drawing.Size(89, 13);
            this.lblEklenecekMiktar.TabIndex = 14;
            this.lblEklenecekMiktar.Text = "Eklenecek Miktar";
            // 
            // txtEklenecekMiktar
            // 
            this.txtEklenecekMiktar.BackColor = System.Drawing.Color.Blue;
            this.txtEklenecekMiktar.ForeColor = System.Drawing.Color.White;
            this.txtEklenecekMiktar.Location = new System.Drawing.Point(150, 227);
            this.txtEklenecekMiktar.Name = "txtEklenecekMiktar";
            this.txtEklenecekMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtEklenecekMiktar.TabIndex = 15;
            this.txtEklenecekMiktar.Text = "1";
            this.txtEklenecekMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.Location = new System.Drawing.Point(30, 270);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(100, 50);
            this.btnUrunAra.TabIndex = 16;
            this.btnUrunAra.Text = "Ürün Adı İle Arama (F2)";
            this.btnUrunAra.UseVisualStyleBackColor = true;
            // 
            // btnFaturayaEkle
            // 
            this.btnFaturayaEkle.Location = new System.Drawing.Point(140, 270);
            this.btnFaturayaEkle.Name = "btnFaturayaEkle";
            this.btnFaturayaEkle.Size = new System.Drawing.Size(100, 50);
            this.btnFaturayaEkle.TabIndex = 17;
            this.btnFaturayaEkle.Text = "Faturaya Ekle (F3)";
            this.btnFaturayaEkle.UseVisualStyleBackColor = true;
            // 
            // btnFaturayiKaydet
            // 
            this.btnFaturayiKaydet.Location = new System.Drawing.Point(250, 270);
            this.btnFaturayiKaydet.Name = "btnFaturayiKaydet";
            this.btnFaturayiKaydet.Size = new System.Drawing.Size(100, 50);
            this.btnFaturayiKaydet.TabIndex = 18;
            this.btnFaturayiKaydet.Text = "Faturayı Kaydet (F4)";
            this.btnFaturayiKaydet.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Orange;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 209);
            this.dataGridView1.TabIndex = 19;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(600, 50);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(32, 13);
            this.lblTutar.TabIndex = 20;
            this.lblTutar.Text = "Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(700, 47);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 20);
            this.txtTutar.TabIndex = 21;
            // 
            // lblIndirimTutari
            // 
            this.lblIndirimTutari.AutoSize = true;
            this.lblIndirimTutari.Location = new System.Drawing.Point(600, 80);
            this.lblIndirimTutari.Name = "lblIndirimTutari";
            this.lblIndirimTutari.Size = new System.Drawing.Size(67, 13);
            this.lblIndirimTutari.TabIndex = 22;
            this.lblIndirimTutari.Text = "İndirim Tutarı";
            // 
            // txtIndirimTutari
            // 
            this.txtIndirimTutari.Location = new System.Drawing.Point(700, 77);
            this.txtIndirimTutari.Name = "txtIndirimTutari";
            this.txtIndirimTutari.Size = new System.Drawing.Size(100, 20);
            this.txtIndirimTutari.TabIndex = 23;
            // 
            // lblNetTutar
            // 
            this.lblNetTutar.AutoSize = true;
            this.lblNetTutar.Location = new System.Drawing.Point(600, 110);
            this.lblNetTutar.Name = "lblNetTutar";
            this.lblNetTutar.Size = new System.Drawing.Size(52, 13);
            this.lblNetTutar.TabIndex = 24;
            this.lblNetTutar.Text = "Net Tutar";
            // 
            // txtNetTutar
            // 
            this.txtNetTutar.BackColor = System.Drawing.Color.LightBlue;
            this.txtNetTutar.Location = new System.Drawing.Point(700, 107);
            this.txtNetTutar.Name = "txtNetTutar";
            this.txtNetTutar.Size = new System.Drawing.Size(100, 20);
            this.txtNetTutar.TabIndex = 25;
            // 
            // lblKdv
            // 
            this.lblKdv.AutoSize = true;
            this.lblKdv.Location = new System.Drawing.Point(600, 140);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(26, 13);
            this.lblKdv.TabIndex = 26;
            this.lblKdv.Text = "Kdv";
            // 
            // txtKdv
            // 
            this.txtKdv.BackColor = System.Drawing.Color.Yellow;
            this.txtKdv.Location = new System.Drawing.Point(700, 137);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(100, 20);
            this.txtKdv.TabIndex = 27;
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(600, 170);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(70, 13);
            this.lblGenelToplam.TabIndex = 28;
            this.lblGenelToplam.Text = "Genel Toplam";
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.BackColor = System.Drawing.Color.Red;
            this.txtGenelToplam.Location = new System.Drawing.Point(700, 167);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(100, 20);
            this.txtGenelToplam.TabIndex = 29;
            // 
            // lblToptanci
            // 
            this.lblToptanci.AutoSize = true;
            this.lblToptanci.Location = new System.Drawing.Point(600, 210);
            this.lblToptanci.Name = "lblToptanci";
            this.lblToptanci.Size = new System.Drawing.Size(67, 13);
            this.lblToptanci.TabIndex = 30;
            this.lblToptanci.Text = "Toptancı Adı";
            // 
            // cmbToptanci
            // 
            this.cmbToptanci.FormattingEnabled = true;
            this.cmbToptanci.Location = new System.Drawing.Point(700, 207);
            this.cmbToptanci.Name = "cmbToptanci";
            this.cmbToptanci.Size = new System.Drawing.Size(200, 21);
            this.cmbToptanci.TabIndex = 31;
            // 
            // lblOdemeSekli
            // 
            this.lblOdemeSekli.AutoSize = true;
            this.lblOdemeSekli.Location = new System.Drawing.Point(600, 240);
            this.lblOdemeSekli.Name = "lblOdemeSekli";
            this.lblOdemeSekli.Size = new System.Drawing.Size(66, 13);
            this.lblOdemeSekli.TabIndex = 32;
            this.lblOdemeSekli.Text = "Ödeme Şekli";
            // 
            // cmbOdemeSekli
            // 
            this.cmbOdemeSekli.FormattingEnabled = true;
            this.cmbOdemeSekli.Location = new System.Drawing.Point(700, 237);
            this.cmbOdemeSekli.Name = "cmbOdemeSekli";
            this.cmbOdemeSekli.Size = new System.Drawing.Size(200, 21);
            this.cmbOdemeSekli.TabIndex = 33;
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.AutoSize = true;
            this.lblFaturaNo.Location = new System.Drawing.Point(600, 270);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(54, 13);
            this.lblFaturaNo.TabIndex = 34;
            this.lblFaturaNo.Text = "Fatura No";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(700, 267);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(100, 20);
            this.txtFaturaNo.TabIndex = 35;
            // 
            // btnYeniToptanci
            // 
            this.btnYeniToptanci.Location = new System.Drawing.Point(810, 265);
            this.btnYeniToptanci.Name = "btnYeniToptanci";
            this.btnYeniToptanci.Size = new System.Drawing.Size(90, 23);
            this.btnYeniToptanci.TabIndex = 36;
            this.btnYeniToptanci.Text = "Yeni Toptancı Ekle";
            this.btnYeniToptanci.UseVisualStyleBackColor = true;
            // 
            // btnYeniUrunEkle
            // 
            this.btnYeniUrunEkle.Location = new System.Drawing.Point(360, 45);
            this.btnYeniUrunEkle.Name = "btnYeniUrunEkle";
            this.btnYeniUrunEkle.Size = new System.Drawing.Size(90, 23);
            this.btnYeniUrunEkle.TabIndex = 37;
            this.btnYeniUrunEkle.Text = "Yeni Ürün Ekle";
            this.btnYeniUrunEkle.UseVisualStyleBackColor = true;

            // 
            // lblIskonto
            // 
            this.lblIskonto.AutoSize = true;
            this.lblIskonto.Location = new System.Drawing.Point(270, 200);
            this.lblIskonto.Name = "lblIskonto";
            this.lblIskonto.Size = new System.Drawing.Size(70, 13);
            this.lblIskonto.TabIndex = 40;
            this.lblIskonto.Text = "İskonto Oranı %";
            // 
            // txtIskonto
            // 
            this.txtIskonto.Location = new System.Drawing.Point(350, 197);
            this.txtIskonto.Name = "txtIskonto";
            this.txtIskonto.Size = new System.Drawing.Size(100, 20);
            this.txtIskonto.TabIndex = 41;
            // 
            // lblBarkodOkutun
            // 
            this.lblBarkodOkutun.AutoSize = true;
            this.lblBarkodOkutun.ForeColor = System.Drawing.Color.Red;
            this.lblBarkodOkutun.Location = new System.Drawing.Point(150, 20);
            this.lblBarkodOkutun.Name = "lblBarkodOkutun";
            this.lblBarkodOkutun.Size = new System.Drawing.Size(200, 13);
            this.lblBarkodOkutun.TabIndex = 42;
            this.lblBarkodOkutun.Text = "Barkod Okutun veya Barkod No + ENTER";
            // 
            // AlisFaturasiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblBarkodOkutun);
            this.Controls.Add(this.txtIskonto);
            this.Controls.Add(this.lblIskonto);
            this.Controls.Add(this.btnYeniUrunEkle);
            this.Controls.Add(this.btnYeniToptanci);
            this.Controls.Add(this.txtFaturaNo);
            this.Controls.Add(this.lblFaturaNo);
            this.Controls.Add(this.cmbOdemeSekli);
            this.Controls.Add(this.lblOdemeSekli);
            this.Controls.Add(this.cmbToptanci);
            this.Controls.Add(this.lblToptanci);
            this.Controls.Add(this.txtGenelToplam);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.txtKdv);
            this.Controls.Add(this.lblKdv);
            this.Controls.Add(this.txtNetTutar);
            this.Controls.Add(this.lblNetTutar);
            this.Controls.Add(this.txtIndirimTutari);
            this.Controls.Add(this.lblIndirimTutari);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFaturayiKaydet);
            this.Controls.Add(this.btnFaturayaEkle);
            this.Controls.Add(this.btnUrunAra);
            this.Controls.Add(this.txtEklenecekMiktar);
            this.Controls.Add(this.lblEklenecekMiktar);
            this.Controls.Add(this.txtKdvOrani);
            this.Controls.Add(this.lblKdvOrani);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.txtAlisFiyatiKdvHaric);
            this.Controls.Add(this.lblAlisFiyatiKdvHaric);
            this.Controls.Add(this.rbKdvHaric);
            this.Controls.Add(this.rbKdvDahil);
            this.Controls.Add(this.txtAlisFiyatiKdvDahil);
            this.Controls.Add(this.lblAlisFiyatiKdvDahil);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblBarkod);
            this.Name = "AlisFaturasiForm";
            this.Text = "ALIŞ FATURASI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblAlisFiyatiKdvDahil;
        private System.Windows.Forms.TextBox txtAlisFiyatiKdvDahil;
        private System.Windows.Forms.RadioButton rbKdvDahil;
        private System.Windows.Forms.RadioButton rbKdvHaric;
        private System.Windows.Forms.Label lblAlisFiyatiKdvHaric;
        private System.Windows.Forms.TextBox txtAlisFiyatiKdvHaric;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label lblKdvOrani;
        private System.Windows.Forms.TextBox txtKdvOrani;
        private System.Windows.Forms.Label lblEklenecekMiktar;
        private System.Windows.Forms.TextBox txtEklenecekMiktar;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.Button btnFaturayaEkle;
        private System.Windows.Forms.Button btnFaturayiKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblIndirimTutari;
        private System.Windows.Forms.TextBox txtIndirimTutari;
        private System.Windows.Forms.Label lblNetTutar;
        private System.Windows.Forms.TextBox txtNetTutar;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.Label lblToptanci;
        private System.Windows.Forms.ComboBox cmbToptanci;
        private System.Windows.Forms.Label lblOdemeSekli;
        private System.Windows.Forms.ComboBox cmbOdemeSekli;
        private System.Windows.Forms.Label lblFaturaNo;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Button btnYeniToptanci;
        private System.Windows.Forms.Button btnYeniUrunEkle;
        private System.Windows.Forms.Label lblIskonto;
        private System.Windows.Forms.TextBox txtIskonto;
        private System.Windows.Forms.Label lblBarkodOkutun;
    }
}
