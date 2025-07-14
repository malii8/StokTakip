namespace StokTakip.Forms
{
    partial class TahsilatYapForm
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblMusterininAdi = new System.Windows.Forms.Label();
            this.txtMusterininAdi = new System.Windows.Forms.TextBox();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.txtToplamBorc = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.lblSaat = new System.Windows.Forms.Label();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.txtOdemeTutari = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
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
            this.grpOdemeSekli = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNakit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKrediKarti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHavale)).BeginInit();
            this.grpOdemeSekli.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblFormTitle.Location = new System.Drawing.Point(50, 20);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(300, 30);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "MÜŞTERİ ÖDEMESİ";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMusterininAdi
            // 
            this.lblMusterininAdi.AutoSize = true;
            this.lblMusterininAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusterininAdi.ForeColor = System.Drawing.Color.Blue;
            this.lblMusterininAdi.Location = new System.Drawing.Point(30, 70);
            this.lblMusterininAdi.Name = "lblMusterininAdi";
            this.lblMusterininAdi.Size = new System.Drawing.Size(73, 13);
            this.lblMusterininAdi.TabIndex = 1;
            this.lblMusterininAdi.Text = "Müşterinin Adı";
            // 
            // txtMusterininAdi
            // 
            this.txtMusterininAdi.Location = new System.Drawing.Point(130, 67);
            this.txtMusterininAdi.Name = "txtMusterininAdi";
            this.txtMusterininAdi.ReadOnly = true;
            this.txtMusterininAdi.Size = new System.Drawing.Size(230, 20);
            this.txtMusterininAdi.TabIndex = 2;
            this.txtMusterininAdi.Text = "BİLAL";
            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.AutoSize = true;
            this.lblToplamBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBorc.ForeColor = System.Drawing.Color.Blue;
            this.lblToplamBorc.Location = new System.Drawing.Point(30, 100);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(64, 13);
            this.lblToplamBorc.TabIndex = 3;
            this.lblToplamBorc.Text = "Toplam Borç";
            // 
            // txtToplamBorc
            // 
            this.txtToplamBorc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtToplamBorc.Location = new System.Drawing.Point(130, 97);
            this.txtToplamBorc.Name = "txtToplamBorc";
            this.txtToplamBorc.ReadOnly = true;
            this.txtToplamBorc.Size = new System.Drawing.Size(100, 20);
            this.txtToplamBorc.TabIndex = 4;
            this.txtToplamBorc.Text = "0,00 TL";
            this.txtToplamBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.Blue;
            this.lblTarih.Location = new System.Drawing.Point(30, 130);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(130, 127);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(100, 20);
            this.txtTarih.TabIndex = 6;
            this.txtTarih.Text = "12.07.2025";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.Blue;
            this.lblSaat.Location = new System.Drawing.Point(30, 160);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(28, 13);
            this.lblSaat.TabIndex = 7;
            this.lblSaat.Text = "Saat";
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(130, 157);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.ReadOnly = true;
            this.txtSaat.Size = new System.Drawing.Size(100, 20);
            this.txtSaat.TabIndex = 8;
            this.txtSaat.Text = "17:46:11";
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTutari.ForeColor = System.Drawing.Color.Blue;
            this.lblOdemeTutari.Location = new System.Drawing.Point(30, 190);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(72, 13);
            this.lblOdemeTutari.TabIndex = 9;
            this.lblOdemeTutari.Text = "Ödeme Tutarı";
            // 
            // txtOdemeTutari
            // 
            this.txtOdemeTutari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeTutari.Location = new System.Drawing.Point(130, 187);
            this.txtOdemeTutari.Name = "txtOdemeTutari";
            this.txtOdemeTutari.Size = new System.Drawing.Size(200, 26);
            this.txtOdemeTutari.TabIndex = 10;
            this.txtOdemeTutari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.Blue;
            this.lblAciklama.Location = new System.Drawing.Point(30, 230);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 11;
            this.lblAciklama.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(30, 250);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(330, 60);
            this.txtAciklama.TabIndex = 12;
            // 
            // lblOdemeSekli
            // 
            this.lblOdemeSekli.AutoSize = true;
            this.lblOdemeSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeSekli.ForeColor = System.Drawing.Color.Red;
            this.lblOdemeSekli.Location = new System.Drawing.Point(30, 330);
            this.lblOdemeSekli.Name = "lblOdemeSekli";
            this.lblOdemeSekli.Size = new System.Drawing.Size(89, 13);
            this.lblOdemeSekli.TabIndex = 13;
            this.lblOdemeSekli.Text = "ÖDEME ŞEKLİ";
            // 
            // grpOdemeSekli
            // 
            this.grpOdemeSekli.Controls.Add(this.picHavale);
            this.grpOdemeSekli.Controls.Add(this.picKrediKarti);
            this.grpOdemeSekli.Controls.Add(this.picNakit);
            this.grpOdemeSekli.Controls.Add(this.rbHavale);
            this.grpOdemeSekli.Controls.Add(this.rbKrediKarti);
            this.grpOdemeSekli.Controls.Add(this.rbNakit);
            this.grpOdemeSekli.Location = new System.Drawing.Point(30, 350);
            this.grpOdemeSekli.Name = "grpOdemeSekli";
            this.grpOdemeSekli.Size = new System.Drawing.Size(330, 100);
            this.grpOdemeSekli.TabIndex = 14;
            this.grpOdemeSekli.TabStop = false;
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNakit.ForeColor = System.Drawing.Color.Blue;
            this.rbNakit.Location = new System.Drawing.Point(20, 30);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(56, 19);
            this.rbNakit.TabIndex = 15;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKrediKarti.ForeColor = System.Drawing.Color.Blue;
            this.rbKrediKarti.Location = new System.Drawing.Point(20, 55);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(90, 19);
            this.rbKrediKarti.TabIndex = 16;
            this.rbKrediKarti.Text = "Kredi Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            // 
            // rbHavale
            // 
            this.rbHavale.AutoSize = true;
            this.rbHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbHavale.ForeColor = System.Drawing.Color.Blue;
            this.rbHavale.Location = new System.Drawing.Point(20, 80);
            this.rbHavale.Name = "rbHavale";
            this.rbHavale.Size = new System.Drawing.Size(64, 19);
            this.rbHavale.TabIndex = 17;
            this.rbHavale.Text = "Havale";
            this.rbHavale.UseVisualStyleBackColor = true;
            // 
            // picNakit
            // 
            this.picNakit.BackColor = System.Drawing.Color.LightGray;
            this.picNakit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNakit.Location = new System.Drawing.Point(200, 25);
            this.picNakit.Name = "picNakit";
            this.picNakit.Size = new System.Drawing.Size(40, 20);
            this.picNakit.TabIndex = 18;
            this.picNakit.TabStop = false;
            // 
            // picKrediKarti
            // 
            this.picKrediKarti.BackColor = System.Drawing.Color.Blue;
            this.picKrediKarti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picKrediKarti.Location = new System.Drawing.Point(200, 50);
            this.picKrediKarti.Name = "picKrediKarti";
            this.picKrediKarti.Size = new System.Drawing.Size(40, 20);
            this.picKrediKarti.TabIndex = 19;
            this.picKrediKarti.TabStop = false;
            // 
            // picHavale
            // 
            this.picHavale.BackColor = System.Drawing.Color.Green;
            this.picHavale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHavale.Location = new System.Drawing.Point(200, 75);
            this.picHavale.Name = "picHavale";
            this.picHavale.Size = new System.Drawing.Size(40, 20);
            this.picHavale.TabIndex = 20;
            this.picHavale.TabStop = false;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.Green;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.ForeColor = System.Drawing.Color.White;
            this.btnOnayla.Location = new System.Drawing.Point(70, 520);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(80, 35);
            this.btnOnayla.TabIndex = 21;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.Red;
            this.btnVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.ForeColor = System.Drawing.Color.White;
            this.btnVazgec.Location = new System.Drawing.Point(160, 520);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(80, 35);
            this.btnVazgec.TabIndex = 22;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            // 
            // btnOdemeBilgisiYazdir
            // 
            this.btnOdemeBilgisiYazdir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOdemeBilgisiYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeBilgisiYazdir.ForeColor = System.Drawing.Color.White;
            this.btnOdemeBilgisiYazdir.Location = new System.Drawing.Point(250, 520);
            this.btnOdemeBilgisiYazdir.Name = "btnOdemeBilgisiYazdir";
            this.btnOdemeBilgisiYazdir.Size = new System.Drawing.Size(80, 35);
            this.btnOdemeBilgisiYazdir.TabIndex = 23;
            this.btnOdemeBilgisiYazdir.Text = "Ödeme\nBilgisi\nYazdır";
            this.btnOdemeBilgisiYazdir.UseVisualStyleBackColor = false;
            // 
            // chkOtomatikYazdir
            // 
            this.chkOtomatikYazdir.AutoSize = true;
            this.chkOtomatikYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkOtomatikYazdir.ForeColor = System.Drawing.Color.Blue;
            this.chkOtomatikYazdir.Location = new System.Drawing.Point(30, 470);
            this.chkOtomatikYazdir.Name = "chkOtomatikYazdir";
            this.chkOtomatikYazdir.Size = new System.Drawing.Size(165, 17);
            this.chkOtomatikYazdir.TabIndex = 24;
            this.chkOtomatikYazdir.Text = "Ödeme Bilgisi Otomatik Yazdırılsın";
            this.chkOtomatikYazdir.UseVisualStyleBackColor = true;
            // 
            // TahsilatYapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(400, 580);
            this.Controls.Add(this.chkOtomatikYazdir);
            this.Controls.Add(this.btnOdemeBilgisiYazdir);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.grpOdemeSekli);
            this.Controls.Add(this.lblOdemeSekli);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtOdemeTutari);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.txtSaat);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.txtToplamBorc);
            this.Controls.Add(this.lblToplamBorc);
            this.Controls.Add(this.txtMusterininAdi);
            this.Controls.Add(this.lblMusterininAdi);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TahsilatYapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİDEN ÖDEME ALMA";
            ((System.ComponentModel.ISupportInitialize)(this.picNakit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKrediKarti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHavale)).EndInit();
            this.grpOdemeSekli.ResumeLayout(false);
            this.grpOdemeSekli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblMusterininAdi;
        private System.Windows.Forms.TextBox txtMusterininAdi;
        private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.TextBox txtToplamBorc;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.TextBox txtOdemeTutari;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblOdemeSekli;
        private System.Windows.Forms.GroupBox grpOdemeSekli;
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
