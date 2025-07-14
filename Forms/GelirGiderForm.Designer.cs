namespace StokTakip.Forms
{
    partial class GelirGiderForm
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
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblSaat = new System.Windows.Forms.Label();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.lblSebep = new System.Windows.Forms.Label();
            this.cmbSebep = new System.Windows.Forms.ComboBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.numTutar = new System.Windows.Forms.NumericUpDown();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblIslemYapan = new System.Windows.Forms.Label();
            this.cmbIslemYapan = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTutar)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTarih.Location = new System.Drawing.Point(20, 20);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(40, 15);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih";

            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(20, 45);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(150, 20);
            this.dtpTarih.TabIndex = 1;

            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaat.Location = new System.Drawing.Point(190, 20);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(34, 15);
            this.lblSaat.TabIndex = 2;
            this.lblSaat.Text = "Saat";

            // 
            // dtpSaat
            // 
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaat.Location = new System.Drawing.Point(190, 45);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.ShowUpDown = true;
            this.dtpSaat.Size = new System.Drawing.Size(120, 20);
            this.dtpSaat.TabIndex = 3;

            // 
            // lblSebep
            // 
            this.lblSebep.AutoSize = true;
            this.lblSebep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSebep.Location = new System.Drawing.Point(20, 80);
            this.lblSebep.Name = "lblSebep";
            this.lblSebep.Size = new System.Drawing.Size(43, 15);
            this.lblSebep.TabIndex = 4;
            this.lblSebep.Text = "Sebep";

            // 
            // cmbSebep
            // 
            this.cmbSebep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSebep.Location = new System.Drawing.Point(20, 105);
            this.cmbSebep.Name = "cmbSebep";
            this.cmbSebep.Size = new System.Drawing.Size(290, 21);
            this.cmbSebep.TabIndex = 5;

            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTutar.Location = new System.Drawing.Point(20, 140);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(40, 15);
            this.lblTutar.TabIndex = 6;
            this.lblTutar.Text = "Tutar";

            // 
            // numTutar
            // 
            this.numTutar.DecimalPlaces = 2;
            this.numTutar.Location = new System.Drawing.Point(20, 165);
            this.numTutar.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numTutar.Name = "numTutar";
            this.numTutar.Size = new System.Drawing.Size(150, 20);
            this.numTutar.TabIndex = 7;

            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAciklama.Location = new System.Drawing.Point(20, 200);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(64, 15);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama";

            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(20, 225);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(290, 60);
            this.txtAciklama.TabIndex = 9;

            // 
            // lblIslemYapan
            // 
            this.lblIslemYapan.AutoSize = true;
            this.lblIslemYapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIslemYapan.Location = new System.Drawing.Point(20, 300);
            this.lblIslemYapan.Name = "lblIslemYapan";
            this.lblIslemYapan.Size = new System.Drawing.Size(79, 15);
            this.lblIslemYapan.TabIndex = 10;
            this.lblIslemYapan.Text = "İşlem Yapan";

            // 
            // cmbIslemYapan
            // 
            this.cmbIslemYapan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemYapan.Location = new System.Drawing.Point(20, 325);
            this.cmbIslemYapan.Name = "cmbIslemYapan";
            this.cmbIslemYapan.Size = new System.Drawing.Size(150, 21);
            this.cmbIslemYapan.TabIndex = 11;

            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(130, 370);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 35);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(230, 370);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(80, 35);
            this.btnIptal.TabIndex = 13;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);

            // 
            // GelirGiderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(350, 430);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbIslemYapan);
            this.Controls.Add(this.lblIslemYapan);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.numTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.cmbSebep);
            this.Controls.Add(this.lblSebep);
            this.Controls.Add(this.dtpSaat);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lblTarih);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GelirGiderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gelir/Gider Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.numTutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.Label lblSebep;
        private System.Windows.Forms.ComboBox cmbSebep;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.NumericUpDown numTutar;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblIslemYapan;
        private System.Windows.Forms.ComboBox cmbIslemYapan;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}
