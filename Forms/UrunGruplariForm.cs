using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class UrunGruplariForm : Form
    {
        public UrunGruplariForm()
        {
            InitializeComponent();
            LoadSampleData();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            btnTopluUrunGrubuDegistir.Click += BtnTopluUrunGrubuDegistir_Click;
            btnSecilenUrunGrubunuSil.Click += BtnSecilenUrunGrubunuSil_Click;
            btnYeniUrunGrubuEkle.Click += BtnYeniUrunGrubuEkle_Click;
            txtUrunGrubuAdi.TextChanged += TxtUrunGrubuAdi_TextChanged;
        }

        private void LoadSampleData()
        {
            // Load sample product groups
            dgvUrunGruplari.Rows.Add("1", "BİSKÜVİ");
            dgvUrunGruplari.Rows.Add("2", "FİLTRE");
            dgvUrunGruplari.Rows.Add("3", "SALÇA");
            dgvUrunGruplari.Rows.Add("4", "TEXT11");
            dgvUrunGruplari.Rows.Add("5", "YAĞ");
        }

        private void TxtUrunGrubuAdi_TextChanged(object? sender, EventArgs e)
        {
            string searchText = txtUrunGrubuAdi.Text.ToLower();

            foreach (DataGridViewRow row in dgvUrunGruplari.Rows)
            {
                if (row.IsNewRow) continue;

                string groupName = row.Cells["colUrunGrubuAdi"].Value?.ToString()?.ToLower() ?? "";
                row.Visible = groupName.Contains(searchText);
            }
        }

        private void BtnTopluUrunGrubuDegistir_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Toplu ürün grubu değiştir işlemi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSecilenUrunGrubunuSil_Click(object? sender, EventArgs e)
        {
            if (dgvUrunGruplari.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Seçili ürün grubunu silmek istediğinizden emin misiniz?",
                    "Grup Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvUrunGruplari.Rows.RemoveAt(dgvUrunGruplari.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek grubu seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnYeniUrunGrubuEkle_Click(object? sender, EventArgs e)
        {
            string newGroupName = Microsoft.VisualBasic.Interaction.InputBox(
                "Yeni ürün grubu adını girin:",
                "Yeni Grup Ekle",
                "");

            if (!string.IsNullOrWhiteSpace(newGroupName))
            {
                int newIndex = dgvUrunGruplari.Rows.Count + 1;
                dgvUrunGruplari.Rows.Add(newIndex.ToString(), newGroupName.ToUpper());
            }
        }
    }
}
