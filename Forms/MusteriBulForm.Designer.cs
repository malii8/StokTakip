namespace StokTakip.Forms
{
    partial class MusteriBulForm
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
            this.lblMusteriAra = new System.Windows.Forms.Label();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.btnYeniMusteriEkle = new System.Windows.Forms.Button();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.colSiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMusterininAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorcu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "<<< Adı Soyadı >>>";
            // 
            // lblMusteriAra
            // 
            this.lblMusteriAra.AutoSize = true;
            this.lblMusteriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMusteriAra.Location = new System.Drawing.Point(70, 60);
            this.lblMusteriAra.Name = "lblMusteriAra";
            this.lblMusteriAra.Size = new System.Drawing.Size(83, 17);
            this.lblMusteriAra.TabIndex = 1;
            this.lblMusteriAra.Text = "Müşteri Ara";
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.BackColor = System.Drawing.Color.Yellow;
            this.txtMusteriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMusteriAra.Location = new System.Drawing.Point(170, 57);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(300, 23);
            this.txtMusteriAra.TabIndex = 2;
            this.txtMusteriAra.TextChanged += new System.EventHandler(this.txtMusteriAra_TextChanged);
            // 
            // btnYeniMusteriEkle
            // 
            this.btnYeniMusteriEkle.BackColor = System.Drawing.Color.LightBlue;
            this.btnYeniMusteriEkle.Location = new System.Drawing.Point(25, 55);
            this.btnYeniMusteriEkle.Name = "btnYeniMusteriEkle";
            this.btnYeniMusteriEkle.Size = new System.Drawing.Size(40, 40);
            this.btnYeniMusteriEkle.TabIndex = 3;
            this.btnYeniMusteriEkle.Text = "Yeni\nMüşteri\nEkle";
            this.btnYeniMusteriEkle.UseVisualStyleBackColor = false;
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.AllowUserToAddRows = false;
            this.dgvMusteriler.AllowUserToDeleteRows = false;
            this.dgvMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSiraNo,
            this.colMusterininAdi,
            this.colBorcu});
            this.dgvMusteriler.Location = new System.Drawing.Point(25, 100);
            this.dgvMusteriler.MultiSelect = false;
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.ReadOnly = true;
            this.dgvMusteriler.RowHeadersVisible = false;
            this.dgvMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriler.Size = new System.Drawing.Size(550, 200);
            this.dgvMusteriler.TabIndex = 4;
            // 
            // colSiraNo
            // 
            this.colSiraNo.HeaderText = "Sıra No";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.ReadOnly = true;
            this.colSiraNo.Width = 80;
            // 
            // colMusterininAdi
            // 
            this.colMusterininAdi.HeaderText = "Müşterinin Adı";
            this.colMusterininAdi.Name = "colMusterininAdi";
            this.colMusterininAdi.ReadOnly = true;
            this.colMusterininAdi.Width = 350;
            // 
            // colBorcu
            // 
            this.colBorcu.HeaderText = "Borcu";
            this.colBorcu.Name = "colBorcu";
            this.colBorcu.ReadOnly = true;
            this.colBorcu.Width = 120;
            // 
            // MusteriBulForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.btnYeniMusteriEkle);
            this.Controls.Add(this.txtMusteriAra);
            this.Controls.Add(this.lblMusteriAra);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriBulForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MÜŞTERİ BUL";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMusteriAra;
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.Button btnYeniMusteriEkle;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMusterininAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorcu;
    }
}
