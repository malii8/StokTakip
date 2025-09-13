namespace StokTakip.Forms
{
    partial class UrunGruplariForm
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
            this.lblSecilenUrunGrubu = new System.Windows.Forms.Label();
            this.btnSecilenUrunGrubunuSil = new System.Windows.Forms.Button();
            this.btnYeniUrunGrubuEkle = new System.Windows.Forms.Button();
            this.lblUrunGrubuAdi = new System.Windows.Forms.Label();
            this.txtUrunGrubuAdi = new System.Windows.Forms.TextBox();
            this.dgvUrunGruplari = new System.Windows.Forms.DataGridView();
            this.colSiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunGrubuAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRightSection = new System.Windows.Forms.Panel();
            this.lblRightSectionTitle = new System.Windows.Forms.Label();
            this.btnTablodakiUrunlerinGrubunuDegistir = new System.Windows.Forms.Button();
            this.cmbYeniUrunGrubu = new System.Windows.Forms.ComboBox();
            this.lblYeniUrunGrubu = new System.Windows.Forms.Label();
            this.dgvDegisecekUrunler = new System.Windows.Forms.DataGridView();
            this.colDegisecekBarkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDegisecekUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUrunGrubuDegisecekTemizle = new System.Windows.Forms.Button();
            this.btnUrunGrubuDegisecekEkle = new System.Windows.Forms.Button();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.colBarkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunGrubu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbUrunGrubuFilter = new System.Windows.Forms.ComboBox();
            this.lblUrunGrubuFilter = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunGruplari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegisecekUrunler)).BeginInit();
            this.pnlRightSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSecilenUrunGrubu
            // 
            this.lblSecilenUrunGrubu.AutoSize = true;
            this.lblSecilenUrunGrubu.ForeColor = System.Drawing.Color.Blue;
            this.lblSecilenUrunGrubu.Location = new System.Drawing.Point(50, 78);
            this.lblSecilenUrunGrubu.Name = "lblSecilenUrunGrubu";
            this.lblSecilenUrunGrubu.Size = new System.Drawing.Size(103, 13);
            this.lblSecilenUrunGrubu.TabIndex = 0;
            this.lblSecilenUrunGrubu.Text = "Seçilen Ürün Grubu";
            // 
            // btnSecilenUrunGrubunuSil
            // 
            this.btnSecilenUrunGrubunuSil.BackColor = System.Drawing.Color.Red;
            this.btnSecilenUrunGrubunuSil.ForeColor = System.Drawing.Color.White;
            this.btnSecilenUrunGrubunuSil.Location = new System.Drawing.Point(270, 125);
            this.btnSecilenUrunGrubunuSil.Name = "btnSecilenUrunGrubunuSil";
            this.btnSecilenUrunGrubunuSil.Size = new System.Drawing.Size(120, 50);
            this.btnSecilenUrunGrubunuSil.TabIndex = 2;
            this.btnSecilenUrunGrubunuSil.Text = "Seçilen Ürün Grubunu Sil";
            this.btnSecilenUrunGrubunuSil.UseVisualStyleBackColor = false;
            // 
            // btnYeniUrunGrubuEkle
            // 
            this.btnYeniUrunGrubuEkle.BackColor = System.Drawing.Color.Blue;
            this.btnYeniUrunGrubuEkle.ForeColor = System.Drawing.Color.White;
            this.btnYeniUrunGrubuEkle.Location = new System.Drawing.Point(450, 125);
            this.btnYeniUrunGrubuEkle.Name = "btnYeniUrunGrubuEkle";
            this.btnYeniUrunGrubuEkle.Size = new System.Drawing.Size(120, 50);
            this.btnYeniUrunGrubuEkle.TabIndex = 3;
            this.btnYeniUrunGrubuEkle.Text = "Yeni Ürün Grubu Ekle";
            this.btnYeniUrunGrubuEkle.UseVisualStyleBackColor = false;
            // 
            // lblUrunGrubuAdi
            // 
            this.lblUrunGrubuAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrunGrubuAdi.ForeColor = System.Drawing.Color.Blue;
            this.lblUrunGrubuAdi.Location = new System.Drawing.Point(200, 208);
            this.lblUrunGrubuAdi.Name = "lblUrunGrubuAdi";
            this.lblUrunGrubuAdi.Size = new System.Drawing.Size(250, 20);
            this.lblUrunGrubuAdi.TabIndex = 4;
            this.lblUrunGrubuAdi.Text = "<<< Ürün Grubu Adı >>>";
            this.lblUrunGrubuAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUrunGrubuAdi
            // 
            this.txtUrunGrubuAdi.BackColor = System.Drawing.Color.Yellow;
            this.txtUrunGrubuAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrunGrubuAdi.Location = new System.Drawing.Point(145, 240);
            this.txtUrunGrubuAdi.Name = "txtUrunGrubuAdi";
            this.txtUrunGrubuAdi.Size = new System.Drawing.Size(360, 23);
            this.txtUrunGrubuAdi.TabIndex = 5;
            // 
            // dgvUrunGruplari
            // 
            this.dgvUrunGruplari.AllowUserToAddRows = false;
            this.dgvUrunGruplari.AllowUserToDeleteRows = false;
            this.dgvUrunGruplari.BackgroundColor = System.Drawing.Color.White;
            this.dgvUrunGruplari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSiraNo,
            this.colUrunGrubuAdi});
            this.dgvUrunGruplari.Location = new System.Drawing.Point(25, 280);
            this.dgvUrunGruplari.MultiSelect = false;
            this.dgvUrunGruplari.Name = "dgvUrunGruplari";
            this.dgvUrunGruplari.ReadOnly = true;
            this.dgvUrunGruplari.RowHeadersVisible = false;
            this.dgvUrunGruplari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunGruplari.Size = new System.Drawing.Size(600, 200);
            this.dgvUrunGruplari.TabIndex = 6;
            // 
            // colSiraNo
            // 
            this.colSiraNo.HeaderText = "Sıra No";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.ReadOnly = true;
            this.colSiraNo.Width = 100;
            // 
            // colUrunGrubuAdi
            // 
            this.colUrunGrubuAdi.HeaderText = "Ürün Grubu Adı";
            this.colUrunGrubuAdi.Name = "colUrunGrubuAdi";
            this.colUrunGrubuAdi.ReadOnly = true;
            this.colUrunGrubuAdi.Width = 500;
            // 
            // pnlRightSection
            // 
            this.pnlRightSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRightSection.Controls.Add(this.lblRightSectionTitle);
            this.pnlRightSection.Controls.Add(this.btnTablodakiUrunlerinGrubunuDegistir);
            this.pnlRightSection.Controls.Add(this.cmbYeniUrunGrubu);
            this.pnlRightSection.Controls.Add(this.lblYeniUrunGrubu);
            this.pnlRightSection.Controls.Add(this.dgvDegisecekUrunler);
            this.pnlRightSection.Controls.Add(this.btnUrunGrubuDegisecekTemizle);
            this.pnlRightSection.Controls.Add(this.btnUrunGrubuDegisecekEkle);
            this.pnlRightSection.Controls.Add(this.dgvUrunler);
            this.pnlRightSection.Controls.Add(this.cmbUrunGrubuFilter);
            this.pnlRightSection.Controls.Add(this.lblUrunGrubuFilter);
            this.pnlRightSection.Controls.Add(this.txtUrunAdi);
            this.pnlRightSection.Controls.Add(this.lblUrunAdi);
            this.pnlRightSection.Location = new System.Drawing.Point(650, 12);
            this.pnlRightSection.Name = "pnlRightSection";
            this.pnlRightSection.Size = new System.Drawing.Size(780, 526);
            this.pnlRightSection.TabIndex = 7;
            // 
            // lblRightSectionTitle
            // 
            this.lblRightSectionTitle.AutoSize = true;
            this.lblRightSectionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRightSectionTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblRightSectionTitle.Location = new System.Drawing.Point(250, 10);
            this.lblRightSectionTitle.Name = "lblRightSectionTitle";
            this.lblRightSectionTitle.Size = new System.Drawing.Size(200, 20);
            this.lblRightSectionTitle.TabIndex = 0;
            this.lblRightSectionTitle.Text = "Ürün Grubu Değiştirme";
            this.lblRightSectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTablodakiUrunlerinGrubunuDegistir
            // 
            this.btnTablodakiUrunlerinGrubunuDegistir.Location = new System.Drawing.Point(500, 380);
            this.btnTablodakiUrunlerinGrubunuDegistir.Name = "btnTablodakiUrunlerinGrubunuDegistir";
            this.btnTablodakiUrunlerinGrubunuDegistir.Size = new System.Drawing.Size(150, 50);
            this.btnTablodakiUrunlerinGrubunuDegistir.TabIndex = 11;
            this.btnTablodakiUrunlerinGrubunuDegistir.Text = "Tablodaki Ürünlerin Ürün Grubunu Değiştir";
            this.btnTablodakiUrunlerinGrubunuDegistir.UseVisualStyleBackColor = true;
            // 
            // cmbYeniUrunGrubu
            // 
            this.cmbYeniUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYeniUrunGrubu.FormattingEnabled = true;
            this.cmbYeniUrunGrubu.Location = new System.Drawing.Point(450, 125);
            this.cmbYeniUrunGrubu.Name = "cmbYeniUrunGrubu";
            this.cmbYeniUrunGrubu.Size = new System.Drawing.Size(200, 21);
            this.cmbYeniUrunGrubu.TabIndex = 10;
            // 
            // lblYeniUrunGrubu
            // 
            this.lblYeniUrunGrubu.AutoSize = true;
            this.lblYeniUrunGrubu.Location = new System.Drawing.Point(450, 105);
            this.lblYeniUrunGrubu.Name = "lblYeniUrunGrubu";
            this.lblYeniUrunGrubu.Size = new System.Drawing.Size(84, 13);
            this.lblYeniUrunGrubu.TabIndex = 9;
            this.lblYeniUrunGrubu.Text = "Yeni Ürün Grubu";
            // 
            // dgvDegisecekUrunler
            // 
            this.dgvDegisecekUrunler.AllowUserToAddRows = false;
            this.dgvDegisecekUrunler.AllowUserToDeleteRows = false;
            this.dgvDegisecekUrunler.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvDegisecekUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDegisecekBarkodNo,
            this.colDegisecekUrunAdi});
            this.dgvDegisecekUrunler.Location = new System.Drawing.Point(450, 165);
            this.dgvDegisecekUrunler.MultiSelect = false;
            this.dgvDegisecekUrunler.Name = "dgvDegisecekUrunler";
            this.dgvDegisecekUrunler.ReadOnly = true;
            this.dgvDegisecekUrunler.RowHeadersVisible = false;
            this.dgvDegisecekUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDegisecekUrunler.Size = new System.Drawing.Size(300, 200);
            this.dgvDegisecekUrunler.TabIndex = 8;
            // 
            // colDegisecekBarkodNo
            // 
            this.colDegisecekBarkodNo.HeaderText = "Barkod No";
            this.colDegisecekBarkodNo.Name = "colDegisecekBarkodNo";
            this.colDegisecekBarkodNo.ReadOnly = true;
            // 
            // colDegisecekUrunAdi
            // 
            this.colDegisecekUrunAdi.HeaderText = "Ürün Adı";
            this.colDegisecekUrunAdi.Name = "colDegisecekUrunAdi";
            this.colDegisecekUrunAdi.ReadOnly = true;
            this.colDegisecekUrunAdi.Width = 150;
            // 
            // btnUrunGrubuDegisecekTemizle
            // 
            this.btnUrunGrubuDegisecekTemizle.Location = new System.Drawing.Point(360, 280);
            this.btnUrunGrubuDegisecekTemizle.Name = "btnUrunGrubuDegisecekTemizle";
            this.btnUrunGrubuDegisecekTemizle.Size = new System.Drawing.Size(75, 60);
            this.btnUrunGrubuDegisecekTemizle.TabIndex = 7;
            this.btnUrunGrubuDegisecekTemizle.Text = "Ürün Grubu Değişecek Tablosunu Temizle";
            this.btnUrunGrubuDegisecekTemizle.UseVisualStyleBackColor = true;
            // 
            // btnUrunGrubuDegisecekEkle
            // 
            this.btnUrunGrubuDegisecekEkle.Location = new System.Drawing.Point(360, 210);
            this.btnUrunGrubuDegisecekEkle.Name = "btnUrunGrubuDegisecekEkle";
            this.btnUrunGrubuDegisecekEkle.Size = new System.Drawing.Size(75, 60);
            this.btnUrunGrubuDegisecekEkle.TabIndex = 6;
            this.btnUrunGrubuDegisecekEkle.Text = "Ürün Grubu Değişecek Tablosuna Ekle";
            this.btnUrunGrubuDegisecekEkle.UseVisualStyleBackColor = true;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBarkodNo,
            this.colUrunAdi,
            this.colUrunGrubu});
            this.dgvUrunler.Location = new System.Drawing.Point(0, 165);
            this.dgvUrunler.MultiSelect = true;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(350, 200);
            this.dgvUrunler.TabIndex = 5;
            this.dgvUrunler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUrunler_CellDoubleClick);
            // 
            // colBarkodNo
            // 
            this.colBarkodNo.HeaderText = "Barkod No";
            this.colBarkodNo.Name = "colBarkodNo";
            this.colBarkodNo.ReadOnly = true;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.HeaderText = "Ürün Adı";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.ReadOnly = true;
            this.colUrunAdi.Width = 150;
            // 
            // colUrunGrubu
            // 
            this.colUrunGrubu.HeaderText = "Ürün Grubu";
            this.colUrunGrubu.Name = "colUrunGrubu";
            this.colUrunGrubu.ReadOnly = true;
            // 
            // cmbUrunGrubuFilter
            // 
            this.cmbUrunGrubuFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubuFilter.FormattingEnabled = true;
            this.cmbUrunGrubuFilter.Location = new System.Drawing.Point(50, 125);
            this.cmbUrunGrubuFilter.Name = "cmbUrunGrubuFilter";
            this.cmbUrunGrubuFilter.Size = new System.Drawing.Size(200, 21);
            this.cmbUrunGrubuFilter.TabIndex = 4;
            // 
            // lblUrunGrubuFilter
            // 
            this.lblUrunGrubuFilter.AutoSize = true;
            this.lblUrunGrubuFilter.Location = new System.Drawing.Point(50, 105);
            this.lblUrunGrubuFilter.Name = "lblUrunGrubuFilter";
            this.lblUrunGrubuFilter.Size = new System.Drawing.Size(61, 13);
            this.lblUrunGrubuFilter.TabIndex = 3;
            this.lblUrunGrubuFilter.Text = "Ürün Grubu";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(50, 70);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(200, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(50, 50);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(48, 13);
            this.lblUrunAdi.TabIndex = 1;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // UrunGruplariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1450, 550); // Increased width
            this.Controls.Add(this.pnlRightSection);
            this.Controls.Add(this.dgvUrunGruplari);
            this.Controls.Add(this.txtUrunGrubuAdi);
            this.Controls.Add(this.lblUrunGrubuAdi);
            this.Controls.Add(this.btnYeniUrunGrubuEkle);
            this.Controls.Add(this.btnSecilenUrunGrubunuSil);
            this.Controls.Add(this.lblSecilenUrunGrubu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunGruplariForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÜRÜN GRUPLARI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunGruplari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegisecekUrunler)).EndInit();
            this.pnlRightSection.ResumeLayout(false);
            this.pnlRightSection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblSecilenUrunGrubu;
        private System.Windows.Forms.Button btnSecilenUrunGrubunuSil;
        private System.Windows.Forms.Button btnYeniUrunGrubuEkle;
        private System.Windows.Forms.Label lblUrunGrubuAdi;
        private System.Windows.Forms.TextBox txtUrunGrubuAdi;
        private System.Windows.Forms.DataGridView dgvUrunGruplari;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunGrubuAdi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblUrunGrubuFilter;
        private System.Windows.Forms.ComboBox cmbUrunGrubuFilter;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunGrubu;
        private System.Windows.Forms.Button btnUrunGrubuDegisecekEkle;
        private System.Windows.Forms.Button btnUrunGrubuDegisecekTemizle;
        private System.Windows.Forms.DataGridView dgvDegisecekUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDegisecekBarkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDegisecekUrunAdi;
        private System.Windows.Forms.Label lblYeniUrunGrubu;
        private System.Windows.Forms.ComboBox cmbYeniUrunGrubu;
        private System.Windows.Forms.Button btnTablodakiUrunlerinGrubunuDegistir;
        private System.Windows.Forms.Panel pnlRightSection;
        private System.Windows.Forms.Label lblRightSectionTitle;
    }
}
