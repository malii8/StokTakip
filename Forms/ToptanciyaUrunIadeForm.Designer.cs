namespace StokTakip.Forms
{
    partial class ToptanciyaUrunIadeForm
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
            this.pnlToptanciBilgi = new System.Windows.Forms.Panel();
            this.lblToptanciAdi = new System.Windows.Forms.Label();
            this.lblMevcutBorc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUrunSecimi = new System.Windows.Forms.Panel();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.colSiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMevcut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplamDeger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUrunSec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlIadeDetay = new System.Windows.Forms.Panel();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.dtpIadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtIadeNedeni = new System.Windows.Forms.TextBox();
            this.lblMevcutStok = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlOzet = new System.Windows.Forms.Panel();
            this.lblYeniBorc = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnIadeEt = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.pnlToptanciBilgi.SuspendLayout();
            this.pnlUrunSecimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.pnlIadeDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(860, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TOPTANCIYA ÜRÜN İADE EDİLECEK";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlToptanciBilgi
            // 
            this.pnlToptanciBilgi.BackColor = System.Drawing.Color.LightBlue;
            this.pnlToptanciBilgi.Controls.Add(this.label2);
            this.pnlToptanciBilgi.Controls.Add(this.label1);
            this.pnlToptanciBilgi.Controls.Add(this.lblMevcutBorc);
            this.pnlToptanciBilgi.Controls.Add(this.lblToptanciAdi);
            this.pnlToptanciBilgi.Location = new System.Drawing.Point(12, 65);
            this.pnlToptanciBilgi.Name = "pnlToptanciBilgi";
            this.pnlToptanciBilgi.Size = new System.Drawing.Size(860, 60);
            this.pnlToptanciBilgi.TabIndex = 1;
            // 
            // lblToptanciAdi
            // 
            this.lblToptanciAdi.AutoSize = true;
            this.lblToptanciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblToptanciAdi.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblToptanciAdi.Location = new System.Drawing.Point(150, 20);
            this.lblToptanciAdi.Name = "lblToptanciAdi";
            this.lblToptanciAdi.Size = new System.Drawing.Size(135, 20);
            this.lblToptanciAdi.TabIndex = 0;
            this.lblToptanciAdi.Text = "Toptancı Adı";
            // 
            // lblMevcutBorc
            // 
            this.lblMevcutBorc.AutoSize = true;
            this.lblMevcutBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMevcutBorc.ForeColor = System.Drawing.Color.Red;
            this.lblMevcutBorc.Location = new System.Drawing.Point(650, 20);
            this.lblMevcutBorc.Name = "lblMevcutBorc";
            this.lblMevcutBorc.Size = new System.Drawing.Size(66, 20);
            this.lblMevcutBorc.TabIndex = 1;
            this.lblMevcutBorc.Text = "0,00 TL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toptancı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(520, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mevcut Borç:";
            // 
            // pnlUrunSecimi
            // 
            this.pnlUrunSecimi.BackColor = System.Drawing.Color.LightGray;
            this.pnlUrunSecimi.Controls.Add(this.label3);
            this.pnlUrunSecimi.Controls.Add(this.btnUrunSec);
            this.pnlUrunSecimi.Controls.Add(this.dgvUrunler);
            this.pnlUrunSecimi.Location = new System.Drawing.Point(12, 140);
            this.pnlUrunSecimi.Name = "pnlUrunSecimi";
            this.pnlUrunSecimi.Size = new System.Drawing.Size(860, 250);
            this.pnlUrunSecimi.TabIndex = 2;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.BackgroundColor = System.Drawing.Color.White;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSiraNo,
            this.colUrunAdi,
            this.colBarkod,
            this.colMevcut,
            this.colBirimFiyat,
            this.colToplamDeger,
            this.colAlisTarihi});
            this.dgvUrunler.Location = new System.Drawing.Point(15, 40);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(720, 180);
            this.dgvUrunler.TabIndex = 0;
            // 
            // colSiraNo
            // 
            this.colSiraNo.FillWeight = 40F;
            this.colSiraNo.HeaderText = "No";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.ReadOnly = true;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.FillWeight = 150F;
            this.colUrunAdi.HeaderText = "Ürün Adı";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.ReadOnly = true;
            // 
            // colBarkod
            // 
            this.colBarkod.FillWeight = 80F;
            this.colBarkod.HeaderText = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.ReadOnly = true;
            // 
            // colMevcut
            // 
            this.colMevcut.FillWeight = 60F;
            this.colMevcut.HeaderText = "Mevcut";
            this.colMevcut.Name = "colMevcut";
            this.colMevcut.ReadOnly = true;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.FillWeight = 80F;
            this.colBirimFiyat.HeaderText = "Birim Fiyat";
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.ReadOnly = true;
            // 
            // colToplamDeger
            // 
            this.colToplamDeger.FillWeight = 90F;
            this.colToplamDeger.HeaderText = "Toplam Değer";
            this.colToplamDeger.Name = "colToplamDeger";
            this.colToplamDeger.ReadOnly = true;
            // 
            // colAlisTarihi
            // 
            this.colAlisTarihi.FillWeight = 80F;
            this.colAlisTarihi.HeaderText = "Alış Tarihi";
            this.colAlisTarihi.Name = "colAlisTarihi";
            this.colAlisTarihi.ReadOnly = true;
            // 
            // btnUrunSec
            // 
            this.btnUrunSec.BackColor = System.Drawing.Color.Blue;
            this.btnUrunSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUrunSec.ForeColor = System.Drawing.Color.White;
            this.btnUrunSec.Location = new System.Drawing.Point(750, 100);
            this.btnUrunSec.Name = "btnUrunSec";
            this.btnUrunSec.Size = new System.Drawing.Size(90, 40);
            this.btnUrunSec.TabIndex = 1;
            this.btnUrunSec.Text = "Ürün Seç";
            this.btnUrunSec.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bu Toptancıdan Alınan Ürünler (İade Edilebilir)";
            // 
            // pnlIadeDetay
            // 
            this.pnlIadeDetay.BackColor = System.Drawing.Color.LightYellow;
            this.pnlIadeDetay.Controls.Add(this.label10);
            this.pnlIadeDetay.Controls.Add(this.label9);
            this.pnlIadeDetay.Controls.Add(this.label8);
            this.pnlIadeDetay.Controls.Add(this.label7);
            this.pnlIadeDetay.Controls.Add(this.label6);
            this.pnlIadeDetay.Controls.Add(this.label5);
            this.pnlIadeDetay.Controls.Add(this.label4);
            this.pnlIadeDetay.Controls.Add(this.lblMevcutStok);
            this.pnlIadeDetay.Controls.Add(this.txtIadeNedeni);
            this.pnlIadeDetay.Controls.Add(this.dtpIadeTarihi);
            this.pnlIadeDetay.Controls.Add(this.lblToplamTutar);
            this.pnlIadeDetay.Controls.Add(this.txtBirimFiyat);
            this.pnlIadeDetay.Controls.Add(this.nudMiktar);
            this.pnlIadeDetay.Controls.Add(this.txtBarkod);
            this.pnlIadeDetay.Controls.Add(this.txtUrunAdi);
            this.pnlIadeDetay.Location = new System.Drawing.Point(12, 405);
            this.pnlIadeDetay.Name = "pnlIadeDetay";
            this.pnlIadeDetay.Size = new System.Drawing.Size(860, 150);
            this.pnlIadeDetay.TabIndex = 3;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.BackColor = System.Drawing.Color.White;
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUrunAdi.Location = new System.Drawing.Point(120, 15);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.ReadOnly = true;
            this.txtUrunAdi.Size = new System.Drawing.Size(200, 23);
            this.txtUrunAdi.TabIndex = 0;
            // 
            // txtBarkod
            // 
            this.txtBarkod.BackColor = System.Drawing.Color.White;
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBarkod.Location = new System.Drawing.Point(120, 45);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.ReadOnly = true;
            this.txtBarkod.Size = new System.Drawing.Size(120, 23);
            this.txtBarkod.TabIndex = 1;
            // 
            // nudMiktar
            // 
            this.nudMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudMiktar.Location = new System.Drawing.Point(120, 75);
            this.nudMiktar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMiktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(80, 23);
            this.nudMiktar.TabIndex = 2;
            this.nudMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBirimFiyat.Location = new System.Drawing.Point(120, 105);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(100, 23);
            this.txtBirimFiyat.TabIndex = 3;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Green;
            this.lblToplamTutar.Location = new System.Drawing.Point(450, 18);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(66, 20);
            this.lblToplamTutar.TabIndex = 4;
            this.lblToplamTutar.Text = "0,00 TL";
            // 
            // dtpIadeTarihi
            // 
            this.dtpIadeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpIadeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIadeTarihi.Location = new System.Drawing.Point(450, 45);
            this.dtpIadeTarihi.Name = "dtpIadeTarihi";
            this.dtpIadeTarihi.Size = new System.Drawing.Size(120, 23);
            this.dtpIadeTarihi.TabIndex = 5;
            // 
            // txtIadeNedeni
            // 
            this.txtIadeNedeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIadeNedeni.Location = new System.Drawing.Point(450, 75);
            this.txtIadeNedeni.Multiline = true;
            this.txtIadeNedeni.Name = "txtIadeNedeni";
            this.txtIadeNedeni.Size = new System.Drawing.Size(380, 55);
            this.txtIadeNedeni.TabIndex = 6;
            // 
            // lblMevcutStok
            // 
            this.lblMevcutStok.AutoSize = true;
            this.lblMevcutStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMevcutStok.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMevcutStok.Location = new System.Drawing.Point(220, 78);
            this.lblMevcutStok.Name = "lblMevcutStok";
            this.lblMevcutStok.Size = new System.Drawing.Size(102, 15);
            this.lblMevcutStok.TabIndex = 7;
            this.lblMevcutStok.Text = "Mevcut Stok: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ürün Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(15, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Barkod:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(15, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Miktar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Birim Fiyat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(350, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Toplam:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(350, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "İade Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(350, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "İade Nedeni:";
            // 
            // pnlOzet
            // 
            this.pnlOzet.BackColor = System.Drawing.Color.Cyan;
            this.pnlOzet.Controls.Add(this.label11);
            this.pnlOzet.Controls.Add(this.lblYeniBorc);
            this.pnlOzet.Location = new System.Drawing.Point(12, 570);
            this.pnlOzet.Name = "pnlOzet";
            this.pnlOzet.Size = new System.Drawing.Size(860, 50);
            this.pnlOzet.TabIndex = 4;
            // 
            // lblYeniBorc
            // 
            this.lblYeniBorc.AutoSize = true;
            this.lblYeniBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblYeniBorc.ForeColor = System.Drawing.Color.Blue;
            this.lblYeniBorc.Location = new System.Drawing.Point(200, 15);
            this.lblYeniBorc.Name = "lblYeniBorc";
            this.lblYeniBorc.Size = new System.Drawing.Size(190, 20);
            this.lblYeniBorc.TabIndex = 0;
            this.lblYeniBorc.Text = "İade Sonrası Borç: 0 TL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(15, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "İade Sonrası Durum:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.LightGray;
            this.pnlButtons.Controls.Add(this.btnIptal);
            this.pnlButtons.Controls.Add(this.btnIadeEt);
            this.pnlButtons.Location = new System.Drawing.Point(12, 635);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(860, 60);
            this.pnlButtons.TabIndex = 5;
            // 
            // btnIadeEt
            // 
            this.btnIadeEt.BackColor = System.Drawing.Color.Green;
            this.btnIadeEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIadeEt.ForeColor = System.Drawing.Color.White;
            this.btnIadeEt.Location = new System.Drawing.Point(300, 15);
            this.btnIadeEt.Name = "btnIadeEt";
            this.btnIadeEt.Size = new System.Drawing.Size(120, 35);
            this.btnIadeEt.TabIndex = 0;
            this.btnIadeEt.Text = "İADE ET";
            this.btnIadeEt.UseVisualStyleBackColor = false;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(440, 15);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(120, 35);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // ToptanciyaUrunIadeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(884, 707);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlOzet);
            this.Controls.Add(this.pnlIadeDetay);
            this.Controls.Add(this.pnlUrunSecimi);
            this.Controls.Add(this.pnlToptanciBilgi);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToptanciyaUrunIadeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Toptancıya Ürün İade";
            this.pnlToptanciBilgi.ResumeLayout(false);
            this.pnlToptanciBilgi.PerformLayout();
            this.pnlUrunSecimi.ResumeLayout(false);
            this.pnlUrunSecimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.pnlIadeDetay.ResumeLayout(false);
            this.pnlIadeDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            this.pnlOzet.ResumeLayout(false);
            this.pnlOzet.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlToptanciBilgi;
        private System.Windows.Forms.Label lblToptanciAdi;
        private System.Windows.Forms.Label lblMevcutBorc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlUrunSecimi;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMevcut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplamDeger;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlisTarihi;
        private System.Windows.Forms.Button btnUrunSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlIadeDetay;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.DateTimePicker dtpIadeTarihi;
        private System.Windows.Forms.TextBox txtIadeNedeni;
        private System.Windows.Forms.Label lblMevcutStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlOzet;
        private System.Windows.Forms.Label lblYeniBorc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnIadeEt;
        private System.Windows.Forms.Button btnIptal;
    }
}
