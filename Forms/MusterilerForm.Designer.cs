namespace StokTakip.Forms
{
    partial class MusterilerForm
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
            this.lblAdiSoyadi = new System.Windows.Forms.Label();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.lblTicariUnvani = new System.Windows.Forms.Label();
            this.txtTicariUnvani = new System.Windows.Forms.TextBox();
            this.lblGsmTelefonu = new System.Windows.Forms.Label();
            this.txtGsmTelefonu = new System.Windows.Forms.TextBox();
            this.lblVergiDairesi = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.lblVergiNoTCN = new System.Windows.Forms.Label();
            this.txtVergiNoTCN = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblIlIlce = new System.Windows.Forms.Label();
            this.txtIlIlce = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblOzelNotlar = new System.Windows.Forms.Label();
            this.txtOzelNotlar = new System.Windows.Forms.TextBox();
            this.lblBelirLenen = new System.Windows.Forms.Label();
            this.txtBelirLenen = new System.Windows.Forms.TextBox();
            this.lblVeresiyeTop = new System.Windows.Forms.Label();
            this.txtVeresiyeTop = new System.Windows.Forms.TextBox();
            this.lblKalanTakTop = new System.Windows.Forms.Label();
            this.txtKalanTakTop = new System.Windows.Forms.TextBox();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.txtToplamBorc = new System.Windows.Forms.TextBox();
            this.btnMusteriBorcDetayi = new System.Windows.Forms.Button();
            this.btnHesabaBorcEkle = new System.Windows.Forms.Button();
            this.btnTahsilatYap = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriBilgileriDuzenle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriBorcListesi = new System.Windows.Forms.Button();
            this.btnTaksitOdemesiGeciktenMusteriler = new System.Windows.Forms.Button();
            this.lblMusteriAra = new System.Windows.Forms.Label();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.lblAdiSoyadiFilter = new System.Windows.Forms.Label();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.colSiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMusterininAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorcu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTumMusterilerinVeresiyeTop = new System.Windows.Forms.Label();
            this.lblVeresiyeTopValue = new System.Windows.Forms.Label();
            this.lblTumMusterilerinOdeyecegiTaksitTop = new System.Windows.Forms.Label();
            this.lblTaksitTopValue = new System.Windows.Forms.Label();
            this.btnMusteriIade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdiSoyadi
            // 
            this.lblAdiSoyadi.AutoSize = true;
            this.lblAdiSoyadi.ForeColor = System.Drawing.Color.Blue;
            this.lblAdiSoyadi.Location = new System.Drawing.Point(12, 15);
            this.lblAdiSoyadi.Name = "lblAdiSoyadi";
            this.lblAdiSoyadi.Size = new System.Drawing.Size(59, 13);
            this.lblAdiSoyadi.TabIndex = 0;
            this.lblAdiSoyadi.Text = "Adı Soyadı";
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(80, 12);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(380, 20);
            this.txtAdiSoyadi.TabIndex = 1;
            // 
            // lblTicariUnvani
            // 
            this.lblTicariUnvani.AutoSize = true;
            this.lblTicariUnvani.ForeColor = System.Drawing.Color.Blue;
            this.lblTicariUnvani.Location = new System.Drawing.Point(12, 45);
            this.lblTicariUnvani.Name = "lblTicariUnvani";
            this.lblTicariUnvani.Size = new System.Drawing.Size(69, 13);
            this.lblTicariUnvani.TabIndex = 2;
            this.lblTicariUnvani.Text = "Ticari Ünvanı";
            // 
            // txtTicariUnvani
            // 
            this.txtTicariUnvani.Location = new System.Drawing.Point(80, 42);
            this.txtTicariUnvani.Name = "txtTicariUnvani";
            this.txtTicariUnvani.Size = new System.Drawing.Size(380, 20);
            this.txtTicariUnvani.TabIndex = 3;
            // 
            // lblGsmTelefonu
            // 
            this.lblGsmTelefonu.AutoSize = true;
            this.lblGsmTelefonu.ForeColor = System.Drawing.Color.Blue;
            this.lblGsmTelefonu.Location = new System.Drawing.Point(12, 75);
            this.lblGsmTelefonu.Name = "lblGsmTelefonu";
            this.lblGsmTelefonu.Size = new System.Drawing.Size(72, 13);
            this.lblGsmTelefonu.TabIndex = 4;
            this.lblGsmTelefonu.Text = "Gsm Telefonu";
            // 
            // txtGsmTelefonu
            // 
            this.txtGsmTelefonu.Location = new System.Drawing.Point(80, 72);
            this.txtGsmTelefonu.Name = "txtGsmTelefonu";
            this.txtGsmTelefonu.Size = new System.Drawing.Size(380, 20);
            this.txtGsmTelefonu.TabIndex = 5;
            // 
            // lblVergiDairesi
            // 
            this.lblVergiDairesi.AutoSize = true;
            this.lblVergiDairesi.ForeColor = System.Drawing.Color.Blue;
            this.lblVergiDairesi.Location = new System.Drawing.Point(12, 105);
            this.lblVergiDairesi.Name = "lblVergiDairesi";
            this.lblVergiDairesi.Size = new System.Drawing.Size(65, 13);
            this.lblVergiDairesi.TabIndex = 6;
            this.lblVergiDairesi.Text = "Vergi Dairesi";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(80, 102);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(200, 20);
            this.txtVergiDairesi.TabIndex = 7;
            // 
            // lblVergiNoTCN
            // 
            this.lblVergiNoTCN.AutoSize = true;
            this.lblVergiNoTCN.ForeColor = System.Drawing.Color.Blue;
            this.lblVergiNoTCN.Location = new System.Drawing.Point(12, 135);
            this.lblVergiNoTCN.Name = "lblVergiNoTCN";
            this.lblVergiNoTCN.Size = new System.Drawing.Size(74, 13);
            this.lblVergiNoTCN.TabIndex = 8;
            this.lblVergiNoTCN.Text = "Vergi No/ TCN";
            // 
            // txtVergiNoTCN
            // 
            this.txtVergiNoTCN.Location = new System.Drawing.Point(80, 132);
            this.txtVergiNoTCN.Name = "txtVergiNoTCN";
            this.txtVergiNoTCN.Size = new System.Drawing.Size(200, 20);
            this.txtVergiNoTCN.TabIndex = 9;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.ForeColor = System.Drawing.Color.Blue;
            this.lblAdres.Location = new System.Drawing.Point(12, 165);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 10;
            this.lblAdres.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(80, 162);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(380, 60);
            this.txtAdres.TabIndex = 11;
            // 
            // lblIlIlce
            // 
            this.lblIlIlce.AutoSize = true;
            this.lblIlIlce.ForeColor = System.Drawing.Color.Blue;
            this.lblIlIlce.Location = new System.Drawing.Point(12, 235);
            this.lblIlIlce.Name = "lblIlIlce";
            this.lblIlIlce.Size = new System.Drawing.Size(33, 13);
            this.lblIlIlce.TabIndex = 12;
            this.lblIlIlce.Text = "İl / İlçe";
            // 
            // txtIlIlce
            // 
            this.txtIlIlce.Location = new System.Drawing.Point(80, 232);
            this.txtIlIlce.Name = "txtIlIlce";
            this.txtIlIlce.Size = new System.Drawing.Size(380, 20);
            this.txtIlIlce.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Blue;
            this.lblEmail.Location = new System.Drawing.Point(12, 265);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 262);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // lblOzelNotlar
            // 
            this.lblOzelNotlar.AutoSize = true;
            this.lblOzelNotlar.ForeColor = System.Drawing.Color.Blue;
            this.lblOzelNotlar.Location = new System.Drawing.Point(500, 15);
            this.lblOzelNotlar.Name = "lblOzelNotlar";
            this.lblOzelNotlar.Size = new System.Drawing.Size(58, 13);
            this.lblOzelNotlar.TabIndex = 16;
            this.lblOzelNotlar.Text = "Özel Notlar";
            // 
            // txtOzelNotlar
            // 
            this.txtOzelNotlar.Location = new System.Drawing.Point(570, 12);
            this.txtOzelNotlar.Multiline = true;
            this.txtOzelNotlar.Name = "txtOzelNotlar";
            this.txtOzelNotlar.Size = new System.Drawing.Size(380, 80);
            this.txtOzelNotlar.TabIndex = 17;
            // 
            // lblBelirLenen
            // 
            this.lblBelirLenen.AutoSize = true;
            this.lblBelirLenen.ForeColor = System.Drawing.Color.Blue;
            this.lblBelirLenen.Location = new System.Drawing.Point(500, 105);
            this.lblBelirLenen.Name = "lblBelirLenen";
            this.lblBelirLenen.Size = new System.Drawing.Size(81, 13);
            this.lblBelirLenen.TabIndex = 18;
            this.lblBelirLenen.Text = "Belirlenen Limit";
            // 
            // txtBelirLenen
            // 
            this.txtBelirLenen.BackColor = System.Drawing.Color.Yellow;
            this.txtBelirLenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBelirLenen.Location = new System.Drawing.Point(590, 102);
            this.txtBelirLenen.Name = "txtBelirLenen";
            this.txtBelirLenen.Size = new System.Drawing.Size(120, 26);
            this.txtBelirLenen.TabIndex = 19;
            this.txtBelirLenen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVeresiyeTop
            // 
            this.lblVeresiyeTop.AutoSize = true;
            this.lblVeresiyeTop.ForeColor = System.Drawing.Color.Blue;
            this.lblVeresiyeTop.Location = new System.Drawing.Point(500, 135);
            this.lblVeresiyeTop.Name = "lblVeresiyeTop";
            this.lblVeresiyeTop.Size = new System.Drawing.Size(83, 13);
            this.lblVeresiyeTop.TabIndex = 20;
            this.lblVeresiyeTop.Text = "Veresiye Toplamı";
            // 
            // txtVeresiyeTop
            // 
            this.txtVeresiyeTop.Location = new System.Drawing.Point(590, 132);
            this.txtVeresiyeTop.Name = "txtVeresiyeTop";
            this.txtVeresiyeTop.Size = new System.Drawing.Size(120, 20);
            this.txtVeresiyeTop.TabIndex = 21;
            this.txtVeresiyeTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKalanTakTop
            // 
            this.lblKalanTakTop.AutoSize = true;
            this.lblKalanTakTop.ForeColor = System.Drawing.Color.Blue;
            this.lblKalanTakTop.Location = new System.Drawing.Point(500, 165);
            this.lblKalanTakTop.Name = "lblKalanTakTop";
            this.lblKalanTakTop.Size = new System.Drawing.Size(107, 13);
            this.lblKalanTakTop.TabIndex = 22;
            this.lblKalanTakTop.Text = "Kalan Taksit Toplamı";
            // 
            // txtKalanTakTop
            // 
            this.txtKalanTakTop.Location = new System.Drawing.Point(610, 162);
            this.txtKalanTakTop.Name = "txtKalanTakTop";
            this.txtKalanTakTop.Size = new System.Drawing.Size(100, 20);
            this.txtKalanTakTop.TabIndex = 23;
            this.txtKalanTakTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.AutoSize = true;
            this.lblToplamBorc.ForeColor = System.Drawing.Color.Blue;
            this.lblToplamBorc.Location = new System.Drawing.Point(500, 195);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(64, 13);
            this.lblToplamBorc.TabIndex = 24;
            this.lblToplamBorc.Text = "Toplam Borç";
            // 
            // txtToplamBorc
            // 
            this.txtToplamBorc.Location = new System.Drawing.Point(570, 192);
            this.txtToplamBorc.Name = "txtToplamBorc";
            this.txtToplamBorc.Size = new System.Drawing.Size(140, 20);
            this.txtToplamBorc.TabIndex = 25;
            this.txtToplamBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMusteriBorcDetayi
            // 
            this.btnMusteriBorcDetayi.Location = new System.Drawing.Point(500, 225);
            this.btnMusteriBorcDetayi.Name = "btnMusteriBorcDetayi";
            this.btnMusteriBorcDetayi.Size = new System.Drawing.Size(80, 30);
            this.btnMusteriBorcDetayi.TabIndex = 26;
            this.btnMusteriBorcDetayi.Text = "Müşteri\nBorç Detayı";
            this.btnMusteriBorcDetayi.UseVisualStyleBackColor = true;
            // 
            // btnHesabaBorcEkle
            // 
            this.btnHesabaBorcEkle.Location = new System.Drawing.Point(590, 225);
            this.btnHesabaBorcEkle.Name = "btnHesabaBorcEkle";
            this.btnHesabaBorcEkle.Size = new System.Drawing.Size(80, 30);
            this.btnHesabaBorcEkle.TabIndex = 27;
            this.btnHesabaBorcEkle.Text = "Hesaba\nBorç Ekle";
            this.btnHesabaBorcEkle.UseVisualStyleBackColor = true;
            // 
            // btnTahsilatYap
            // 
            this.btnTahsilatYap.Location = new System.Drawing.Point(680, 225);
            this.btnTahsilatYap.Name = "btnTahsilatYap";
            this.btnTahsilatYap.Size = new System.Drawing.Size(80, 30);
            this.btnTahsilatYap.TabIndex = 28;
            this.btnTahsilatYap.Text = "Tahsilat Yap";
            this.btnTahsilatYap.UseVisualStyleBackColor = true;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(520, 340);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(100, 30);
            this.btnMusteriEkle.TabIndex = 29;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            // 
            // btnMusteriBilgileriDuzenle
            // 
            this.btnMusteriBilgileriDuzenle.Location = new System.Drawing.Point(630, 340);
            this.btnMusteriBilgileriDuzenle.Name = "btnMusteriBilgileriDuzenle";
            this.btnMusteriBilgileriDuzenle.Size = new System.Drawing.Size(100, 30);
            this.btnMusteriBilgileriDuzenle.TabIndex = 30;
            this.btnMusteriBilgileriDuzenle.Text = "Müşteri Bilgileri\nDüzenle";
            this.btnMusteriBilgileriDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(520, 380);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(100, 30);
            this.btnMusteriSil.TabIndex = 31;
            this.btnMusteriSil.Text = "Müşteri Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            // 
            // btnMusteriBorcListesi
            // 
            this.btnMusteriBorcListesi.Location = new System.Drawing.Point(630, 380);
            this.btnMusteriBorcListesi.Name = "btnMusteriBorcListesi";
            this.btnMusteriBorcListesi.Size = new System.Drawing.Size(100, 30);
            this.btnMusteriBorcListesi.TabIndex = 32;
            this.btnMusteriBorcListesi.Text = "Müşteri\nBorç Listesi";
            this.btnMusteriBorcListesi.UseVisualStyleBackColor = true;
            // 
            // btnTaksitOdemesiGeciktenMusteriler
            // 
            this.btnTaksitOdemesiGeciktenMusteriler.Location = new System.Drawing.Point(740, 420);
            this.btnTaksitOdemesiGeciktenMusteriler.Name = "btnTaksitOdemesiGeciktenMusteriler";
            this.btnTaksitOdemesiGeciktenMusteriler.Size = new System.Drawing.Size(120, 30);
            this.btnTaksitOdemesiGeciktenMusteriler.TabIndex = 33;
            this.btnTaksitOdemesiGeciktenMusteriler.Text = "Taksit Ödemesi\nGecikten Müşteriler";
            this.btnTaksitOdemesiGeciktenMusteriler.UseVisualStyleBackColor = true;
            // 
            // lblMusteriAra
            // 
            this.lblMusteriAra.AutoSize = true;
            this.lblMusteriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAra.ForeColor = System.Drawing.Color.Blue;
            this.lblMusteriAra.Location = new System.Drawing.Point(12, 310);
            this.lblMusteriAra.Name = "lblMusteriAra";
            this.lblMusteriAra.Size = new System.Drawing.Size(71, 13);
            this.lblMusteriAra.TabIndex = 34;
            this.lblMusteriAra.Text = "Müşteri Ara";
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.BackColor = System.Drawing.Color.Yellow;
            this.txtMusteriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAra.Location = new System.Drawing.Point(90, 305);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(370, 22);
            this.txtMusteriAra.TabIndex = 35;
            // 
            // lblAdiSoyadiFilter
            // 
            this.lblAdiSoyadiFilter.AutoSize = true;
            this.lblAdiSoyadiFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdiSoyadiFilter.ForeColor = System.Drawing.Color.Blue;
            this.lblAdiSoyadiFilter.Location = new System.Drawing.Point(190, 340);
            this.lblAdiSoyadiFilter.Name = "lblAdiSoyadiFilter";
            this.lblAdiSoyadiFilter.Size = new System.Drawing.Size(104, 13);
            this.lblAdiSoyadiFilter.TabIndex = 36;
            this.lblAdiSoyadiFilter.Text = "<<< Adı Soyadı >>>";
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.BackgroundColor = System.Drawing.Color.Orange;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSiraNo,
            this.colMusterininAdi,
            this.colBorcu});
            this.dgvMusteriler.Location = new System.Drawing.Point(15, 365);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.Size = new System.Drawing.Size(445, 200);
            this.dgvMusteriler.TabIndex = 37;
            // 
            // colSiraNo
            // 
            this.colSiraNo.HeaderText = "Sıra No";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.Width = 80;
            // 
            // colMusterininAdi
            // 
            this.colMusterininAdi.HeaderText = "Müşterinin Adı";
            this.colMusterininAdi.Name = "colMusterininAdi";
            this.colMusterininAdi.Width = 250;
            // 
            // colBorcu
            // 
            this.colBorcu.HeaderText = "Borcu";
            this.colBorcu.Name = "colBorcu";
            this.colBorcu.Width = 100;
            // 
            // lblTumMusterilerinVeresiyeTop
            // 
            this.lblTumMusterilerinVeresiyeTop.AutoSize = true;
            this.lblTumMusterilerinVeresiyeTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTumMusterilerinVeresiyeTop.ForeColor = System.Drawing.Color.Blue;
            this.lblTumMusterilerinVeresiyeTop.Location = new System.Drawing.Point(15, 580);
            this.lblTumMusterilerinVeresiyeTop.Name = "lblTumMusterilerinVeresiyeTop";
            this.lblTumMusterilerinVeresiyeTop.Size = new System.Drawing.Size(192, 13);
            this.lblTumMusterilerinVeresiyeTop.TabIndex = 38;
            this.lblTumMusterilerinVeresiyeTop.Text = "Tüm Müşterilerin Veresiye Toplamı";
            // 
            // lblVeresiyeTopValue
            // 
            this.lblVeresiyeTopValue.BackColor = System.Drawing.Color.Cyan;
            this.lblVeresiyeTopValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeresiyeTopValue.Location = new System.Drawing.Point(520, 570);
            this.lblVeresiyeTopValue.Name = "lblVeresiyeTopValue";
            this.lblVeresiyeTopValue.Size = new System.Drawing.Size(120, 30);
            this.lblVeresiyeTopValue.TabIndex = 39;
            this.lblVeresiyeTopValue.Text = "39,00 TL";
            this.lblVeresiyeTopValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTumMusterilerinOdeyecegiTaksitTop
            // 
            this.lblTumMusterilerinOdeyecegiTaksitTop.AutoSize = true;
            this.lblTumMusterilerinOdeyecegiTaksitTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTumMusterilerinOdeyecegiTaksitTop.ForeColor = System.Drawing.Color.Blue;
            this.lblTumMusterilerinOdeyecegiTaksitTop.Location = new System.Drawing.Point(15, 610);
            this.lblTumMusterilerinOdeyecegiTaksitTop.Name = "lblTumMusterilerinOdeyecegiTaksitTop";
            this.lblTumMusterilerinOdeyecegiTaksitTop.Size = new System.Drawing.Size(248, 13);
            this.lblTumMusterilerinOdeyecegiTaksitTop.TabIndex = 40;
            this.lblTumMusterilerinOdeyecegiTaksitTop.Text = "Tüm Müşterilerin Ödeyeceği Taksit Toplamı";
            // 
            // lblTaksitTopValue
            // 
            this.lblTaksitTopValue.BackColor = System.Drawing.Color.Cyan;
            this.lblTaksitTopValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksitTopValue.Location = new System.Drawing.Point(520, 600);
            this.lblTaksitTopValue.Name = "lblTaksitTopValue";
            this.lblTaksitTopValue.Size = new System.Drawing.Size(120, 30);
            this.lblTaksitTopValue.TabIndex = 41;
            this.lblTaksitTopValue.Text = "0,00 TL";
            this.lblTaksitTopValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMusteriIade
            // 
            this.btnMusteriIade.Location = new System.Drawing.Point(740, 340);
            this.btnMusteriIade.Name = "btnMusteriIade";
            this.btnMusteriIade.Size = new System.Drawing.Size(100, 30);
            this.btnMusteriIade.TabIndex = 34;
            this.btnMusteriIade.Text = "Müşteri\nİade Al";
            this.btnMusteriIade.UseVisualStyleBackColor = true;
            // 
            // MusterilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.lblTaksitTopValue);
            this.Controls.Add(this.lblTumMusterilerinOdeyecegiTaksitTop);
            this.Controls.Add(this.lblVeresiyeTopValue);
            this.Controls.Add(this.lblTumMusterilerinVeresiyeTop);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.lblAdiSoyadiFilter);
            this.Controls.Add(this.txtMusteriAra);
            this.Controls.Add(this.lblMusteriAra);
            this.Controls.Add(this.btnTaksitOdemesiGeciktenMusteriler);
            this.Controls.Add(this.btnMusteriBorcListesi);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnMusteriBilgileriDuzenle);
            this.Controls.Add(this.btnMusteriIade);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.btnTahsilatYap);
            this.Controls.Add(this.btnHesabaBorcEkle);
            this.Controls.Add(this.btnMusteriBorcDetayi);
            this.Controls.Add(this.txtToplamBorc);
            this.Controls.Add(this.lblToplamBorc);
            this.Controls.Add(this.txtKalanTakTop);
            this.Controls.Add(this.lblKalanTakTop);
            this.Controls.Add(this.txtVeresiyeTop);
            this.Controls.Add(this.lblVeresiyeTop);
            this.Controls.Add(this.txtBelirLenen);
            this.Controls.Add(this.lblBelirLenen);
            this.Controls.Add(this.txtOzelNotlar);
            this.Controls.Add(this.lblOzelNotlar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtIlIlce);
            this.Controls.Add(this.lblIlIlce);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtVergiNoTCN);
            this.Controls.Add(this.lblVergiNoTCN);
            this.Controls.Add(this.txtVergiDairesi);
            this.Controls.Add(this.lblVergiDairesi);
            this.Controls.Add(this.txtGsmTelefonu);
            this.Controls.Add(this.lblGsmTelefonu);
            this.Controls.Add(this.txtTicariUnvani);
            this.Controls.Add(this.lblTicariUnvani);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.lblAdiSoyadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MusterilerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ BİLGİLERİ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdiSoyadi;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.Label lblTicariUnvani;
        private System.Windows.Forms.TextBox txtTicariUnvani;
        private System.Windows.Forms.Label lblGsmTelefonu;
        private System.Windows.Forms.TextBox txtGsmTelefonu;
        private System.Windows.Forms.Label lblVergiDairesi;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label lblVergiNoTCN;
        private System.Windows.Forms.TextBox txtVergiNoTCN;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblIlIlce;
        private System.Windows.Forms.TextBox txtIlIlce;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblOzelNotlar;
        private System.Windows.Forms.TextBox txtOzelNotlar;
        private System.Windows.Forms.Label lblBelirLenen;
        private System.Windows.Forms.TextBox txtBelirLenen;
        private System.Windows.Forms.Label lblVeresiyeTop;
        private System.Windows.Forms.TextBox txtVeresiyeTop;
        private System.Windows.Forms.Label lblKalanTakTop;
        private System.Windows.Forms.TextBox txtKalanTakTop;
        private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.TextBox txtToplamBorc;
        private System.Windows.Forms.Button btnMusteriBorcDetayi;
        private System.Windows.Forms.Button btnHesabaBorcEkle;
        private System.Windows.Forms.Button btnTahsilatYap;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriBilgileriDuzenle;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriBorcListesi;
        private System.Windows.Forms.Button btnTaksitOdemesiGeciktenMusteriler;
        private System.Windows.Forms.Label lblMusteriAra;
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.Label lblAdiSoyadiFilter;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMusterininAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorcu;
        private System.Windows.Forms.Label lblTumMusterilerinVeresiyeTop;
        private System.Windows.Forms.Label lblVeresiyeTopValue;
        private System.Windows.Forms.Label lblTumMusterilerinOdeyecegiTaksitTop;
        private System.Windows.Forms.Label lblTaksitTopValue;
        private System.Windows.Forms.Button btnMusteriIade;
    }
}
