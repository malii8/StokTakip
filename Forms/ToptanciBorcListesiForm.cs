using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class ToptanciBorcListesiForm : Form
    {
        public ToptanciBorcListesiForm()
        {
            InitializeComponent();
            LoadBorcListesi();
            SetupEventHandlers();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Set form properties
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Initialize totals
            UpdateTotals();
        }

        private void SetupEventHandlers()
        {
            // DataGridView event handlers
            dgvBorcListesi.SelectionChanged += DgvBorcListesi_SelectionChanged;

            // Button event handlers
            btnKapat.Click += BtnKapat_Click;
            btnYazdir.Click += BtnYazdir_Click;
            btnExcel.Click += BtnExcel_Click;
            btnYenile.Click += BtnYenile_Click;

            // Search event handlers
            txtArama.TextChanged += TxtArama_TextChanged;

            // Radio button event handlers
            rbTumToptancilar.CheckedChanged += RbFilter_CheckedChanged;
            rbSadeceBorclu.CheckedChanged += RbFilter_CheckedChanged;
            rbSadeceAlacakli.CheckedChanged += RbFilter_CheckedChanged;
        }

        private void LoadBorcListesi()
        {
            // Sample data - in real application, this would come from database
            dgvBorcListesi.Rows.Clear();

            dgvBorcListesi.Rows.Add("1", "ATS FİLTRE İSTANBUL", "0,00", "0212 123 45 67", "Kadıköy", "Borç Yok");
            dgvBorcListesi.Rows.Add("2", "LEVENT TİCARET", "114,70", "0212 987 65 43", "Şişli", "Borçlu");
            dgvBorcListesi.Rows.Add("3", "MERKEZ OTOMOTİV", "250,00", "0216 555 44 33", "Üsküdar", "Borçlu");
            dgvBorcListesi.Rows.Add("4", "YILDIZ YEDEK PARÇA", "0,00", "0212 777 88 99", "Beşiktaş", "Borç Yok");
            dgvBorcListesi.Rows.Add("5", "ANADOLU TİCARET", "89,50", "0216 444 33 22", "Kadıköy", "Borçlu");
            dgvBorcListesi.Rows.Add("6", "DOĞU OTOMOTİV", "-50,00", "0212 666 77 88", "Fatih", "Alacaklı");

            // Apply color coding
            ApplyRowColors();
        }

        private void ApplyRowColors()
        {
            foreach (DataGridViewRow row in dgvBorcListesi.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(row.Cells["colBorcMiktari"].Value?.ToString(), out decimal borc))
                {
                    if (borc > 0)
                    {
                        // Borçlu - Kırmızı
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.Cells["colDurum"].Value = "Borçlu";
                    }
                    else if (borc < 0)
                    {
                        // Alacaklı - Yeşil
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.Cells["colDurum"].Value = "Alacaklı";
                    }
                    else
                    {
                        // Borç Yok - Beyaz
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.Cells["colDurum"].Value = "Borç Yok";
                    }
                }
            }
        }

        private void UpdateTotals()
        {
            decimal toplamBorc = 0;
            decimal toplamAlacak = 0;
            int borcluSayisi = 0;
            int alacakliSayisi = 0;
            int borcSizSayisi = 0;

            foreach (DataGridViewRow row in dgvBorcListesi.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(row.Cells["colBorcMiktari"].Value?.ToString(), out decimal miktar))
                {
                    if (miktar > 0)
                    {
                        toplamBorc += miktar;
                        borcluSayisi++;
                    }
                    else if (miktar < 0)
                    {
                        toplamAlacak += Math.Abs(miktar);
                        alacakliSayisi++;
                    }
                    else
                    {
                        borcSizSayisi++;
                    }
                }
            }

            // Update summary labels
            lblToplamBorclu.Text = $"Toplam Borçlu: {borcluSayisi} Toptancı";
            lblToplamAlacakli.Text = $"Toplam Alacaklı: {alacakliSayisi} Toptancı";
            lblBorcSiz.Text = $"Borç Yok: {borcSizSayisi} Toptancı";
            lblToplamBorcMiktari.Text = $"Toplam Borç: {toplamBorc:F2} TL";
            lblToplamAlacakMiktari.Text = $"Toplam Alacak: {toplamAlacak:F2} TL";
            lblNetBorc.Text = $"Net Borç: {(toplamBorc - toplamAlacak):F2} TL";
        }

        private void DgvBorcListesi_SelectionChanged(object? sender, EventArgs e)
        {
            // Handle selection change if needed
        }

        private void TxtArama_TextChanged(object? sender, EventArgs e)
        {
            FilterData();
        }

        private void RbFilter_CheckedChanged(object? sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            string searchText = txtArama.Text.ToLower();

            foreach (DataGridViewRow row in dgvBorcListesi.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = true;

                // Text search filter
                if (!string.IsNullOrEmpty(searchText))
                {
                    string toptanciAdi = row.Cells["colToptanciAdi"].Value?.ToString()?.ToLower() ?? "";
                    string telefon = row.Cells["colTelefon"].Value?.ToString()?.ToLower() ?? "";
                    string adres = row.Cells["colAdres"].Value?.ToString()?.ToLower() ?? "";

                    visible = toptanciAdi.Contains(searchText) ||
                             telefon.Contains(searchText) ||
                             adres.Contains(searchText);
                }

                // Debt status filter
                if (visible)
                {
                    if (decimal.TryParse(row.Cells["colBorcMiktari"].Value?.ToString(), out decimal borc))
                    {
                        if (rbSadeceBorclu.Checked && borc <= 0)
                            visible = false;
                        else if (rbSadeceAlacakli.Checked && borc >= 0)
                            visible = false;
                    }
                }

                row.Visible = visible;
            }

            UpdateTotals();
        }

        private void BtnYenile_Click(object? sender, EventArgs e)
        {
            LoadBorcListesi();
            txtArama.Clear();
            rbTumToptancilar.Checked = true;
            UpdateTotals();
        }

        private void BtnYazdir_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Borç listesi yazdırılıyor...", "Yazdır", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExcel_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Borç listesi Excel'e aktarılıyor...", "Excel'e Aktar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnKapat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
