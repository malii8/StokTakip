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
            this.btnTopluUrunGrubuDegistir = new System.Windows.Forms.Button();
            this.btnSecilenUrunGrubunuSil = new System.Windows.Forms.Button();
            this.btnYeniUrunGrubuEkle = new System.Windows.Forms.Button();
            this.lblUrunGrubuAdi = new System.Windows.Forms.Label();
            this.txtUrunGrubuAdi = new System.Windows.Forms.TextBox();
            this.dgvUrunGruplari = new System.Windows.Forms.DataGridView();
            this.colSiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunGrubuAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunGruplari)).BeginInit();
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
            // btnTopluUrunGrubuDegistir
            // 
            this.btnTopluUrunGrubuDegistir.BackColor = System.Drawing.Color.LightGreen;
            this.btnTopluUrunGrubuDegistir.Location = new System.Drawing.Point(80, 125);
            this.btnTopluUrunGrubuDegistir.Name = "btnTopluUrunGrubuDegistir";
            this.btnTopluUrunGrubuDegistir.Size = new System.Drawing.Size(120, 50);
            this.btnTopluUrunGrubuDegistir.TabIndex = 1;
            this.btnTopluUrunGrubuDegistir.Text = "Toplu Ürün Grubu Değiştir";
            this.btnTopluUrunGrubuDegistir.UseVisualStyleBackColor = false;
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
            // UrunGruplariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(650, 550);
            this.Controls.Add(this.dgvUrunGruplari);
            this.Controls.Add(this.txtUrunGrubuAdi);
            this.Controls.Add(this.lblUrunGrubuAdi);
            this.Controls.Add(this.btnYeniUrunGrubuEkle);
            this.Controls.Add(this.btnSecilenUrunGrubunuSil);
            this.Controls.Add(this.btnTopluUrunGrubuDegistir);
            this.Controls.Add(this.lblSecilenUrunGrubu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunGruplariForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÜRÜN GRUPLARI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunGruplari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblSecilenUrunGrubu;
        private System.Windows.Forms.Button btnTopluUrunGrubuDegistir;
        private System.Windows.Forms.Button btnSecilenUrunGrubunuSil;
        private System.Windows.Forms.Button btnYeniUrunGrubuEkle;
        private System.Windows.Forms.Label lblUrunGrubuAdi;
        private System.Windows.Forms.TextBox txtUrunGrubuAdi;
        private System.Windows.Forms.DataGridView dgvUrunGruplari;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunGrubuAdi;
    }
}
