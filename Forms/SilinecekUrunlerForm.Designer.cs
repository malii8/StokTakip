namespace StokTakip.Forms
{
    partial class SilinecekUrunlerForm
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunGrubu = new System.Windows.Forms.Label();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.chkSadeceStokMiktari = new System.Windows.Forms.CheckBox();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.colBarkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMevcutStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUyari = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblSilinecekUrunlerListesi = new System.Windows.Forms.Label();
            this.dgvSilinecekler = new System.Windows.Forms.DataGridView();
            this.colSilinecekBarkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSilinecekUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSilineceklerTablosuna = new System.Windows.Forms.Button();
            this.btnSilinecekleriTemizle = new System.Windows.Forms.Button();
            this.btnTablodakiUrunleriSil = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilinecekler)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.LightBlue;
            this.pnlLeft.Controls.Add(this.lblUrunAdi);
            this.pnlLeft.Controls.Add(this.txtUrunAdi);
            this.pnlLeft.Controls.Add(this.lblUrunGrubu);
            this.pnlLeft.Controls.Add(this.cmbUrunGrubu);
            this.pnlLeft.Controls.Add(this.chkSadeceStokMiktari);
            this.pnlLeft.Controls.Add(this.dgvUrunler);
            this.pnlLeft.Controls.Add(this.lblUyari);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(500, 600);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.ForeColor = System.Drawing.Color.Blue;
            this.lblUrunAdi.Location = new System.Drawing.Point(25, 60);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(48, 13);
            this.lblUrunAdi.TabIndex = 0;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.BackColor = System.Drawing.Color.Yellow;
            this.txtUrunAdi.Location = new System.Drawing.Point(140, 57);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(320, 20);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // lblUrunGrubu
            // 
            this.lblUrunGrubu.AutoSize = true;
            this.lblUrunGrubu.ForeColor = System.Drawing.Color.Blue;
            this.lblUrunGrubu.Location = new System.Drawing.Point(25, 100);
            this.lblUrunGrubu.Name = "lblUrunGrubu";
            this.lblUrunGrubu.Size = new System.Drawing.Size(64, 13);
            this.lblUrunGrubu.TabIndex = 2;
            this.lblUrunGrubu.Text = "Ürün Grubu";
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Items.AddRange(new object[] {
            "Tümü"});
            this.cmbUrunGrubu.Location = new System.Drawing.Point(140, 97);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(200, 21);
            this.cmbUrunGrubu.TabIndex = 3;
            this.cmbUrunGrubu.Text = "Tümü";
            // 
            // chkSadeceStokMiktari
            // 
            this.chkSadeceStokMiktari.AutoSize = true;
            this.chkSadeceStokMiktari.ForeColor = System.Drawing.Color.Blue;
            this.chkSadeceStokMiktari.Location = new System.Drawing.Point(25, 140);
            this.chkSadeceStokMiktari.Name = "chkSadeceStokMiktari";
            this.chkSadeceStokMiktari.Size = new System.Drawing.Size(213, 17);
            this.chkSadeceStokMiktari.TabIndex = 4;
            this.chkSadeceStokMiktari.Text = "Sadece Stok Miktarı Sıfır Olanlar listelensin";
            this.chkSadeceStokMiktari.UseVisualStyleBackColor = true;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.BackgroundColor = System.Drawing.Color.White;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBarkodNo,
            this.colUrunAdi,
            this.colMevcutStok});
            this.dgvUrunler.Location = new System.Drawing.Point(25, 170);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(450, 350);
            this.dgvUrunler.TabIndex = 5;
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
            // colMevcutStok
            // 
            this.colMevcutStok.HeaderText = "Mevcut Stok";
            this.colMevcutStok.Name = "colMevcutStok";
            this.colMevcutStok.ReadOnly = true;
            this.colMevcutStok.Width = 80;
            // 
            // lblUyari
            // 
            this.lblUyari.BackColor = System.Drawing.Color.Red;
            this.lblUyari.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUyari.ForeColor = System.Drawing.Color.White;
            this.lblUyari.Location = new System.Drawing.Point(0, 570);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(500, 30);
            this.lblUyari.TabIndex = 6;
            this.lblUyari.Text = "Silinecek Ürünün üzerinde Çift Tıklayın";
            this.lblUyari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.LightGray;
            this.pnlRight.Controls.Add(this.lblSilinecekUrunlerListesi);
            this.pnlRight.Controls.Add(this.dgvSilinecekler);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(650, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(400, 600);
            this.pnlRight.TabIndex = 1;
            // 
            // lblSilinecekUrunlerListesi
            // 
            this.lblSilinecekUrunlerListesi.BackColor = System.Drawing.Color.White;
            this.lblSilinecekUrunlerListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSilinecekUrunlerListesi.ForeColor = System.Drawing.Color.Blue;
            this.lblSilinecekUrunlerListesi.Location = new System.Drawing.Point(20, 20);
            this.lblSilinecekUrunlerListesi.Name = "lblSilinecekUrunlerListesi";
            this.lblSilinecekUrunlerListesi.Size = new System.Drawing.Size(360, 40);
            this.lblSilinecekUrunlerListesi.TabIndex = 0;
            this.lblSilinecekUrunlerListesi.Text = "SİLİNECEK ÜRÜNLER LİSTESİ";
            this.lblSilinecekUrunlerListesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSilinecekler
            // 
            this.dgvSilinecekler.AllowUserToAddRows = false;
            this.dgvSilinecekler.AllowUserToDeleteRows = false;
            this.dgvSilinecekler.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dgvSilinecekler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSilinecekBarkodNo,
            this.colSilinecekUrunAdi});
            this.dgvSilinecekler.Location = new System.Drawing.Point(20, 80);
            this.dgvSilinecekler.Name = "dgvSilinecekler";
            this.dgvSilinecekler.ReadOnly = true;
            this.dgvSilinecekler.RowHeadersVisible = false;
            this.dgvSilinecekler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSilinecekler.Size = new System.Drawing.Size(360, 400);
            this.dgvSilinecekler.TabIndex = 1;
            // 
            // colSilinecekBarkodNo
            // 
            this.colSilinecekBarkodNo.HeaderText = "Barkod No";
            this.colSilinecekBarkodNo.Name = "colSilinecekBarkodNo";
            this.colSilinecekBarkodNo.ReadOnly = true;
            this.colSilinecekBarkodNo.Width = 120;
            // 
            // colSilinecekUrunAdi
            // 
            this.colSilinecekUrunAdi.HeaderText = "Ürünün Adı";
            this.colSilinecekUrunAdi.Name = "colSilinecekUrunAdi";
            this.colSilinecekUrunAdi.ReadOnly = true;
            this.colSilinecekUrunAdi.Width = 240;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.LightBlue;
            this.pnlButtons.Controls.Add(this.btnSilineceklerTablosuna);
            this.pnlButtons.Controls.Add(this.btnSilinecekleriTemizle);
            this.pnlButtons.Controls.Add(this.btnTablodakiUrunleriSil);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(500, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(150, 600);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnSilineceklerTablosuna
            // 
            this.btnSilineceklerTablosuna.BackColor = System.Drawing.Color.Blue;
            this.btnSilineceklerTablosuna.ForeColor = System.Drawing.Color.White;
            this.btnSilineceklerTablosuna.Location = new System.Drawing.Point(20, 200);
            this.btnSilineceklerTablosuna.Name = "btnSilineceklerTablosuna";
            this.btnSilineceklerTablosuna.Size = new System.Drawing.Size(110, 70);
            this.btnSilineceklerTablosuna.TabIndex = 0;
            this.btnSilineceklerTablosuna.Text = "Silinecekler Tablosuna Ekle";
            this.btnSilineceklerTablosuna.UseVisualStyleBackColor = false;
            // 
            // btnSilinecekleriTemizle
            // 
            this.btnSilinecekleriTemizle.BackColor = System.Drawing.Color.Red;
            this.btnSilinecekleriTemizle.ForeColor = System.Drawing.Color.White;
            this.btnSilinecekleriTemizle.Location = new System.Drawing.Point(20, 290);
            this.btnSilinecekleriTemizle.Name = "btnSilinecekleriTemizle";
            this.btnSilinecekleriTemizle.Size = new System.Drawing.Size(110, 70);
            this.btnSilinecekleriTemizle.TabIndex = 1;
            this.btnSilinecekleriTemizle.Text = "Silinecekleri Tablosunu Temizle";
            this.btnSilinecekleriTemizle.UseVisualStyleBackColor = false;
            // 
            // btnTablodakiUrunleriSil
            // 
            this.btnTablodakiUrunleriSil.BackColor = System.Drawing.Color.Red;
            this.btnTablodakiUrunleriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTablodakiUrunleriSil.ForeColor = System.Drawing.Color.White;
            this.btnTablodakiUrunleriSil.Location = new System.Drawing.Point(650, 500);
            this.btnTablodakiUrunleriSil.Name = "btnTablodakiUrunleriSil";
            this.btnTablodakiUrunleriSil.Size = new System.Drawing.Size(120, 50);
            this.btnTablodakiUrunleriSil.TabIndex = 2;
            this.btnTablodakiUrunleriSil.Text = "Tablodaki Ürünleri Sil";
            this.btnTablodakiUrunleriSil.UseVisualStyleBackColor = false;
            // 
            // SilinecekUrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SilinecekUrunlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SİLİNECEK ÜRÜNLER";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilinecekler)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblUrunGrubu;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.CheckBox chkSadeceStokMiktari;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMevcutStok;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblSilinecekUrunlerListesi;
        private System.Windows.Forms.DataGridView dgvSilinecekler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSilinecekBarkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSilinecekUrunAdi;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSilineceklerTablosuna;
        private System.Windows.Forms.Button btnSilinecekleriTemizle;
        private System.Windows.Forms.Button btnTablodakiUrunleriSil;
    }
}
