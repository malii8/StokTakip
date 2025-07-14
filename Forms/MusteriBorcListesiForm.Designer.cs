namespace StokTakip.Forms
{
    partial class MusteriBorcListesiForm
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.grpFiltre = new System.Windows.Forms.GroupBox();
            this.rbAdaGoreSirala = new System.Windows.Forms.RadioButton();
            this.rbSonIslemTarihineGoreSirala = new System.Windows.Forms.RadioButton();
            this.rbBorcMiktarinaGoreSirala = new System.Windows.Forms.RadioButton();
            this.grpMusteriAra = new System.Windows.Forms.GroupBox();
            this.lblMusteriAra = new System.Windows.Forms.Label();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.lblAdiSoyadi = new System.Windows.Forms.Label();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.colSiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMusterininAdiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorcMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSonIslemTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkBorcuSifirTLOlanlar = new System.Windows.Forms.CheckBox();
            this.btnTabloExcel = new System.Windows.Forms.Button();
            this.lblMusterilerinVeresiyeToplamı = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.grpFiltre.SuspendLayout();
            this.grpMusteriAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Blue;
            this.lblBaslik.Location = new System.Drawing.Point(12, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(169, 20);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "MÜŞTERİ BORÇ LİSTESİ";
            // 
            // grpFiltre
            // 
            this.grpFiltre.Controls.Add(this.rbAdaGoreSirala);
            this.grpFiltre.Controls.Add(this.rbSonIslemTarihineGoreSirala);
            this.grpFiltre.Controls.Add(this.rbBorcMiktarinaGoreSirala);
            this.grpFiltre.Location = new System.Drawing.Point(12, 40);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Size = new System.Drawing.Size(600, 50);
            this.grpFiltre.TabIndex = 1;
            this.grpFiltre.TabStop = false;
            // 
            // rbAdaGoreSirala
            // 
            this.rbAdaGoreSirala.AutoSize = true;
            this.rbAdaGoreSirala.Checked = true;
            this.rbAdaGoreSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAdaGoreSirala.ForeColor = System.Drawing.Color.Blue;
            this.rbAdaGoreSirala.Location = new System.Drawing.Point(20, 20);
            this.rbAdaGoreSirala.Name = "rbAdaGoreSirala";
            this.rbAdaGoreSirala.Size = new System.Drawing.Size(118, 17);
            this.rbAdaGoreSirala.TabIndex = 0;
            this.rbAdaGoreSirala.TabStop = true;
            this.rbAdaGoreSirala.Text = "Ada Göre Sırala";
            this.rbAdaGoreSirala.UseVisualStyleBackColor = true;
            // 
            // rbSonIslemTarihineGoreSirala
            // 
            this.rbSonIslemTarihineGoreSirala.AutoSize = true;
            this.rbSonIslemTarihineGoreSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSonIslemTarihineGoreSirala.ForeColor = System.Drawing.Color.Blue;
            this.rbSonIslemTarihineGoreSirala.Location = new System.Drawing.Point(160, 20);
            this.rbSonIslemTarihineGoreSirala.Name = "rbSonIslemTarihineGoreSirala";
            this.rbSonIslemTarihineGoreSirala.Size = new System.Drawing.Size(194, 17);
            this.rbSonIslemTarihineGoreSirala.TabIndex = 1;
            this.rbSonIslemTarihineGoreSirala.Text = "Son İşlem Tarihine Göre Sırala";
            this.rbSonIslemTarihineGoreSirala.UseVisualStyleBackColor = true;
            // 
            // rbBorcMiktarinaGoreSirala
            // 
            this.rbBorcMiktarinaGoreSirala.AutoSize = true;
            this.rbBorcMiktarinaGoreSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBorcMiktarinaGoreSirala.ForeColor = System.Drawing.Color.Blue;
            this.rbBorcMiktarinaGoreSirala.Location = new System.Drawing.Point(380, 20);
            this.rbBorcMiktarinaGoreSirala.Name = "rbBorcMiktarinaGoreSirala";
            this.rbBorcMiktarinaGoreSirala.Size = new System.Drawing.Size(168, 17);
            this.rbBorcMiktarinaGoreSirala.TabIndex = 2;
            this.rbBorcMiktarinaGoreSirala.Text = "Borç Miktarına Göre Sırala";
            this.rbBorcMiktarinaGoreSirala.UseVisualStyleBackColor = true;
            // 
            // grpMusteriAra
            // 
            this.grpMusteriAra.Controls.Add(this.lblMusteriAra);
            this.grpMusteriAra.Controls.Add(this.txtMusteriAra);
            this.grpMusteriAra.Controls.Add(this.lblAdiSoyadi);
            this.grpMusteriAra.Location = new System.Drawing.Point(12, 100);
            this.grpMusteriAra.Name = "grpMusteriAra";
            this.grpMusteriAra.Size = new System.Drawing.Size(600, 50);
            this.grpMusteriAra.TabIndex = 2;
            this.grpMusteriAra.TabStop = false;
            // 
            // lblMusteriAra
            // 
            this.lblMusteriAra.AutoSize = true;
            this.lblMusteriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAra.ForeColor = System.Drawing.Color.Blue;
            this.lblMusteriAra.Location = new System.Drawing.Point(20, 22);
            this.lblMusteriAra.Name = "lblMusteriAra";
            this.lblMusteriAra.Size = new System.Drawing.Size(71, 13);
            this.lblMusteriAra.TabIndex = 0;
            this.lblMusteriAra.Text = "Müşteri Ara";
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.BackColor = System.Drawing.Color.Yellow;
            this.txtMusteriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAra.Location = new System.Drawing.Point(100, 19);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(300, 22);
            this.txtMusteriAra.TabIndex = 1;
            // 
            // lblAdiSoyadi
            // 
            this.lblAdiSoyadi.AutoSize = true;
            this.lblAdiSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdiSoyadi.ForeColor = System.Drawing.Color.Blue;
            this.lblAdiSoyadi.Location = new System.Drawing.Point(420, 22);
            this.lblAdiSoyadi.Name = "lblAdiSoyadi";
            this.lblAdiSoyadi.Size = new System.Drawing.Size(104, 13);
            this.lblAdiSoyadi.TabIndex = 2;
            this.lblAdiSoyadi.Text = "<<< Adı Soyadı >>>";
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSiraNo,
            this.colMusterininAdiSoyadi,
            this.colBorcMiktari,
            this.colSonIslemTarihi,
            this.colTelefon,
            this.colAdres});
            this.dgvMusteriler.Location = new System.Drawing.Point(12, 170);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.Size = new System.Drawing.Size(1020, 350);
            this.dgvMusteriler.TabIndex = 3;
            // 
            // colSiraNo
            // 
            this.colSiraNo.HeaderText = "Sıra No";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.Width = 60;
            // 
            // colMusterininAdiSoyadi
            // 
            this.colMusterininAdiSoyadi.HeaderText = "Müşterinin Adı Soyadı";
            this.colMusterininAdiSoyadi.Name = "colMusterininAdiSoyadi";
            this.colMusterininAdiSoyadi.Width = 200;
            // 
            // colBorcMiktari
            // 
            this.colBorcMiktari.HeaderText = "Borç Miktarı";
            this.colBorcMiktari.Name = "colBorcMiktari";
            this.colBorcMiktari.Width = 100;
            // 
            // colSonIslemTarihi
            // 
            this.colSonIslemTarihi.HeaderText = "Son İşlem Tarihi";
            this.colSonIslemTarihi.Name = "colSonIslemTarihi";
            this.colSonIslemTarihi.Width = 120;
            // 
            // colTelefon
            // 
            this.colTelefon.HeaderText = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Width = 120;
            // 
            // colAdres
            // 
            this.colAdres.HeaderText = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Width = 400;
            // 
            // chkBorcuSifirTLOlanlar
            // 
            this.chkBorcuSifirTLOlanlar.AutoSize = true;
            this.chkBorcuSifirTLOlanlar.Checked = true;
            this.chkBorcuSifirTLOlanlar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBorcuSifirTLOlanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBorcuSifirTLOlanlar.ForeColor = System.Drawing.Color.Red;
            this.chkBorcuSifirTLOlanlar.Location = new System.Drawing.Point(12, 530);
            this.chkBorcuSifirTLOlanlar.Name = "chkBorcuSifirTLOlanlar";
            this.chkBorcuSifirTLOlanlar.Size = new System.Drawing.Size(252, 19);
            this.chkBorcuSifirTLOlanlar.TabIndex = 4;
            this.chkBorcuSifirTLOlanlar.Text = "Borcu 0,00 TL Olanlar da Listelensin";
            this.chkBorcuSifirTLOlanlar.UseVisualStyleBackColor = true;
            // 
            // btnTabloExcel
            // 
            this.btnTabloExcel.BackColor = System.Drawing.Color.LightGreen;
            this.btnTabloExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTabloExcel.Location = new System.Drawing.Point(420, 526);
            this.btnTabloExcel.Name = "btnTabloExcel";
            this.btnTabloExcel.Size = new System.Drawing.Size(100, 30);
            this.btnTabloExcel.TabIndex = 5;
            this.btnTabloExcel.Text = "Tabloyu\nExcel'e Aktar";
            this.btnTabloExcel.UseVisualStyleBackColor = false;
            // 
            // lblMusterilerinVeresiyeToplamı
            // 
            this.lblMusterilerinVeresiyeToplamı.AutoSize = true;
            this.lblMusterilerinVeresiyeToplamı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusterilerinVeresiyeToplamı.ForeColor = System.Drawing.Color.Blue;
            this.lblMusterilerinVeresiyeToplamı.Location = new System.Drawing.Point(680, 533);
            this.lblMusterilerinVeresiyeToplamı.Name = "lblMusterilerinVeresiyeToplamı";
            this.lblMusterilerinVeresiyeToplamı.Size = new System.Drawing.Size(192, 16);
            this.lblMusterilerinVeresiyeToplamı.TabIndex = 6;
            this.lblMusterilerinVeresiyeToplamı.Text = "Müşterilerin Veresiye Toplamı";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.BackColor = System.Drawing.Color.Red;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.White;
            this.lblToplamTutar.Location = new System.Drawing.Point(890, 526);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(100, 30);
            this.lblToplamTutar.TabIndex = 7;
            this.lblToplamTutar.Text = "39,00 TL";
            this.lblToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MusteriBorcListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1050, 580);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblMusterilerinVeresiyeToplamı);
            this.Controls.Add(this.btnTabloExcel);
            this.Controls.Add(this.chkBorcuSifirTLOlanlar);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.grpMusteriAra);
            this.Controls.Add(this.grpFiltre);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MusteriBorcListesiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ BORÇ LİSTESİ";
            this.grpFiltre.ResumeLayout(false);
            this.grpFiltre.PerformLayout();
            this.grpMusteriAra.ResumeLayout(false);
            this.grpMusteriAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.GroupBox grpFiltre;
        private System.Windows.Forms.RadioButton rbAdaGoreSirala;
        private System.Windows.Forms.RadioButton rbSonIslemTarihineGoreSirala;
        private System.Windows.Forms.RadioButton rbBorcMiktarinaGoreSirala;
        private System.Windows.Forms.GroupBox grpMusteriAra;
        private System.Windows.Forms.Label lblMusteriAra;
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.Label lblAdiSoyadi;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMusterininAdiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorcMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSonIslemTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdres;
        private System.Windows.Forms.CheckBox chkBorcuSifirTLOlanlar;
        private System.Windows.Forms.Button btnTabloExcel;
        private System.Windows.Forms.Label lblMusterilerinVeresiyeToplamı;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}
