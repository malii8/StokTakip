namespace StokTakip.Forms
{
    partial class KasaForm
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
            this.lblTarihAraliklari = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.lblHareketTuru = new System.Windows.Forms.Label();
            this.cmbHareketTuru = new System.Windows.Forms.ComboBox();
            this.lblIslemYapan = new System.Windows.Forms.Label();
            this.cmbIslemYapan = new System.Windows.Forms.ComboBox();
            this.btnSayfayiYenile = new System.Windows.Forms.Button();
            this.btnGelirGiderGrafigi = new System.Windows.Forms.Button();
            this.btnGiderGirisi = new System.Windows.Forms.Button();
            this.btnGelirGirisi = new System.Windows.Forms.Button();

            // Summary panels
            this.pnlGelir = new System.Windows.Forms.Panel();
            this.lblGelirText = new System.Windows.Forms.Label();
            this.lblGelirTutar = new System.Windows.Forms.Label();
            this.pnlGider = new System.Windows.Forms.Panel();
            this.lblGiderText = new System.Windows.Forms.Label();
            this.lblGiderTutar = new System.Windows.Forms.Label();
            this.pnlToplam = new System.Windows.Forms.Panel();
            this.lblToplamText = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();

            this.dgvKasaHareketleri = new System.Windows.Forms.DataGridView();
            this.colTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGelirGiderSebebi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarkodu = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.btnGelirGiderTuruSil = new System.Windows.Forms.Button();
            this.btnYeniGelirGiderTuruEkle = new System.Windows.Forms.Button();
            this.pnlListelenenKayitSayisi = new System.Windows.Forms.Panel();
            this.lblListelenenKayitSayisiText = new System.Windows.Forms.Label();
            this.lblListelenenKayitSayisi = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaHareketleri)).BeginInit();
            this.pnlGelir.SuspendLayout();
            this.pnlGider.SuspendLayout();
            this.pnlToplam.SuspendLayout();
            this.pnlListelenenKayitSayisi.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblTarihAraliklari
            // 
            this.lblTarihAraliklari.AutoSize = true;
            this.lblTarihAraliklari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTarihAraliklari.Location = new System.Drawing.Point(20, 20);
            this.lblTarihAraliklari.Name = "lblTarihAraliklari";
            this.lblTarihAraliklari.Size = new System.Drawing.Size(98, 15);
            this.lblTarihAraliklari.TabIndex = 0;
            this.lblTarihAraliklari.Text = "Tarih Aralıkları";

            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(20, 45);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(100, 20);
            this.dtpBaslangic.TabIndex = 1;

            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(135, 45);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(100, 20);
            this.dtpBitis.TabIndex = 2;

            // 
            // lblHareketTuru
            // 
            this.lblHareketTuru.AutoSize = true;
            this.lblHareketTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHareketTuru.Location = new System.Drawing.Point(280, 20);
            this.lblHareketTuru.Name = "lblHareketTuru";
            this.lblHareketTuru.Size = new System.Drawing.Size(85, 15);
            this.lblHareketTuru.TabIndex = 3;
            this.lblHareketTuru.Text = "Hareket Türü";

            // 
            // cmbHareketTuru
            // 
            this.cmbHareketTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHareketTuru.Location = new System.Drawing.Point(280, 45);
            this.cmbHareketTuru.Name = "cmbHareketTuru";
            this.cmbHareketTuru.Size = new System.Drawing.Size(120, 21);
            this.cmbHareketTuru.TabIndex = 4;

            // 
            // lblIslemYapan
            // 
            this.lblIslemYapan.AutoSize = true;
            this.lblIslemYapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIslemYapan.Location = new System.Drawing.Point(420, 20);
            this.lblIslemYapan.Name = "lblIslemYapan";
            this.lblIslemYapan.Size = new System.Drawing.Size(79, 15);
            this.lblIslemYapan.TabIndex = 5;
            this.lblIslemYapan.Text = "İşlem Yapan";

            // 
            // cmbIslemYapan
            // 
            this.cmbIslemYapan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemYapan.Location = new System.Drawing.Point(420, 45);
            this.cmbIslemYapan.Name = "cmbIslemYapan";
            this.cmbIslemYapan.Size = new System.Drawing.Size(120, 21);
            this.cmbIslemYapan.TabIndex = 6;

            // 
            // btnSayfayiYenile
            // 
            this.btnSayfayiYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnSayfayiYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayfayiYenile.ForeColor = System.Drawing.Color.White;
            this.btnSayfayiYenile.Location = new System.Drawing.Point(780, 40);
            this.btnSayfayiYenile.Name = "btnSayfayiYenile";
            this.btnSayfayiYenile.Size = new System.Drawing.Size(80, 30);
            this.btnSayfayiYenile.TabIndex = 7;
            this.btnSayfayiYenile.Text = "Sayfayı Yenile";
            this.btnSayfayiYenile.UseVisualStyleBackColor = false;

            // 
            // btnGelirGiderGrafigi
            // 
            this.btnGelirGiderGrafigi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnGelirGiderGrafigi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGelirGiderGrafigi.ForeColor = System.Drawing.Color.White;
            this.btnGelirGiderGrafigi.Location = new System.Drawing.Point(870, 40);
            this.btnGelirGiderGrafigi.Name = "btnGelirGiderGrafigi";
            this.btnGelirGiderGrafigi.Size = new System.Drawing.Size(80, 30);
            this.btnGelirGiderGrafigi.TabIndex = 8;
            this.btnGelirGiderGrafigi.Text = "Gelir Gider Grafiği";
            this.btnGelirGiderGrafigi.UseVisualStyleBackColor = false;

            // 
            // pnlGelir
            // 
            this.pnlGelir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnlGelir.Controls.Add(this.lblGelirText);
            this.pnlGelir.Controls.Add(this.lblGelirTutar);
            this.pnlGelir.Location = new System.Drawing.Point(1000, 20);
            this.pnlGelir.Name = "pnlGelir";
            this.pnlGelir.Size = new System.Drawing.Size(120, 60);
            this.pnlGelir.TabIndex = 9;

            // 
            // lblGelirText
            // 
            this.lblGelirText.AutoSize = true;
            this.lblGelirText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGelirText.ForeColor = System.Drawing.Color.White;
            this.lblGelirText.Location = new System.Drawing.Point(5, 5);
            this.lblGelirText.Name = "lblGelirText";
            this.lblGelirText.Size = new System.Drawing.Size(38, 15);
            this.lblGelirText.TabIndex = 0;
            this.lblGelirText.Text = "Gelir";

            // 
            // lblGelirTutar
            // 
            this.lblGelirTutar.AutoSize = true;
            this.lblGelirTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGelirTutar.ForeColor = System.Drawing.Color.White;
            this.lblGelirTutar.Location = new System.Drawing.Point(5, 30);
            this.lblGelirTutar.Name = "lblGelirTutar";
            this.lblGelirTutar.Size = new System.Drawing.Size(56, 17);
            this.lblGelirTutar.TabIndex = 1;
            this.lblGelirTutar.Text = "0,00 TL";

            // 
            // pnlGider
            // 
            this.pnlGider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnlGider.Controls.Add(this.lblGiderText);
            this.pnlGider.Controls.Add(this.lblGiderTutar);
            this.pnlGider.Location = new System.Drawing.Point(1130, 20);
            this.pnlGider.Name = "pnlGider";
            this.pnlGider.Size = new System.Drawing.Size(120, 60);
            this.pnlGider.TabIndex = 10;

            // 
            // lblGiderText
            // 
            this.lblGiderText.AutoSize = true;
            this.lblGiderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGiderText.ForeColor = System.Drawing.Color.White;
            this.lblGiderText.Location = new System.Drawing.Point(5, 5);
            this.lblGiderText.Name = "lblGiderText";
            this.lblGiderText.Size = new System.Drawing.Size(39, 15);
            this.lblGiderText.TabIndex = 0;
            this.lblGiderText.Text = "Gider";

            // 
            // lblGiderTutar
            // 
            this.lblGiderTutar.AutoSize = true;
            this.lblGiderTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGiderTutar.ForeColor = System.Drawing.Color.White;
            this.lblGiderTutar.Location = new System.Drawing.Point(5, 30);
            this.lblGiderTutar.Name = "lblGiderTutar";
            this.lblGiderTutar.Size = new System.Drawing.Size(56, 17);
            this.lblGiderTutar.TabIndex = 1;
            this.lblGiderTutar.Text = "0,00 TL";

            // 
            // pnlToplam
            // 
            this.pnlToplam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnlToplam.Controls.Add(this.lblToplamText);
            this.pnlToplam.Controls.Add(this.lblToplamTutar);
            this.pnlToplam.Location = new System.Drawing.Point(1260, 20);
            this.pnlToplam.Name = "pnlToplam";
            this.pnlToplam.Size = new System.Drawing.Size(120, 60);
            this.pnlToplam.TabIndex = 11;

            // 
            // lblToplamText
            // 
            this.lblToplamText.AutoSize = true;
            this.lblToplamText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamText.ForeColor = System.Drawing.Color.White;
            this.lblToplamText.Location = new System.Drawing.Point(5, 5);
            this.lblToplamText.Name = "lblToplamText";
            this.lblToplamText.Size = new System.Drawing.Size(50, 15);
            this.lblToplamText.TabIndex = 0;
            this.lblToplamText.Text = "Toplam";

            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamTutar.ForeColor = System.Drawing.Color.White;
            this.lblToplamTutar.Location = new System.Drawing.Point(5, 30);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(56, 17);
            this.lblToplamTutar.TabIndex = 1;
            this.lblToplamTutar.Text = "0,00 TL";

            // 
            // dgvKasaHareketleri
            // 
            this.dgvKasaHareketleri.AllowUserToAddRows = false;
            this.dgvKasaHareketleri.AllowUserToDeleteRows = false;
            this.dgvKasaHareketleri.BackgroundColor = System.Drawing.Color.White;
            this.dgvKasaHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKasaHareketleri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTarih,
            this.colSaat,
            this.colTuru,
            this.colGelirGiderSebebi,
            this.colTutari,
            this.colAciklama,
            this.colBarkodu});
            this.dgvKasaHareketleri.Location = new System.Drawing.Point(20, 100);
            this.dgvKasaHareketleri.Name = "dgvKasaHareketleri";
            this.dgvKasaHareketleri.ReadOnly = true;
            this.dgvKasaHareketleri.RowHeadersVisible = false;
            this.dgvKasaHareketleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKasaHareketleri.Size = new System.Drawing.Size(1200, 450);
            this.dgvKasaHareketleri.TabIndex = 12;

            // 
            // colTarih
            // 
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.ReadOnly = true;
            this.colTarih.Width = 120;

            // 
            // colSaat
            // 
            this.colSaat.HeaderText = "Saat";
            this.colSaat.Name = "colSaat";
            this.colSaat.ReadOnly = true;
            this.colSaat.Width = 80;

            // 
            // colTuru
            // 
            this.colTuru.HeaderText = "Türü";
            this.colTuru.Name = "colTuru";
            this.colTuru.ReadOnly = true;
            this.colTuru.Width = 100;

            // 
            // colGelirGiderSebebi
            // 
            this.colGelirGiderSebebi.HeaderText = "Gelir Gider Sebebi";
            this.colGelirGiderSebebi.Name = "colGelirGiderSebebi";
            this.colGelirGiderSebebi.ReadOnly = true;
            this.colGelirGiderSebebi.Width = 150;

            // 
            // colTutari
            // 
            this.colTutari.HeaderText = "Tutarı";
            this.colTutari.Name = "colTutari";
            this.colTutari.ReadOnly = true;
            this.colTutari.Width = 120;

            // 
            // colAciklama
            // 
            this.colAciklama.HeaderText = "Açıklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.ReadOnly = true;
            this.colAciklama.Width = 200;

            // 
            // colBarkodu
            // 
            this.colBarkodu.HeaderText = "Barkodu";
            this.colBarkodu.Name = "colBarkodu";
            this.colBarkodu.ReadOnly = true;
            this.colBarkodu.Width = 120;

            // Action buttons
            // 
            // btnGiderGirisi
            // 
            this.btnGiderGirisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnGiderGirisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiderGirisi.ForeColor = System.Drawing.Color.White;
            this.btnGiderGirisi.Location = new System.Drawing.Point(460, 570);
            this.btnGiderGirisi.Name = "btnGiderGirisi";
            this.btnGiderGirisi.Size = new System.Drawing.Size(120, 35);
            this.btnGiderGirisi.TabIndex = 13;
            this.btnGiderGirisi.Text = "Yeni Gider - Gider Türü Ekle";
            this.btnGiderGirisi.UseVisualStyleBackColor = false;

            // 
            // btnGelirGirisi
            // 
            this.btnGelirGirisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnGelirGirisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGelirGirisi.ForeColor = System.Drawing.Color.White;
            this.btnGelirGirisi.Location = new System.Drawing.Point(590, 570);
            this.btnGelirGirisi.Name = "btnGelirGirisi";
            this.btnGelirGirisi.Size = new System.Drawing.Size(120, 35);
            this.btnGelirGirisi.TabIndex = 14;
            this.btnGelirGirisi.Text = "Yeni Gelir - Gider Türü Ekle";
            this.btnGelirGirisi.UseVisualStyleBackColor = false;

            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.btnExcelAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelAktar.ForeColor = System.Drawing.Color.White;
            // this.btnExcelAktar.Image = global::StokTakip.Properties.Resources.excel_icon; // You'll need to add this resource
            this.btnExcelAktar.Location = new System.Drawing.Point(520, 620);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(100, 35);
            this.btnExcelAktar.TabIndex = 15;
            this.btnExcelAktar.Text = "Excel'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = false;

            // 
            // btnGelirGiderTuruSil
            // 
            this.btnGelirGiderTuruSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnGelirGiderTuruSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGelirGiderTuruSil.ForeColor = System.Drawing.Color.White;
            this.btnGelirGiderTuruSil.Location = new System.Drawing.Point(720, 570);
            this.btnGelirGiderTuruSil.Name = "btnGelirGiderTuruSil";
            this.btnGelirGiderTuruSil.Size = new System.Drawing.Size(120, 35);
            this.btnGelirGiderTuruSil.TabIndex = 16;
            this.btnGelirGiderTuruSil.Text = "Gelir - Gider Türü Sil";
            this.btnGelirGiderTuruSil.UseVisualStyleBackColor = false;

            // 
            // btnYeniGelirGiderTuruEkle
            // 
            this.btnYeniGelirGiderTuruEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnYeniGelirGiderTuruEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniGelirGiderTuruEkle.ForeColor = System.Drawing.Color.White;
            this.btnYeniGelirGiderTuruEkle.Location = new System.Drawing.Point(850, 570);
            this.btnYeniGelirGiderTuruEkle.Name = "btnYeniGelirGiderTuruEkle";
            this.btnYeniGelirGiderTuruEkle.Size = new System.Drawing.Size(120, 35);
            this.btnYeniGelirGiderTuruEkle.TabIndex = 17;
            this.btnYeniGelirGiderTuruEkle.Text = "Yeni Gelir - Gider Türü Ekle";
            this.btnYeniGelirGiderTuruEkle.UseVisualStyleBackColor = false;

            // 
            // pnlListelenenKayitSayisi
            // 
            this.pnlListelenenKayitSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.pnlListelenenKayitSayisi.Controls.Add(this.lblListelenenKayitSayisiText);
            this.pnlListelenenKayitSayisi.Controls.Add(this.lblListelenenKayitSayisi);
            this.pnlListelenenKayitSayisi.Location = new System.Drawing.Point(1240, 570);
            this.pnlListelenenKayitSayisi.Name = "pnlListelenenKayitSayisi";
            this.pnlListelenenKayitSayisi.Size = new System.Drawing.Size(140, 60);
            this.pnlListelenenKayitSayisi.TabIndex = 18;

            // 
            // lblListelenenKayitSayisiText
            // 
            this.lblListelenenKayitSayisiText.AutoSize = true;
            this.lblListelenenKayitSayisiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListelenenKayitSayisiText.ForeColor = System.Drawing.Color.White;
            this.lblListelenenKayitSayisiText.Location = new System.Drawing.Point(5, 5);
            this.lblListelenenKayitSayisiText.Name = "lblListelenenKayitSayisiText";
            this.lblListelenenKayitSayisiText.Size = new System.Drawing.Size(130, 15);
            this.lblListelenenKayitSayisiText.TabIndex = 0;
            this.lblListelenenKayitSayisiText.Text = "Listelenen Kayıt Sayısı";

            // 
            // lblListelenenKayitSayisi
            // 
            this.lblListelenenKayitSayisi.AutoSize = true;
            this.lblListelenenKayitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListelenenKayitSayisi.ForeColor = System.Drawing.Color.White;
            this.lblListelenenKayitSayisi.Location = new System.Drawing.Point(5, 30);
            this.lblListelenenKayitSayisi.Name = "lblListelenenKayitSayisi";
            this.lblListelenenKayitSayisi.Size = new System.Drawing.Size(19, 20);
            this.lblListelenenKayitSayisi.TabIndex = 1;
            this.lblListelenenKayitSayisi.Text = "0";

            // 
            // KasaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1400, 680);
            this.Controls.Add(this.pnlListelenenKayitSayisi);
            this.Controls.Add(this.btnYeniGelirGiderTuruEkle);
            this.Controls.Add(this.btnGelirGiderTuruSil);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.btnGelirGirisi);
            this.Controls.Add(this.btnGiderGirisi);
            this.Controls.Add(this.dgvKasaHareketleri);
            this.Controls.Add(this.pnlToplam);
            this.Controls.Add(this.pnlGider);
            this.Controls.Add(this.pnlGelir);
            this.Controls.Add(this.btnGelirGiderGrafigi);
            this.Controls.Add(this.btnSayfayiYenile);
            this.Controls.Add(this.cmbIslemYapan);
            this.Controls.Add(this.lblIslemYapan);
            this.Controls.Add(this.cmbHareketTuru);
            this.Controls.Add(this.lblHareketTuru);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.lblTarihAraliklari);
            this.Name = "KasaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KASA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaHareketleri)).EndInit();
            this.pnlGelir.ResumeLayout(false);
            this.pnlGelir.PerformLayout();
            this.pnlGider.ResumeLayout(false);
            this.pnlGider.PerformLayout();
            this.pnlToplam.ResumeLayout(false);
            this.pnlToplam.PerformLayout();
            this.pnlListelenenKayitSayisi.ResumeLayout(false);
            this.pnlListelenenKayitSayisi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTarihAraliklari;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label lblHareketTuru;
        private System.Windows.Forms.ComboBox cmbHareketTuru;
        private System.Windows.Forms.Label lblIslemYapan;
        private System.Windows.Forms.ComboBox cmbIslemYapan;
        private System.Windows.Forms.Button btnSayfayiYenile;
        private System.Windows.Forms.Button btnGelirGiderGrafigi;
        private System.Windows.Forms.Panel pnlGelir;
        private System.Windows.Forms.Label lblGelirText;
        private System.Windows.Forms.Label lblGelirTutar;
        private System.Windows.Forms.Panel pnlGider;
        private System.Windows.Forms.Label lblGiderText;
        private System.Windows.Forms.Label lblGiderTutar;
        private System.Windows.Forms.Panel pnlToplam;
        private System.Windows.Forms.Label lblToplamText;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.DataGridView dgvKasaHareketleri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGelirGiderSebebi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkodu;
        private System.Windows.Forms.Button btnGiderGirisi;
        private System.Windows.Forms.Button btnGelirGirisi;
        private System.Windows.Forms.Button btnExcelAktar;
        private System.Windows.Forms.Button btnGelirGiderTuruSil;
        private System.Windows.Forms.Button btnYeniGelirGiderTuruEkle;
        private System.Windows.Forms.Panel pnlListelenenKayitSayisi;
        private System.Windows.Forms.Label lblListelenenKayitSayisiText;
        private System.Windows.Forms.Label lblListelenenKayitSayisi;
    }
}
