using System;
using System.Drawing;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class ToptanciyaUrunIadeForm : Form
    {
        private string toptanciAdi;
        private decimal mevcutBorc;

        public decimal IadeTutari { get; private set; }
        public string IadeAciklamasi { get; private set; } = string.Empty;
        public int IadeEdilecekMiktar { get; private set; }
        public string IadeEdilecekUrun { get; private set; } = string.Empty;

        public ToptanciyaUrunIadeForm(string toptanciAdi, decimal mevcutBorc)
        {
            InitializeComponent();
            this.toptanciAdi = toptanciAdi;
            this.mevcutBorc = mevcutBorc;
            InitializeForm();
            LoadUrunler();
            SetupEventHandlers();
        }

        private void InitializeForm()
        {
            // Set form properties
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Initialize form data
            lblToptanciAdi.Text = toptanciAdi;
            lblMevcutBorc.Text = $"{mevcutBorc:F2} TL";
            dtpIadeTarihi.Value = DateTime.Now;

            // Set default values
            nudMiktar.Value = 1;
            txtBirimFiyat.Text = "0,00";
            lblToplamTutar.Text = "0,00 TL";

            UpdateIadeToplamı();
        }

        private void SetupEventHandlers()
        {
            // Button event handlers
            btnIadeEt.Click += BtnIadeEt_Click;
            btnIptal.Click += BtnIptal_Click;
            btnUrunSec.Click += BtnUrunSec_Click;

            // Value change event handlers
            nudMiktar.ValueChanged += CalculateTotal;
            txtBirimFiyat.TextChanged += CalculateTotal;

            // DataGridView event handlers
            dgvUrunler.SelectionChanged += DgvUrunler_SelectionChanged;
        }

        private void LoadUrunler()
        {
            // Sample product data that was previously purchased from this wholesaler
            dgvUrunler.Rows.Clear();

            dgvUrunler.Rows.Add("1", "Yağ Filtresi", "YF-001", "15", "25,00", "375,00", "10.07.2025");
            dgvUrunler.Rows.Add("2", "Hava Filtresi", "HF-002", "8", "30,00", "240,00", "08.07.2025");
            dgvUrunler.Rows.Add("3", "Fren Balata", "FB-003", "12", "45,00", "540,00", "05.07.2025");
            dgvUrunler.Rows.Add("4", "Motor Yağı", "MY-004", "20", "75,00", "1500,00", "03.07.2025");
            dgvUrunler.Rows.Add("5", "Amortisör", "AM-005", "6", "120,00", "720,00", "01.07.2025");
            dgvUrunler.Rows.Add("6", "Lastik", "LS-006", "4", "200,00", "800,00", "28.06.2025");

            // Apply alternating row colors
            ApplyRowColors();
        }

        private void ApplyRowColors()
        {
            for (int i = 0; i < dgvUrunler.Rows.Count; i++)
            {
                if (dgvUrunler.Rows[i].IsNewRow) continue;

                if (i % 2 == 0)
                {
                    dgvUrunler.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else
                {
                    dgvUrunler.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void DgvUrunler_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUrunler.SelectedRows[0];

                // Load selected product details
                txtUrunAdi.Text = selectedRow.Cells["colUrunAdi"].Value?.ToString() ?? "";
                txtBarkod.Text = selectedRow.Cells["colBarkod"].Value?.ToString() ?? "";

                if (decimal.TryParse(selectedRow.Cells["colBirimFiyat"].Value?.ToString(), out decimal birimFiyat))
                {
                    txtBirimFiyat.Text = birimFiyat.ToString("F2");
                }

                if (int.TryParse(selectedRow.Cells["colMevcut"].Value?.ToString(), out int mevcutMiktar))
                {
                    nudMiktar.Maximum = mevcutMiktar;
                    lblMevcutStok.Text = $"Mevcut Stok: {mevcutMiktar} adet";
                }

                CalculateTotal(null, null);
            }
        }

        private void BtnUrunSec_Click(object? sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUrunler.SelectedRows[0];
                txtUrunAdi.Text = selectedRow.Cells["colUrunAdi"].Value?.ToString() ?? "";
                txtBarkod.Text = selectedRow.Cells["colBarkod"].Value?.ToString() ?? "";

                if (decimal.TryParse(selectedRow.Cells["colBirimFiyat"].Value?.ToString(), out decimal birimFiyat))
                {
                    txtBirimFiyat.Text = birimFiyat.ToString("F2");
                }

                CalculateTotal(null, null);
                MessageBox.Show("Ürün seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CalculateTotal(object? sender, EventArgs e)
        {
            if (decimal.TryParse(txtBirimFiyat.Text, out decimal birimFiyat))
            {
                decimal toplamTutar = birimFiyat * nudMiktar.Value;
                lblToplamTutar.Text = $"{toplamTutar:F2} TL";
                UpdateIadeToplamı();
            }
        }

        private void UpdateIadeToplamı()
        {
            if (decimal.TryParse(lblToplamTutar.Text.Replace(" TL", ""), out decimal iadeTutari))
            {
                decimal yeniBorc = mevcutBorc - iadeTutari;
                lblYeniBorc.Text = $"İade Sonrası Borç: {yeniBorc:F2} TL";

                if (yeniBorc < 0)
                {
                    lblYeniBorc.ForeColor = Color.Green;
                }
                else if (yeniBorc > mevcutBorc)
                {
                    lblYeniBorc.ForeColor = Color.Red;
                }
                else
                {
                    lblYeniBorc.ForeColor = Color.Blue;
                }
            }
        }

        private void BtnIadeEt_Click(object? sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Lütfen iade edilecek ürünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudMiktar.Value <= 0)
            {
                MessageBox.Show("İade miktarı 0'dan büyük olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtBirimFiyat.Text, out decimal birimFiyat) || birimFiyat <= 0)
            {
                MessageBox.Show("Geçerli bir birim fiyat giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIadeNedeni.Text))
            {
                MessageBox.Show("İade nedenini belirtiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmation
            decimal toplamIadeTutari = birimFiyat * nudMiktar.Value;
            DialogResult result = MessageBox.Show(
                $"İade Bilgileri:\n\n" +
                $"Toptancı: {toptanciAdi}\n" +
                $"Ürün: {txtUrunAdi.Text}\n" +
                $"Miktar: {nudMiktar.Value} adet\n" +
                $"Birim Fiyat: {birimFiyat:F2} TL\n" +
                $"Toplam İade Tutarı: {toplamIadeTutari:F2} TL\n" +
                $"İade Nedeni: {txtIadeNedeni.Text}\n\n" +
                $"İade işlemini onaylıyor musunuz?",
                "İade Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Set return values
                IadeTutari = toplamIadeTutari;
                IadeAciklamasi = $"{txtUrunAdi.Text} - {nudMiktar.Value} adet - {txtIadeNedeni.Text}";
                IadeEdilecekMiktar = (int)nudMiktar.Value;
                IadeEdilecekUrun = txtUrunAdi.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnIptal_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
