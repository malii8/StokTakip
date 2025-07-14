namespace StokTakip.Forms
{
    partial class HesabaBorcEkleForm
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblMusterininAdi = new System.Windows.Forms.Label();
            this.txtMusterininAdi = new System.Windows.Forms.TextBox();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.txtToplamBorc = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.lblSaat = new System.Windows.Forms.Label();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.lblEklenecekTutar = new System.Windows.Forms.Label();
            this.txtEklenecekTutar = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnOnayGreenTick = new System.Windows.Forms.Button();
            this.btnVazgecRedX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblFormTitle.Location = new System.Drawing.Point(50, 20);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(300, 50);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "VERESİYE DEFTERİNE\nBORÇ EKLEME";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMusterininAdi
            // 
            this.lblMusterininAdi.AutoSize = true;
            this.lblMusterininAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusterininAdi.ForeColor = System.Drawing.Color.Blue;
            this.lblMusterininAdi.Location = new System.Drawing.Point(30, 90);
            this.lblMusterininAdi.Name = "lblMusterininAdi";
            this.lblMusterininAdi.Size = new System.Drawing.Size(73, 13);
            this.lblMusterininAdi.TabIndex = 1;
            this.lblMusterininAdi.Text = "Müşterinin Adı";
            // 
            // txtMusterininAdi
            // 
            this.txtMusterininAdi.Location = new System.Drawing.Point(130, 87);
            this.txtMusterininAdi.Name = "txtMusterininAdi";
            this.txtMusterininAdi.ReadOnly = true;
            this.txtMusterininAdi.Size = new System.Drawing.Size(230, 20);
            this.txtMusterininAdi.TabIndex = 2;
            this.txtMusterininAdi.Text = "BİLAL";
            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.AutoSize = true;
            this.lblToplamBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBorc.ForeColor = System.Drawing.Color.Blue;
            this.lblToplamBorc.Location = new System.Drawing.Point(30, 130);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(64, 13);
            this.lblToplamBorc.TabIndex = 3;
            this.lblToplamBorc.Text = "Toplam Borç";
            // 
            // txtToplamBorc
            // 
            this.txtToplamBorc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtToplamBorc.Location = new System.Drawing.Point(130, 127);
            this.txtToplamBorc.Name = "txtToplamBorc";
            this.txtToplamBorc.ReadOnly = true;
            this.txtToplamBorc.Size = new System.Drawing.Size(100, 20);
            this.txtToplamBorc.TabIndex = 4;
            this.txtToplamBorc.Text = "0,00 TL";
            this.txtToplamBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.Blue;
            this.lblTarih.Location = new System.Drawing.Point(30, 170);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(130, 167);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(100, 20);
            this.txtTarih.TabIndex = 6;
            this.txtTarih.Text = "12.07.2025";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.Blue;
            this.lblSaat.Location = new System.Drawing.Point(30, 210);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(28, 13);
            this.lblSaat.TabIndex = 7;
            this.lblSaat.Text = "Saat";
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(130, 207);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.ReadOnly = true;
            this.txtSaat.Size = new System.Drawing.Size(100, 20);
            this.txtSaat.TabIndex = 8;
            this.txtSaat.Text = "17:30:43";
            // 
            // lblEklenecekTutar
            // 
            this.lblEklenecekTutar.AutoSize = true;
            this.lblEklenecekTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEklenecekTutar.ForeColor = System.Drawing.Color.Blue;
            this.lblEklenecekTutar.Location = new System.Drawing.Point(30, 250);
            this.lblEklenecekTutar.Name = "lblEklenecekTutar";
            this.lblEklenecekTutar.Size = new System.Drawing.Size(84, 13);
            this.lblEklenecekTutar.TabIndex = 9;
            this.lblEklenecekTutar.Text = "Eklenecek Tutar";
            // 
            // txtEklenecekTutar
            // 
            this.txtEklenecekTutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEklenecekTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEklenecekTutar.Location = new System.Drawing.Point(130, 247);
            this.txtEklenecekTutar.Name = "txtEklenecekTutar";
            this.txtEklenecekTutar.Size = new System.Drawing.Size(200, 26);
            this.txtEklenecekTutar.TabIndex = 10;
            this.txtEklenecekTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.Blue;
            this.lblAciklama.Location = new System.Drawing.Point(30, 290);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 11;
            this.lblAciklama.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(30, 310);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(330, 80);
            this.txtAciklama.TabIndex = 12;
            // 
            // btnOnayGreenTick
            // 
            this.btnOnayGreenTick.BackColor = System.Drawing.Color.Green;
            this.btnOnayGreenTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayGreenTick.ForeColor = System.Drawing.Color.White;
            this.btnOnayGreenTick.Location = new System.Drawing.Point(140, 420);
            this.btnOnayGreenTick.Name = "btnOnayGreenTick";
            this.btnOnayGreenTick.Size = new System.Drawing.Size(60, 40);
            this.btnOnayGreenTick.TabIndex = 13;
            this.btnOnayGreenTick.Text = "✓";
            this.btnOnayGreenTick.UseVisualStyleBackColor = false;
            // 
            // btnVazgecRedX
            // 
            this.btnVazgecRedX.BackColor = System.Drawing.Color.Red;
            this.btnVazgecRedX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgecRedX.ForeColor = System.Drawing.Color.White;
            this.btnVazgecRedX.Location = new System.Drawing.Point(220, 420);
            this.btnVazgecRedX.Name = "btnVazgecRedX";
            this.btnVazgecRedX.Size = new System.Drawing.Size(60, 40);
            this.btnVazgecRedX.TabIndex = 14;
            this.btnVazgecRedX.Text = "✗";
            this.btnVazgecRedX.UseVisualStyleBackColor = false;
            // 
            // HesabaBorcEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.btnVazgecRedX);
            this.Controls.Add(this.btnOnayGreenTick);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtEklenecekTutar);
            this.Controls.Add(this.lblEklenecekTutar);
            this.Controls.Add(this.txtSaat);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.txtToplamBorc);
            this.Controls.Add(this.lblToplamBorc);
            this.Controls.Add(this.txtMusterininAdi);
            this.Controls.Add(this.lblMusterininAdi);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HesabaBorcEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VERESİYE DEFTERİNE BORÇ EKLEME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblMusterininAdi;
        private System.Windows.Forms.TextBox txtMusterininAdi;
        private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.TextBox txtToplamBorc;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.Label lblEklenecekTutar;
        private System.Windows.Forms.TextBox txtEklenecekTutar;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnOnayGreenTick;
        private System.Windows.Forms.Button btnVazgecRedX;
    }
}
