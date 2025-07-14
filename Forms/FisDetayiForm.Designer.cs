namespace StokTakip.Forms
{
    partial class FisDetayiForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFisInfo = new System.Windows.Forms.Panel();
            this.lblFisNo = new System.Windows.Forms.Label();
            this.lblFisNoValue = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblTarihValue = new System.Windows.Forms.Label();
            this.lblOdemeTuru = new System.Windows.Forms.Label();
            this.lblOdemeTuruValue = new System.Windows.Forms.Label();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.lblMusteriAdiValue = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblDurumValue = new System.Windows.Forms.Label();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.colBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblToplamUrun = new System.Windows.Forms.Label();
            this.lblToplamUrunValue = new System.Windows.Forms.Label();
            this.lblAraToplam = new System.Windows.Forms.Label();
            this.lblAraToplamValue = new System.Windows.Forms.Label();
            this.lblKdv = new System.Windows.Forms.Label();
            this.lblKdvValue = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.lblGenelToplamValue = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblToplamTutarValue = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFisInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Navy;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(300, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FİŞ DETAY BİLGİSİ";
            // 
            // pnlFisInfo
            // 
            this.pnlFisInfo.BackColor = System.Drawing.Color.LightBlue;
            this.pnlFisInfo.Controls.Add(this.lblFisNo);
            this.pnlFisInfo.Controls.Add(this.lblFisNoValue);
            this.pnlFisInfo.Controls.Add(this.lblTarih);
            this.pnlFisInfo.Controls.Add(this.lblTarihValue);
            this.pnlFisInfo.Controls.Add(this.lblOdemeTuru);
            this.pnlFisInfo.Controls.Add(this.lblOdemeTuruValue);
            this.pnlFisInfo.Controls.Add(this.lblMusteriAdi);
            this.pnlFisInfo.Controls.Add(this.lblMusteriAdiValue);
            this.pnlFisInfo.Controls.Add(this.lblDurum);
            this.pnlFisInfo.Controls.Add(this.lblDurumValue);
            this.pnlFisInfo.Controls.Add(this.lblToplamTutar);
            this.pnlFisInfo.Controls.Add(this.lblToplamTutarValue);
            this.pnlFisInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFisInfo.Location = new System.Drawing.Point(0, 50);
            this.pnlFisInfo.Name = "pnlFisInfo";
            this.pnlFisInfo.Size = new System.Drawing.Size(800, 100);
            this.pnlFisInfo.TabIndex = 1;
            // 
            // lblFisNo
            // 
            this.lblFisNo.AutoSize = true;
            this.lblFisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFisNo.Location = new System.Drawing.Point(20, 15);
            this.lblFisNo.Name = "lblFisNo";
            this.lblFisNo.Size = new System.Drawing.Size(61, 17);
            this.lblFisNo.TabIndex = 0;
            this.lblFisNo.Text = "Fiş No:";
            // 
            // lblFisNoValue
            // 
            this.lblFisNoValue.AutoSize = true;
            this.lblFisNoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFisNoValue.Location = new System.Drawing.Point(90, 15);
            this.lblFisNoValue.Name = "lblFisNoValue";
            this.lblFisNoValue.Size = new System.Drawing.Size(16, 17);
            this.lblFisNoValue.TabIndex = 1;
            this.lblFisNoValue.Text = "-";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTarih.Location = new System.Drawing.Point(20, 40);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(53, 17);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblTarihValue
            // 
            this.lblTarihValue.AutoSize = true;
            this.lblTarihValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTarihValue.Location = new System.Drawing.Point(90, 40);
            this.lblTarihValue.Name = "lblTarihValue";
            this.lblTarihValue.Size = new System.Drawing.Size(16, 17);
            this.lblTarihValue.TabIndex = 3;
            this.lblTarihValue.Text = "-";
            // 
            // lblOdemeTuru
            // 
            this.lblOdemeTuru.AutoSize = true;
            this.lblOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblOdemeTuru.Location = new System.Drawing.Point(250, 15);
            this.lblOdemeTuru.Name = "lblOdemeTuru";
            this.lblOdemeTuru.Size = new System.Drawing.Size(103, 17);
            this.lblOdemeTuru.TabIndex = 4;
            this.lblOdemeTuru.Text = "Ödeme Türü:";
            // 
            // lblOdemeTuruValue
            // 
            this.lblOdemeTuruValue.AutoSize = true;
            this.lblOdemeTuruValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOdemeTuruValue.Location = new System.Drawing.Point(360, 15);
            this.lblOdemeTuruValue.Name = "lblOdemeTuruValue";
            this.lblOdemeTuruValue.Size = new System.Drawing.Size(16, 17);
            this.lblOdemeTuruValue.TabIndex = 5;
            this.lblOdemeTuruValue.Text = "-";
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMusteriAdi.Location = new System.Drawing.Point(250, 40);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(98, 17);
            this.lblMusteriAdi.TabIndex = 6;
            this.lblMusteriAdi.Text = "Müşteri Adı:";
            // 
            // lblMusteriAdiValue
            // 
            this.lblMusteriAdiValue.AutoSize = true;
            this.lblMusteriAdiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMusteriAdiValue.Location = new System.Drawing.Point(360, 40);
            this.lblMusteriAdiValue.Name = "lblMusteriAdiValue";
            this.lblMusteriAdiValue.Size = new System.Drawing.Size(16, 17);
            this.lblMusteriAdiValue.TabIndex = 7;
            this.lblMusteriAdiValue.Text = "-";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDurum.Location = new System.Drawing.Point(250, 65);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(59, 17);
            this.lblDurum.TabIndex = 8;
            this.lblDurum.Text = "Durum:";
            // 
            // lblDurumValue
            // 
            this.lblDurumValue.AutoSize = true;
            this.lblDurumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDurumValue.Location = new System.Drawing.Point(360, 65);
            this.lblDurumValue.Name = "lblDurumValue";
            this.lblDurumValue.Size = new System.Drawing.Size(15, 17);
            this.lblDurumValue.TabIndex = 9;
            this.lblDurumValue.Text = "-";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.BackgroundColor = System.Drawing.Color.White;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBarkod,
            this.colUrunAdi,
            this.colMiktar,
            this.colBirimFiyat,
            this.colToplam});
            this.dgvUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUrunler.Location = new System.Drawing.Point(0, 150);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.Size = new System.Drawing.Size(800, 250);
            this.dgvUrunler.TabIndex = 2;
            // 
            // colBarkod
            // 
            this.colBarkod.HeaderText = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.ReadOnly = true;
            this.colBarkod.Width = 150;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.HeaderText = "Ürün Adı";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.ReadOnly = true;
            this.colUrunAdi.Width = 300;
            // 
            // colMiktar
            // 
            this.colMiktar.HeaderText = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.ReadOnly = true;
            this.colMiktar.Width = 80;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.HeaderText = "Birim Fiyat";
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.ReadOnly = true;
            this.colBirimFiyat.Width = 100;
            // 
            // colToplam
            // 
            this.colToplam.HeaderText = "Toplam";
            this.colToplam.Name = "colToplam";
            this.colToplam.ReadOnly = true;
            this.colToplam.Width = 100;
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.LightGreen;
            this.pnlSummary.Controls.Add(this.lblToplamUrun);
            this.pnlSummary.Controls.Add(this.lblToplamUrunValue);
            this.pnlSummary.Controls.Add(this.lblAraToplam);
            this.pnlSummary.Controls.Add(this.lblAraToplamValue);
            this.pnlSummary.Controls.Add(this.lblKdv);
            this.pnlSummary.Controls.Add(this.lblKdvValue);
            this.pnlSummary.Controls.Add(this.lblGenelToplam);
            this.pnlSummary.Controls.Add(this.lblGenelToplamValue);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSummary.Location = new System.Drawing.Point(0, 400);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(800, 80);
            this.pnlSummary.TabIndex = 3;
            // 
            // lblToplamUrun
            // 
            this.lblToplamUrun.AutoSize = true;
            this.lblToplamUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamUrun.Location = new System.Drawing.Point(20, 15);
            this.lblToplamUrun.Name = "lblToplamUrun";
            this.lblToplamUrun.Size = new System.Drawing.Size(106, 17);
            this.lblToplamUrun.TabIndex = 0;
            this.lblToplamUrun.Text = "Toplam Ürün:";
            // 
            // lblToplamUrunValue
            // 
            this.lblToplamUrunValue.AutoSize = true;
            this.lblToplamUrunValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblToplamUrunValue.Location = new System.Drawing.Point(130, 15);
            this.lblToplamUrunValue.Name = "lblToplamUrunValue";
            this.lblToplamUrunValue.Size = new System.Drawing.Size(16, 17);
            this.lblToplamUrunValue.TabIndex = 1;
            this.lblToplamUrunValue.Text = "0";
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.AutoSize = true;
            this.lblAraToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAraToplam.Location = new System.Drawing.Point(400, 15);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Size = new System.Drawing.Size(96, 17);
            this.lblAraToplam.TabIndex = 2;
            this.lblAraToplam.Text = "Ara Toplam:";
            // 
            // lblAraToplamValue
            // 
            this.lblAraToplamValue.AutoSize = true;
            this.lblAraToplamValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAraToplamValue.Location = new System.Drawing.Point(500, 15);
            this.lblAraToplamValue.Name = "lblAraToplamValue";
            this.lblAraToplamValue.Size = new System.Drawing.Size(44, 17);
            this.lblAraToplamValue.TabIndex = 3;
            this.lblAraToplamValue.Text = "0,00 ";
            // 
            // lblKdv
            // 
            this.lblKdv.AutoSize = true;
            this.lblKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblKdv.Location = new System.Drawing.Point(400, 35);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(41, 17);
            this.lblKdv.TabIndex = 4;
            this.lblKdv.Text = "KDV:";
            // 
            // lblKdvValue
            // 
            this.lblKdvValue.AutoSize = true;
            this.lblKdvValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKdvValue.Location = new System.Drawing.Point(500, 35);
            this.lblKdvValue.Name = "lblKdvValue";
            this.lblKdvValue.Size = new System.Drawing.Size(44, 17);
            this.lblKdvValue.TabIndex = 5;
            this.lblKdvValue.Text = "0,00 ";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenelToplam.Location = new System.Drawing.Point(400, 55);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(122, 20);
            this.lblGenelToplam.TabIndex = 6;
            this.lblGenelToplam.Text = "Genel Toplam:";
            // 
            // lblGenelToplamValue
            // 
            this.lblGenelToplamValue.AutoSize = true;
            this.lblGenelToplamValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblGenelToplamValue.ForeColor = System.Drawing.Color.Red;
            this.lblGenelToplamValue.Location = new System.Drawing.Point(530, 55);
            this.lblGenelToplamValue.Name = "lblGenelToplamValue";
            this.lblGenelToplamValue.Size = new System.Drawing.Size(49, 20);
            this.lblGenelToplamValue.TabIndex = 7;
            this.lblGenelToplamValue.Text = "0,00 ";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamTutar.Location = new System.Drawing.Point(20, 65);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(109, 17);
            this.lblToplamTutar.TabIndex = 10;
            this.lblToplamTutar.Text = "Toplam Tutar:";
            // 
            // lblToplamTutarValue
            // 
            this.lblToplamTutarValue.AutoSize = true;
            this.lblToplamTutarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamTutarValue.ForeColor = System.Drawing.Color.Blue;
            this.lblToplamTutarValue.Location = new System.Drawing.Point(135, 65);
            this.lblToplamTutarValue.Name = "lblToplamTutarValue";
            this.lblToplamTutarValue.Size = new System.Drawing.Size(15, 17);
            this.lblToplamTutarValue.TabIndex = 11;
            this.lblToplamTutarValue.Text = "-";
            // 
            // FisDetayiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlFisInfo);
            this.Controls.Add(this.pnlHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FisDetayiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FİŞ DETAYI";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFisInfo.ResumeLayout(false);
            this.pnlFisInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFisInfo;
        private System.Windows.Forms.Label lblFisNo;
        private System.Windows.Forms.Label lblFisNoValue;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblTarihValue;
        private System.Windows.Forms.Label lblOdemeTuru;
        private System.Windows.Forms.Label lblOdemeTuruValue;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.Label lblMusteriAdiValue;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblDurumValue;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplam;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblToplamUrun;
        private System.Windows.Forms.Label lblToplamUrunValue;
        private System.Windows.Forms.Label lblAraToplam;
        private System.Windows.Forms.Label lblAraToplamValue;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.Label lblKdvValue;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label lblGenelToplamValue;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblToplamTutarValue;
    }
}
