namespace StokTakip.Forms
{
    partial class UrunDuzenleForm
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
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblStokKodu = new System.Windows.Forms.Label();
            this.txtStokKodu = new System.Windows.Forms.TextBox();
            this.lblUrunGrubu = new System.Windows.Forms.Label();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.lblKDVOrani = new System.Windows.Forms.Label();
            this.txtKDVOrani = new System.Windows.Forms.TextBox();
            this.lblMevcutStok = new System.Windows.Forms.Label();
            this.txtMevcutStok = new System.Windows.Forms.TextBox();
            this.lblAsgariStok = new System.Windows.Forms.Label();
            this.txtAsgariStok = new System.Windows.Forms.TextBox();
            this.lblOlcuBirimi = new System.Windows.Forms.Label();
            this.cmbOlcuBirimi = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ÜRÜN DÜZELT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.ForeColor = System.Drawing.Color.Blue;
            this.lblBarkodNo.Location = new System.Drawing.Point(40, 139);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(65, 13);
            this.lblBarkodNo.TabIndex = 1;
            this.lblBarkodNo.Text = "Barkod No:";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.BackColor = System.Drawing.Color.LightCoral;
            this.txtBarkodNo.Location = new System.Drawing.Point(210, 136);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.ReadOnly = true;
            this.txtBarkodNo.Size = new System.Drawing.Size(300, 20);
            this.txtBarkodNo.TabIndex = 2;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.ForeColor = System.Drawing.Color.Blue;
            this.lblUrunAdi.Location = new System.Drawing.Point(40, 179);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(52, 13);
            this.lblUrunAdi.TabIndex = 3;
            this.lblUrunAdi.Text = "Ürünün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.BackColor = System.Drawing.Color.LightGreen;
            this.txtUrunAdi.Location = new System.Drawing.Point(210, 176);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(300, 20);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // lblStokKodu
            // 
            this.lblStokKodu.AutoSize = true;
            this.lblStokKodu.ForeColor = System.Drawing.Color.Blue;
            this.lblStokKodu.Location = new System.Drawing.Point(40, 219);
            this.lblStokKodu.Name = "lblStokKodu";
            this.lblStokKodu.Size = new System.Drawing.Size(58, 13);
            this.lblStokKodu.TabIndex = 5;
            this.lblStokKodu.Text = "Stok Kodu";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(210, 216);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(300, 20);
            this.txtStokKodu.TabIndex = 6;
            // 
            // lblUrunGrubu
            // 
            this.lblUrunGrubu.AutoSize = true;
            this.lblUrunGrubu.ForeColor = System.Drawing.Color.Blue;
            this.lblUrunGrubu.Location = new System.Drawing.Point(40, 259);
            this.lblUrunGrubu.Name = "lblUrunGrubu";
            this.lblUrunGrubu.Size = new System.Drawing.Size(64, 13);
            this.lblUrunGrubu.TabIndex = 7;
            this.lblUrunGrubu.Text = "Ürünün Grubu";
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Items.AddRange(new object[] {
            "BELİRTİLMEDİ",
            "BİSKÜVİ",
            "FİLTRE",
            "SALÇA",
            "YAĞ"});
            this.cmbUrunGrubu.Location = new System.Drawing.Point(210, 256);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(300, 21);
            this.cmbUrunGrubu.TabIndex = 8;
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.ForeColor = System.Drawing.Color.Blue;
            this.lblAlisFiyati.Location = new System.Drawing.Point(40, 299);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(54, 13);
            this.lblAlisFiyati.TabIndex = 9;
            this.lblAlisFiyati.Text = "Alış Fiyatı";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(210, 296);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(140, 20);
            this.txtAlisFiyati.TabIndex = 10;
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.ForeColor = System.Drawing.Color.Blue;
            this.lblSatisFiyati.Location = new System.Drawing.Point(40, 339);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(59, 13);
            this.lblSatisFiyati.TabIndex = 11;
            this.lblSatisFiyati.Text = "Satış Fiyatı";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(210, 336);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(140, 20);
            this.txtSatisFiyati.TabIndex = 12;
            // 
            // lblKDVOrani
            // 
            this.lblKDVOrani.AutoSize = true;
            this.lblKDVOrani.ForeColor = System.Drawing.Color.Blue;
            this.lblKDVOrani.Location = new System.Drawing.Point(40, 419);
            this.lblKDVOrani.Name = "lblKDVOrani";
            this.lblKDVOrani.Size = new System.Drawing.Size(63, 13);
            this.lblKDVOrani.TabIndex = 15;
            this.lblKDVOrani.Text = "KDV Oranı %";
            // 
            // txtKDVOrani
            // 
            this.txtKDVOrani.Location = new System.Drawing.Point(210, 416);
            this.txtKDVOrani.Name = "txtKDVOrani";
            this.txtKDVOrani.Size = new System.Drawing.Size(140, 20);
            this.txtKDVOrani.TabIndex = 16;
            // 
            // lblMevcutStok
            // 
            this.lblMevcutStok.AutoSize = true;
            this.lblMevcutStok.ForeColor = System.Drawing.Color.Blue;
            this.lblMevcutStok.Location = new System.Drawing.Point(40, 459);
            this.lblMevcutStok.Name = "lblMevcutStok";
            this.lblMevcutStok.Size = new System.Drawing.Size(89, 13);
            this.lblMevcutStok.TabIndex = 17;
            this.lblMevcutStok.Text = "Mevcut Stok Miktarı";
            // 
            // txtMevcutStok
            // 
            this.txtMevcutStok.BackColor = System.Drawing.Color.LightGreen;
            this.txtMevcutStok.Location = new System.Drawing.Point(210, 456);
            this.txtMevcutStok.Name = "txtMevcutStok";
            this.txtMevcutStok.Size = new System.Drawing.Size(140, 20);
            this.txtMevcutStok.TabIndex = 18;
            // 
            // lblAsgariStok
            // 
            this.lblAsgariStok.AutoSize = true;
            this.lblAsgariStok.ForeColor = System.Drawing.Color.Blue;
            this.lblAsgariStok.Location = new System.Drawing.Point(40, 499);
            this.lblAsgariStok.Name = "lblAsgariStok";
            this.lblAsgariStok.Size = new System.Drawing.Size(63, 13);
            this.lblAsgariStok.TabIndex = 19;
            this.lblAsgariStok.Text = "Asgari Stok";
            // 
            // txtAsgariStok
            // 
            this.txtAsgariStok.Location = new System.Drawing.Point(210, 496);
            this.txtAsgariStok.Name = "txtAsgariStok";
            this.txtAsgariStok.Size = new System.Drawing.Size(140, 20);
            this.txtAsgariStok.TabIndex = 20;
            // 
            // lblOlcuBirimi
            // 
            this.lblOlcuBirimi.AutoSize = true;
            this.lblOlcuBirimi.ForeColor = System.Drawing.Color.Blue;
            this.lblOlcuBirimi.Location = new System.Drawing.Point(40, 539);
            this.lblOlcuBirimi.Name = "lblOlcuBirimi";
            this.lblOlcuBirimi.Size = new System.Drawing.Size(58, 13);
            this.lblOlcuBirimi.TabIndex = 21;
            this.lblOlcuBirimi.Text = "Ölçü Birimi";
            // 
            // cmbOlcuBirimi
            // 
            this.cmbOlcuBirimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOlcuBirimi.FormattingEnabled = true;
            this.cmbOlcuBirimi.Items.AddRange(new object[] {
            "Adet",
            "Kg",
            "Litre",
            "Metre"});
            this.cmbOlcuBirimi.Location = new System.Drawing.Point(210, 536);
            this.cmbOlcuBirimi.Name = "cmbOlcuBirimi";
            this.cmbOlcuBirimi.Size = new System.Drawing.Size(140, 21);
            this.cmbOlcuBirimi.TabIndex = 22;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightGreen;
            this.btnKaydet.Location = new System.Drawing.Point(130, 609);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 40);
            this.btnKaydet.TabIndex = 23;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.Red;
            this.btnVazgec.ForeColor = System.Drawing.Color.White;
            this.btnVazgec.Location = new System.Drawing.Point(280, 609);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(80, 40);
            this.btnVazgec.TabIndex = 24;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            // 
            // UrunDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(540, 680);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbOlcuBirimi);
            this.Controls.Add(this.lblOlcuBirimi);
            this.Controls.Add(this.txtAsgariStok);
            this.Controls.Add(this.lblAsgariStok);
            this.Controls.Add(this.txtMevcutStok);
            this.Controls.Add(this.lblMevcutStok);
            this.Controls.Add(this.txtKDVOrani);
            this.Controls.Add(this.lblKDVOrani);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.lblAlisFiyati);
            this.Controls.Add(this.cmbUrunGrubu);
            this.Controls.Add(this.lblUrunGrubu);
            this.Controls.Add(this.txtStokKodu);
            this.Controls.Add(this.lblStokKodu);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÜRÜN DÜZELTME";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblStokKodu;
        private System.Windows.Forms.TextBox txtStokKodu;
        private System.Windows.Forms.Label lblUrunGrubu;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label lblKDVOrani;
        private System.Windows.Forms.TextBox txtKDVOrani;
        private System.Windows.Forms.Label lblMevcutStok;
        private System.Windows.Forms.TextBox txtMevcutStok;
        private System.Windows.Forms.Label lblAsgariStok;
        private System.Windows.Forms.TextBox txtAsgariStok;
        private System.Windows.Forms.Label lblOlcuBirimi;
        private System.Windows.Forms.ComboBox cmbOlcuBirimi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnVazgec;
    }
}
