using System.Windows.Forms;
using StokTakip.Data;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Models; // Eklendi

namespace StokTakip.Forms
{
    public partial class AlisFaturasiForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public AlisFaturasiForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            btnYeniUrunEkle.Click += new System.EventHandler(btnYeniUrunEkle_Click);
            btnYeniToptanci.Click += new System.EventHandler(btnYeniToptanci_Click);
            btnUrunAra.Click += new System.EventHandler(btnUrunAra_Click);
            btnFaturayaEkle.Click += new System.EventHandler(btnFaturayaEkle_Click);
            btnFaturayiKaydet.Click += new System.EventHandler(btnFaturaKaydet_Click);
            rbKdvDahil.CheckedChanged += RbKdvDahil_CheckedChanged;
            rbKdvHaric.CheckedChanged += RbKdvHaric_CheckedChanged;
            RbKdvDahil_CheckedChanged(rbKdvDahil, EventArgs.Empty); // Başlangıç durumu

            InitializeDataGridView();
            LoadWholesalers();
            LoadPaymentTypes();
        }

        private void LoadWholesalers()
        {
            var wholesalers = _context.Wholesalers.ToList();
            cmbToptanci.DataSource = wholesalers;
            cmbToptanci.DisplayMember = "Name"; // Toptancının adını göster
            cmbToptanci.ValueMember = "Id";     // Toptancının ID'sini değer olarak tut
            cmbToptanci.SelectedIndex = -1; // Başlangıçta seçim olmasın
        }

        private void LoadPaymentTypes()
        {
            var paymentTypes = new List<string>
            {
                "Nakit",
                "Kredi Kartı",
                "Havale/EFT",
                "Veresiye"
            };
            cmbOdemeSekli.DataSource = paymentTypes;
            cmbOdemeSekli.SelectedIndex = -1; // Başlangıçta seçim olmasın
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("BarkodNo", "Barkod No");
            dataGridView1.Columns.Add("UrunAdi", "Ürün Adı");
            dataGridView1.Columns.Add("Miktar", "Miktar");
            dataGridView1.Columns.Add("BirimFiyat", "Birim Fiyat");
            dataGridView1.Columns.Add("KdvOrani", "KDV Oranı");
            dataGridView1.Columns.Add("KdvTutari", "KDV Tutarı");
            dataGridView1.Columns.Add("ToplamTutar", "Toplam Tutar");

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnYeniUrunEkle_Click(object? sender, System.EventArgs e)
        {
            var urunYeniKayitForm = _serviceProvider.GetRequiredService<UrunYeniKayitForm>();
            urunYeniKayitForm.ShowDialog();
        }

        private void btnYeniToptanci_Click(object? sender, System.EventArgs e)
        {
            var toptanciKayitForm = _serviceProvider.GetRequiredService<ToptanciKayitForm>();
            toptanciKayitForm.ShowDialog();
        }

        private void btnUrunAra_Click(object? sender, System.EventArgs e)
        {
            var urunAramaForm = _serviceProvider.GetRequiredService<UrunAramaForm>();
            if (urunAramaForm.ShowDialog() == DialogResult.OK)
            {
                if (urunAramaForm.SelectedProduct != null)
                {
                    LoadProductData(urunAramaForm.SelectedProduct);
                }
            }
        }

        public void LoadProductData(Product product)
        {
            txtBarkod.Text = product.BarcodeNo;
            txtUrunAdi.Text = product.Name;
            // Diğer alanları da burada doldurabilirsiniz
            // Örneğin:
            // txtAlisFiyatiKdvDahil.Text = product.PurchasePrice.ToString();
            // txtSatisFiyati.Text = product.SalePrice.ToString();
            // txtKdvOrani.Text = product.VatRate.ToString();
            // txtEklenecekMiktar.Text = "1"; // Varsayılan miktar

            // KDV radyo butonlarını ve ilgili alanları güncelle
            // Varsayılan olarak Kdv Dahil seçili gelsin
            rbKdvDahil.Checked = true;
            RbKdvDahil_CheckedChanged(rbKdvDahil, EventArgs.Empty);

            // Fiyatları doldur
            txtAlisFiyatiKdvDahil.Text = product.PurchasePrice.ToString("F2");
            txtSatisFiyati.Text = product.SalePrice.ToString("F2");
            txtKdvOrani.Text = product.VatRate.ToString("F0");
        }

        private void btnFaturayaEkle_Click(object? sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarkod.Text) || string.IsNullOrEmpty(txtUrunAdi.Text) || string.IsNullOrEmpty(txtEklenecekMiktar.Text) || string.IsNullOrEmpty(txtSatisFiyati.Text) || string.IsNullOrEmpty(txtKdvOrani.Text))
            {
                MessageBox.Show("Lütfen tüm ürün bilgilerini doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSatisFiyati.Text, out decimal satisFiyati) ||
                !int.TryParse(txtEklenecekMiktar.Text, out int miktar) ||
                !decimal.TryParse(txtKdvOrani.Text, out decimal kdvOrani))
            {
                MessageBox.Show("Lütfen geçerli sayısal değerler girin (Fiyat, Miktar, KDV Oranı).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal kdvTutari = (satisFiyati * miktar * kdvOrani) / 100;
            decimal toplamTutar = (satisFiyati * miktar) + kdvTutari;

            dataGridView1.Rows.Add(
                txtBarkod.Text,
                txtUrunAdi.Text,
                miktar,
                satisFiyati.ToString("F2"),
                kdvOrani.ToString("F0"),
                kdvTutari.ToString("F2"),
                toplamTutar.ToString("F2")
            );

            // Sağdaki toplam alanlarını güncelle
            UpdateTotals();

            // Sol taraftaki alanları temizle
            ClearProductInputFields();
        }

        private void ClearProductInputFields()
        {
            txtBarkod.Clear();
            txtUrunAdi.Clear();
            txtAlisFiyatiKdvDahil.Clear();
            txtAlisFiyatiKdvHaric.Clear();
            txtSatisFiyati.Clear();
            txtKdvOrani.Clear();
            txtEklenecekMiktar.Text = "1"; // Varsayılan miktar
            rbKdvDahil.Checked = true;
        }

        private void UpdateTotals()
        {
            decimal totalTutar = 0;
            decimal totalKdv = 0;
            decimal totalNetTutar = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ToplamTutar"].Value != null && decimal.TryParse(row.Cells["ToplamTutar"].Value.ToString(), out decimal rowToplamTutar))
                {
                    totalTutar += rowToplamTutar;
                }
                if (row.Cells["KdvTutari"].Value != null && decimal.TryParse(row.Cells["KdvTutari"].Value.ToString(), out decimal rowKdvTutari))
                {
                    totalKdv += rowKdvTutari;
                }
                // Net Tutar hesaplaması için, KDV hariç fiyatı kullanabiliriz veya toplam tutardan KDV'yi çıkarabiliriz.
                // Şu anki durumda, ToplamTutar zaten KDV dahil olduğu için, Net Tutar = ToplamTutar - KDV Tutarı
                if (row.Cells["BirimFiyat"].Value != null && decimal.TryParse(row.Cells["BirimFiyat"].Value.ToString(), out decimal birimFiyat) &&
                    row.Cells["Miktar"].Value != null && int.TryParse(row.Cells["Miktar"].Value.ToString(), out int miktar))
                {
                    totalNetTutar += (birimFiyat * miktar);
                }
            }

            txtTutar.Text = totalNetTutar.ToString("F2"); // KDV hariç toplam
            txtKdv.Text = totalKdv.ToString("F2");
            txtGenelToplam.Text = totalTutar.ToString("F2");
            txtNetTutar.Text = totalNetTutar.ToString("F2"); // Net Tutar da KDV hariç toplamı gösterebilir
        }

        private void btnFaturaKaydet_Click(object? sender, System.EventArgs e)
        {
            // Fatura kaydetme veya satış işlemleri burada yapılacak.
            MessageBox.Show("Fatura satış işlemi yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            ClearProductInputFields();
            dataGridView1.Rows.Clear();
            txtTutar.Clear();
            txtIndirimTutari.Clear();
            txtNetTutar.Clear();
            txtKdv.Clear();
            txtGenelToplam.Clear();
            cmbToptanci.SelectedIndex = -1;
            cmbOdemeSekli.SelectedIndex = -1;
            txtFaturaNo.Clear();
            txtIskonto.Clear();
        }

        private void RbKdvDahil_CheckedChanged(object? sender, EventArgs e)
        {
            if (rbKdvDahil.Checked)
            {
                txtAlisFiyatiKdvDahil.Enabled = true;
                txtAlisFiyatiKdvHaric.Enabled = false;
                txtAlisFiyatiKdvHaric.Text = string.Empty; // Clear the other field
            }
        }

        private void RbKdvHaric_CheckedChanged(object? sender, EventArgs e)
        {
            if (rbKdvHaric.Checked)
            {
                txtAlisFiyatiKdvHaric.Enabled = true;
                txtAlisFiyatiKdvDahil.Enabled = false;
                txtAlisFiyatiKdvDahil.Text = string.Empty; // Clear the other field
            }
        }
    }
}
