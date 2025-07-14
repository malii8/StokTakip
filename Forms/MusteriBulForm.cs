using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class MusteriBulForm : Form
    {
        public string SelectedCustomer { get; private set; } = "";

        public MusteriBulForm()
        {
            InitializeComponent();
            LoadSampleData();

            // Event handler'ları bağla
            btnYeniMusteriEkle.Click += BtnYeniMusteriEkle_Click;
            dgvMusteriler.CellDoubleClick += DgvMusteriler_CellDoubleClick;
        }

        private void LoadSampleData()
        {
            // Örnek müşteri verileri
            dgvMusteriler.Rows.Add("1", "BİLAL", "0,00");
            dgvMusteriler.Rows.Add("2", "HAKAN DOĞAN", "39,00");
            dgvMusteriler.Rows.Add("3", "SEMİH AKDOĞAN", "0,00");
        }

        private void BtnYeniMusteriEkle_Click(object? sender, EventArgs e)
        {
            MusteriEkleForm musteriEkleForm = new MusteriEkleForm();
            musteriEkleForm.ShowDialog();
        }

        private void DgvMusteriler_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedCustomer = dgvMusteriler.Rows[e.RowIndex].Cells["Müşterinin Adı"].Value?.ToString() ?? "";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtMusteriAra_TextChanged(object? sender, EventArgs e)
        {
            // Müşteri arama işlevi
            string searchText = txtMusteriAra.Text.ToLower();

            foreach (DataGridViewRow row in dgvMusteriler.Rows)
            {
                if (row.IsNewRow) continue;

                string customerName = row.Cells["Müşterinin Adı"].Value?.ToString()?.ToLower() ?? "";
                row.Visible = customerName.Contains(searchText);
            }
        }
    }
}
