using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class EskiFislerForm : Form
    {
        public EskiFislerForm()
        {
            InitializeComponent();
            LoadSampleData();
            SetupEventHandlers();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Set default date range to last 30 days
            dtpBaslangicTarihi.Value = DateTime.Now.AddDays(-30);
            dtpBitisTarihi.Value = DateTime.Now;

            // Set default payment type filter
            cmbOdemeTuru.SelectedIndex = 0; // "Tümü"

            // Apply filters on load
            ApplyFilters();
        }

        private void SetupEventHandlers()
        {
            btnAra.Click += BtnAra_Click;
            btnFisDetayi.Click += BtnFisDetayi_Click;
            btnFisIptal.Click += BtnFisIptal_Click;
            btnYazdir.Click += BtnYazdir_Click;
            btnExcel.Click += BtnExcel_Click;
            dgvEskiFisler.SelectionChanged += DgvEskiFisler_SelectionChanged;

            // Date change events
            dtpBaslangicTarihi.ValueChanged += DateFilter_Changed;
            dtpBitisTarihi.ValueChanged += DateFilter_Changed;
            cmbOdemeTuru.SelectedIndexChanged += Filter_Changed;
            txtMusteriAdi.TextChanged += Filter_Changed;
        }

        private void LoadSampleData()
        {
            // Sample sales receipt data
            dgvEskiFisler.Rows.Clear();

            // Add sample historical receipts
            dgvEskiFisler.Rows.Add("20250709171534", "09.07.2025", "17:15:34", "Kredi Kartı", "", "0,00", "İptal");
            dgvEskiFisler.Rows.Add("20250709165432", "09.07.2025", "16:54:32", "Nakit", "Ahmet Yılmaz", "75,50", "Tamamlandı");
            dgvEskiFisler.Rows.Add("20250709153210", "09.07.2025", "15:32:10", "Veresiye", "Mehmet Demir", "125,00", "Tamamlandı");
            dgvEskiFisler.Rows.Add("20250709142108", "09.07.2025", "14:21:08", "Kredi Kartı", "", "89,25", "Tamamlandı");
            dgvEskiFisler.Rows.Add("20250709131045", "09.07.2025", "13:10:45", "Nakit", "Fatma Özkan", "45,75", "Tamamlandı");
            dgvEskiFisler.Rows.Add("20250708175530", "08.07.2025", "17:55:30", "Havale", "Ayşe Kara", "199,90", "Tamamlandı");
            dgvEskiFisler.Rows.Add("20250708162145", "08.07.2025", "16:21:45", "Nakit", "", "33,50", "Tamamlandı");
            dgvEskiFisler.Rows.Add("20250708145015", "08.07.2025", "14:50:15", "Kredi Kartı", "", "67,80", "Tamamlandı");
            dgvEskiFisler.Rows.Add("20250708133022", "08.07.2025", "13:30:22", "Veresiye", "Ali Şahin", "156,25", "Tamamlandı");
            dgvEskiFisler.Rows.Add("20250708121530", "08.07.2025", "12:15:30", "Nakit", "", "92,40", "Tamamlandı");

            UpdateSummary();
        }

        private void UpdateSummary()
        {
            decimal toplamTutar = 0;
            int fisAdet = 0;
            int iptalFisAdet = 0;

            foreach (DataGridViewRow row in dgvEskiFisler.Rows)
            {
                if (row.IsNewRow || !row.Visible) continue;

                fisAdet++;
                string durum = row.Cells["colDurum"].Value?.ToString() ?? "";

                if (durum == "İptal")
                {
                    iptalFisAdet++;
                }
                else if (decimal.TryParse(row.Cells["colTutar"].Value?.ToString(), out decimal tutar))
                {
                    toplamTutar += tutar;
                }
            }

            lblToplamFis.Text = $"Toplam Fiş: {fisAdet}";
            lblIptalFis.Text = $"İptal Fiş: {iptalFisAdet}";
            lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar:F2} TL";
        }

        private void ApplyFilters()
        {
            DateTime baslangic = dtpBaslangicTarihi.Value.Date;
            DateTime bitis = dtpBitisTarihi.Value.Date.AddDays(1).AddSeconds(-1);
            string musteriFilter = txtMusteriAdi.Text.Trim().ToLower();
            string odemeFilter = cmbOdemeTuru.SelectedItem?.ToString() ?? "";

            foreach (DataGridViewRow row in dgvEskiFisler.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = true;

                // Date filter
                if (DateTime.TryParse(row.Cells["colTarih"].Value?.ToString(), out DateTime fisTarihi))
                {
                    if (fisTarihi < baslangic || fisTarihi > bitis)
                    {
                        visible = false;
                    }
                }

                // Customer filter
                if (visible && !string.IsNullOrEmpty(musteriFilter))
                {
                    string musteriAdi = row.Cells["colMusteriAdi"].Value?.ToString()?.ToLower() ?? "";
                    if (!musteriAdi.Contains(musteriFilter))
                    {
                        visible = false;
                    }
                }

                // Payment type filter
                if (visible && !string.IsNullOrEmpty(odemeFilter) && odemeFilter != "Tümü")
                {
                    string odemeTuru = row.Cells["colOdemeTuru"].Value?.ToString() ?? "";
                    if (odemeTuru != odemeFilter)
                    {
                        visible = false;
                    }
                }

                row.Visible = visible;
            }

            UpdateSummary();
        }

        private void DateFilter_Changed(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void Filter_Changed(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void BtnAra_Click(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void BtnFisDetayi_Click(object? sender, EventArgs e)
        {
            if (dgvEskiFisler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEskiFisler.SelectedRows[0];
                string fisNo = selectedRow.Cells["colFisNo"].Value?.ToString() ?? "";
                string tarih = selectedRow.Cells["colTarih"].Value?.ToString() ?? "";
                string saat = selectedRow.Cells["colSaat"].Value?.ToString() ?? "";
                string odemeTuru = selectedRow.Cells["colOdemeTuru"].Value?.ToString() ?? "";
                string musteriAdi = selectedRow.Cells["colMusteriAdi"].Value?.ToString() ?? "";
                string tutar = selectedRow.Cells["colTutar"].Value?.ToString() ?? "";
                string durum = selectedRow.Cells["colDurum"].Value?.ToString() ?? "";

                using (var detayForm = new FisDetayiForm(fisNo, tarih, saat, odemeTuru, musteriAdi, tutar, durum))
                {
                    detayForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir fiş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnFisIptal_Click(object? sender, EventArgs e)
        {
            if (dgvEskiFisler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEskiFisler.SelectedRows[0];
                string fisNo = selectedRow.Cells["colFisNo"].Value?.ToString() ?? "";
                string durum = selectedRow.Cells["colDurum"].Value?.ToString() ?? "";

                if (durum == "İptal")
                {
                    MessageBox.Show("Bu fiş zaten iptal edilmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Fiş No: {fisNo}\n\nBu fişi iptal etmek istediğinizden emin misiniz?",
                    "Fiş İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    selectedRow.Cells["colDurum"].Value = "İptal";
                    selectedRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

                    UpdateSummary();
                    MessageBox.Show("Fiş başarıyla iptal edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir fiş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnYazdir_Click(object? sender, EventArgs e)
        {
            if (dgvEskiFisler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEskiFisler.SelectedRows[0];
                string fisNo = selectedRow.Cells["colFisNo"].Value?.ToString() ?? "";

                MessageBox.Show($"Fiş No: {fisNo} yazdırılıyor...", "Yazdır", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir fiş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExcel_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Fiş listesi Excel'e aktarılıyor...", "Excel Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DgvEskiFisler_SelectionChanged(object? sender, EventArgs e)
        {
            bool hasSelection = dgvEskiFisler.SelectedRows.Count > 0;
            btnFisDetayi.Enabled = hasSelection;
            btnFisIptal.Enabled = hasSelection;
            btnYazdir.Enabled = hasSelection;
        }
    }
}
