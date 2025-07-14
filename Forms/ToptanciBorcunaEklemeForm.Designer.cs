namespace StokTakip.Forms
{
    partial class ToptanciBorcunaEklemeForm
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
            this.lblToptanciAdi = new System.Windows.Forms.Label();
            this.txtToptanciAdi = new System.Windows.Forms.TextBox();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.txtToplamBorc = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblSaat = new System.Windows.Forms.Label();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.lblEklenecekTutar = new System.Windows.Forms.Label();
            this.txtEklenecekTutar = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(50, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TOPTANCI BORCUNA EKLEME YAPMA";

            // 
            // lblToptanciAdi
            // 
            this.lblToptanciAdi.AutoSize = true;
            this.lblToptanciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToptanciAdi.ForeColor = System.Drawing.Color.Blue;
            this.lblToptanciAdi.Location = new System.Drawing.Point(12, 50);
            this.lblToptanciAdi.Name = "lblToptanciAdi";
            this.lblToptanciAdi.Size = new System.Drawing.Size(97, 15);
            this.lblToptanciAdi.TabIndex = 1;
            this.lblToptanciAdi.Text = "Toptancının Adı";

            // 
            // txtToptanciAdi
            // 
            this.txtToptanciAdi.Location = new System.Drawing.Point(130, 48);
            this.txtToptanciAdi.Name = "txtToptanciAdi";
            this.txtToptanciAdi.ReadOnly = true;
            this.txtToptanciAdi.Size = new System.Drawing.Size(250, 20);
            this.txtToptanciAdi.TabIndex = 2;

            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.AutoSize = true;
            this.lblToplamBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamBorc.ForeColor = System.Drawing.Color.Blue;
            this.lblToplamBorc.Location = new System.Drawing.Point(12, 80);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(82, 15);
            this.lblToplamBorc.TabIndex = 3;
            this.lblToplamBorc.Text = "Toplam Borç";

            // 
            // txtToplamBorc
            // 
            this.txtToplamBorc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtToplamBorc.Location = new System.Drawing.Point(130, 78);
            this.txtToplamBorc.Name = "txtToplamBorc";
            this.txtToplamBorc.ReadOnly = true;
            this.txtToplamBorc.Size = new System.Drawing.Size(250, 20);
            this.txtToplamBorc.TabIndex = 4;

            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTarih.ForeColor = System.Drawing.Color.Blue;
            this.lblTarih.Location = new System.Drawing.Point(12, 110);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 15);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih";

            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(130, 108);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(100, 20);
            this.dtpTarih.TabIndex = 6;

            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaat.ForeColor = System.Drawing.Color.Blue;
            this.lblSaat.Location = new System.Drawing.Point(250, 110);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(33, 15);
            this.lblSaat.TabIndex = 7;
            this.lblSaat.Text = "Saat";

            // 
            // dtpSaat
            // 
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaat.Location = new System.Drawing.Point(290, 108);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.ShowUpDown = true;
            this.dtpSaat.Size = new System.Drawing.Size(90, 20);
            this.dtpSaat.TabIndex = 8;

            // 
            // lblEklenecekTutar
            // 
            this.lblEklenecekTutar.AutoSize = true;
            this.lblEklenecekTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEklenecekTutar.ForeColor = System.Drawing.Color.Blue;
            this.lblEklenecekTutar.Location = new System.Drawing.Point(12, 140);
            this.lblEklenecekTutar.Name = "lblEklenecekTutar";
            this.lblEklenecekTutar.Size = new System.Drawing.Size(106, 15);
            this.lblEklenecekTutar.TabIndex = 9;
            this.lblEklenecekTutar.Text = "Eklenecek Tutar";

            // 
            // txtEklenecekTutar
            // 
            this.txtEklenecekTutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEklenecekTutar.Location = new System.Drawing.Point(130, 138);
            this.txtEklenecekTutar.Name = "txtEklenecekTutar";
            this.txtEklenecekTutar.Size = new System.Drawing.Size(250, 20);
            this.txtEklenecekTutar.TabIndex = 10;

            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAciklama.ForeColor = System.Drawing.Color.Blue;
            this.lblAciklama.Location = new System.Drawing.Point(12, 170);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(65, 15);
            this.lblAciklama.TabIndex = 11;
            this.lblAciklama.Text = "Açıklama";

            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(12, 195);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(368, 80);
            this.txtAciklama.TabIndex = 12;

            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOnayla.ForeColor = System.Drawing.Color.White;
            this.btnOnayla.Location = new System.Drawing.Point(120, 300);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(80, 35);
            this.btnOnayla.TabIndex = 13;
            this.btnOnayla.Text = "✓ Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.BtnOnayla_Click);

            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnVazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVazgec.ForeColor = System.Drawing.Color.White;
            this.btnVazgec.Location = new System.Drawing.Point(220, 300);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(80, 35);
            this.btnVazgec.TabIndex = 14;
            this.btnVazgec.Text = "✗ Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            this.btnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);

            // 
            // ToptanciBorcunaEklemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 360);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtEklenecekTutar);
            this.Controls.Add(this.lblEklenecekTutar);
            this.Controls.Add(this.dtpSaat);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.txtToplamBorc);
            this.Controls.Add(this.lblToplamBorc);
            this.Controls.Add(this.txtToptanciAdi);
            this.Controls.Add(this.lblToptanciAdi);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToptanciBorcunaEklemeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TOPTANCI BORCUNA EKLEME YAPMA";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblToptanciAdi;
        private System.Windows.Forms.TextBox txtToptanciAdi;
        private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.TextBox txtToplamBorc;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.Label lblEklenecekTutar;
        private System.Windows.Forms.TextBox txtEklenecekTutar;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnVazgec;
    }
}
