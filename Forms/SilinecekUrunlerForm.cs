using System;
using System.Windows.Forms;
using StokTakip.Data;

namespace StokTakip.Forms
{
    public partial class SilinecekUrunlerForm : Form
    {
        private readonly StokTakipDbContext _context;

        public SilinecekUrunlerForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            LoadSampleData();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            // Search functionality
            txtUrunAdi.TextChanged += TxtUrunAdi_TextChanged;

            // Button events
            btnSilineceklerTablosuna.Click += BtnSilineceklerTablosuna_Click;
            btnSilinecekleriTemizle.Click += BtnSilinecekleriTemizle_Click;
            btnTablodakiUrunleriSil.Click += BtnTablodakiUrunleriSil_Click;

            // Checkbox event
            chkSadeceStokMiktari.CheckedChanged += ChkSadeceStokMiktari_CheckedChanged;
        }

        private void LoadSampleData()
        {
            // Sample data for products to be deleted
            dgvUrunler.Rows.Add("8690511010128", "ABC ÇAMAŞIR SUYU 4000 ML", "12");
            dgvUrunler.Rows.Add("000002", "OE 688 PASSAT YAĞ B7", "0");
            dgvUrunler.Rows.Add("000001", "ŞEKER 1KG", "17,5");
            dgvUrunler.Rows.Add("8690575012519", "TAMEK DOMATES SALÇASI 830 GR", "7");
            dgvUrunler.Rows.Add("8690504034506", "ÜLKER ALBENİ", "4");
            dgvUrunler.Rows.Add("8690876010016", "YUDUM 1 LT SIVI YAĞ", "3");
        }

        private void TxtUrunAdi_TextChanged(object? sender, EventArgs e)
        {
            string searchText = txtUrunAdi.Text.ToLower();

            foreach (DataGridViewRow row in dgvUrunler.Rows)
            {
                if (row.IsNewRow) continue;

                string productName = row.Cells["colUrunAdi"].Value?.ToString()?.ToLower() ?? "";
                row.Visible = productName.Contains(searchText);
            }
        }

        private void BtnSilineceklerTablosuna_Click(object? sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dgvUrunler.SelectedRows)
                {
                    string barkodNo = selectedRow.Cells["colBarkodNo"].Value?.ToString() ?? "";
                    string urunAdi = selectedRow.Cells["colUrunAdi"].Value?.ToString() ?? "";

                    // Add to delete list (right panel)
                    dgvSilinecekler.Rows.Add(barkodNo, urunAdi);
                }
            }
        }

        private void BtnSilinecekleriTemizle_Click(object? sender, EventArgs e)
        {
            dgvSilinecekler.Rows.Clear();
        }

        private void BtnTablodakiUrunleriSil_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show($"Silinecek listesindeki {dgvSilinecekler.Rows.Count} ürünü silmek istediğinizden emin misiniz?",
                "Ürünleri Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dgvSilinecekler.Rows.Clear();
                MessageBox.Show("Seçilen ürünler başarıyla silindi.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void ChkSadeceStokMiktari_CheckedChanged(object? sender, EventArgs e)
        {
            if (chkSadeceStokMiktari.Checked)
            {
                // Show only products with zero stock
                foreach (DataGridViewRow row in dgvUrunler.Rows)
                {
                    if (row.IsNewRow) continue;

                    string mevcutStok = row.Cells["colMevcutStok"].Value?.ToString() ?? "0";
                    row.Visible = mevcutStok == "0";
                }
            }
            else
            {
                // Show all products
                foreach (DataGridViewRow row in dgvUrunler.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.Visible = true;
                }
            }
        }
    }
}
