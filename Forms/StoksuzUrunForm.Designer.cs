namespace StokTakip.Forms
{
    partial class StoksuzUrunForm
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
            this.lblSatisTutari = new System.Windows.Forms.Label();
            this.txtSatisTutari = new System.Windows.Forms.TextBox();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSatisTutari
            // 
            this.lblSatisTutari.AutoSize = true;
            this.lblSatisTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisTutari.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblSatisTutari.Location = new System.Drawing.Point(50, 50);
            this.lblSatisTutari.Name = "lblSatisTutari";
            this.lblSatisTutari.Size = new System.Drawing.Size(99, 20);
            this.lblSatisTutari.TabIndex = 0;
            this.lblSatisTutari.Text = "Satış Tutarı";
            // 
            // txtSatisTutari
            // 
            this.txtSatisTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisTutari.Location = new System.Drawing.Point(180, 47);
            this.txtSatisTutari.Name = "txtSatisTutari";
            this.txtSatisTutari.Size = new System.Drawing.Size(150, 26);
            this.txtSatisTutari.TabIndex = 1;
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlisFiyati.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblAlisFiyati.Location = new System.Drawing.Point(50, 90);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(87, 20);
            this.lblAlisFiyati.TabIndex = 2;
            this.lblAlisFiyati.Text = "Alış Fiyatı";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisFiyati.Location = new System.Drawing.Point(180, 87);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(150, 26);
            this.txtAlisFiyati.TabIndex = 3;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblUrunAdi.Location = new System.Drawing.Point(50, 130);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(124, 40);
            this.lblUrunAdi.TabIndex = 4;
            this.lblUrunAdi.Text = "Ürün veya Hizmet Adı\r\n( İsteğe Bağlı )";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(180, 137);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(150, 26);
            this.txtUrunAdi.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = null;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(50, 200);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 50);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.Image = global::StokTakip.Properties.Resources.delete_button;
            this.btnVazgec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVazgec.Location = new System.Drawing.Point(210, 200);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(120, 50);
            this.btnVazgec.TabIndex = 7;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVazgec.UseVisualStyleBackColor = true;
            // 
            // StoksuzUrunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.lblAlisFiyati);
            this.Controls.Add(this.txtSatisTutari);
            this.Controls.Add(this.lblSatisTutari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoksuzUrunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stoksuz Ürün";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSatisTutari;
        private System.Windows.Forms.TextBox txtSatisTutari;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnVazgec;
    }
}
