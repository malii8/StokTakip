namespace StokTakip.Forms
{
    partial class EskiFislerForm
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.lblOdemeTuru = new System.Windows.Forms.Label();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnFisDetayi = new System.Windows.Forms.Button();
            this.btnFisIptal = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dgvEskiFisler = new System.Windows.Forms.DataGridView();
            this.colFisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOdemeTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMusteriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblToplamFis = new System.Windows.Forms.Label();
            this.lblIptalFis = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.grpFilters.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEskiFisler)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Orange;
            this.pnlTop.Controls.Add(this.grpFilters);
            this.pnlTop.Controls.Add(this.pnlButtons);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1200, 120);
            this.pnlTop.TabIndex = 0;
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.lblBaslangicTarihi);
            this.grpFilters.Controls.Add(this.dtpBaslangicTarihi);
            this.grpFilters.Controls.Add(this.lblBitisTarihi);
            this.grpFilters.Controls.Add(this.dtpBitisTarihi);
            this.grpFilters.Controls.Add(this.lblMusteriAdi);
            this.grpFilters.Controls.Add(this.txtMusteriAdi);
            this.grpFilters.Controls.Add(this.lblOdemeTuru);
            this.grpFilters.Controls.Add(this.cmbOdemeTuru);
            this.grpFilters.Controls.Add(this.btnAra);
            this.grpFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpFilters.Location = new System.Drawing.Point(12, 12);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(800, 96);
            this.grpFilters.TabIndex = 0;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "FİLTRELER";
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(20, 25);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(111, 15);
            this.lblBaslangicTarihi.TabIndex = 0;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi:";
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(20, 45);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(120, 21);
            this.dtpBaslangicTarihi.TabIndex = 1;
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Location = new System.Drawing.Point(160, 25);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(78, 15);
            this.lblBitisTarihi.TabIndex = 2;
            this.lblBitisTarihi.Text = "Bitiş Tarihi:";
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitisTarihi.Location = new System.Drawing.Point(160, 45);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(120, 21);
            this.dtpBitisTarihi.TabIndex = 3;
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(300, 25);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(82, 15);
            this.lblMusteriAdi.TabIndex = 4;
            this.lblMusteriAdi.Text = "Müşteri Adı:";
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(300, 45);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(150, 21);
            this.txtMusteriAdi.TabIndex = 5;
            // 
            // lblOdemeTuru
            // 
            this.lblOdemeTuru.AutoSize = true;
            this.lblOdemeTuru.Location = new System.Drawing.Point(470, 25);
            this.lblOdemeTuru.Name = "lblOdemeTuru";
            this.lblOdemeTuru.Size = new System.Drawing.Size(85, 15);
            this.lblOdemeTuru.TabIndex = 6;
            this.lblOdemeTuru.Text = "Ödeme Türü:";
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "Tümü",
            "Nakit",
            "Kredi Kartı",
            "Veresiye",
            "Havale"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(470, 45);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(120, 23);
            this.cmbOdemeTuru.TabIndex = 7;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Green;
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(610, 35);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 40);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnFisDetayi);
            this.pnlButtons.Controls.Add(this.btnFisIptal);
            this.pnlButtons.Controls.Add(this.btnYazdir);
            this.pnlButtons.Controls.Add(this.btnExcel);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtons.Location = new System.Drawing.Point(830, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(370, 120);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnFisDetayi
            // 
            this.btnFisDetayi.BackColor = System.Drawing.Color.Blue;
            this.btnFisDetayi.Enabled = false;
            this.btnFisDetayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnFisDetayi.ForeColor = System.Drawing.Color.White;
            this.btnFisDetayi.Location = new System.Drawing.Point(15, 15);
            this.btnFisDetayi.Name = "btnFisDetayi";
            this.btnFisDetayi.Size = new System.Drawing.Size(80, 45);
            this.btnFisDetayi.TabIndex = 0;
            this.btnFisDetayi.Text = "FİŞ DETAYI";
            this.btnFisDetayi.UseVisualStyleBackColor = false;
            // 
            // btnFisIptal
            // 
            this.btnFisIptal.BackColor = System.Drawing.Color.Red;
            this.btnFisIptal.Enabled = false;
            this.btnFisIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnFisIptal.ForeColor = System.Drawing.Color.White;
            this.btnFisIptal.Location = new System.Drawing.Point(105, 15);
            this.btnFisIptal.Name = "btnFisIptal";
            this.btnFisIptal.Size = new System.Drawing.Size(80, 45);
            this.btnFisIptal.TabIndex = 1;
            this.btnFisIptal.Text = "FİŞ İPTAL";
            this.btnFisIptal.UseVisualStyleBackColor = false;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.Purple;
            this.btnYazdir.Enabled = false;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(195, 15);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(80, 45);
            this.btnYazdir.TabIndex = 2;
            this.btnYazdir.Text = "YAZDIR";
            this.btnYazdir.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(285, 15);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(80, 45);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "EXCEL";
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // dgvEskiFisler
            // 
            this.dgvEskiFisler.AllowUserToAddRows = false;
            this.dgvEskiFisler.AllowUserToDeleteRows = false;
            this.dgvEskiFisler.BackgroundColor = System.Drawing.Color.White;
            this.dgvEskiFisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEskiFisler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFisNo,
            this.colTarih,
            this.colSaat,
            this.colOdemeTuru,
            this.colMusteriAdi,
            this.colTutar,
            this.colDurum});
            this.dgvEskiFisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEskiFisler.Location = new System.Drawing.Point(0, 120);
            this.dgvEskiFisler.MultiSelect = false;
            this.dgvEskiFisler.Name = "dgvEskiFisler";
            this.dgvEskiFisler.ReadOnly = true;
            this.dgvEskiFisler.RowHeadersVisible = false;
            this.dgvEskiFisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEskiFisler.Size = new System.Drawing.Size(1200, 380);
            this.dgvEskiFisler.TabIndex = 1;
            // 
            // colFisNo
            // 
            this.colFisNo.HeaderText = "Fiş No";
            this.colFisNo.Name = "colFisNo";
            this.colFisNo.ReadOnly = true;
            this.colFisNo.Width = 150;
            // 
            // colTarih
            // 
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.ReadOnly = true;
            this.colTarih.Width = 100;
            // 
            // colSaat
            // 
            this.colSaat.HeaderText = "Saat";
            this.colSaat.Name = "colSaat";
            this.colSaat.ReadOnly = true;
            this.colSaat.Width = 80;
            // 
            // colOdemeTuru
            // 
            this.colOdemeTuru.HeaderText = "Ödeme Türü";
            this.colOdemeTuru.Name = "colOdemeTuru";
            this.colOdemeTuru.ReadOnly = true;
            this.colOdemeTuru.Width = 120;
            // 
            // colMusteriAdi
            // 
            this.colMusteriAdi.HeaderText = "Müşteri Adı";
            this.colMusteriAdi.Name = "colMusteriAdi";
            this.colMusteriAdi.ReadOnly = true;
            this.colMusteriAdi.Width = 200;
            // 
            // colTutar
            // 
            this.colTutar.HeaderText = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.ReadOnly = true;
            this.colTutar.Width = 100;
            // 
            // colDurum
            // 
            this.colDurum.HeaderText = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.ReadOnly = true;
            this.colDurum.Width = 100;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Cyan;
            this.pnlBottom.Controls.Add(this.lblToplamFis);
            this.pnlBottom.Controls.Add(this.lblIptalFis);
            this.pnlBottom.Controls.Add(this.lblToplamTutar);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 500);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1200, 60);
            this.pnlBottom.TabIndex = 2;
            // 
            // lblToplamFis
            // 
            this.lblToplamFis.AutoSize = true;
            this.lblToplamFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblToplamFis.Location = new System.Drawing.Point(20, 20);
            this.lblToplamFis.Name = "lblToplamFis";
            this.lblToplamFis.Size = new System.Drawing.Size(102, 20);
            this.lblToplamFis.TabIndex = 0;
            this.lblToplamFis.Text = "Toplam Fiş: 0";
            // 
            // lblIptalFis
            // 
            this.lblIptalFis.AutoSize = true;
            this.lblIptalFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblIptalFis.ForeColor = System.Drawing.Color.Red;
            this.lblIptalFis.Location = new System.Drawing.Point(200, 20);
            this.lblIptalFis.Name = "lblIptalFis";
            this.lblIptalFis.Size = new System.Drawing.Size(83, 20);
            this.lblIptalFis.TabIndex = 1;
            this.lblIptalFis.Text = "İptal Fiş: 0";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblToplamTutar.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblToplamTutar.Location = new System.Drawing.Point(900, 18);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(178, 24);
            this.lblToplamTutar.TabIndex = 2;
            this.lblToplamTutar.Text = "Toplam Tutar: 0,00";
            // 
            // EskiFislerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 560);
            this.Controls.Add(this.dgvEskiFisler);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EskiFislerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ESKİ FİŞLER";
            this.pnlTop.ResumeLayout(false);
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEskiFisler)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label lblOdemeTuru;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnFisDetayi;
        private System.Windows.Forms.Button btnFisIptal;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dgvEskiFisler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFisNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOdemeTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMusteriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDurum;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblToplamFis;
        private System.Windows.Forms.Label lblIptalFis;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}
