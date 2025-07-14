namespace StokTakip.Forms
{
    partial class AsgariStokAltiForm
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
            this.lblUrunAdiIleArama = new System.Windows.Forms.Label();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.lblUrunGrubu = new System.Windows.Forms.Label();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.dgvAsgariStokAlti = new System.Windows.Forms.DataGridView();
            this.colBarkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsgariStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMevcutStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOlcuBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSatisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunGrubu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.lblListelenenKayitSayisi = new System.Windows.Forms.Label();
            this.lblKayitSayisiText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsgariStokAlti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunAdiIleArama
            // 
            this.lblUrunAdiIleArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrunAdiIleArama.ForeColor = System.Drawing.Color.Blue;
            this.lblUrunAdiIleArama.Location = new System.Drawing.Point(20, 50);
            this.lblUrunAdiIleArama.Name = "lblUrunAdiIleArama";
            this.lblUrunAdiIleArama.Size = new System.Drawing.Size(350, 20);
            this.lblUrunAdiIleArama.TabIndex = 0;
            this.lblUrunAdiIleArama.Text = "<<< ÜRÜN ADI İLE ARAMA >>>";
            this.lblUrunAdiIleArama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.BackColor = System.Drawing.Color.Yellow;
            this.txtUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrunAra.Location = new System.Drawing.Point(20, 80);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(350, 23);
            this.txtUrunAra.TabIndex = 1;
            // 
            // lblUrunGrubu
            // 
            this.lblUrunGrubu.AutoSize = true;
            this.lblUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrunGrubu.Location = new System.Drawing.Point(450, 55);
            this.lblUrunGrubu.Name = "lblUrunGrubu";
            this.lblUrunGrubu.Size = new System.Drawing.Size(82, 15);
            this.lblUrunGrubu.TabIndex = 2;
            this.lblUrunGrubu.Text = "Ürün Grubu";
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.BackColor = System.Drawing.Color.Yellow;
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbUrunGrubu.Location = new System.Drawing.Point(450, 80);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(200, 23);
            this.cmbUrunGrubu.TabIndex = 3;
            // 
            // dgvAsgariStokAlti
            // 
            this.dgvAsgariStokAlti.AllowUserToAddRows = false;
            this.dgvAsgariStokAlti.AllowUserToDeleteRows = false;
            this.dgvAsgariStokAlti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvAsgariStokAlti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAsgariStokAlti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsgariStokAlti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBarkodNo,
            this.colUrunAdi,
            this.colAsgariStok,
            this.colMevcutStok,
            this.colOlcuBirimi,
            this.colAlisFiyati,
            this.colSatisFiyati,
            this.colUrunGrubu});
            this.dgvAsgariStokAlti.Location = new System.Drawing.Point(20, 120);
            this.dgvAsgariStokAlti.Name = "dgvAsgariStokAlti";
            this.dgvAsgariStokAlti.ReadOnly = true;
            this.dgvAsgariStokAlti.RowHeadersVisible = false;
            this.dgvAsgariStokAlti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsgariStokAlti.Size = new System.Drawing.Size(940, 380);
            this.dgvAsgariStokAlti.TabIndex = 4;
            // 
            // colBarkodNo
            // 
            this.colBarkodNo.HeaderText = "Barkod No";
            this.colBarkodNo.Name = "colBarkodNo";
            this.colBarkodNo.ReadOnly = true;
            this.colBarkodNo.Width = 120;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.HeaderText = "Ürünün Adı";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.ReadOnly = true;
            this.colUrunAdi.Width = 250;
            // 
            // colAsgariStok
            // 
            this.colAsgariStok.HeaderText = "Asgari Stok";
            this.colAsgariStok.Name = "colAsgariStok";
            this.colAsgariStok.ReadOnly = true;
            this.colAsgariStok.Width = 90;
            // 
            // colMevcutStok
            // 
            this.colMevcutStok.HeaderText = "Mevcut Stok";
            this.colMevcutStok.Name = "colMevcutStok";
            this.colMevcutStok.ReadOnly = true;
            this.colMevcutStok.Width = 90;
            // 
            // colOlcuBirimi
            // 
            this.colOlcuBirimi.HeaderText = "Ölçü Birimi";
            this.colOlcuBirimi.Name = "colOlcuBirimi";
            this.colOlcuBirimi.ReadOnly = true;
            this.colOlcuBirimi.Width = 80;
            // 
            // colAlisFiyati
            // 
            this.colAlisFiyati.HeaderText = "Alış Fiyatı";
            this.colAlisFiyati.Name = "colAlisFiyati";
            this.colAlisFiyati.ReadOnly = true;
            this.colAlisFiyati.Width = 90;
            // 
            // colSatisFiyati
            // 
            this.colSatisFiyati.HeaderText = "Satış Fiyatı";
            this.colSatisFiyati.Name = "colSatisFiyati";
            this.colSatisFiyati.ReadOnly = true;
            this.colSatisFiyati.Width = 90;
            // 
            // colUrunGrubu
            // 
            this.colUrunGrubu.HeaderText = "Ürün Grubu";
            this.colUrunGrubu.Name = "colUrunGrubu";
            this.colUrunGrubu.ReadOnly = true;
            this.colUrunGrubu.Width = 120;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.LightGray;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYazdir.Location = new System.Drawing.Point(370, 520);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(100, 40);
            this.btnYazdir.TabIndex = 5;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.BackColor = System.Drawing.Color.LightGreen;
            this.btnExcelAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcelAktar.Location = new System.Drawing.Point(500, 520);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(100, 40);
            this.btnExcelAktar.TabIndex = 6;
            this.btnExcelAktar.Text = "Excel'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = false;
            // 
            // lblListelenenKayitSayisi
            // 
            this.lblListelenenKayitSayisi.BackColor = System.Drawing.Color.Green;
            this.lblListelenenKayitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListelenenKayitSayisi.ForeColor = System.Drawing.Color.White;
            this.lblListelenenKayitSayisi.Location = new System.Drawing.Point(890, 520);
            this.lblListelenenKayitSayisi.Name = "lblListelenenKayitSayisi";
            this.lblListelenenKayitSayisi.Size = new System.Drawing.Size(70, 40);
            this.lblListelenenKayitSayisi.TabIndex = 7;
            this.lblListelenenKayitSayisi.Text = "1";
            this.lblListelenenKayitSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKayitSayisiText
            // 
            this.lblKayitSayisiText.AutoSize = true;
            this.lblKayitSayisiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKayitSayisiText.Location = new System.Drawing.Point(700, 535);
            this.lblKayitSayisiText.Name = "lblKayitSayisiText";
            this.lblKayitSayisiText.Size = new System.Drawing.Size(184, 17);
            this.lblKayitSayisiText.TabIndex = 8;
            this.lblKayitSayisiText.Text = "Listelenen Kayıt Sayısı";
            // 
            // AsgariStokAltiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.lblKayitSayisiText);
            this.Controls.Add(this.lblListelenenKayitSayisi);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.dgvAsgariStokAlti);
            this.Controls.Add(this.cmbUrunGrubu);
            this.Controls.Add(this.lblUrunGrubu);
            this.Controls.Add(this.txtUrunAra);
            this.Controls.Add(this.lblUrunAdiIleArama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AsgariStokAltiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ASGARI STOK ALTINDAKİ ÜRÜNLER";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsgariStokAlti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblUrunAdiIleArama;
        private System.Windows.Forms.TextBox txtUrunAra;
        private System.Windows.Forms.Label lblUrunGrubu;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.DataGridView dgvAsgariStokAlti;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsgariStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMevcutStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOlcuBirimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSatisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunGrubu;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnExcelAktar;
        private System.Windows.Forms.Label lblListelenenKayitSayisi;
        private System.Windows.Forms.Label lblKayitSayisiText;
    }
}
