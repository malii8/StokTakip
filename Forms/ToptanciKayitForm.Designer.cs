namespace StokTakip.Forms
{
    partial class ToptanciKayitForm
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
            this.lblToptanciAdi = new System.Windows.Forms.Label();
            this.txtToptanciAdi = new System.Windows.Forms.TextBox();
            this.lblSirketYetkisi = new System.Windows.Forms.Label();
            this.txtSirketYetkisi = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblInternetAdresi = new System.Windows.Forms.Label();
            this.txtInternetAdresi = new System.Windows.Forms.TextBox();
            this.lblVDaire = new System.Windows.Forms.Label();
            this.txtVDaire = new System.Windows.Forms.TextBox();
            this.lblVNo = new System.Windows.Forms.Label();
            this.txtVNo = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblIsTelefonu = new System.Windows.Forms.Label();
            this.txtIsTelefonu = new System.Windows.Forms.TextBox();
            this.lblGsmTelefonu = new System.Windows.Forms.Label();
            this.txtGsmTelefonu = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lblOzelNotlar = new System.Windows.Forms.Label();
            this.txtOzelNotlar = new System.Windows.Forms.TextBox();

            // Action buttons
            this.btnToptanciHesapDetayi = new System.Windows.Forms.Button();
            this.btnToptanciyaOdemeYap = new System.Windows.Forms.Button();
            this.btnToptanciBorcunaEkleme = new System.Windows.Forms.Button();

            // Data grid and related
            this.lblToptanciAra = new System.Windows.Forms.Label();
            this.dgvToptancilar = new System.Windows.Forms.DataGridView();
            this.colSiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToptanciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorc = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Summary panel
            this.pnlToplamBorc = new System.Windows.Forms.Panel();
            this.lblToplamBorcText = new System.Windows.Forms.Label();
            this.lblToplamBorcu = new System.Windows.Forms.Label();

            // Right side buttons
            this.btnToptanciEkle = new System.Windows.Forms.Button();
            this.btnToptanciBilgileriDuzenle = new System.Windows.Forms.Button();
            this.btnToptanciSil = new System.Windows.Forms.Button();
            this.btnToptanciyaUrunIadeEt = new System.Windows.Forms.Button();
            this.btnToptanciBorcListesi = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvToptancilar)).BeginInit();
            this.pnlToplamBorc.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblToptanciAdi
            // 
            this.lblToptanciAdi.AutoSize = true;
            this.lblToptanciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToptanciAdi.ForeColor = System.Drawing.Color.Blue;
            this.lblToptanciAdi.Location = new System.Drawing.Point(20, 20);
            this.lblToptanciAdi.Name = "lblToptanciAdi";
            this.lblToptanciAdi.Size = new System.Drawing.Size(83, 15);
            this.lblToptanciAdi.TabIndex = 0;
            this.lblToptanciAdi.Text = "Toptancı Adı";

            // 
            // txtToptanciAdi
            // 
            this.txtToptanciAdi.BackColor = System.Drawing.Color.Honeydew;
            this.txtToptanciAdi.Location = new System.Drawing.Point(120, 18);
            this.txtToptanciAdi.Name = "txtToptanciAdi";
            this.txtToptanciAdi.Size = new System.Drawing.Size(250, 20);
            this.txtToptanciAdi.TabIndex = 1;

            // 
            // lblSirketYetkisi
            // 
            this.lblSirketYetkisi.AutoSize = true;
            this.lblSirketYetkisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSirketYetkisi.ForeColor = System.Drawing.Color.Blue;
            this.lblSirketYetkisi.Location = new System.Drawing.Point(400, 20);
            this.lblSirketYetkisi.Name = "lblSirketYetkisi";
            this.lblSirketYetkisi.Size = new System.Drawing.Size(89, 15);
            this.lblSirketYetkisi.TabIndex = 2;
            this.lblSirketYetkisi.Text = "Şirket Yetkisi";

            // 
            // txtSirketYetkisi
            // 
            this.txtSirketYetkisi.Location = new System.Drawing.Point(500, 18);
            this.txtSirketYetkisi.Name = "txtSirketYetkisi";
            this.txtSirketYetkisi.Size = new System.Drawing.Size(150, 20);
            this.txtSirketYetkisi.TabIndex = 3;

            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.Blue;
            this.lblEmail.Location = new System.Drawing.Point(20, 50);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-Mail";

            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 20);
            this.txtEmail.TabIndex = 5;

            // 
            // lblInternetAdresi
            // 
            this.lblInternetAdresi.AutoSize = true;
            this.lblInternetAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInternetAdresi.ForeColor = System.Drawing.Color.Blue;
            this.lblInternetAdresi.Location = new System.Drawing.Point(400, 50);
            this.lblInternetAdresi.Name = "lblInternetAdresi";
            this.lblInternetAdresi.Size = new System.Drawing.Size(97, 15);
            this.lblInternetAdresi.TabIndex = 6;
            this.lblInternetAdresi.Text = "İnternet Adresi";

            // 
            // txtInternetAdresi
            // 
            this.txtInternetAdresi.Location = new System.Drawing.Point(500, 48);
            this.txtInternetAdresi.Name = "txtInternetAdresi";
            this.txtInternetAdresi.Size = new System.Drawing.Size(150, 20);
            this.txtInternetAdresi.TabIndex = 7;

            // 
            // lblVDaire
            // 
            this.lblVDaire.AutoSize = true;
            this.lblVDaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVDaire.ForeColor = System.Drawing.Color.Blue;
            this.lblVDaire.Location = new System.Drawing.Point(20, 80);
            this.lblVDaire.Name = "lblVDaire";
            this.lblVDaire.Size = new System.Drawing.Size(31, 15);
            this.lblVDaire.TabIndex = 8;
            this.lblVDaire.Text = "V.D";

            // 
            // txtVDaire
            // 
            this.txtVDaire.Location = new System.Drawing.Point(120, 78);
            this.txtVDaire.Name = "txtVDaire";
            this.txtVDaire.Size = new System.Drawing.Size(100, 20);
            this.txtVDaire.TabIndex = 9;

            // 
            // lblVNo
            // 
            this.lblVNo.AutoSize = true;
            this.lblVNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVNo.ForeColor = System.Drawing.Color.Blue;
            this.lblVNo.Location = new System.Drawing.Point(270, 80);
            this.lblVNo.Name = "lblVNo";
            this.lblVNo.Size = new System.Drawing.Size(36, 15);
            this.lblVNo.TabIndex = 10;
            this.lblVNo.Text = "V.NO";

            // 
            // txtVNo
            // 
            this.txtVNo.Location = new System.Drawing.Point(320, 78);
            this.txtVNo.Name = "txtVNo";
            this.txtVNo.Size = new System.Drawing.Size(120, 20);
            this.txtVNo.TabIndex = 11;

            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdres.ForeColor = System.Drawing.Color.Blue;
            this.lblAdres.Location = new System.Drawing.Point(20, 110);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(42, 15);
            this.lblAdres.TabIndex = 12;
            this.lblAdres.Text = "Adres";

            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(20, 135);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(350, 80);
            this.txtAdres.TabIndex = 13;

            // 
            // lblIsTelefonu
            // 
            this.lblIsTelefonu.AutoSize = true;
            this.lblIsTelefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIsTelefonu.ForeColor = System.Drawing.Color.Blue;
            this.lblIsTelefonu.Location = new System.Drawing.Point(500, 80);
            this.lblIsTelefonu.Name = "lblIsTelefonu";
            this.lblIsTelefonu.Size = new System.Drawing.Size(79, 15);
            this.lblIsTelefonu.TabIndex = 14;
            this.lblIsTelefonu.Text = "İş Telefonu";

            // 
            // txtIsTelefonu
            // 
            this.txtIsTelefonu.Location = new System.Drawing.Point(500, 105);
            this.txtIsTelefonu.Name = "txtIsTelefonu";
            this.txtIsTelefonu.Size = new System.Drawing.Size(150, 20);
            this.txtIsTelefonu.TabIndex = 15;

            // 
            // lblGsmTelefonu
            // 
            this.lblGsmTelefonu.AutoSize = true;
            this.lblGsmTelefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGsmTelefonu.ForeColor = System.Drawing.Color.Blue;
            this.lblGsmTelefonu.Location = new System.Drawing.Point(500, 135);
            this.lblGsmTelefonu.Name = "lblGsmTelefonu";
            this.lblGsmTelefonu.Size = new System.Drawing.Size(92, 15);
            this.lblGsmTelefonu.TabIndex = 16;
            this.lblGsmTelefonu.Text = "Gsm Telefonu";

            // 
            // txtGsmTelefonu
            // 
            this.txtGsmTelefonu.Location = new System.Drawing.Point(500, 160);
            this.txtGsmTelefonu.Name = "txtGsmTelefonu";
            this.txtGsmTelefonu.Size = new System.Drawing.Size(150, 20);
            this.txtGsmTelefonu.TabIndex = 17;

            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFax.ForeColor = System.Drawing.Color.Blue;
            this.lblFax.Location = new System.Drawing.Point(500, 190);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(28, 15);
            this.lblFax.TabIndex = 18;
            this.lblFax.Text = "Fax";

            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(500, 215);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(150, 20);
            this.txtFax.TabIndex = 19;

            // 
            // lblOzelNotlar
            // 
            this.lblOzelNotlar.AutoSize = true;
            this.lblOzelNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOzelNotlar.ForeColor = System.Drawing.Color.Blue;
            this.lblOzelNotlar.Location = new System.Drawing.Point(20, 230);
            this.lblOzelNotlar.Name = "lblOzelNotlar";
            this.lblOzelNotlar.Size = new System.Drawing.Size(78, 15);
            this.lblOzelNotlar.TabIndex = 20;
            this.lblOzelNotlar.Text = "Özel Notlar";

            // 
            // txtOzelNotlar
            // 
            this.txtOzelNotlar.Location = new System.Drawing.Point(20, 255);
            this.txtOzelNotlar.Multiline = true;
            this.txtOzelNotlar.Name = "txtOzelNotlar";
            this.txtOzelNotlar.Size = new System.Drawing.Size(350, 60);
            this.txtOzelNotlar.TabIndex = 21;

            // Action buttons in the middle
            // 
            // btnToptanciHesapDetayi
            // 
            this.btnToptanciHesapDetayi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnToptanciHesapDetayi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToptanciHesapDetayi.ForeColor = System.Drawing.Color.White;
            this.btnToptanciHesapDetayi.Location = new System.Drawing.Point(400, 260);
            this.btnToptanciHesapDetayi.Name = "btnToptanciHesapDetayi";
            this.btnToptanciHesapDetayi.Size = new System.Drawing.Size(100, 35);
            this.btnToptanciHesapDetayi.TabIndex = 22;
            this.btnToptanciHesapDetayi.Text = "Toptancı Hesap Detayı";
            this.btnToptanciHesapDetayi.UseVisualStyleBackColor = false;
            this.btnToptanciHesapDetayi.Click += new System.EventHandler(this.BtnToptanciHesapDetayi_Click);

            // 
            // btnToptanciyaOdemeYap
            // 
            this.btnToptanciyaOdemeYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnToptanciyaOdemeYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToptanciyaOdemeYap.ForeColor = System.Drawing.Color.White;
            this.btnToptanciyaOdemeYap.Location = new System.Drawing.Point(510, 260);
            this.btnToptanciyaOdemeYap.Name = "btnToptanciyaOdemeYap";
            this.btnToptanciyaOdemeYap.Size = new System.Drawing.Size(100, 35);
            this.btnToptanciyaOdemeYap.TabIndex = 23;
            this.btnToptanciyaOdemeYap.Text = "Toptancıya Ödeme Yap";
            this.btnToptanciyaOdemeYap.UseVisualStyleBackColor = false;
            this.btnToptanciyaOdemeYap.Click += new System.EventHandler(this.BtnToptanciyaOdemeYap_Click);

            // 
            // btnToptanciBorcunaEkleme
            // 
            this.btnToptanciBorcunaEkleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnToptanciBorcunaEkleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToptanciBorcunaEkleme.ForeColor = System.Drawing.Color.White;
            this.btnToptanciBorcunaEkleme.Location = new System.Drawing.Point(620, 260);
            this.btnToptanciBorcunaEkleme.Name = "btnToptanciBorcunaEkleme";
            this.btnToptanciBorcunaEkleme.Size = new System.Drawing.Size(100, 35);
            this.btnToptanciBorcunaEkleme.TabIndex = 24;
            this.btnToptanciBorcunaEkleme.Text = "Toptancı Borcuna Ekleme Yap";
            this.btnToptanciBorcunaEkleme.UseVisualStyleBackColor = false;
            this.btnToptanciBorcunaEkleme.Click += new System.EventHandler(this.BtnToptanciBorcunaEkleme_Click);

            // 
            // lblToptanciAra
            // 
            this.lblToptanciAra.BackColor = System.Drawing.Color.Yellow;
            this.lblToptanciAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToptanciAra.Location = new System.Drawing.Point(20, 340);
            this.lblToptanciAra.Name = "lblToptanciAra";
            this.lblToptanciAra.Size = new System.Drawing.Size(350, 25);
            this.lblToptanciAra.TabIndex = 25;
            this.lblToptanciAra.Text = "<<< Toptancı Ara >>>";
            this.lblToptanciAra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // dgvToptancilar
            // 
            this.dgvToptancilar.AllowUserToAddRows = false;
            this.dgvToptancilar.AllowUserToDeleteRows = false;
            this.dgvToptancilar.BackgroundColor = System.Drawing.Color.White;
            this.dgvToptancilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToptancilar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSiraNo,
            this.colToptanciAdi,
            this.colBorc});
            this.dgvToptancilar.Location = new System.Drawing.Point(20, 375);
            this.dgvToptancilar.Name = "dgvToptancilar";
            this.dgvToptancilar.ReadOnly = true;
            this.dgvToptancilar.RowHeadersVisible = false;
            this.dgvToptancilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToptancilar.Size = new System.Drawing.Size(500, 200);
            this.dgvToptancilar.TabIndex = 26;
            this.dgvToptancilar.SelectionChanged += new System.EventHandler(this.DgvToptancilar_SelectionChanged);

            // 
            // colSiraNo
            // 
            this.colSiraNo.HeaderText = "Sıra No";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.ReadOnly = true;
            this.colSiraNo.Width = 80;

            // 
            // colToptanciAdi
            // 
            this.colToptanciAdi.HeaderText = "Toptancı Adı";
            this.colToptanciAdi.Name = "colToptanciAdi";
            this.colToptanciAdi.ReadOnly = true;
            this.colToptanciAdi.Width = 300;

            // 
            // colBorc
            // 
            this.colBorc.HeaderText = "Borç";
            this.colBorc.Name = "colBorc";
            this.colBorc.ReadOnly = true;
            this.colBorc.Width = 120;

            // 
            // pnlToplamBorc
            // 
            this.pnlToplamBorc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnlToplamBorc.Controls.Add(this.lblToplamBorcText);
            this.pnlToplamBorc.Controls.Add(this.lblToplamBorcu);
            this.pnlToplamBorc.Location = new System.Drawing.Point(300, 585);
            this.pnlToplamBorc.Name = "pnlToplamBorc";
            this.pnlToplamBorc.Size = new System.Drawing.Size(220, 50);
            this.pnlToplamBorc.TabIndex = 27;

            // 
            // lblToplamBorcText
            // 
            this.lblToplamBorcText.AutoSize = true;
            this.lblToplamBorcText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamBorcText.ForeColor = System.Drawing.Color.White;
            this.lblToplamBorcText.Location = new System.Drawing.Point(5, 5);
            this.lblToplamBorcText.Name = "lblToplamBorcText";
            this.lblToplamBorcText.Size = new System.Drawing.Size(167, 15);
            this.lblToplamBorcText.TabIndex = 0;
            this.lblToplamBorcText.Text = "Bütün Toptancılara Toplam Borcunuz";

            // 
            // lblToplamBorcu
            // 
            this.lblToplamBorcu.AutoSize = true;
            this.lblToplamBorcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamBorcu.ForeColor = System.Drawing.Color.White;
            this.lblToplamBorcu.Location = new System.Drawing.Point(5, 25);
            this.lblToplamBorcu.Name = "lblToplamBorcu";
            this.lblToplamBorcu.Size = new System.Drawing.Size(66, 20);
            this.lblToplamBorcu.TabIndex = 1;
            this.lblToplamBorcu.Text = "0,00 TL";

            // Right side buttons
            // 
            // btnToptanciEkle
            // 
            this.btnToptanciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnToptanciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToptanciEkle.ForeColor = System.Drawing.Color.White;
            this.btnToptanciEkle.Location = new System.Drawing.Point(540, 370);
            this.btnToptanciEkle.Name = "btnToptanciEkle";
            this.btnToptanciEkle.Size = new System.Drawing.Size(80, 35);
            this.btnToptanciEkle.TabIndex = 28;
            this.btnToptanciEkle.Text = "Toptancı Ekle";
            this.btnToptanciEkle.UseVisualStyleBackColor = false;
            this.btnToptanciEkle.Click += new System.EventHandler(this.BtnToptanciEkle_Click);

            // 
            // btnToptanciBilgileriDuzenle
            // 
            this.btnToptanciBilgileriDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnToptanciBilgileriDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToptanciBilgileriDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnToptanciBilgileriDuzenle.Location = new System.Drawing.Point(630, 370);
            this.btnToptanciBilgileriDuzenle.Name = "btnToptanciBilgileriDuzenle";
            this.btnToptanciBilgileriDuzenle.Size = new System.Drawing.Size(80, 35);
            this.btnToptanciBilgileriDuzenle.TabIndex = 29;
            this.btnToptanciBilgileriDuzenle.Text = "Toptancı Bilgileri Düzenle";
            this.btnToptanciBilgileriDuzenle.UseVisualStyleBackColor = false;
            this.btnToptanciBilgileriDuzenle.Click += new System.EventHandler(this.BtnToptanciBilgileriDuzenle_Click);

            // 
            // btnToptanciSil
            // 
            this.btnToptanciSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnToptanciSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToptanciSil.ForeColor = System.Drawing.Color.White;
            this.btnToptanciSil.Location = new System.Drawing.Point(540, 420);
            this.btnToptanciSil.Name = "btnToptanciSil";
            this.btnToptanciSil.Size = new System.Drawing.Size(80, 35);
            this.btnToptanciSil.TabIndex = 30;
            this.btnToptanciSil.Text = "Toptancı Sil";
            this.btnToptanciSil.UseVisualStyleBackColor = false;
            this.btnToptanciSil.Click += new System.EventHandler(this.BtnToptanciSil_Click);

            // 
            // btnToptanciyaUrunIadeEt
            // 
            this.btnToptanciyaUrunIadeEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.btnToptanciyaUrunIadeEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToptanciyaUrunIadeEt.ForeColor = System.Drawing.Color.White;
            this.btnToptanciyaUrunIadeEt.Location = new System.Drawing.Point(630, 420);
            this.btnToptanciyaUrunIadeEt.Name = "btnToptanciyaUrunIadeEt";
            this.btnToptanciyaUrunIadeEt.Size = new System.Drawing.Size(80, 35);
            this.btnToptanciyaUrunIadeEt.TabIndex = 31;
            this.btnToptanciyaUrunIadeEt.Text = "Toptancıya Ürün İade Et";
            this.btnToptanciyaUrunIadeEt.UseVisualStyleBackColor = false;
            this.btnToptanciyaUrunIadeEt.Click += new System.EventHandler(this.BtnToptanciyaUrunIadeEt_Click);

            // 
            // btnToptanciBorcListesi
            // 
            this.btnToptanciBorcListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnToptanciBorcListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToptanciBorcListesi.ForeColor = System.Drawing.Color.White;
            this.btnToptanciBorcListesi.Location = new System.Drawing.Point(540, 470);
            this.btnToptanciBorcListesi.Name = "btnToptanciBorcListesi";
            this.btnToptanciBorcListesi.Size = new System.Drawing.Size(170, 35);
            this.btnToptanciBorcListesi.TabIndex = 32;
            this.btnToptanciBorcListesi.Text = "Toptancı Borç Listesi";
            this.btnToptanciBorcListesi.UseVisualStyleBackColor = false;
            this.btnToptanciBorcListesi.Click += new System.EventHandler(this.BtnToptanciBorcListesi_Click);

            // 
            // ToptanciKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(750, 650);
            this.Controls.Add(this.btnToptanciBorcListesi);
            this.Controls.Add(this.btnToptanciyaUrunIadeEt);
            this.Controls.Add(this.btnToptanciSil);
            this.Controls.Add(this.btnToptanciBilgileriDuzenle);
            this.Controls.Add(this.btnToptanciEkle);
            this.Controls.Add(this.pnlToplamBorc);
            this.Controls.Add(this.dgvToptancilar);
            this.Controls.Add(this.lblToptanciAra);
            this.Controls.Add(this.btnToptanciBorcunaEkleme);
            this.Controls.Add(this.btnToptanciyaOdemeYap);
            this.Controls.Add(this.btnToptanciHesapDetayi);
            this.Controls.Add(this.txtOzelNotlar);
            this.Controls.Add(this.lblOzelNotlar);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.txtGsmTelefonu);
            this.Controls.Add(this.lblGsmTelefonu);
            this.Controls.Add(this.txtIsTelefonu);
            this.Controls.Add(this.lblIsTelefonu);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtVNo);
            this.Controls.Add(this.lblVNo);
            this.Controls.Add(this.txtVDaire);
            this.Controls.Add(this.lblVDaire);
            this.Controls.Add(this.txtInternetAdresi);
            this.Controls.Add(this.lblInternetAdresi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSirketYetkisi);
            this.Controls.Add(this.lblSirketYetkisi);
            this.Controls.Add(this.txtToptanciAdi);
            this.Controls.Add(this.lblToptanciAdi);
            this.Name = "ToptanciKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPTANCILAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvToptancilar)).EndInit();
            this.pnlToplamBorc.ResumeLayout(false);
            this.pnlToplamBorc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblToptanciAdi;
        private System.Windows.Forms.TextBox txtToptanciAdi;
        private System.Windows.Forms.Label lblSirketYetkisi;
        private System.Windows.Forms.TextBox txtSirketYetkisi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblInternetAdresi;
        private System.Windows.Forms.TextBox txtInternetAdresi;
        private System.Windows.Forms.Label lblVDaire;
        private System.Windows.Forms.TextBox txtVDaire;
        private System.Windows.Forms.Label lblVNo;
        private System.Windows.Forms.TextBox txtVNo;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblIsTelefonu;
        private System.Windows.Forms.TextBox txtIsTelefonu;
        private System.Windows.Forms.Label lblGsmTelefonu;
        private System.Windows.Forms.TextBox txtGsmTelefonu;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblOzelNotlar;
        private System.Windows.Forms.TextBox txtOzelNotlar;
        private System.Windows.Forms.Button btnToptanciHesapDetayi;
        private System.Windows.Forms.Button btnToptanciyaOdemeYap;
        private System.Windows.Forms.Button btnToptanciBorcunaEkleme;
        private System.Windows.Forms.Label lblToptanciAra;
        private System.Windows.Forms.DataGridView dgvToptancilar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToptanciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorc;
        private System.Windows.Forms.Panel pnlToplamBorc;
        private System.Windows.Forms.Label lblToplamBorcText;
        private System.Windows.Forms.Label lblToplamBorcu;
        private System.Windows.Forms.Button btnToptanciEkle;
        private System.Windows.Forms.Button btnToptanciBilgileriDuzenle;
        private System.Windows.Forms.Button btnToptanciSil;
        private System.Windows.Forms.Button btnToptanciyaUrunIadeEt;
        private System.Windows.Forms.Button btnToptanciBorcListesi;
    }
}