namespace StokTakip.Forms
{
    partial class UrunYeniKayitForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbOlcuBirimi = new System.Windows.Forms.ComboBox();
            this.txtAsgariStok = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtAlisFiyatiKdvHaric = new System.Windows.Forms.TextBox();
            this.txtAlisFiyatiKdvDahil = new System.Windows.Forms.TextBox();
            this.txtKdvOrani = new System.Windows.Forms.TextBox();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.txtStokKodu = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnOtomatikBarkod = new System.Windows.Forms.Button();
            this.rbKdvHaric = new System.Windows.Forms.RadioButton();
            this.rbKdvDahil = new System.Windows.Forms.RadioButton();
            this.lblOlcuBirimi = new System.Windows.Forms.Label();
            this.lblAsgariStok = new System.Windows.Forms.Label();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.lblAlisFiyatiKdvHaric = new System.Windows.Forms.Label();
            this.lblAlisFiyatiKdvDahil = new System.Windows.Forms.Label();
            this.lblKdvOrani = new System.Windows.Forms.Label();
            this.lblUrunGrubu = new System.Windows.Forms.Label();
            this.lblStokKodu = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(150, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ÜRÜN YENİ KAYIT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVazgec);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.cmbOlcuBirimi);
            this.groupBox1.Controls.Add(this.txtAsgariStok);
            this.groupBox1.Controls.Add(this.txtSatisFiyati);
            this.groupBox1.Controls.Add(this.txtAlisFiyatiKdvHaric);
            this.groupBox1.Controls.Add(this.txtAlisFiyatiKdvDahil);
            this.groupBox1.Controls.Add(this.txtKdvOrani);
            this.groupBox1.Controls.Add(this.cmbUrunGrubu);
            this.groupBox1.Controls.Add(this.txtStokKodu);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.txtBarkodNo);
            this.groupBox1.Controls.Add(this.btnOtomatikBarkod);
            this.groupBox1.Controls.Add(this.rbKdvHaric);
            this.groupBox1.Controls.Add(this.rbKdvDahil);
            this.groupBox1.Controls.Add(this.lblOlcuBirimi);
            this.groupBox1.Controls.Add(this.lblAsgariStok);
            this.groupBox1.Controls.Add(this.lblSatisFiyati);
            this.groupBox1.Controls.Add(this.lblAlisFiyatiKdvHaric);
            this.groupBox1.Controls.Add(this.lblAlisFiyatiKdvDahil);
            this.groupBox1.Controls.Add(this.lblKdvOrani);
            this.groupBox1.Controls.Add(this.lblUrunGrubu);
            this.groupBox1.Controls.Add(this.lblStokKodu);
            this.groupBox1.Controls.Add(this.lblUrunAdi);
            this.groupBox1.Controls.Add(this.lblBarkodNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 489);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnVazgec
            // 
            this.btnVazgec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVazgec.Location = new System.Drawing.Point(250, 430);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(100, 40);
            this.btnVazgec.TabIndex = 26;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(140, 430);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 40);
            this.btnKaydet.TabIndex = 25;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // cmbOlcuBirimi
            // 
            this.cmbOlcuBirimi.FormattingEnabled = true;
            this.cmbOlcuBirimi.Location = new System.Drawing.Point(180, 390);
            this.cmbOlcuBirimi.Name = "cmbOlcuBirimi";
            this.cmbOlcuBirimi.Size = new System.Drawing.Size(150, 21);
            this.cmbOlcuBirimi.TabIndex = 24;
            // 
            // txtAsgariStok
            // 
            this.txtAsgariStok.Location = new System.Drawing.Point(180, 360);
            this.txtAsgariStok.Name = "txtAsgariStok";
            this.txtAsgariStok.Size = new System.Drawing.Size(150, 20);
            this.txtAsgariStok.TabIndex = 23;
            // 
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(180, 300);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(150, 20);
            this.txtSatisFiyati.TabIndex = 21;
            // 
            // txtAlisFiyatiKdvHaric
            // 
            this.txtAlisFiyatiKdvHaric.Location = new System.Drawing.Point(180, 270);
            this.txtAlisFiyatiKdvHaric.Name = "txtAlisFiyatiKdvHaric";
            this.txtAlisFiyatiKdvHaric.Size = new System.Drawing.Size(150, 20);
            this.txtAlisFiyatiKdvHaric.TabIndex = 20;
            // 
            // txtAlisFiyatiKdvDahil
            // 
            this.txtAlisFiyatiKdvDahil.Location = new System.Drawing.Point(180, 240);
            this.txtAlisFiyatiKdvDahil.Name = "txtAlisFiyatiKdvDahil";
            this.txtAlisFiyatiKdvDahil.Size = new System.Drawing.Size(150, 20);
            this.txtAlisFiyatiKdvDahil.TabIndex = 19;
            // 
            // txtKdvOrani
            // 
            this.txtKdvOrani.Location = new System.Drawing.Point(180, 210);
            this.txtKdvOrani.Name = "txtKdvOrani";
            this.txtKdvOrani.Size = new System.Drawing.Size(150, 20);
            this.txtKdvOrani.TabIndex = 18;
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(180, 180);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(150, 21);
            this.cmbUrunGrubu.TabIndex = 17;
            this.cmbUrunGrubu.Text = "BELİRTİLMEDİ";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(180, 150);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(150, 20);
            this.txtStokKodu.TabIndex = 16;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.BackColor = System.Drawing.Color.LightGreen;
            this.txtUrunAdi.Location = new System.Drawing.Point(180, 120);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(250, 20);
            this.txtUrunAdi.TabIndex = 15;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.BackColor = System.Drawing.Color.LightCoral;
            this.txtBarkodNo.Location = new System.Drawing.Point(180, 90);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(150, 20);
            this.txtBarkodNo.TabIndex = 14;
            // 
            // btnOtomatikBarkod
            // 
            this.btnOtomatikBarkod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtomatikBarkod.Location = new System.Drawing.Point(340, 88);
            this.btnOtomatikBarkod.Name = "btnOtomatikBarkod";
            this.btnOtomatikBarkod.Size = new System.Drawing.Size(110, 23);
            this.btnOtomatikBarkod.TabIndex = 13;
            this.btnOtomatikBarkod.Text = "Otomatik Barkod No Ver";
            this.btnOtomatikBarkod.UseVisualStyleBackColor = true;
            // 
            // rbKdvHaric
            // 
            this.rbKdvHaric.AutoSize = true;
            this.rbKdvHaric.Location = new System.Drawing.Point(340, 271);
            this.rbKdvHaric.Name = "rbKdvHaric";
            this.rbKdvHaric.Size = new System.Drawing.Size(74, 17);
            this.rbKdvHaric.TabIndex = 12;
            this.rbKdvHaric.Text = "Kdv Hariç";
            this.rbKdvHaric.UseVisualStyleBackColor = true;
            // 
            // rbKdvDahil
            // 
            this.rbKdvDahil.AutoSize = true;
            this.rbKdvDahil.Checked = true;
            this.rbKdvDahil.Location = new System.Drawing.Point(340, 241);
            this.rbKdvDahil.Name = "rbKdvDahil";
            this.rbKdvDahil.Size = new System.Drawing.Size(72, 17);
            this.rbKdvDahil.TabIndex = 11;
            this.rbKdvDahil.TabStop = true;
            this.rbKdvDahil.Text = "Kdv Dahil";
            this.rbKdvDahil.UseVisualStyleBackColor = true;
            // 
            // lblOlcuBirimi
            // 
            this.lblOlcuBirimi.AutoSize = true;
            this.lblOlcuBirimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOlcuBirimi.Location = new System.Drawing.Point(30, 390);
            this.lblOlcuBirimi.Name = "lblOlcuBirimi";
            this.lblOlcuBirimi.Size = new System.Drawing.Size(83, 16);
            this.lblOlcuBirimi.TabIndex = 10;
            this.lblOlcuBirimi.Text = "Ölçü Birimi";
            // 
            // lblAsgariStok
            // 
            this.lblAsgariStok.AutoSize = true;
            this.lblAsgariStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAsgariStok.Location = new System.Drawing.Point(30, 360);
            this.lblAsgariStok.Name = "lblAsgariStok";
            this.lblAsgariStok.Size = new System.Drawing.Size(91, 16);
            this.lblAsgariStok.TabIndex = 9;
            this.lblAsgariStok.Text = "Asgari Stok";
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisFiyati.Location = new System.Drawing.Point(30, 300);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(84, 16);
            this.lblSatisFiyati.TabIndex = 7;
            this.lblSatisFiyati.Text = "Satış Fiyatı";
            // 
            // lblAlisFiyatiKdvHaric
            // 
            this.lblAlisFiyatiKdvHaric.AutoSize = true;
            this.lblAlisFiyatiKdvHaric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlisFiyatiKdvHaric.Location = new System.Drawing.Point(30, 270);
            this.lblAlisFiyatiKdvHaric.Name = "lblAlisFiyatiKdvHaric";
            this.lblAlisFiyatiKdvHaric.Size = new System.Drawing.Size(145, 16);
            this.lblAlisFiyatiKdvHaric.TabIndex = 6;
            this.lblAlisFiyatiKdvHaric.Text = "Alış Fiyatı (Kdv Hariç)";
            // 
            // lblAlisFiyatiKdvDahil
            // 
            this.lblAlisFiyatiKdvDahil.AutoSize = true;
            this.lblAlisFiyatiKdvDahil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlisFiyatiKdvDahil.Location = new System.Drawing.Point(30, 240);
            this.lblAlisFiyatiKdvDahil.Name = "lblAlisFiyatiKdvDahil";
            this.lblAlisFiyatiKdvDahil.Size = new System.Drawing.Size(143, 16);
            this.lblAlisFiyatiKdvDahil.TabIndex = 5;
            this.lblAlisFiyatiKdvDahil.Text = "Alış Fiyatı (Kdv Dahil)";
            // 
            // lblKdvOrani
            // 
            this.lblKdvOrani.AutoSize = true;
            this.lblKdvOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKdvOrani.Location = new System.Drawing.Point(30, 210);
            this.lblKdvOrani.Name = "lblKdvOrani";
            this.lblKdvOrani.Size = new System.Drawing.Size(91, 16);
            this.lblKdvOrani.TabIndex = 4;
            this.lblKdvOrani.Text = "KDV Oranı %";
            // 
            // lblUrunGrubu
            // 
            this.lblUrunGrubu.AutoSize = true;
            this.lblUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunGrubu.Location = new System.Drawing.Point(30, 180);
            this.lblUrunGrubu.Name = "lblUrunGrubu";
            this.lblUrunGrubu.Size = new System.Drawing.Size(89, 16);
            this.lblUrunGrubu.TabIndex = 3;
            this.lblUrunGrubu.Text = "Ürünün Grubu";
            // 
            // lblStokKodu
            // 
            this.lblStokKodu.AutoSize = true;
            this.lblStokKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokKodu.Location = new System.Drawing.Point(30, 150);
            this.lblStokKodu.Name = "lblStokKodu";
            this.lblStokKodu.Size = new System.Drawing.Size(77, 16);
            this.lblStokKodu.TabIndex = 2;
            this.lblStokKodu.Text = "Stok Kodu";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(30, 120);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(79, 16);
            this.lblUrunAdi.TabIndex = 1;
            this.lblUrunAdi.Text = "Ürünün Adı";
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkodNo.Location = new System.Drawing.Point(30, 90);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(84, 16);
            this.lblBarkodNo.TabIndex = 0;
            this.lblBarkodNo.Text = "Barkod No:";
            // 
            // UrunYeniKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "UrunYeniKayitForm";
            this.Text = "ÜRÜN YENİ KAYIT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblStokKodu;
        private System.Windows.Forms.Label lblUrunGrubu;
        private System.Windows.Forms.Label lblKdvOrani;
        private System.Windows.Forms.Label lblAlisFiyatiKdvDahil;
        private System.Windows.Forms.Label lblAlisFiyatiKdvHaric;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Label lblAsgariStok;
        private System.Windows.Forms.Label lblOlcuBirimi;
        private System.Windows.Forms.RadioButton rbKdvHaric;
        private System.Windows.Forms.RadioButton rbKdvDahil;
        private System.Windows.Forms.Button btnOtomatikBarkod;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtStokKodu;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.TextBox txtKdvOrani;
        private System.Windows.Forms.TextBox txtAlisFiyatiKdvDahil;
        private System.Windows.Forms.TextBox txtAlisFiyatiKdvHaric;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtAsgariStok;
        private System.Windows.Forms.ComboBox cmbOlcuBirimi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnVazgec;
    }
}
