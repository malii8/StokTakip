namespace StokTakip.Forms
{
    partial class ToptanciBorcListesiForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvBorcListesi = new System.Windows.Forms.DataGridView();
            this.colSiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToptanciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorcMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlArama = new System.Windows.Forms.Panel();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.pnlFiltre = new System.Windows.Forms.Panel();
            this.rbSadeceAlacakli = new System.Windows.Forms.RadioButton();
            this.rbSadeceBorclu = new System.Windows.Forms.RadioButton();
            this.rbTumToptancilar = new System.Windows.Forms.RadioButton();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.pnlOzet = new System.Windows.Forms.Panel();
            this.lblToplamBorclu = new System.Windows.Forms.Label();
            this.lblToplamAlacakli = new System.Windows.Forms.Label();
            this.lblBorcSiz = new System.Windows.Forms.Label();
            this.lblToplamBorcMiktari = new System.Windows.Forms.Label();
            this.lblToplamAlacakMiktari = new System.Windows.Forms.Label();
            this.lblNetBorc = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorcListesi)).BeginInit();
            this.pnlArama.SuspendLayout();
            this.pnlFiltre.SuspendLayout();
            this.pnlOzet.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Orange;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(960, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TOPTANCI BORÇ LİSTESİ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvBorcListesi
            // 
            this.dgvBorcListesi.AllowUserToAddRows = false;
            this.dgvBorcListesi.AllowUserToDeleteRows = false;
            this.dgvBorcListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorcListesi.BackgroundColor = System.Drawing.Color.White;
            this.dgvBorcListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorcListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSiraNo,
            this.colToptanciAdi,
            this.colBorcMiktari,
            this.colTelefon,
            this.colAdres,
            this.colDurum});
            this.dgvBorcListesi.Location = new System.Drawing.Point(12, 130);
            this.dgvBorcListesi.MultiSelect = false;
            this.dgvBorcListesi.Name = "dgvBorcListesi";
            this.dgvBorcListesi.ReadOnly = true;
            this.dgvBorcListesi.RowHeadersVisible = false;
            this.dgvBorcListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorcListesi.Size = new System.Drawing.Size(960, 350);
            this.dgvBorcListesi.TabIndex = 1;
            // 
            // colSiraNo
            // 
            this.colSiraNo.FillWeight = 50F;
            this.colSiraNo.HeaderText = "No";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.ReadOnly = true;
            // 
            // colToptanciAdi
            // 
            this.colToptanciAdi.FillWeight = 200F;
            this.colToptanciAdi.HeaderText = "Toptancı Adı";
            this.colToptanciAdi.Name = "colToptanciAdi";
            this.colToptanciAdi.ReadOnly = true;
            // 
            // colBorcMiktari
            // 
            this.colBorcMiktari.FillWeight = 100F;
            this.colBorcMiktari.HeaderText = "Borç Miktarı (TL)";
            this.colBorcMiktari.Name = "colBorcMiktari";
            this.colBorcMiktari.ReadOnly = true;
            // 
            // colTelefon
            // 
            this.colTelefon.FillWeight = 120F;
            this.colTelefon.HeaderText = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.ReadOnly = true;
            // 
            // colAdres
            // 
            this.colAdres.FillWeight = 150F;
            this.colAdres.HeaderText = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.ReadOnly = true;
            // 
            // colDurum
            // 
            this.colDurum.FillWeight = 80F;
            this.colDurum.HeaderText = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.ReadOnly = true;
            // 
            // pnlArama
            // 
            this.pnlArama.BackColor = System.Drawing.Color.LightGray;
            this.pnlArama.Controls.Add(this.txtArama);
            this.pnlArama.Controls.Add(this.lblArama);
            this.pnlArama.Location = new System.Drawing.Point(12, 65);
            this.pnlArama.Name = "pnlArama";
            this.pnlArama.Size = new System.Drawing.Size(300, 50);
            this.pnlArama.TabIndex = 2;
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.Color.Yellow;
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtArama.Location = new System.Drawing.Point(80, 15);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(200, 23);
            this.txtArama.TabIndex = 1;
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblArama.Location = new System.Drawing.Point(10, 18);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(57, 17);
            this.lblArama.TabIndex = 0;
            this.lblArama.Text = "Arama:";
            // 
            // pnlFiltre
            // 
            this.pnlFiltre.BackColor = System.Drawing.Color.LightGray;
            this.pnlFiltre.Controls.Add(this.rbSadeceAlacakli);
            this.pnlFiltre.Controls.Add(this.rbSadeceBorclu);
            this.pnlFiltre.Controls.Add(this.rbTumToptancilar);
            this.pnlFiltre.Controls.Add(this.lblFiltre);
            this.pnlFiltre.Location = new System.Drawing.Point(330, 65);
            this.pnlFiltre.Name = "pnlFiltre";
            this.pnlFiltre.Size = new System.Drawing.Size(450, 50);
            this.pnlFiltre.TabIndex = 3;
            // 
            // rbSadeceAlacakli
            // 
            this.rbSadeceAlacakli.AutoSize = true;
            this.rbSadeceAlacakli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbSadeceAlacakli.Location = new System.Drawing.Point(340, 18);
            this.rbSadeceAlacakli.Name = "rbSadeceAlacakli";
            this.rbSadeceAlacakli.Size = new System.Drawing.Size(107, 19);
            this.rbSadeceAlacakli.TabIndex = 3;
            this.rbSadeceAlacakli.Text = "Sadece Alacaklı";
            this.rbSadeceAlacakli.UseVisualStyleBackColor = true;
            // 
            // rbSadeceBorclu
            // 
            this.rbSadeceBorclu.AutoSize = true;
            this.rbSadeceBorclu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbSadeceBorclu.Location = new System.Drawing.Point(230, 18);
            this.rbSadeceBorclu.Name = "rbSadeceBorclu";
            this.rbSadeceBorclu.Size = new System.Drawing.Size(97, 19);
            this.rbSadeceBorclu.TabIndex = 2;
            this.rbSadeceBorclu.Text = "Sadece Borçlu";
            this.rbSadeceBorclu.UseVisualStyleBackColor = true;
            // 
            // rbTumToptancilar
            // 
            this.rbTumToptancilar.AutoSize = true;
            this.rbTumToptancilar.Checked = true;
            this.rbTumToptancilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbTumToptancilar.Location = new System.Drawing.Point(110, 18);
            this.rbTumToptancilar.Name = "rbTumToptancilar";
            this.rbTumToptancilar.Size = new System.Drawing.Size(110, 19);
            this.rbTumToptancilar.TabIndex = 1;
            this.rbTumToptancilar.TabStop = true;
            this.rbTumToptancilar.Text = "Tüm Toptancılar";
            this.rbTumToptancilar.UseVisualStyleBackColor = true;
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFiltre.Location = new System.Drawing.Point(10, 18);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(47, 17);
            this.lblFiltre.TabIndex = 0;
            this.lblFiltre.Text = "Filtre:";
            // 
            // pnlOzet
            // 
            this.pnlOzet.BackColor = System.Drawing.Color.Cyan;
            this.pnlOzet.Controls.Add(this.lblNetBorc);
            this.pnlOzet.Controls.Add(this.lblToplamAlacakMiktari);
            this.pnlOzet.Controls.Add(this.lblToplamBorcMiktari);
            this.pnlOzet.Controls.Add(this.lblBorcSiz);
            this.pnlOzet.Controls.Add(this.lblToplamAlacakli);
            this.pnlOzet.Controls.Add(this.lblToplamBorclu);
            this.pnlOzet.Location = new System.Drawing.Point(12, 495);
            this.pnlOzet.Name = "pnlOzet";
            this.pnlOzet.Size = new System.Drawing.Size(960, 80);
            this.pnlOzet.TabIndex = 4;
            // 
            // lblToplamBorclu
            // 
            this.lblToplamBorclu.AutoSize = true;
            this.lblToplamBorclu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamBorclu.Location = new System.Drawing.Point(15, 15);
            this.lblToplamBorclu.Name = "lblToplamBorclu";
            this.lblToplamBorclu.Size = new System.Drawing.Size(169, 17);
            this.lblToplamBorclu.TabIndex = 0;
            this.lblToplamBorclu.Text = "Toplam Borçlu: 0 Kişi";
            // 
            // lblToplamAlacakli
            // 
            this.lblToplamAlacakli.AutoSize = true;
            this.lblToplamAlacakli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamAlacakli.Location = new System.Drawing.Point(200, 15);
            this.lblToplamAlacakli.Name = "lblToplamAlacakli";
            this.lblToplamAlacakli.Size = new System.Drawing.Size(181, 17);
            this.lblToplamAlacakli.TabIndex = 1;
            this.lblToplamAlacakli.Text = "Toplam Alacaklı: 0 Kişi";
            // 
            // lblBorcSiz
            // 
            this.lblBorcSiz.AutoSize = true;
            this.lblBorcSiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblBorcSiz.Location = new System.Drawing.Point(400, 15);
            this.lblBorcSiz.Name = "lblBorcSiz";
            this.lblBorcSiz.Size = new System.Drawing.Size(119, 17);
            this.lblBorcSiz.TabIndex = 2;
            this.lblBorcSiz.Text = "Borç Yok: 0 Kişi";
            // 
            // lblToplamBorcMiktari
            // 
            this.lblToplamBorcMiktari.AutoSize = true;
            this.lblToplamBorcMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamBorcMiktari.ForeColor = System.Drawing.Color.Red;
            this.lblToplamBorcMiktari.Location = new System.Drawing.Point(15, 45);
            this.lblToplamBorcMiktari.Name = "lblToplamBorcMiktari";
            this.lblToplamBorcMiktari.Size = new System.Drawing.Size(144, 17);
            this.lblToplamBorcMiktari.TabIndex = 3;
            this.lblToplamBorcMiktari.Text = "Toplam Borç: 0 TL";
            // 
            // lblToplamAlacakMiktari
            // 
            this.lblToplamAlacakMiktari.AutoSize = true;
            this.lblToplamAlacakMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamAlacakMiktari.ForeColor = System.Drawing.Color.Green;
            this.lblToplamAlacakMiktari.Location = new System.Drawing.Point(200, 45);
            this.lblToplamAlacakMiktari.Name = "lblToplamAlacakMiktari";
            this.lblToplamAlacakMiktari.Size = new System.Drawing.Size(156, 17);
            this.lblToplamAlacakMiktari.TabIndex = 4;
            this.lblToplamAlacakMiktari.Text = "Toplam Alacak: 0 TL";
            // 
            // lblNetBorc
            // 
            this.lblNetBorc.AutoSize = true;
            this.lblNetBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNetBorc.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNetBorc.Location = new System.Drawing.Point(400, 45);
            this.lblNetBorc.Name = "lblNetBorc";
            this.lblNetBorc.Size = new System.Drawing.Size(112, 20);
            this.lblNetBorc.TabIndex = 5;
            this.lblNetBorc.Text = "Net Borç: 0 TL";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.LightGray;
            this.pnlButtons.Controls.Add(this.btnYenile);
            this.pnlButtons.Controls.Add(this.btnExcel);
            this.pnlButtons.Controls.Add(this.btnYazdir);
            this.pnlButtons.Controls.Add(this.btnKapat);
            this.pnlButtons.Location = new System.Drawing.Point(12, 590);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(960, 60);
            this.pnlButtons.TabIndex = 5;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(850, 15);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 30);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.Blue;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(20, 15);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(90, 30);
            this.btnYazdir.TabIndex = 1;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Green;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(130, 15);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(120, 30);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Excel'e Aktar";
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.Orange;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(270, 15);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(90, 30);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            // 
            // ToptanciBorcListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlOzet);
            this.Controls.Add(this.pnlFiltre);
            this.Controls.Add(this.pnlArama);
            this.Controls.Add(this.dgvBorcListesi);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToptanciBorcListesiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Toptancı Borç Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorcListesi)).EndInit();
            this.pnlArama.ResumeLayout(false);
            this.pnlArama.PerformLayout();
            this.pnlFiltre.ResumeLayout(false);
            this.pnlFiltre.PerformLayout();
            this.pnlOzet.ResumeLayout(false);
            this.pnlOzet.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBorcListesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToptanciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorcMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDurum;
        private System.Windows.Forms.Panel pnlArama;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.Panel pnlFiltre;
        private System.Windows.Forms.RadioButton rbSadeceAlacakli;
        private System.Windows.Forms.RadioButton rbSadeceBorclu;
        private System.Windows.Forms.RadioButton rbTumToptancilar;
        private System.Windows.Forms.Label lblFiltre;
        private System.Windows.Forms.Panel pnlOzet;
        private System.Windows.Forms.Label lblToplamBorclu;
        private System.Windows.Forms.Label lblToplamAlacakli;
        private System.Windows.Forms.Label lblBorcSiz;
        private System.Windows.Forms.Label lblToplamBorcMiktari;
        private System.Windows.Forms.Label lblToplamAlacakMiktari;
        private System.Windows.Forms.Label lblNetBorc;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnYenile;
    }
}
