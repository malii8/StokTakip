namespace StokTakip.Forms
{
    partial class FiyatDegistirmeForm
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
            this.lblUrunGrubu = new System.Windows.Forms.Label();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.lblUrunAra = new System.Windows.Forms.Label();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.btnYuzde10Artir = new System.Windows.Forms.Button();
            this.btnYuzde20Artir = new System.Windows.Forms.Button();
            this.btnYuzde30Artir = new System.Windows.Forms.Button();
            this.btnYuzde15Azalt = new System.Windows.Forms.Button();
            this.btnYuzde20Azalt = new System.Windows.Forms.Button();
            this.btnYuzde30Azalt = new System.Windows.Forms.Button();
            this.btnTumunuSec = new System.Windows.Forms.Button();
            this.btnHicbiriniSecme = new System.Windows.Forms.Button();
            this.lblOzelFiyat = new System.Windows.Forms.Label();
            this.txtOzelFiyat = new System.Windows.Forms.TextBox();
            this.btnOzelFiyatUygula = new System.Windows.Forms.Button();
            this.dgvUrunFiyatlari = new System.Windows.Forms.DataGridView();
            this.colSecim = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSatisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunFiyatlari)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunGrubu
            // 
            this.lblUrunGrubu.AutoSize = true;
            this.lblUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrunGrubu.Location = new System.Drawing.Point(20, 20);
            this.lblUrunGrubu.Name = "lblUrunGrubu";
            this.lblUrunGrubu.Size = new System.Drawing.Size(82, 15);
            this.lblUrunGrubu.TabIndex = 0;
            this.lblUrunGrubu.Text = "Ürün Grubu:";
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbUrunGrubu.Location = new System.Drawing.Point(110, 17);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(150, 23);
            this.cmbUrunGrubu.TabIndex = 1;
            // 
            // lblUrunAra
            // 
            this.lblUrunAra.AutoSize = true;
            this.lblUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrunAra.Location = new System.Drawing.Point(300, 20);
            this.lblUrunAra.Name = "lblUrunAra";
            this.lblUrunAra.Size = new System.Drawing.Size(68, 15);
            this.lblUrunAra.TabIndex = 2;
            this.lblUrunAra.Text = "Ürün Ara:";
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.BackColor = System.Drawing.Color.Yellow;
            this.txtUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrunAra.Location = new System.Drawing.Point(375, 17);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(200, 21);
            this.txtUrunAra.TabIndex = 3;
            // 
            // btnYuzde10Artir
            // 
            this.btnYuzde10Artir.BackColor = System.Drawing.Color.LightGreen;
            this.btnYuzde10Artir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYuzde10Artir.Location = new System.Drawing.Point(20, 60);
            this.btnYuzde10Artir.Name = "btnYuzde10Artir";
            this.btnYuzde10Artir.Size = new System.Drawing.Size(90, 40);
            this.btnYuzde10Artir.TabIndex = 4;
            this.btnYuzde10Artir.Text = "%10 ARTIR";
            this.btnYuzde10Artir.UseVisualStyleBackColor = false;
            // 
            // btnYuzde20Artir
            // 
            this.btnYuzde20Artir.BackColor = System.Drawing.Color.LightGreen;
            this.btnYuzde20Artir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYuzde20Artir.Location = new System.Drawing.Point(125, 60);
            this.btnYuzde20Artir.Name = "btnYuzde20Artir";
            this.btnYuzde20Artir.Size = new System.Drawing.Size(90, 40);
            this.btnYuzde20Artir.TabIndex = 5;
            this.btnYuzde20Artir.Text = "%20 ARTIR";
            this.btnYuzde20Artir.UseVisualStyleBackColor = false;
            // 
            // btnYuzde30Artir
            // 
            this.btnYuzde30Artir.BackColor = System.Drawing.Color.LightGreen;
            this.btnYuzde30Artir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYuzde30Artir.Location = new System.Drawing.Point(230, 60);
            this.btnYuzde30Artir.Name = "btnYuzde30Artir";
            this.btnYuzde30Artir.Size = new System.Drawing.Size(90, 40);
            this.btnYuzde30Artir.TabIndex = 6;
            this.btnYuzde30Artir.Text = "%30 ARTIR";
            this.btnYuzde30Artir.UseVisualStyleBackColor = false;
            // 
            // btnYuzde15Azalt
            // 
            this.btnYuzde15Azalt.BackColor = System.Drawing.Color.LightCoral;
            this.btnYuzde15Azalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYuzde15Azalt.Location = new System.Drawing.Point(340, 60);
            this.btnYuzde15Azalt.Name = "btnYuzde15Azalt";
            this.btnYuzde15Azalt.Size = new System.Drawing.Size(90, 40);
            this.btnYuzde15Azalt.TabIndex = 7;
            this.btnYuzde15Azalt.Text = "%15 AZALT";
            this.btnYuzde15Azalt.UseVisualStyleBackColor = false;
            // 
            // btnYuzde20Azalt
            // 
            this.btnYuzde20Azalt.BackColor = System.Drawing.Color.LightCoral;
            this.btnYuzde20Azalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYuzde20Azalt.Location = new System.Drawing.Point(445, 60);
            this.btnYuzde20Azalt.Name = "btnYuzde20Azalt";
            this.btnYuzde20Azalt.Size = new System.Drawing.Size(90, 40);
            this.btnYuzde20Azalt.TabIndex = 8;
            this.btnYuzde20Azalt.Text = "%20 AZALT";
            this.btnYuzde20Azalt.UseVisualStyleBackColor = false;
            // 
            // btnYuzde30Azalt
            // 
            this.btnYuzde30Azalt.BackColor = System.Drawing.Color.LightCoral;
            this.btnYuzde30Azalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYuzde30Azalt.Location = new System.Drawing.Point(550, 60);
            this.btnYuzde30Azalt.Name = "btnYuzde30Azalt";
            this.btnYuzde30Azalt.Size = new System.Drawing.Size(90, 40);
            this.btnYuzde30Azalt.TabIndex = 9;
            this.btnYuzde30Azalt.Text = "%30 AZALT";
            this.btnYuzde30Azalt.UseVisualStyleBackColor = false;
            // 
            // btnTumunuSec
            // 
            this.btnTumunuSec.BackColor = System.Drawing.Color.LightBlue;
            this.btnTumunuSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTumunuSec.Location = new System.Drawing.Point(20, 115);
            this.btnTumunuSec.Name = "btnTumunuSec";
            this.btnTumunuSec.Size = new System.Drawing.Size(100, 30);
            this.btnTumunuSec.TabIndex = 10;
            this.btnTumunuSec.Text = "TÜMÜNÜ SEÇ";
            this.btnTumunuSec.UseVisualStyleBackColor = false;
            // 
            // btnHicbiriniSecme
            // 
            this.btnHicbiriniSecme.BackColor = System.Drawing.Color.LightGray;
            this.btnHicbiriniSecme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHicbiriniSecme.Location = new System.Drawing.Point(140, 115);
            this.btnHicbiriniSecme.Name = "btnHicbiriniSecme";
            this.btnHicbiriniSecme.Size = new System.Drawing.Size(120, 30);
            this.btnHicbiriniSecme.TabIndex = 11;
            this.btnHicbiriniSecme.Text = "HİÇBİRİNİ SEÇME";
            this.btnHicbiriniSecme.UseVisualStyleBackColor = false;
            // 
            // lblOzelFiyat
            // 
            this.lblOzelFiyat.AutoSize = true;
            this.lblOzelFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOzelFiyat.Location = new System.Drawing.Point(300, 122);
            this.lblOzelFiyat.Name = "lblOzelFiyat";
            this.lblOzelFiyat.Size = new System.Drawing.Size(77, 15);
            this.lblOzelFiyat.TabIndex = 12;
            this.lblOzelFiyat.Text = "Özel Fiyat:";
            // 
            // txtOzelFiyat
            // 
            this.txtOzelFiyat.BackColor = System.Drawing.Color.Yellow;
            this.txtOzelFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOzelFiyat.Location = new System.Drawing.Point(385, 119);
            this.txtOzelFiyat.Name = "txtOzelFiyat";
            this.txtOzelFiyat.Size = new System.Drawing.Size(100, 21);
            this.txtOzelFiyat.TabIndex = 13;
            // 
            // btnOzelFiyatUygula
            // 
            this.btnOzelFiyatUygula.BackColor = System.Drawing.Color.Orange;
            this.btnOzelFiyatUygula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOzelFiyatUygula.Location = new System.Drawing.Point(500, 115);
            this.btnOzelFiyatUygula.Name = "btnOzelFiyatUygula";
            this.btnOzelFiyatUygula.Size = new System.Drawing.Size(120, 30);
            this.btnOzelFiyatUygula.TabIndex = 14;
            this.btnOzelFiyatUygula.Text = "ÖZEL FİYAT UYGULA";
            this.btnOzelFiyatUygula.UseVisualStyleBackColor = false;
            // 
            // dgvUrunFiyatlari
            // 
            this.dgvUrunFiyatlari.AllowUserToAddRows = false;
            this.dgvUrunFiyatlari.AllowUserToDeleteRows = false;
            this.dgvUrunFiyatlari.BackgroundColor = System.Drawing.Color.White;
            this.dgvUrunFiyatlari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSecim,
            this.colBarkod,
            this.colUrunAdi,
            this.colAlisFiyati,
            this.colSatisFiyati});
            this.dgvUrunFiyatlari.Location = new System.Drawing.Point(20, 160);
            this.dgvUrunFiyatlari.Name = "dgvUrunFiyatlari";
            this.dgvUrunFiyatlari.RowHeadersVisible = false;
            this.dgvUrunFiyatlari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunFiyatlari.Size = new System.Drawing.Size(750, 300);
            this.dgvUrunFiyatlari.TabIndex = 15;
            // 
            // colSecim
            // 
            this.colSecim.HeaderText = "Seç";
            this.colSecim.Name = "colSecim";
            this.colSecim.Width = 50;
            // 
            // colBarkod
            // 
            this.colBarkod.HeaderText = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.ReadOnly = true;
            this.colBarkod.Width = 80;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.HeaderText = "Ürün Adı";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.ReadOnly = true;
            this.colUrunAdi.Width = 350;
            // 
            // colAlisFiyati
            // 
            this.colAlisFiyati.HeaderText = "Alış Fiyatı";
            this.colAlisFiyati.Name = "colAlisFiyati";
            this.colAlisFiyati.Width = 100;
            // 
            // colSatisFiyati
            // 
            this.colSatisFiyati.HeaderText = "Satış Fiyatı";
            this.colSatisFiyati.Name = "colSatisFiyati";
            this.colSatisFiyati.Width = 100;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightGreen;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKaydet.Location = new System.Drawing.Point(580, 480);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 40);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.Red;
            this.btnVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVazgec.ForeColor = System.Drawing.Color.White;
            this.btnVazgec.Location = new System.Drawing.Point(680, 480);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(90, 40);
            this.btnVazgec.TabIndex = 17;
            this.btnVazgec.Text = "VAZGEÇ";
            this.btnVazgec.UseVisualStyleBackColor = false;
            // 
            // FiyatDegistirmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(790, 540);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvUrunFiyatlari);
            this.Controls.Add(this.btnOzelFiyatUygula);
            this.Controls.Add(this.txtOzelFiyat);
            this.Controls.Add(this.lblOzelFiyat);
            this.Controls.Add(this.btnHicbiriniSecme);
            this.Controls.Add(this.btnTumunuSec);
            this.Controls.Add(this.btnYuzde30Azalt);
            this.Controls.Add(this.btnYuzde20Azalt);
            this.Controls.Add(this.btnYuzde15Azalt);
            this.Controls.Add(this.btnYuzde30Artir);
            this.Controls.Add(this.btnYuzde20Artir);
            this.Controls.Add(this.btnYuzde10Artir);
            this.Controls.Add(this.txtUrunAra);
            this.Controls.Add(this.lblUrunAra);
            this.Controls.Add(this.cmbUrunGrubu);
            this.Controls.Add(this.lblUrunGrubu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FiyatDegistirmeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FİYAT DEĞİŞTİRME";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunFiyatlari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblUrunGrubu;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.Label lblUrunAra;
        private System.Windows.Forms.TextBox txtUrunAra;
        private System.Windows.Forms.Button btnYuzde10Artir;
        private System.Windows.Forms.Button btnYuzde20Artir;
        private System.Windows.Forms.Button btnYuzde30Artir;
        private System.Windows.Forms.Button btnYuzde15Azalt;
        private System.Windows.Forms.Button btnYuzde20Azalt;
        private System.Windows.Forms.Button btnYuzde30Azalt;
        private System.Windows.Forms.Button btnTumunuSec;
        private System.Windows.Forms.Button btnHicbiriniSecme;
        private System.Windows.Forms.Label lblOzelFiyat;
        private System.Windows.Forms.TextBox txtOzelFiyat;
        private System.Windows.Forms.Button btnOzelFiyatUygula;
        private System.Windows.Forms.DataGridView dgvUrunFiyatlari;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSecim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSatisFiyati;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnVazgec;
    }
}
