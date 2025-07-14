namespace StokTakip.Forms
{
    partial class ToptanciyaOdemeYapForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblToptanciAdi = new System.Windows.Forms.Label();
            this.txtToptanciAdi = new System.Windows.Forms.TextBox();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.txtToplamBorc = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblSaat = new System.Windows.Forms.Label();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.txtOdemeTutari = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.pnlOdemeSekli = new System.Windows.Forms.Panel();
            this.lblOdemeSekli = new System.Windows.Forms.Label();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbHavale = new System.Windows.Forms.RadioButton();
            this.picNakit = new System.Windows.Forms.PictureBox();
            this.picKrediKarti = new System.Windows.Forms.PictureBox();
            this.picHavale = new System.Windows.Forms.PictureBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnOdemeBilgisiYazdir = new System.Windows.Forms.Button();
            this.chkOtomatikYazdir = new System.Windows.Forms.CheckBox();
            this.pnlOdemeSekli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNakit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKrediKarti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHavale)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(80, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TOPTANCI ÖDEMESİ";

            // 
            // lblToptanciAdi
            // 
            this.lblToptanciAdi.AutoSize = true;
            this.lblToptanciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToptanciAdi.ForeColor = System.Drawing.Color.Blue;
            this.lblToptanciAdi.Location = new System.Drawing.Point(12, 50);
            this.lblToptanciAdi.Name = "lblToptanciAdi";
            this.lblToptanciAdi.Size = new System.Drawing.Size(83, 15);
            this.lblToptanciAdi.TabIndex = 1;
            this.lblToptanciAdi.Text = "Toptancı Adı";

            // 
            // txtToptanciAdi
            // 
            this.txtToptanciAdi.Location = new System.Drawing.Point(130, 48);
            this.txtToptanciAdi.Name = "txtToptanciAdi";
            this.txtToptanciAdi.ReadOnly = true;
            this.txtToptanciAdi.Size = new System.Drawing.Size(250, 20);
            this.txtToptanciAdi.TabIndex = 2;

            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.AutoSize = true;
            this.lblToplamBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamBorc.ForeColor = System.Drawing.Color.Blue;
            this.lblToplamBorc.Location = new System.Drawing.Point(12, 80);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(82, 15);
            this.lblToplamBorc.TabIndex = 3;
            this.lblToplamBorc.Text = "Toplam Borç";

            // 
            // txtToplamBorc
            // 
            this.txtToplamBorc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtToplamBorc.Location = new System.Drawing.Point(130, 78);
            this.txtToplamBorc.Name = "txtToplamBorc";
            this.txtToplamBorc.ReadOnly = true;
            this.txtToplamBorc.Size = new System.Drawing.Size(250, 20);
            this.txtToplamBorc.TabIndex = 4;

            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTarih.ForeColor = System.Drawing.Color.Blue;
            this.lblTarih.Location = new System.Drawing.Point(12, 110);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 15);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih";

            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(130, 108);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(100, 20);
            this.dtpTarih.TabIndex = 6;

            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaat.ForeColor = System.Drawing.Color.Blue;
            this.lblSaat.Location = new System.Drawing.Point(250, 110);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(33, 15);
            this.lblSaat.TabIndex = 7;
            this.lblSaat.Text = "Saat";

            // 
            // dtpSaat
            // 
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaat.Location = new System.Drawing.Point(290, 108);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.ShowUpDown = true;
            this.dtpSaat.Size = new System.Drawing.Size(90, 20);
            this.dtpSaat.TabIndex = 8;

            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOdemeTutari.ForeColor = System.Drawing.Color.Blue;
            this.lblOdemeTutari.Location = new System.Drawing.Point(12, 140);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(90, 15);
            this.lblOdemeTutari.TabIndex = 9;
            this.lblOdemeTutari.Text = "Ödeme Tutarı";

            // 
            // txtOdemeTutari
            // 
            this.txtOdemeTutari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOdemeTutari.Location = new System.Drawing.Point(130, 138);
            this.txtOdemeTutari.Name = "txtOdemeTutari";
            this.txtOdemeTutari.Size = new System.Drawing.Size(250, 20);
            this.txtOdemeTutari.TabIndex = 10;

            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAciklama.ForeColor = System.Drawing.Color.Blue;
            this.lblAciklama.Location = new System.Drawing.Point(12, 170);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(65, 15);
            this.lblAciklama.TabIndex = 11;
            this.lblAciklama.Text = "Açıklama";

            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(12, 195);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(368, 60);
            this.txtAciklama.TabIndex = 12;

            // 
            // pnlOdemeSekli
            // 
            this.pnlOdemeSekli.BackColor = System.Drawing.Color.LightGray;
            this.pnlOdemeSekli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOdemeSekli.Controls.Add(this.lblOdemeSekli);
            this.pnlOdemeSekli.Controls.Add(this.rbNakit);
            this.pnlOdemeSekli.Controls.Add(this.picNakit);
            this.pnlOdemeSekli.Controls.Add(this.rbKrediKarti);
            this.pnlOdemeSekli.Controls.Add(this.picKrediKarti);
            this.pnlOdemeSekli.Controls.Add(this.rbHavale);
            this.pnlOdemeSekli.Controls.Add(this.picHavale);
            this.pnlOdemeSekli.Location = new System.Drawing.Point(30, 270);
            this.pnlOdemeSekli.Name = "pnlOdemeSekli";
            this.pnlOdemeSekli.Size = new System.Drawing.Size(350, 100);
            this.pnlOdemeSekli.TabIndex = 13;

            // 
            // lblOdemeSekli
            // 
            this.lblOdemeSekli.AutoSize = true;
            this.lblOdemeSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOdemeSekli.ForeColor = System.Drawing.Color.Red;
            this.lblOdemeSekli.Location = new System.Drawing.Point(125, 5);
            this.lblOdemeSekli.Name = "lblOdemeSekli";
            this.lblOdemeSekli.Size = new System.Drawing.Size(98, 17);
            this.lblOdemeSekli.TabIndex = 0;
            this.lblOdemeSekli.Text = "ÖDEME ŞEKLİ";

            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbNakit.Location = new System.Drawing.Point(20, 70);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(57, 19);
            this.rbNakit.TabIndex = 1;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.RbOdemeSekli_CheckedChanged);

            // 
            // picNakit
            // 
            this.picNakit.BackColor = System.Drawing.Color.Green;
            this.picNakit.Location = new System.Drawing.Point(20, 30);
            this.picNakit.Name = "picNakit";
            this.picNakit.Size = new System.Drawing.Size(60, 35);
            this.picNakit.TabIndex = 2;
            this.picNakit.TabStop = false;

            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbKrediKarti.Location = new System.Drawing.Point(130, 70);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(88, 19);
            this.rbKrediKarti.TabIndex = 3;
            this.rbKrediKarti.Text = "Kredi Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            this.rbKrediKarti.CheckedChanged += new System.EventHandler(this.RbOdemeSekli_CheckedChanged);

            // 
            // picKrediKarti
            // 
            this.picKrediKarti.BackColor = System.Drawing.Color.Blue;
            this.picKrediKarti.Location = new System.Drawing.Point(140, 30);
            this.picKrediKarti.Name = "picKrediKarti";
            this.picKrediKarti.Size = new System.Drawing.Size(60, 35);
            this.picKrediKarti.TabIndex = 4;
            this.picKrediKarti.TabStop = false;

            // 
            // rbHavale
            // 
            this.rbHavale.AutoSize = true;
            this.rbHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbHavale.Location = new System.Drawing.Point(260, 70);
            this.rbHavale.Name = "rbHavale";
            this.rbHavale.Size = new System.Drawing.Size(65, 19);
            this.rbHavale.TabIndex = 5;
            this.rbHavale.Text = "Havale";
            this.rbHavale.UseVisualStyleBackColor = true;
            this.rbHavale.CheckedChanged += new System.EventHandler(this.RbOdemeSekli_CheckedChanged);

            // 
            // picHavale
            // 
            this.picHavale.BackColor = System.Drawing.Color.Cyan;
            this.picHavale.Location = new System.Drawing.Point(260, 30);
            this.picHavale.Name = "picHavale";
            this.picHavale.Size = new System.Drawing.Size(60, 35);
            this.picHavale.TabIndex = 6;
            this.picHavale.TabStop = false;

            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOnayla.ForeColor = System.Drawing.Color.White;
            this.btnOnayla.Location = new System.Drawing.Point(30, 390);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(80, 35);
            this.btnOnayla.TabIndex = 14;
            this.btnOnayla.Text = "✓ Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.BtnOnayla_Click);

            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnVazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVazgec.ForeColor = System.Drawing.Color.White;
            this.btnVazgec.Location = new System.Drawing.Point(130, 390);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(80, 35);
            this.btnVazgec.TabIndex = 15;
            this.btnVazgec.Text = "✗ Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            this.btnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);

            // 
            // btnOdemeBilgisiYazdir
            // 
            this.btnOdemeBilgisiYazdir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnOdemeBilgisiYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdemeBilgisiYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOdemeBilgisiYazdir.ForeColor = System.Drawing.Color.White;
            this.btnOdemeBilgisiYazdir.Location = new System.Drawing.Point(270, 390);
            this.btnOdemeBilgisiYazdir.Name = "btnOdemeBilgisiYazdir";
            this.btnOdemeBilgisiYazdir.Size = new System.Drawing.Size(80, 35);
            this.btnOdemeBilgisiYazdir.TabIndex = 16;
            this.btnOdemeBilgisiYazdir.Text = "🖨 Ödeme Bilgisi Yazdır";
            this.btnOdemeBilgisiYazdir.UseVisualStyleBackColor = false;

            // 
            // chkOtomatikYazdir
            // 
            this.chkOtomatikYazdir.AutoSize = true;
            this.chkOtomatikYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkOtomatikYazdir.Location = new System.Drawing.Point(30, 440);
            this.chkOtomatikYazdir.Name = "chkOtomatikYazdir";
            this.chkOtomatikYazdir.Size = new System.Drawing.Size(170, 17);
            this.chkOtomatikYazdir.TabIndex = 17;
            this.chkOtomatikYazdir.Text = "Ödeme Bilgisi Otomatik Yazdırılsın";
            this.chkOtomatikYazdir.UseVisualStyleBackColor = true;

            // 
            // ToptanciyaOdemeYapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 470);
            this.Controls.Add(this.chkOtomatikYazdir);
            this.Controls.Add(this.btnOdemeBilgisiYazdir);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.pnlOdemeSekli);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtOdemeTutari);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.dtpSaat);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.txtToplamBorc);
            this.Controls.Add(this.lblToplamBorc);
            this.Controls.Add(this.txtToptanciAdi);
            this.Controls.Add(this.lblToptanciAdi);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToptanciyaOdemeYapForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TOPTANCIYA ÖDEME YAP";
            this.pnlOdemeSekli.ResumeLayout(false);
            this.pnlOdemeSekli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNakit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKrediKarti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHavale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblToptanciAdi;
        private System.Windows.Forms.TextBox txtToptanciAdi;
        private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.TextBox txtToplamBorc;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.TextBox txtOdemeTutari;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Panel pnlOdemeSekli;
        private System.Windows.Forms.Label lblOdemeSekli;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.RadioButton rbHavale;
        private System.Windows.Forms.PictureBox picNakit;
        private System.Windows.Forms.PictureBox picKrediKarti;
        private System.Windows.Forms.PictureBox picHavale;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnOdemeBilgisiYazdir;
        private System.Windows.Forms.CheckBox chkOtomatikYazdir;
    }
}
