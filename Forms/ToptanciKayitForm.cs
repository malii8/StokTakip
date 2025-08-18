using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using StokTakip.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class ToptanciKayitForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public ToptanciKayitForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal; // Formu normal boyutta aç
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeDataGridView(); // Add this line
            LoadWholesalerData();
            SetupEventHandlers();
            InitializeForm();
        }

        private void InitializeDataGridView()
        {
            dgvToptancilar.Columns.Clear();
            dgvToptancilar.Columns.Add("colId", "ID");
            dgvToptancilar.Columns.Add("colName", "Toptancı Adı");
            dgvToptancilar.Columns.Add("colBorc", "Borç");

            // Sütunların otomatik boyutlandırılmasını ayarla
            foreach (DataGridViewColumn column in dgvToptancilar.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // ID sütununu gizle
            dgvToptancilar.Columns["colId"].Visible = false;
        }

        private void InitializeForm()
        {
            // Initialize form state
            ClearFields();
            UpdateTotalDebt();
        }

        private void SetupEventHandlers()
        {
            // Button event handlers
            btnToptanciEkle.Click += BtnToptanciEkle_Click;
            btnToptanciyaOdemeYap.Click += BtnToptanciyaOdemeYap_Click;
            btnToptanciBorcunaEkleme.Click += BtnToptanciBorcunaEkleme_Click;
            btnToptanciSil.Click += BtnToptanciSil_Click;
            btnToptanciyaUrunIadeEt.Click += BtnToptanciyaUrunIadeEt_Click;
            btnToptanciBorcListesi.Click += BtnToptanciBorcListesi_Click;
            btnToptanciHesapDetayi.Click += BtnToptanciHesapDetayi_Click;
            btnToptanciBilgileriDuzenle.Click += BtnToptanciBilgileriDuzenle_Click;

            // DataGridView event handlers
            dgvToptancilar.SelectionChanged += DgvToptancilar_SelectionChanged;
        }

        private void LoadWholesalerData()
        {
            try
            {
                dgvToptancilar.Rows.Clear();

                var wholesalers = _context.Wholesalers
                    .Where(w => w.IsActive)
                    .ToList();

                foreach (var wholesaler in wholesalers)
                {
                    dgvToptancilar.Rows.Add(
                        wholesaler.Id.ToString(),
                        wholesaler.Name,
                        wholesaler.Debt.ToString("F2")
                    );
                }

                UpdateTotalDebt();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Toptancı verileri yüklenirken hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSampleData()
        {
            // This method is kept for backward compatibility but now calls LoadWholesalerData
            LoadWholesalerData();
        }

        private void UpdateTotalDebt()
        {
            decimal totalDebt = 0;

            foreach (DataGridViewRow row in dgvToptancilar.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(row.Cells["colBorc"].Value?.ToString(), out decimal debt))
                {
                    totalDebt += debt;
                }
            }

            lblToplamBorcu.Text = $"{totalDebt:F2} TL";
        }

        private void DgvToptancilar_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvToptancilar.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvToptancilar.SelectedRows[0];
                LoadToptanciDetails(selectedRow);
            }
        }

        private void BtnToptanciEkle_Click(object? sender, EventArgs e)
        {
            using (var yeniKayitForm = _serviceProvider.GetRequiredService<ToptanciYeniKayitForm>()) // No wholesaler passed for new entry
            {
                if (yeniKayitForm.ShowDialog() == DialogResult.OK)
                {
                    LoadWholesalerData(); // Refresh data
                    MessageBox.Show("Toptancı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnToptanciyaOdemeYap_Click(object? sender, EventArgs e)
        {
            if (dgvToptancilar.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvToptancilar.SelectedRows[0];
                int wholesalerId = Convert.ToInt32(selectedRow.Cells["colId"].Value);
                var wholesaler = _context.Wholesalers.Find(wholesalerId);

                if (wholesaler != null)
                {
                    using (var odemeForm = _serviceProvider.GetRequiredService<ToptanciyaOdemeYapForm>())
                    {
                        // Pass wholesaler to the form
                        odemeForm.SetWholesaler(wholesaler);
                        if (odemeForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadWholesalerData(); // Refresh data
                            MessageBox.Show($"Ödeme başarıyla gerçekleştirildi.",
                                "Ödeme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir toptancı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnToptanciBorcunaEkleme_Click(object? sender, EventArgs e)
        {
            if (dgvToptancilar.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvToptancilar.SelectedRows[0];
                int wholesalerId = Convert.ToInt32(selectedRow.Cells["colId"].Value);
                var wholesaler = _context.Wholesalers.Find(wholesalerId);

                if (wholesaler != null)
                {
                    using (var borcEklemeForm = _serviceProvider.GetRequiredService<ToptanciBorcunaEklemeForm>())
                    {
                        // Pass wholesaler to the form
                        borcEklemeForm.SetWholesaler(wholesaler);
                        if (borcEklemeForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadWholesalerData(); // Refresh data
                            MessageBox.Show($"Borç ekleme başarıyla gerçekleştirildi.",
                                "Borç Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir toptancı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnToptanciSil_Click(object? sender, EventArgs e)
        {
            if (dgvToptancilar.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili toptancıyı silmek istediğinizden emin misiniz?",
                    "Toptancı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int wholesalerId = Convert.ToInt32(dgvToptancilar.SelectedRows[0].Cells["colId"].Value);
                    var wholesalerToDelete = _context.Wholesalers.Find(wholesalerId);

                    if (wholesalerToDelete != null)
                    {
                        _context.Wholesalers.Remove(wholesalerToDelete);
                        _context.SaveChanges();
                        LoadWholesalerData(); // Refresh data
                        ClearFields();
                        MessageBox.Show("Toptancı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir toptancı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnToptanciyaUrunIadeEt_Click(object? sender, EventArgs e)
        {
            if (dgvToptancilar.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvToptancilar.SelectedRows[0];
                int wholesalerId = Convert.ToInt32(selectedRow.Cells["colId"].Value);
                var wholesaler = _context.Wholesalers.Find(wholesalerId);

                if (wholesaler != null)
                {
                    using (var iadeForm = _serviceProvider.GetRequiredService<ToptanciyaUrunIadeForm>())
                    {
                        // Pass wholesaler to the form
                        iadeForm.SetWholesaler(wholesaler);
                        if (iadeForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadWholesalerData(); // Refresh data
                            MessageBox.Show($"Ürün iadesi başarıyla gerçekleştirildi.",
                                "İade Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir toptancı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnToptanciBorcListesi_Click(object? sender, EventArgs e)
        {
            using (var borcListesiForm = _serviceProvider.GetRequiredService<ToptanciBorcListesiForm>())
            {
                borcListesiForm.ShowDialog();
            }
        }

        private void BtnToptanciHesapDetayi_Click(object? sender, EventArgs e)
        {
            if (dgvToptancilar.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvToptancilar.SelectedRows[0];
                int wholesalerId = Convert.ToInt32(selectedRow.Cells["colId"].Value);
                var wholesaler = _context.Wholesalers.Find(wholesalerId);

                if (wholesaler != null)
                {
                    using (var hesapDetayForm = _serviceProvider.GetRequiredService<ToptanciHesapDetayiForm>())
                    {
                        // Pass wholesaler to the form
                        hesapDetayForm.SetWholesaler(wholesaler);
                        hesapDetayForm.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir toptancı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnToptanciBilgileriDuzenle_Click(object? sender, EventArgs e)
        {
            if (dgvToptancilar.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvToptancilar.SelectedRows[0];
                int wholesalerId = Convert.ToInt32(selectedRow.Cells["colId"].Value);
                var wholesaler = _context.Wholesalers.Find(wholesalerId);

                if (wholesaler != null)
                {
                    using (var duzenleForm = _serviceProvider.GetRequiredService<ToptanciYeniKayitForm>())
                    {
                        duzenleForm.LoadToptanciData(wholesaler);

                        if (duzenleForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadWholesalerData(); // Refresh data
                            MessageBox.Show("Toptancı bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir toptancı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFields()
        {
            txtToptanciAdi.Clear();
            txtSirketYetkisi.Clear();
            txtEmail.Clear();
            txtInternetAdresi.Clear();
            txtVDaire.Clear();
            txtVNo.Clear();
            txtAdres.Clear();
            txtIsTelefonu.Clear();
            txtGsmTelefonu.Clear();
            txtFax.Clear();
            txtOzelNotlar.Clear();
        }

        private void LoadToptanciDetails(DataGridViewRow row)
        {
            int wholesalerId = Convert.ToInt32(row.Cells["colId"].Value);
            var wholesaler = _context.Wholesalers.Find(wholesalerId);

            if (wholesaler != null)
            {
                txtToptanciAdi.Text = wholesaler.Name;
                txtSirketYetkisi.Text = wholesaler.ContactPerson;
                txtEmail.Text = wholesaler.Email;
                txtInternetAdresi.Text = wholesaler.Website;
                txtVDaire.Text = wholesaler.TaxOffice;
                txtVNo.Text = wholesaler.TaxNumber;
                txtAdres.Text = wholesaler.Address;
                txtIsTelefonu.Text = wholesaler.BusinessPhone;
                txtGsmTelefonu.Text = wholesaler.MobilePhone;
                txtFax.Text = wholesaler.Fax;
                txtOzelNotlar.Text = wholesaler.Notes;
            }
        }
    }
}
