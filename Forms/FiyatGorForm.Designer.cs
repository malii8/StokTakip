namespace StokTakip.Forms
{
    partial class FiyatGorForm
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
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnUrunAdiIleAra = new System.Windows.Forms.Button();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblMevcutStok = new System.Windows.Forms.Label();
            this.txtMevcutStok = new System.Windows.Forms.TextBox();
            this.lblSatisFiyatiLabel = new System.Windows.Forms.Label();
            this.lblSatisFiyatiValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkodNo.ForeColor = System.Drawing.Color.Blue;
            this.lblBarkodNo.Location = new System.Drawing.Point(30, 30);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(121, 30);
            this.lblBarkodNo.TabIndex = 0;
            this.lblBarkodNo.Text = "Barkod No";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.BackColor = System.Drawing.Color.LightCoral;
            this.txtBarkodNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.Location = new System.Drawing.Point(160, 30);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(310, 35);
            this.txtBarkodNo.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(160, 80);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(90, 40);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(260, 80);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 40);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat (Esc)";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // btnUrunAdiIleAra
            // 
            this.btnUrunAdiIleAra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunAdiIleAra.Location = new System.Drawing.Point(360, 80);
            this.btnUrunAdiIleAra.Name = "btnUrunAdiIleAra";
            this.btnUrunAdiIleAra.Size = new System.Drawing.Size(110, 40);
            this.btnUrunAdiIleAra.TabIndex = 4;
            this.btnUrunAdiIleAra.Text = "Ürün Adı İle Ara";
            this.btnUrunAdiIleAra.UseVisualStyleBackColor = true;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUrunAdi.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(35, 140);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(435, 100);
            this.lblUrunAdi.TabIndex = 5;
            this.lblUrunAdi.Text = "ŞEKER 1KG";
            this.lblUrunAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMevcutStok
            // 
            this.lblMevcutStok.AutoSize = true;
            this.lblMevcutStok.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMevcutStok.ForeColor = System.Drawing.Color.Blue;
            this.lblMevcutStok.Location = new System.Drawing.Point(30, 260);
            this.lblMevcutStok.Name = "lblMevcutStok";
            this.lblMevcutStok.Size = new System.Drawing.Size(140, 30);
            this.lblMevcutStok.TabIndex = 6;
            this.lblMevcutStok.Text = "Mevcut Stok";
            // 
            // txtMevcutStok
            // 
            this.txtMevcutStok.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMevcutStok.Location = new System.Drawing.Point(180, 260);
            this.txtMevcutStok.Name = "txtMevcutStok";
            this.txtMevcutStok.Size = new System.Drawing.Size(120, 35);
            this.txtMevcutStok.TabIndex = 7;
            this.txtMevcutStok.Text = "17,5";
            this.txtMevcutStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSatisFiyatiLabel
            // 
            this.lblSatisFiyatiLabel.AutoSize = true;
            this.lblSatisFiyatiLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisFiyatiLabel.ForeColor = System.Drawing.Color.Blue;
            this.lblSatisFiyatiLabel.Location = new System.Drawing.Point(30, 320);
            this.lblSatisFiyatiLabel.Name = "lblSatisFiyatiLabel";
            this.lblSatisFiyatiLabel.Size = new System.Drawing.Size(125, 30);
            this.lblSatisFiyatiLabel.TabIndex = 8;
            this.lblSatisFiyatiLabel.Text = "Satış Fiyatı";
            // 
            // lblSatisFiyatiValue
            // 
            this.lblSatisFiyatiValue.BackColor = System.Drawing.Color.Turquoise;
            this.lblSatisFiyatiValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisFiyatiValue.Location = new System.Drawing.Point(180, 310);
            this.lblSatisFiyatiValue.Name = "lblSatisFiyatiValue";
            this.lblSatisFiyatiValue.Size = new System.Drawing.Size(290, 70);
            this.lblSatisFiyatiValue.TabIndex = 9;
            this.lblSatisFiyatiValue.Text = "45,00";
            this.lblSatisFiyatiValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FiyatGorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(504, 411);
            this.Controls.Add(this.lblSatisFiyatiValue);
            this.Controls.Add(this.lblSatisFiyatiLabel);
            this.Controls.Add(this.txtMevcutStok);
            this.Controls.Add(this.lblMevcutStok);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.btnUrunAdiIleAra);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.lblBarkodNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FiyatGorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FİYAT GÖR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnUrunAdiIleAra;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblMevcutStok;
        private System.Windows.Forms.TextBox txtMevcutStok;
        private System.Windows.Forms.Label lblSatisFiyatiLabel;
        private System.Windows.Forms.Label lblSatisFiyatiValue;
    }
}
