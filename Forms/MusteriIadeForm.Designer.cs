namespace StokTakip.Forms
{
    partial class MusteriIadeForm
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
            this.grpBarkodArama = new System.Windows.Forms.GroupBox();
            this.picBarkod = new System.Windows.Forms.PictureBox();
            this.lblBarkodNoIleArama = new System.Windows.Forms.Label();
            this.lblF10 = new System.Windows.Forms.Label();
            this.grpUrunAdiArama = new System.Windows.Forms.GroupBox();
            this.picUrunAdi = new System.Windows.Forms.PictureBox();
            this.lblUrunAdiIleArama = new System.Windows.Forms.Label();
            this.lblF2 = new System.Windows.Forms.Label();
            this.grpArama = new System.Windows.Forms.GroupBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnIskontoUygula = new System.Windows.Forms.Button();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.colBarkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKalanStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsgariStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSatisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOlcuBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpIadeOnaylama = new System.Windows.Forms.GroupBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnMusteriNakitOdendi = new System.Windows.Forms.Button();
            this.btnKrediKartindan = new System.Windows.Forms.Button();
            this.btnMusteriBorcundan = new System.Windows.Forms.Button();
            this.grpBarkodArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarkod)).BeginInit();
            this.grpUrunAdiArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUrunAdi)).BeginInit();
            this.grpArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.grpIadeOnaylama.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Blue;
            this.lblBaslik.Location = new System.Drawing.Point(12, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(226, 20);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "MÜŞTERİDEN ALINAN İADELER";
            // 
            // grpBarkodArama
            // 
            this.grpBarkodArama.Controls.Add(this.picBarkod);
            this.grpBarkodArama.Controls.Add(this.lblBarkodNoIleArama);
            this.grpBarkodArama.Controls.Add(this.lblF10);
            this.grpBarkodArama.Location = new System.Drawing.Point(12, 40);
            this.grpBarkodArama.Name = "grpBarkodArama";
            this.grpBarkodArama.Size = new System.Drawing.Size(480, 80);
            this.grpBarkodArama.TabIndex = 1;
            this.grpBarkodArama.TabStop = false;
            // 
            // picBarkod
            // 
            this.picBarkod.BackColor = System.Drawing.Color.White;
            this.picBarkod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBarkod.Location = new System.Drawing.Point(115, 25);
            this.picBarkod.Name = "picBarkod";
            this.picBarkod.Size = new System.Drawing.Size(40, 40);
            this.picBarkod.TabIndex = 0;
            this.picBarkod.TabStop = false;
            // 
            // lblBarkodNoIleArama
            // 
            this.lblBarkodNoIleArama.AutoSize = true;
            this.lblBarkodNoIleArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkodNoIleArama.ForeColor = System.Drawing.Color.Blue;
            this.lblBarkodNoIleArama.Location = new System.Drawing.Point(170, 35);
            this.lblBarkodNoIleArama.Name = "lblBarkodNoIleArama";
            this.lblBarkodNoIleArama.Size = new System.Drawing.Size(168, 16);
            this.lblBarkodNoIleArama.TabIndex = 1;
            this.lblBarkodNoIleArama.Text = "BARKOD NO İLE ARAMA";
            // 
            // lblF10
            // 
            this.lblF10.AutoSize = true;
            this.lblF10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblF10.ForeColor = System.Drawing.Color.Blue;
            this.lblF10.Location = new System.Drawing.Point(350, 40);
            this.lblF10.Name = "lblF10";
            this.lblF10.Size = new System.Drawing.Size(32, 13);
            this.lblF10.TabIndex = 2;
            this.lblF10.Text = "(F10)";
            // 
            // grpUrunAdiArama
            // 
            this.grpUrunAdiArama.Controls.Add(this.picUrunAdi);
            this.grpUrunAdiArama.Controls.Add(this.lblUrunAdiIleArama);
            this.grpUrunAdiArama.Controls.Add(this.lblF2);
            this.grpUrunAdiArama.Location = new System.Drawing.Point(510, 40);
            this.grpUrunAdiArama.Name = "grpUrunAdiArama";
            this.grpUrunAdiArama.Size = new System.Drawing.Size(460, 80);
            this.grpUrunAdiArama.TabIndex = 2;
            this.grpUrunAdiArama.TabStop = false;
            // 
            // picUrunAdi
            // 
            this.picUrunAdi.BackColor = System.Drawing.Color.White;
            this.picUrunAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUrunAdi.Location = new System.Drawing.Point(115, 25);
            this.picUrunAdi.Name = "picUrunAdi";
            this.picUrunAdi.Size = new System.Drawing.Size(40, 40);
            this.picUrunAdi.TabIndex = 0;
            this.picUrunAdi.TabStop = false;
            // 
            // lblUrunAdiIleArama
            // 
            this.lblUrunAdiIleArama.AutoSize = true;
            this.lblUrunAdiIleArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdiIleArama.ForeColor = System.Drawing.Color.Blue;
            this.lblUrunAdiIleArama.Location = new System.Drawing.Point(170, 35);
            this.lblUrunAdiIleArama.Name = "lblUrunAdiIleArama";
            this.lblUrunAdiIleArama.Size = new System.Drawing.Size(147, 16);
            this.lblUrunAdiIleArama.TabIndex = 1;
            this.lblUrunAdiIleArama.Text = "ÜRÜN ADI İLE ARAMA";
            // 
            // lblF2
            // 
            this.lblF2.AutoSize = true;
            this.lblF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblF2.ForeColor = System.Drawing.Color.Blue;
            this.lblF2.Location = new System.Drawing.Point(330, 40);
            this.lblF2.Name = "lblF2";
            this.lblF2.Size = new System.Drawing.Size(27, 13);
            this.lblF2.TabIndex = 2;
            this.lblF2.Text = "(F2)";
            // 
            // grpArama
            // 
            this.grpArama.Controls.Add(this.lblMiktar);
            this.grpArama.Controls.Add(this.txtMiktar);
            this.grpArama.Controls.Add(this.lblBarkodNo);
            this.grpArama.Controls.Add(this.txtBarkodNo);
            this.grpArama.Controls.Add(this.btnAra);
            this.grpArama.Controls.Add(this.btnVazgec);
            this.grpArama.Controls.Add(this.btnIskontoUygula);
            this.grpArama.Location = new System.Drawing.Point(12, 130);
            this.grpArama.Name = "grpArama";
            this.grpArama.Size = new System.Drawing.Size(958, 80);
            this.grpArama.TabIndex = 3;
            this.grpArama.TabStop = false;
            // 
            // lblMiktar
            // 
            this.lblMiktar.BackColor = System.Drawing.Color.Red;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.ForeColor = System.Drawing.Color.White;
            this.lblMiktar.Location = new System.Drawing.Point(15, 25);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(70, 35);
            this.lblMiktar.TabIndex = 0;
            this.lblMiktar.Text = "Miktarı (F3)";
            this.lblMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.Color.Red;
            this.txtMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.ForeColor = System.Drawing.Color.White;
            this.txtMiktar.Location = new System.Drawing.Point(90, 25);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(70, 29);
            this.txtMiktar.TabIndex = 1;
            this.txtMiktar.Text = "1";
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkodNo.ForeColor = System.Drawing.Color.Blue;
            this.lblBarkodNo.Location = new System.Drawing.Point(180, 15);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(100, 16);
            this.lblBarkodNo.TabIndex = 2;
            this.lblBarkodNo.Text = "Barkod No (F4)";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.BackColor = System.Drawing.Color.Yellow;
            this.txtBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.Location = new System.Drawing.Point(180, 34);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(300, 24);
            this.txtBarkodNo.TabIndex = 3;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.LightBlue;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(500, 25);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(80, 35);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.Salmon;
            this.btnVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.Location = new System.Drawing.Point(590, 25);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(80, 35);
            this.btnVazgec.TabIndex = 5;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            // 
            // btnIskontoUygula
            // 
            this.btnIskontoUygula.BackColor = System.Drawing.Color.LightGreen;
            this.btnIskontoUygula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIskontoUygula.Location = new System.Drawing.Point(680, 25);
            this.btnIskontoUygula.Name = "btnIskontoUygula";
            this.btnIskontoUygula.Size = new System.Drawing.Size(80, 35);
            this.btnIskontoUygula.TabIndex = 6;
            this.btnIskontoUygula.Text = "İskonto\nUygula";
            this.btnIskontoUygula.UseVisualStyleBackColor = false;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.BackgroundColor = System.Drawing.Color.Orange;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBarkodNo,
            this.colUrunAdi,
            this.colKalanStok,
            this.colAsgariStok,
            this.colSatisFiyati,
            this.colMiktar,
            this.colOlcuBirimi,
            this.colToplamTutar});
            this.dgvUrunler.Location = new System.Drawing.Point(12, 220);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(958, 300);
            this.dgvUrunler.TabIndex = 4;
            // 
            // colBarkodNo
            // 
            this.colBarkodNo.HeaderText = "Barkod No";
            this.colBarkodNo.Name = "colBarkodNo";
            this.colBarkodNo.Width = 120;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.HeaderText = "Ürünün Adı";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Width = 300;
            // 
            // colKalanStok
            // 
            this.colKalanStok.HeaderText = "Kalan Stok";
            this.colKalanStok.Name = "colKalanStok";
            this.colKalanStok.Width = 80;
            // 
            // colAsgariStok
            // 
            this.colAsgariStok.HeaderText = "Asgari Stok";
            this.colAsgariStok.Name = "colAsgariStok";
            this.colAsgariStok.Width = 80;
            // 
            // colSatisFiyati
            // 
            this.colSatisFiyati.HeaderText = "Satış Fiyatı";
            this.colSatisFiyati.Name = "colSatisFiyati";
            this.colSatisFiyati.Width = 100;
            // 
            // colMiktar
            // 
            this.colMiktar.HeaderText = "Miktarı";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Width = 70;
            // 
            // colOlcuBirimi
            // 
            this.colOlcuBirimi.HeaderText = "Ölçü Birimi";
            this.colOlcuBirimi.Name = "colOlcuBirimi";
            this.colOlcuBirimi.Width = 80;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.HeaderText = "Toplam Tutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.Width = 120;
            // 
            // grpIadeOnaylama
            // 
            this.grpIadeOnaylama.Controls.Add(this.lblToplam);
            this.grpIadeOnaylama.Controls.Add(this.lblToplamTutar);
            this.grpIadeOnaylama.Controls.Add(this.btnMusteriNakitOdendi);
            this.grpIadeOnaylama.Controls.Add(this.btnKrediKartindan);
            this.grpIadeOnaylama.Controls.Add(this.btnMusteriBorcundan);
            this.grpIadeOnaylama.Location = new System.Drawing.Point(12, 530);
            this.grpIadeOnaylama.Name = "grpIadeOnaylama";
            this.grpIadeOnaylama.Size = new System.Drawing.Size(958, 100);
            this.grpIadeOnaylama.TabIndex = 5;
            this.grpIadeOnaylama.TabStop = false;
            this.grpIadeOnaylama.Text = "İADE ONAYLAMA";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.Black;
            this.lblToplam.Location = new System.Drawing.Point(20, 40);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(106, 25);
            this.lblToplam.TabIndex = 0;
            this.lblToplam.Text = "TOPLAM";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.BackColor = System.Drawing.Color.Turquoise;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Black;
            this.lblToplamTutar.Location = new System.Drawing.Point(140, 30);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(200, 45);
            this.lblToplamTutar.TabIndex = 1;
            this.lblToplamTutar.Text = "0,00";
            this.lblToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMusteriNakitOdendi
            // 
            this.btnMusteriNakitOdendi.BackColor = System.Drawing.Color.LightBlue;
            this.btnMusteriNakitOdendi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriNakitOdendi.Location = new System.Drawing.Point(380, 30);
            this.btnMusteriNakitOdendi.Name = "btnMusteriNakitOdendi";
            this.btnMusteriNakitOdendi.Size = new System.Drawing.Size(120, 45);
            this.btnMusteriNakitOdendi.TabIndex = 2;
            this.btnMusteriNakitOdendi.Text = "Müşteriye\nNakit Ödendi";
            this.btnMusteriNakitOdendi.UseVisualStyleBackColor = false;
            // 
            // btnKrediKartindan
            // 
            this.btnKrediKartindan.BackColor = System.Drawing.Color.LightGreen;
            this.btnKrediKartindan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKrediKartindan.Location = new System.Drawing.Point(520, 30);
            this.btnKrediKartindan.Name = "btnKrediKartindan";
            this.btnKrediKartindan.Size = new System.Drawing.Size(120, 45);
            this.btnKrediKartindan.TabIndex = 3;
            this.btnKrediKartindan.Text = "Kredi Kartından\nDüşülecek";
            this.btnKrediKartindan.UseVisualStyleBackColor = false;
            // 
            // btnMusteriBorcundan
            // 
            this.btnMusteriBorcundan.BackColor = System.Drawing.Color.Yellow;
            this.btnMusteriBorcundan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriBorcundan.Location = new System.Drawing.Point(660, 30);
            this.btnMusteriBorcundan.Name = "btnMusteriBorcundan";
            this.btnMusteriBorcundan.Size = new System.Drawing.Size(120, 45);
            this.btnMusteriBorcundan.TabIndex = 4;
            this.btnMusteriBorcundan.Text = "Müşteri\nBorcundan\nDüşülecek";
            this.btnMusteriBorcundan.UseVisualStyleBackColor = false;
            // 
            // MusteriIadeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(990, 650);
            this.Controls.Add(this.grpIadeOnaylama);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.grpArama);
            this.Controls.Add(this.grpUrunAdiArama);
            this.Controls.Add(this.grpBarkodArama);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MusteriIadeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİDEN ALINAN İADELER";
            this.grpBarkodArama.ResumeLayout(false);
            this.grpBarkodArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarkod)).EndInit();
            this.grpUrunAdiArama.ResumeLayout(false);
            this.grpUrunAdiArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUrunAdi)).EndInit();
            this.grpArama.ResumeLayout(false);
            this.grpArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.grpIadeOnaylama.ResumeLayout(false);
            this.grpIadeOnaylama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.GroupBox grpBarkodArama;
        private System.Windows.Forms.PictureBox picBarkod;
        private System.Windows.Forms.Label lblBarkodNoIleArama;
        private System.Windows.Forms.Label lblF10;
        private System.Windows.Forms.GroupBox grpUrunAdiArama;
        private System.Windows.Forms.PictureBox picUrunAdi;
        private System.Windows.Forms.Label lblUrunAdiIleArama;
        private System.Windows.Forms.Label lblF2;
        private System.Windows.Forms.GroupBox grpArama;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnIskontoUygula;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKalanStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsgariStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSatisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOlcuBirimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplamTutar;
        private System.Windows.Forms.GroupBox grpIadeOnaylama;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnMusteriNakitOdendi;
        private System.Windows.Forms.Button btnKrediKartindan;
        private System.Windows.Forms.Button btnMusteriBorcundan;
    }
}
