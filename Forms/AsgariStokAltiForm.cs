using System;
using System.Data;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class AsgariStokAltiForm : Form
    {
        public AsgariStokAltiForm()
        {
            InitializeComponent();
            LoadSampleData();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            txtUrunAra.TextChanged += TxtUrunAra_TextChanged;
            cmbUrunGrubu.SelectedIndexChanged += CmbUrunGrubu_SelectedIndexChanged;
            btnYazdir.Click += BtnYazdir_Click;
            btnExcelAktar.Click += BtnExcelAktar_Click;
        }

        private void LoadSampleData()
        {
            // Load product groups
            cmbUrunGrubu.Items.Clear();
            cmbUrunGrubu.Items.Add("Tümü");
            cmbUrunGrubu.Items.Add("BİSKÜVİ");
            cmbUrunGrubu.Items.Add("FİLTRE");
            cmbUrunGrubu.Items.Add("SALÇA");
            cmbUrunGrubu.Items.Add("YAĞ");
            cmbUrunGrubu.Items.Add("DETERJAN");
            cmbUrunGrubu.SelectedIndex = 0;

            // Sample data for products below minimum stock
            dgvAsgariStokAlti.Rows.Clear();

            string[] lowStockProducts = {
                "000002|OE 688 PASSAT YAĞ B7|30|0|Adet|100,00|150,00|FİLTRE",
                "8690504034506|ÜLKER ALBENİ 35 GR|4|4|Adet|7,00|10,00|BİSKÜVİ",
                "8690876010016|YUDUM 1 LT SIVI YAĞ|1|3|Adet|55,00|75,00|YAĞ",
                "8690511010128|ABC ÇAMAŞIR SUYU 4000 ML|2|12|Adet|70,00|90,00|DETERJAN",
                "8690575012519|TAMEK DOMATES SALÇASI 830 GR|1|7|Adet|45,00|60,00|SALÇA",
                "8690123456789|COCA COLA 330 ML|0|5|Adet|3,50|5,00|İÇECEK",
                "8690987654321|ÜLKER ÇOKOKREM 350 GR|2|8|Adet|18,00|25,00|KREMA",
                "8690147258369|PINAR SÜT 1 LT|1|6|Adet|8,50|12,00|SÜT ÜRÜNLERİ"
            };

            foreach (string product in lowStockProducts)
            {
                string[] parts = product.Split('|');
                dgvAsgariStokAlti.Rows.Add(
                    parts[0], // Barkod No
                    parts[1], // Ürünün Adı
                    parts[2], // Asgari Stok
                    parts[3], // Mevcut Stok
                    parts[4], // Ölçü Birimi
                    parts[5], // Alış Fiyatı
                    parts[6], // Satış Fiyatı
                    parts[7]  // Ürün Grubu
                );
            }

            UpdateRecordCount();
        }

        private void UpdateRecordCount()
        {
            int visibleRowCount = 0;
            foreach (DataGridViewRow row in dgvAsgariStokAlti.Rows)
            {
                if (!row.IsNewRow && row.Visible)
                {
                    visibleRowCount++;
                }
            }
            lblListelenenKayitSayisi.Text = visibleRowCount.ToString();
        }

        private void TxtUrunAra_TextChanged(object? sender, EventArgs e)
        {
            string searchText = txtUrunAra.Text.ToUpper();

            foreach (DataGridViewRow row in dgvAsgariStokAlti.Rows)
            {
                if (row.IsNewRow) continue;

                string barkod = row.Cells["colBarkodNo"].Value?.ToString()?.ToUpper() ?? "";
                string urunAdi = row.Cells["colUrunAdi"].Value?.ToString()?.ToUpper() ?? "";
                string urunGrubu = row.Cells["colUrunGrubu"].Value?.ToString()?.ToUpper() ?? "";

                bool visible = string.IsNullOrEmpty(searchText) ||
                              barkod.Contains(searchText) ||
                              urunAdi.Contains(searchText) ||
                              urunGrubu.Contains(searchText);

                row.Visible = visible && IsGroupFilterMatched(row);
            }

            UpdateRecordCount();
        }

        private void CmbUrunGrubu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAsgariStokAlti.Rows)
            {
                if (row.IsNewRow) continue;
                row.Visible = IsGroupFilterMatched(row) && IsSearchFilterMatched(row);
            }

            UpdateRecordCount();
        }

        private bool IsGroupFilterMatched(DataGridViewRow row)
        {
            string? selectedGroup = cmbUrunGrubu.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedGroup) || selectedGroup == "Tümü")
                return true;

            string rowGroup = row.Cells["colUrunGrubu"].Value?.ToString() ?? "";
            return rowGroup.ToUpper().Contains(selectedGroup.ToUpper());
        }

        private bool IsSearchFilterMatched(DataGridViewRow row)
        {
            string searchText = txtUrunAra.Text.ToUpper();
            if (string.IsNullOrEmpty(searchText))
                return true;

            string barkod = row.Cells["colBarkodNo"].Value?.ToString()?.ToUpper() ?? "";
            string urunAdi = row.Cells["colUrunAdi"].Value?.ToString()?.ToUpper() ?? "";
            string urunGrubu = row.Cells["colUrunGrubu"].Value?.ToString()?.ToUpper() ?? "";

            return barkod.Contains(searchText) ||
                   urunAdi.Contains(searchText) ||
                   urunGrubu.Contains(searchText);
        }

        private void BtnYazdir_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Asgari stok altındaki ürünler raporu yazdırılıyor...", "Yazdır",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExcelAktar_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Asgari stok altındaki ürünler Excel'e aktarılıyor...", "Excel Aktar",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
