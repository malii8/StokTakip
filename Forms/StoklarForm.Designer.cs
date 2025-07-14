namespace StokTakip.Forms
{
    partial class StoklarForm
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnUrunDuzenle = new System.Windows.Forms.Button();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.lblStokKodu = new System.Windows.Forms.Label();
            this.txtStokKodu = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.lblUrunGrubu = new System.Windows.Forms.Label();
            this.txtUrunGrubu = new System.Windows.Forms.TextBox();
            this.btnTopluUrunSil = new System.Windows.Forms.Button();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.btnUrunGruplan = new System.Windows.Forms.Button();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.btnTopluUrunFiyatiDegistirme = new System.Windows.Forms.Button();
            this.lblMevcutStok = new System.Windows.Forms.Label();
            this.txtMevcutStok = new System.Windows.Forms.TextBox();
            this.btnUrunDetayi = new System.Windows.Forms.Button();
            this.btnBarkodYazdir = new System.Windows.Forms.Button();
            this.btnSayim = new System.Windows.Forms.Button();
            this.btnAsgariStokAlti = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblUrunArama = new System.Windows.Forms.Label();
            this.txtUrunArama = new System.Windows.Forms.TextBox();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.lblSiralamaOlcutu = new System.Windows.Forms.Label();
            this.cmbSiralamaOlcutu = new System.Windows.Forms.ComboBox();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.colBarkodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStokKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsgariStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMevcutStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOlcuBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSatisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKDVOrani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrunGrubu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblStoklarinAlisFiyatiDegeri = new System.Windows.Forms.Label();
            this.lblAlisFiyatiDegeri = new System.Windows.Forms.Label();
            this.lblListelenenKayitSayisi = new System.Windows.Forms.Label();
            this.lblListelenenSayisi = new System.Windows.Forms.Label();
            this.lblStoklarinSatisFiyatiDegeri = new System.Windows.Forms.Label();
            this.lblSatisFiyatiDegeri = new System.Windows.Forms.Label();
            this.btnTerazye = new System.Windows.Forms.Button();
            this.lblToplamStokAdedi = new System.Windows.Forms.Label();
            this.lblToplamStok = new System.Windows.Forms.Label();
            this.btnExcelKayitAl = new System.Windows.Forms.Button();
            this.btnExcelKayitVer = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.LightGray;
            this.pnlTop.Controls.Add(this.lblBarkodNo);
            this.pnlTop.Controls.Add(this.txtBarkodNo);
            this.pnlTop.Controls.Add(this.btnUrunDuzenle);
            this.pnlTop.Controls.Add(this.lblUrunAdi);
            this.pnlTop.Controls.Add(this.txtUrunAdi);
            this.pnlTop.Controls.Add(this.btnUrunSil);
            this.pnlTop.Controls.Add(this.lblStokKodu);
            this.pnlTop.Controls.Add(this.txtStokKodu);
            this.pnlTop.Controls.Add(this.btnUrunEkle);
            this.pnlTop.Controls.Add(this.lblUrunGrubu);
            this.pnlTop.Controls.Add(this.txtUrunGrubu);
            this.pnlTop.Controls.Add(this.btnTopluUrunSil);
            this.pnlTop.Controls.Add(this.lblSatisFiyati);
            this.pnlTop.Controls.Add(this.txtSatisFiyati);
            this.pnlTop.Controls.Add(this.btnUrunGruplan);
            this.pnlTop.Controls.Add(this.lblAlisFiyati);
            this.pnlTop.Controls.Add(this.txtAlisFiyati);
            this.pnlTop.Controls.Add(this.btnTopluUrunFiyatiDegistirme);
            this.pnlTop.Controls.Add(this.lblMevcutStok);
            this.pnlTop.Controls.Add(this.txtMevcutStok);
            this.pnlTop.Controls.Add(this.btnUrunDetayi);
            this.pnlTop.Controls.Add(this.btnBarkodYazdir);
            this.pnlTop.Controls.Add(this.btnSayim);
            this.pnlTop.Controls.Add(this.btnAsgariStokAlti);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1024, 300);
            this.pnlTop.TabIndex = 0;
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.ForeColor = System.Drawing.Color.Blue;
            this.lblBarkodNo.Location = new System.Drawing.Point(27, 67);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(61, 13);
            this.lblBarkodNo.TabIndex = 0;
            this.lblBarkodNo.Text = "Barkod No";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(120, 64);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(350, 20);
            this.txtBarkodNo.TabIndex = 1;
            // 
            // btnUrunDuzenle
            // 
            this.btnUrunDuzenle.Location = new System.Drawing.Point(500, 50);
            this.btnUrunDuzenle.Name = "btnUrunDuzenle";
            this.btnUrunDuzenle.Size = new System.Drawing.Size(50, 50);
            this.btnUrunDuzenle.TabIndex = 2;
            this.btnUrunDuzenle.Text = "Ürün Düzenle";
            this.btnUrunDuzenle.UseVisualStyleBackColor = true;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.ForeColor = System.Drawing.Color.Blue;
            this.lblUrunAdi.Location = new System.Drawing.Point(27, 100);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(48, 13);
            this.lblUrunAdi.TabIndex = 3;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(120, 97);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(350, 20);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.Red;
            this.btnUrunSil.ForeColor = System.Drawing.Color.White;
            this.btnUrunSil.Location = new System.Drawing.Point(560, 50);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(50, 50);
            this.btnUrunSil.TabIndex = 5;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = false;
            // 
            // lblStokKodu
            // 
            this.lblStokKodu.AutoSize = true;
            this.lblStokKodu.ForeColor = System.Drawing.Color.Blue;
            this.lblStokKodu.Location = new System.Drawing.Point(27, 133);
            this.lblStokKodu.Name = "lblStokKodu";
            this.lblStokKodu.Size = new System.Drawing.Size(58, 13);
            this.lblStokKodu.TabIndex = 6;
            this.lblStokKodu.Text = "Stok Kodu";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(120, 130);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(350, 20);
            this.txtStokKodu.TabIndex = 7;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btnUrunEkle.Location = new System.Drawing.Point(640, 50);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(50, 50);
            this.btnUrunEkle.TabIndex = 8;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            // 
            // lblUrunGrubu
            // 
            this.lblUrunGrubu.AutoSize = true;
            this.lblUrunGrubu.ForeColor = System.Drawing.Color.Blue;
            this.lblUrunGrubu.Location = new System.Drawing.Point(27, 166);
            this.lblUrunGrubu.Name = "lblUrunGrubu";
            this.lblUrunGrubu.Size = new System.Drawing.Size(64, 13);
            this.lblUrunGrubu.TabIndex = 9;
            this.lblUrunGrubu.Text = "Ürün Grubu";
            // 
            // txtUrunGrubu
            // 
            this.txtUrunGrubu.Location = new System.Drawing.Point(120, 163);
            this.txtUrunGrubu.Name = "txtUrunGrubu";
            this.txtUrunGrubu.Size = new System.Drawing.Size(350, 20);
            this.txtUrunGrubu.TabIndex = 10;
            // 
            // btnTopluUrunSil
            // 
            this.btnTopluUrunSil.BackColor = System.Drawing.Color.Orange;
            this.btnTopluUrunSil.Location = new System.Drawing.Point(720, 50);
            this.btnTopluUrunSil.Name = "btnTopluUrunSil";
            this.btnTopluUrunSil.Size = new System.Drawing.Size(50, 50);
            this.btnTopluUrunSil.TabIndex = 11;
            this.btnTopluUrunSil.Text = "Toplu Ürün Sil";
            this.btnTopluUrunSil.UseVisualStyleBackColor = false;
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.ForeColor = System.Drawing.Color.Blue;
            this.lblSatisFiyati.Location = new System.Drawing.Point(27, 199);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(59, 13);
            this.lblSatisFiyati.TabIndex = 12;
            this.lblSatisFiyati.Text = "Satış Fiyatı";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(120, 196);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(120, 20);
            this.txtSatisFiyati.TabIndex = 13;
            // 
            // btnUrunGruplan
            // 
            this.btnUrunGruplan.BackColor = System.Drawing.Color.Yellow;
            this.btnUrunGruplan.Location = new System.Drawing.Point(640, 120);
            this.btnUrunGruplan.Name = "btnUrunGruplan";
            this.btnUrunGruplan.Size = new System.Drawing.Size(50, 50);
            this.btnUrunGruplan.TabIndex = 14;
            this.btnUrunGruplan.Text = "Ürün Gruplan";
            this.btnUrunGruplan.UseVisualStyleBackColor = false;
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.ForeColor = System.Drawing.Color.Blue;
            this.lblAlisFiyati.Location = new System.Drawing.Point(27, 232);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(54, 13);
            this.lblAlisFiyati.TabIndex = 15;
            this.lblAlisFiyati.Text = "Alış Fiyatı";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(120, 229);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(120, 20);
            this.txtAlisFiyati.TabIndex = 16;
            // 
            // btnTopluUrunFiyatiDegistirme
            // 
            this.btnTopluUrunFiyatiDegistirme.BackColor = System.Drawing.Color.LightBlue;
            this.btnTopluUrunFiyatiDegistirme.Location = new System.Drawing.Point(780, 120);
            this.btnTopluUrunFiyatiDegistirme.Name = "btnTopluUrunFiyatiDegistirme";
            this.btnTopluUrunFiyatiDegistirme.Size = new System.Drawing.Size(50, 50);
            this.btnTopluUrunFiyatiDegistirme.TabIndex = 17;
            this.btnTopluUrunFiyatiDegistirme.Text = "Toplu Ürün Fiyatı Değiştirme";
            this.btnTopluUrunFiyatiDegistirme.UseVisualStyleBackColor = false;
            // 
            // lblMevcutStok
            // 
            this.lblMevcutStok.AutoSize = true;
            this.lblMevcutStok.ForeColor = System.Drawing.Color.Blue;
            this.lblMevcutStok.Location = new System.Drawing.Point(27, 266);
            this.lblMevcutStok.Name = "lblMevcutStok";
            this.lblMevcutStok.Size = new System.Drawing.Size(70, 13);
            this.lblMevcutStok.TabIndex = 18;
            this.lblMevcutStok.Text = "Mevcut Stok";
            // 
            // txtMevcutStok
            // 
            this.txtMevcutStok.Location = new System.Drawing.Point(120, 263);
            this.txtMevcutStok.Name = "txtMevcutStok";
            this.txtMevcutStok.Size = new System.Drawing.Size(120, 20);
            this.txtMevcutStok.TabIndex = 19;
            // 
            // btnUrunDetayi
            // 
            this.btnUrunDetayi.BackColor = System.Drawing.Color.LightGray;
            this.btnUrunDetayi.Location = new System.Drawing.Point(640, 190);
            this.btnUrunDetayi.Name = "btnUrunDetayi";
            this.btnUrunDetayi.Size = new System.Drawing.Size(50, 50);
            this.btnUrunDetayi.TabIndex = 20;
            this.btnUrunDetayi.Text = "Ürün Detayı";
            this.btnUrunDetayi.UseVisualStyleBackColor = false;
            // 
            // btnBarkodYazdir
            // 
            this.btnBarkodYazdir.Location = new System.Drawing.Point(780, 190);
            this.btnBarkodYazdir.Name = "btnBarkodYazdir";
            this.btnBarkodYazdir.Size = new System.Drawing.Size(50, 50);
            this.btnBarkodYazdir.TabIndex = 21;
            this.btnBarkodYazdir.Text = "Barkod Yazdır";
            this.btnBarkodYazdir.UseVisualStyleBackColor = true;
            // 
            // btnSayim
            // 
            this.btnSayim.BackColor = System.Drawing.Color.LightGreen;
            this.btnSayim.Location = new System.Drawing.Point(640, 250);
            this.btnSayim.Name = "btnSayim";
            this.btnSayim.Size = new System.Drawing.Size(50, 50);
            this.btnSayim.TabIndex = 22;
            this.btnSayim.Text = "Sayım";
            this.btnSayim.UseVisualStyleBackColor = false;
            // 
            // btnAsgariStokAlti
            // 
            this.btnAsgariStokAlti.BackColor = System.Drawing.Color.Yellow;
            this.btnAsgariStokAlti.Location = new System.Drawing.Point(780, 250);
            this.btnAsgariStokAlti.Name = "btnAsgariStokAlti";
            this.btnAsgariStokAlti.Size = new System.Drawing.Size(50, 50);
            this.btnAsgariStokAlti.TabIndex = 23;
            this.btnAsgariStokAlti.Text = "Asgari Stok Altında Olan Ürünler";
            this.btnAsgariStokAlti.UseVisualStyleBackColor = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.LightBlue;
            this.pnlSearch.Controls.Add(this.lblUrunArama);
            this.pnlSearch.Controls.Add(this.txtUrunArama);
            this.pnlSearch.Controls.Add(this.cmbUrunGrubu);
            this.pnlSearch.Controls.Add(this.lblSiralamaOlcutu);
            this.pnlSearch.Controls.Add(this.cmbSiralamaOlcutu);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 300);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1024, 60);
            this.pnlSearch.TabIndex = 1;
            // 
            // lblUrunArama
            // 
            this.lblUrunArama.AutoSize = true;
            this.lblUrunArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrunArama.ForeColor = System.Drawing.Color.Blue;
            this.lblUrunArama.Location = new System.Drawing.Point(200, 20);
            this.lblUrunArama.Name = "lblUrunArama";
            this.lblUrunArama.Size = new System.Drawing.Size(180, 20);
            this.lblUrunArama.TabIndex = 0;
            this.lblUrunArama.Text = "<<< ÜRÜN ARAMA >>>";
            // 
            // txtUrunArama
            // 
            this.txtUrunArama.BackColor = System.Drawing.Color.Yellow;
            this.txtUrunArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrunArama.Location = new System.Drawing.Point(20, 20);
            this.txtUrunArama.Name = "txtUrunArama";
            this.txtUrunArama.Size = new System.Drawing.Size(150, 23);
            this.txtUrunArama.TabIndex = 1;
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Items.AddRange(new object[] {
            "Tümü"});
            this.cmbUrunGrubu.Location = new System.Drawing.Point(460, 20);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(120, 21);
            this.cmbUrunGrubu.TabIndex = 2;
            this.cmbUrunGrubu.Text = "Ürün Grubu";
            // 
            // lblSiralamaOlcutu
            // 
            this.lblSiralamaOlcutu.AutoSize = true;
            this.lblSiralamaOlcutu.ForeColor = System.Drawing.Color.Blue;
            this.lblSiralamaOlcutu.Location = new System.Drawing.Point(726, 24);
            this.lblSiralamaOlcutu.Name = "lblSiralamaOlcutu";
            this.lblSiralamaOlcutu.Size = new System.Drawing.Size(88, 13);
            this.lblSiralamaOlcutu.TabIndex = 3;
            this.lblSiralamaOlcutu.Text = "Sıralama Ölçütü";
            // 
            // cmbSiralamaOlcutu
            // 
            this.cmbSiralamaOlcutu.BackColor = System.Drawing.Color.Yellow;
            this.cmbSiralamaOlcutu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSiralamaOlcutu.FormattingEnabled = true;
            this.cmbSiralamaOlcutu.Items.AddRange(new object[] {
            "AD"});
            this.cmbSiralamaOlcutu.Location = new System.Drawing.Point(820, 20);
            this.cmbSiralamaOlcutu.Name = "cmbSiralamaOlcutu";
            this.cmbSiralamaOlcutu.Size = new System.Drawing.Size(100, 21);
            this.cmbSiralamaOlcutu.TabIndex = 4;
            this.cmbSiralamaOlcutu.Text = "AD";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.BackgroundColor = System.Drawing.Color.White;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBarkodNo,
            this.colUrunAdi,
            this.colStokKodu,
            this.colAsgariStok,
            this.colMevcutStok,
            this.colOlcuBirimi,
            this.colAlisFiyati,
            this.colSatisFiyati,
            this.colKDVOrani,
            this.colUrunGrubu});
            this.dgvUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUrunler.Location = new System.Drawing.Point(0, 360);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(1024, 200);
            this.dgvUrunler.TabIndex = 2;
            // 
            // colBarkodNo
            // 
            this.colBarkodNo.HeaderText = "Barkod No";
            this.colBarkodNo.Name = "colBarkodNo";
            this.colBarkodNo.ReadOnly = true;
            this.colBarkodNo.Width = 120;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.HeaderText = "Ürünün Adı";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.ReadOnly = true;
            this.colUrunAdi.Width = 200;
            // 
            // colStokKodu
            // 
            this.colStokKodu.HeaderText = "Stok Kodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.ReadOnly = true;
            this.colStokKodu.Width = 80;
            // 
            // colAsgariStok
            // 
            this.colAsgariStok.HeaderText = "Asgari Stok";
            this.colAsgariStok.Name = "colAsgariStok";
            this.colAsgariStok.ReadOnly = true;
            this.colAsgariStok.Width = 80;
            // 
            // colMevcutStok
            // 
            this.colMevcutStok.HeaderText = "Mevcut Stok";
            this.colMevcutStok.Name = "colMevcutStok";
            this.colMevcutStok.ReadOnly = true;
            this.colMevcutStok.Width = 80;
            // 
            // colOlcuBirimi
            // 
            this.colOlcuBirimi.HeaderText = "Ölçü Birimi";
            this.colOlcuBirimi.Name = "colOlcuBirimi";
            this.colOlcuBirimi.ReadOnly = true;
            this.colOlcuBirimi.Width = 80;
            // 
            // colAlisFiyati
            // 
            this.colAlisFiyati.HeaderText = "Alış Fiyatı";
            this.colAlisFiyati.Name = "colAlisFiyati";
            this.colAlisFiyati.ReadOnly = true;
            this.colAlisFiyati.Width = 80;
            // 
            // colSatisFiyati
            // 
            this.colSatisFiyati.HeaderText = "Satış Fiyatı";
            this.colSatisFiyati.Name = "colSatisFiyati";
            this.colSatisFiyati.ReadOnly = true;
            this.colSatisFiyati.Width = 80;
            // 
            // colKDVOrani
            // 
            this.colKDVOrani.HeaderText = "KDV Oranı";
            this.colKDVOrani.Name = "colKDVOrani";
            this.colKDVOrani.ReadOnly = true;
            this.colKDVOrani.Width = 80;
            // 
            // colUrunGrubu
            // 
            this.colUrunGrubu.HeaderText = "Ürün Grubu";
            this.colUrunGrubu.Name = "colUrunGrubu";
            this.colUrunGrubu.ReadOnly = true;
            this.colUrunGrubu.Width = 120;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.LightGray;
            this.pnlBottom.Controls.Add(this.lblStoklarinAlisFiyatiDegeri);
            this.pnlBottom.Controls.Add(this.lblAlisFiyatiDegeri);
            this.pnlBottom.Controls.Add(this.lblListelenenKayitSayisi);
            this.pnlBottom.Controls.Add(this.lblListelenenSayisi);
            this.pnlBottom.Controls.Add(this.lblStoklarinSatisFiyatiDegeri);
            this.pnlBottom.Controls.Add(this.lblSatisFiyatiDegeri);
            this.pnlBottom.Controls.Add(this.btnTerazye);
            this.pnlBottom.Controls.Add(this.lblToplamStokAdedi);
            this.pnlBottom.Controls.Add(this.lblToplamStok);
            this.pnlBottom.Controls.Add(this.btnExcelKayitAl);
            this.pnlBottom.Controls.Add(this.btnExcelKayitVer);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 560);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1024, 100);
            this.pnlBottom.TabIndex = 3;
            // 
            // lblStoklarinAlisFiyatiDegeri
            // 
            this.lblStoklarinAlisFiyatiDegeri.AutoSize = true;
            this.lblStoklarinAlisFiyatiDegeri.ForeColor = System.Drawing.Color.Blue;
            this.lblStoklarinAlisFiyatiDegeri.Location = new System.Drawing.Point(160, 20);
            this.lblStoklarinAlisFiyatiDegeri.Name = "lblStoklarinAlisFiyatiDegeri";
            this.lblStoklarinAlisFiyatiDegeri.Size = new System.Drawing.Size(133, 13);
            this.lblStoklarinAlisFiyatiDegeri.TabIndex = 0;
            this.lblStoklarinAlisFiyatiDegeri.Text = "Stokların Alış Fiyatı Değeri";
            // 
            // lblAlisFiyatiDegeri
            // 
            this.lblAlisFiyatiDegeri.BackColor = System.Drawing.Color.Turquoise;
            this.lblAlisFiyatiDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlisFiyatiDegeri.Location = new System.Drawing.Point(300, 15);
            this.lblAlisFiyatiDegeri.Name = "lblAlisFiyatiDegeri";
            this.lblAlisFiyatiDegeri.Size = new System.Drawing.Size(120, 25);
            this.lblAlisFiyatiDegeri.TabIndex = 1;
            this.lblAlisFiyatiDegeri.Text = "1.908,00 TL";
            this.lblAlisFiyatiDegeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListelenenKayitSayisi
            // 
            this.lblListelenenKayitSayisi.AutoSize = true;
            this.lblListelenenKayitSayisi.ForeColor = System.Drawing.Color.Blue;
            this.lblListelenenKayitSayisi.Location = new System.Drawing.Point(830, 20);
            this.lblListelenenKayitSayisi.Name = "lblListelenenKayitSayisi";
            this.lblListelenenKayitSayisi.Size = new System.Drawing.Size(126, 13);
            this.lblListelenenKayitSayisi.TabIndex = 2;
            this.lblListelenenKayitSayisi.Text = "Listelenen Kayıt Sayısı";
            // 
            // lblListelenenSayisi
            // 
            this.lblListelenenSayisi.BackColor = System.Drawing.Color.Turquoise;
            this.lblListelenenSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListelenenSayisi.Location = new System.Drawing.Point(960, 15);
            this.lblListelenenSayisi.Name = "lblListelenenSayisi";
            this.lblListelenenSayisi.Size = new System.Drawing.Size(50, 25);
            this.lblListelenenSayisi.TabIndex = 3;
            this.lblListelenenSayisi.Text = "6";
            this.lblListelenenSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStoklarinSatisFiyatiDegeri
            // 
            this.lblStoklarinSatisFiyatiDegeri.AutoSize = true;
            this.lblStoklarinSatisFiyatiDegeri.ForeColor = System.Drawing.Color.Blue;
            this.lblStoklarinSatisFiyatiDegeri.Location = new System.Drawing.Point(160, 50);
            this.lblStoklarinSatisFiyatiDegeri.Name = "lblStoklarinSatisFiyatiDegeri";
            this.lblStoklarinSatisFiyatiDegeri.Size = new System.Drawing.Size(138, 13);
            this.lblStoklarinSatisFiyatiDegeri.TabIndex = 4;
            this.lblStoklarinSatisFiyatiDegeri.Text = "Stokların Satış Fiyatı Değeri";
            // 
            // lblSatisFiyatiDegeri
            // 
            this.lblSatisFiyatiDegeri.BackColor = System.Drawing.Color.Turquoise;
            this.lblSatisFiyatiDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSatisFiyatiDegeri.Location = new System.Drawing.Point(300, 45);
            this.lblSatisFiyatiDegeri.Name = "lblSatisFiyatiDegeri";
            this.lblSatisFiyatiDegeri.Size = new System.Drawing.Size(120, 25);
            this.lblSatisFiyatiDegeri.TabIndex = 5;
            this.lblSatisFiyatiDegeri.Text = "2.552,50 TL";
            this.lblSatisFiyatiDegeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTerazye
            // 
            this.btnTerazye.Location = new System.Drawing.Point(550, 20);
            this.btnTerazye.Name = "btnTerazye";
            this.btnTerazye.Size = new System.Drawing.Size(60, 50);
            this.btnTerazye.TabIndex = 6;
            this.btnTerazye.Text = "Teraziye Aktar";
            this.btnTerazye.UseVisualStyleBackColor = true;
            // 
            // lblToplamStokAdedi
            // 
            this.lblToplamStokAdedi.BackColor = System.Drawing.Color.Turquoise;
            this.lblToplamStokAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamStokAdedi.Location = new System.Drawing.Point(300, 75);
            this.lblToplamStokAdedi.Name = "lblToplamStokAdedi";
            this.lblToplamStokAdedi.Size = new System.Drawing.Size(120, 25);
            this.lblToplamStokAdedi.TabIndex = 7;
            this.lblToplamStokAdedi.Text = "44";
            this.lblToplamStokAdedi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToplamStok
            // 
            this.lblToplamStok.AutoSize = true;
            this.lblToplamStok.ForeColor = System.Drawing.Color.Blue;
            this.lblToplamStok.Location = new System.Drawing.Point(160, 80);
            this.lblToplamStok.Name = "lblToplamStok";
            this.lblToplamStok.Size = new System.Drawing.Size(90, 13);
            this.lblToplamStok.TabIndex = 8;
            this.lblToplamStok.Text = "Toplam Stok Adedi";
            // 
            // btnExcelKayitAl
            // 
            this.btnExcelKayitAl.Location = new System.Drawing.Point(650, 20);
            this.btnExcelKayitAl.Name = "btnExcelKayitAl";
            this.btnExcelKayitAl.Size = new System.Drawing.Size(60, 50);
            this.btnExcelKayitAl.TabIndex = 9;
            this.btnExcelKayitAl.Text = "Excel\'den Kayıt Al";
            this.btnExcelKayitAl.UseVisualStyleBackColor = true;
            // 
            // btnExcelKayitVer
            // 
            this.btnExcelKayitVer.Location = new System.Drawing.Point(750, 20);
            this.btnExcelKayitVer.Name = "btnExcelKayitVer";
            this.btnExcelKayitVer.Size = new System.Drawing.Size(60, 50);
            this.btnExcelKayitVer.TabIndex = 10;
            this.btnExcelKayitVer.Text = "Excel\'e Kayıt Ver";
            this.btnExcelKayitVer.UseVisualStyleBackColor = true;
            // 
            // StoklarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1024, 660);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlTop);
            this.Name = "StoklarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOKLAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnUrunDuzenle;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Label lblStokKodu;
        private System.Windows.Forms.TextBox txtStokKodu;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Label lblUrunGrubu;
        private System.Windows.Forms.TextBox txtUrunGrubu;
        private System.Windows.Forms.Button btnTopluUrunSil;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Button btnUrunGruplan;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.Button btnTopluUrunFiyatiDegistirme;
        private System.Windows.Forms.Label lblMevcutStok;
        private System.Windows.Forms.TextBox txtMevcutStok;
        private System.Windows.Forms.Button btnUrunDetayi;
        private System.Windows.Forms.Button btnBarkodYazdir;
        private System.Windows.Forms.Button btnSayim;
        private System.Windows.Forms.Button btnAsgariStokAlti;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblUrunArama;
        private System.Windows.Forms.TextBox txtUrunArama;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.Label lblSiralamaOlcutu;
        private System.Windows.Forms.ComboBox cmbSiralamaOlcutu;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStokKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsgariStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMevcutStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOlcuBirimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSatisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKDVOrani;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrunGrubu;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblStoklarinAlisFiyatiDegeri;
        private System.Windows.Forms.Label lblAlisFiyatiDegeri;
        private System.Windows.Forms.Label lblListelenenKayitSayisi;
        private System.Windows.Forms.Label lblListelenenSayisi;
        private System.Windows.Forms.Label lblStoklarinSatisFiyatiDegeri;
        private System.Windows.Forms.Label lblSatisFiyatiDegeri;
        private System.Windows.Forms.Button btnTerazye;
        private System.Windows.Forms.Label lblToplamStokAdedi;
        private System.Windows.Forms.Label lblToplamStok;
        private System.Windows.Forms.Button btnExcelKayitAl;
        private System.Windows.Forms.Button btnExcelKayitVer;
    }
}
