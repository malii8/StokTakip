namespace StokTakip.Forms
{
    partial class UrunGirisForm
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
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnOtomatikBarkod = new System.Windows.Forms.Button();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.lblUrunGrubu = new System.Windows.Forms.Label();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.btnYeniUrunGrubu = new System.Windows.Forms.Button();
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
            this.lblMevcutStok = new System.Windows.Forms.Label();
            this.txtMevcutStok = new System.Windows.Forms.TextBox();
            this.lblOlcuBirimi = new System.Windows.Forms.Label();
            this.txtOlcuBirimi = new System.Windows.Forms.TextBox();
            this.lblAsgariStok = new System.Windows.Forms.Label();
            this.txtAsgariStok = new System.Windows.Forms.TextBox();
            this.lblToptanci = new System.Windows.Forms.Label();
            this.cmbToptanci = new System.Windows.Forms.ComboBox();
            this.btnYeniToptanci = new System.Windows.Forms.Button();
            this.lblOdemeSekli = new System.Windows.Forms.Label();
            this.cmbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.lblZorunluAlanlar = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.btnFaturaliGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(40, 40);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(75, 13);
            this.lblBarkodNo.TabIndex = 0;
            this.lblBarkodNo.Text = "Barkod No:";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(150, 37);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(200, 20);
            this.txtBarkodNo.TabIndex = 1;
            // 
            // btnOtomatikBarkod
            // 
            this.btnOtomatikBarkod.Location = new System.Drawing.Point(360, 35);
            this.btnOtomatikBarkod.Name = "btnOtomatikBarkod";
            this.btnOtomatikBarkod.Size = new System.Drawing.Size(150, 23);
            this.btnOtomatikBarkod.TabIndex = 2;
            this.btnOtomatikBarkod.Text = "Otomatik Barkod No Ver";
            this.btnOtomatikBarkod.UseVisualStyleBackColor = true;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(40, 70);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(62, 13);
            this.lblUrunAdi.TabIndex = 3;
            this.lblUrunAdi.Text = "Ürünün Adı:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(150, 67);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(200, 20);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.AutoSize = true;
            this.lblUrunKodu.Location = new System.Drawing.Point(40, 100);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(117, 13);
            this.lblUrunKodu.TabIndex = 5;
            this.lblUrunKodu.Text = "Ürün Kodu - Açıklama:";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(150, 97);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(200, 20);
            this.txtUrunKodu.TabIndex = 6;
            // 
            // lblUrunGrubu
            // 
            this.lblUrunGrubu.AutoSize = true;
            this.lblUrunGrubu.Location = new System.Drawing.Point(40, 130);
            this.lblUrunGrubu.Name = "lblUrunGrubu";
            this.lblUrunGrubu.Size = new System.Drawing.Size(93, 13);
            this.lblUrunGrubu.TabIndex = 7;
            this.lblUrunGrubu.Text = "Ürün Grubu Seç:";
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(150, 127);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(200, 21);
            this.cmbUrunGrubu.TabIndex = 8;
            // 
            // btnYeniUrunGrubu
            // 
            this.btnYeniUrunGrubu.Location = new System.Drawing.Point(360, 125);
            this.btnYeniUrunGrubu.Name = "btnYeniUrunGrubu";
            this.btnYeniUrunGrubu.Size = new System.Drawing.Size(150, 23);
            this.btnYeniUrunGrubu.TabIndex = 9;
            this.btnYeniUrunGrubu.Text = "Yeni Ürün Grubu Ekle";
            this.btnYeniUrunGrubu.UseVisualStyleBackColor = true;
            // 
            // lblAlisFiyatiKdvDahil
            // 
            this.lblAlisFiyatiKdvDahil.AutoSize = true;
            this.lblAlisFiyatiKdvDahil.Location = new System.Drawing.Point(40, 160);
            this.lblAlisFiyatiKdvDahil.Name = "lblAlisFiyatiKdvDahil";
            this.lblAlisFiyatiKdvDahil.Size = new System.Drawing.Size(108, 13);
            this.lblAlisFiyatiKdvDahil.TabIndex = 10;
            this.lblAlisFiyatiKdvDahil.Text = "Alış Fiyatı (Kdv Dahil):";
            // 
            // txtAlisFiyatiKdvDahil
            // 
            this.txtAlisFiyatiKdvDahil.Location = new System.Drawing.Point(150, 157);
            this.txtAlisFiyatiKdvDahil.Name = "txtAlisFiyatiKdvDahil";
            this.txtAlisFiyatiKdvDahil.Size = new System.Drawing.Size(100, 20);
            this.txtAlisFiyatiKdvDahil.TabIndex = 11;
            // 
            // rbKdvDahil
            // 
            this.rbKdvDahil.AutoSize = true;
            this.rbKdvDahil.Checked = true;
            this.rbKdvDahil.Location = new System.Drawing.Point(260, 158);
            this.rbKdvDahil.Name = "rbKdvDahil";
            this.rbKdvDahil.Size = new System.Drawing.Size(72, 17);
            this.rbKdvDahil.TabIndex = 12;
            this.rbKdvDahil.TabStop = true;
            this.rbKdvDahil.Text = "Kdv Dahil";
            this.rbKdvDahil.UseVisualStyleBackColor = true;
            // 
            // rbKdvHaric
            // 
            this.rbKdvHaric.AutoSize = true;
            this.rbKdvHaric.Location = new System.Drawing.Point(340, 158);
            this.rbKdvHaric.Name = "rbKdvHaric";
            this.rbKdvHaric.Size = new System.Drawing.Size(74, 17);
            this.rbKdvHaric.TabIndex = 13;
            this.rbKdvHaric.Text = "Kdv Hariç";
            this.rbKdvHaric.UseVisualStyleBackColor = true;
            // 
            // lblAlisFiyatiKdvHaric
            // 
            this.lblAlisFiyatiKdvHaric.AutoSize = true;
            this.lblAlisFiyatiKdvHaric.Location = new System.Drawing.Point(40, 190);
            this.lblAlisFiyatiKdvHaric.Name = "lblAlisFiyatiKdvHaric";
            this.lblAlisFiyatiKdvHaric.Size = new System.Drawing.Size(110, 13);
            this.lblAlisFiyatiKdvHaric.TabIndex = 14;
            this.lblAlisFiyatiKdvHaric.Text = "Alış Fiyatı (Kdv Hariç):";
            // 
            // txtAlisFiyatiKdvHaric
            // 
            this.txtAlisFiyatiKdvHaric.Location = new System.Drawing.Point(150, 187);
            this.txtAlisFiyatiKdvHaric.Name = "txtAlisFiyatiKdvHaric";
            this.txtAlisFiyatiKdvHaric.Size = new System.Drawing.Size(100, 20);
            this.txtAlisFiyatiKdvHaric.TabIndex = 15;
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Location = new System.Drawing.Point(40, 220);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(63, 13);
            this.lblSatisFiyati.TabIndex = 16;
            this.lblSatisFiyati.Text = "Satış Fiyatı:";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(150, 217);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtSatisFiyati.TabIndex = 17;
            // 
            // lblKdvOrani
            // 
            this.lblKdvOrani.AutoSize = true;
            this.lblKdvOrani.Location = new System.Drawing.Point(40, 250);
            this.lblKdvOrani.Name = "lblKdvOrani";
            this.lblKdvOrani.Size = new System.Drawing.Size(70, 13);
            this.lblKdvOrani.TabIndex = 18;
            this.lblKdvOrani.Text = "KDV Oranı %:";
            // 
            // txtKdvOrani
            // 
            this.txtKdvOrani.Location = new System.Drawing.Point(150, 247);
            this.txtKdvOrani.Name = "txtKdvOrani";
            this.txtKdvOrani.Size = new System.Drawing.Size(100, 20);
            this.txtKdvOrani.TabIndex = 19;
            this.txtKdvOrani.Text = "10";
            // 
            // lblMevcutStok
            // 
            this.lblMevcutStok.AutoSize = true;
            this.lblMevcutStok.Location = new System.Drawing.Point(40, 280);
            this.lblMevcutStok.Name = "lblMevcutStok";
            this.lblMevcutStok.Size = new System.Drawing.Size(107, 13);
            this.lblMevcutStok.TabIndex = 20;
            this.lblMevcutStok.Text = "Mevcut Stok Miktarı:";
            // 
            // txtMevcutStok
            // 
            this.txtMevcutStok.BackColor = System.Drawing.Color.LightCoral;
            this.txtMevcutStok.Location = new System.Drawing.Point(150, 277);
            this.txtMevcutStok.Name = "txtMevcutStok";
            this.txtMevcutStok.Size = new System.Drawing.Size(100, 20);
            this.txtMevcutStok.TabIndex = 21;
            // 
            // lblOlcuBirimi
            // 
            this.lblOlcuBirimi.AutoSize = true;
            this.lblOlcuBirimi.Location = new System.Drawing.Point(40, 310);
            this.lblOlcuBirimi.Name = "lblOlcuBirimi";
            this.lblOlcuBirimi.Size = new System.Drawing.Size(62, 13);
            this.lblOlcuBirimi.TabIndex = 22;
            this.lblOlcuBirimi.Text = "Ölçü Birimi:";
            // 
            // txtOlcuBirimi
            // 
            this.txtOlcuBirimi.Location = new System.Drawing.Point(150, 307);
            this.txtOlcuBirimi.Name = "txtOlcuBirimi";
            this.txtOlcuBirimi.Size = new System.Drawing.Size(100, 20);
            this.txtOlcuBirimi.TabIndex = 23;
            // 
            // lblAsgariStok
            // 
            this.lblAsgariStok.AutoSize = true;
            this.lblAsgariStok.Location = new System.Drawing.Point(40, 340);
            this.lblAsgariStok.Name = "lblAsgariStok";
            this.lblAsgariStok.Size = new System.Drawing.Size(68, 13);
            this.lblAsgariStok.TabIndex = 24;
            this.lblAsgariStok.Text = "Asgari Stok:";
            // 
            // txtAsgariStok
            // 
            this.txtAsgariStok.Location = new System.Drawing.Point(150, 337);
            this.txtAsgariStok.Name = "txtAsgariStok";
            this.txtAsgariStok.Size = new System.Drawing.Size(100, 20);
            this.txtAsgariStok.TabIndex = 25;
            this.txtAsgariStok.Text = "0";
            // 
            // lblToptanci
            // 
            this.lblToptanci.AutoSize = true;
            this.lblToptanci.Location = new System.Drawing.Point(40, 370);
            this.lblToptanci.Name = "lblToptanci";
            this.lblToptanci.Size = new System.Drawing.Size(73, 13);
            this.lblToptanci.TabIndex = 26;
            this.lblToptanci.Text = "Toptancı Adı:";
            // 
            // cmbToptanci
            // 
            this.cmbToptanci.FormattingEnabled = true;
            this.cmbToptanci.Location = new System.Drawing.Point(150, 367);
            this.cmbToptanci.Name = "cmbToptanci";
            this.cmbToptanci.Size = new System.Drawing.Size(200, 21);
            this.cmbToptanci.TabIndex = 27;
            // 
            // btnYeniToptanci
            // 
            this.btnYeniToptanci.Location = new System.Drawing.Point(360, 365);
            this.btnYeniToptanci.Name = "btnYeniToptanci";
            this.btnYeniToptanci.Size = new System.Drawing.Size(150, 23);
            this.btnYeniToptanci.TabIndex = 28;
            this.btnYeniToptanci.Text = "Yeni Toptancı Ekle";
            this.btnYeniToptanci.UseVisualStyleBackColor = true;
            // 
            // lblOdemeSekli
            // 
            this.lblOdemeSekli.AutoSize = true;
            this.lblOdemeSekli.Location = new System.Drawing.Point(40, 400);
            this.lblOdemeSekli.Name = "lblOdemeSekli";
            this.lblOdemeSekli.Size = new System.Drawing.Size(72, 13);
            this.lblOdemeSekli.TabIndex = 29;
            this.lblOdemeSekli.Text = "Ödeme Şekli:";
            // 
            // cmbOdemeSekli
            // 
            this.cmbOdemeSekli.FormattingEnabled = true;
            this.cmbOdemeSekli.Location = new System.Drawing.Point(150, 397);
            this.cmbOdemeSekli.Name = "cmbOdemeSekli";
            this.cmbOdemeSekli.Size = new System.Drawing.Size(200, 21);
            this.cmbOdemeSekli.TabIndex = 30;
            // 
            // lblZorunluAlanlar
            // 
            this.lblZorunluAlanlar.AutoSize = true;
            this.lblZorunluAlanlar.ForeColor = System.Drawing.Color.Red;
            this.lblZorunluAlanlar.Location = new System.Drawing.Point(40, 450);
            this.lblZorunluAlanlar.Name = "lblZorunluAlanlar";
            this.lblZorunluAlanlar.Size = new System.Drawing.Size(132, 13);
            this.lblZorunluAlanlar.TabIndex = 31;
            this.lblZorunluAlanlar.Text = "* Girilmesi Mecburi Olan Satırlar";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(40, 480);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 40);
            this.btnKaydet.TabIndex = 32;
            this.btnKaydet.Text = "Kaydet (F1)";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(150, 480);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(100, 40);
            this.btnVazgec.TabIndex = 33;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.Location = new System.Drawing.Point(280, 480);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(120, 40);
            this.btnUrunAra.TabIndex = 34;
            this.btnUrunAra.Text = "Ürün Adı İle Arama (F2)";
            this.btnUrunAra.UseVisualStyleBackColor = true;
            // 
            // btnFaturaliGiris
            // 
            this.btnFaturaliGiris.Location = new System.Drawing.Point(410, 480);
            this.btnFaturaliGiris.Name = "btnFaturaliGiris";
            this.btnFaturaliGiris.Size = new System.Drawing.Size(120, 40);
            this.btnFaturaliGiris.TabIndex = 35;
            this.btnFaturaliGiris.Text = "Faturalı Ürün Girişi";
            this.btnFaturaliGiris.UseVisualStyleBackColor = true;
            // 
            // UrunGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnFaturaliGiris);
            this.Controls.Add(this.btnUrunAra);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblZorunluAlanlar);
            this.Controls.Add(this.cmbOdemeSekli);
            this.Controls.Add(this.lblOdemeSekli);
            this.Controls.Add(this.btnYeniToptanci);
            this.Controls.Add(this.cmbToptanci);
            this.Controls.Add(this.lblToptanci);
            this.Controls.Add(this.txtAsgariStok);
            this.Controls.Add(this.lblAsgariStok);
            this.Controls.Add(this.txtOlcuBirimi);
            this.Controls.Add(this.lblOlcuBirimi);
            this.Controls.Add(this.txtMevcutStok);
            this.Controls.Add(this.lblMevcutStok);
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
            this.Controls.Add(this.btnYeniUrunGrubu);
            this.Controls.Add(this.cmbUrunGrubu);
            this.Controls.Add(this.lblUrunGrubu);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.lblUrunKodu);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.btnOtomatikBarkod);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.lblBarkodNo);
            this.Name = "UrunGirisForm";
            this.Text = "ÜRÜN GİRİŞİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnOtomatikBarkod;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Label lblUrunGrubu;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.Button btnYeniUrunGrubu;
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
        private System.Windows.Forms.Label lblMevcutStok;
        private System.Windows.Forms.TextBox txtMevcutStok;
        private System.Windows.Forms.Label lblOlcuBirimi;
        private System.Windows.Forms.TextBox txtOlcuBirimi;
        private System.Windows.Forms.Label lblAsgariStok;
        private System.Windows.Forms.TextBox txtAsgariStok;
        private System.Windows.Forms.Label lblToptanci;
        private System.Windows.Forms.ComboBox cmbToptanci;
        private System.Windows.Forms.Button btnYeniToptanci;
        private System.Windows.Forms.Label lblOdemeSekli;
        private System.Windows.Forms.ComboBox cmbOdemeSekli;
        private System.Windows.Forms.Label lblZorunluAlanlar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.Button btnFaturaliGiris;
    }
}
