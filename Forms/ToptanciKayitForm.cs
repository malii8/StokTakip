using Microsoft.EntityFrameworkCore;
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

        public ToptanciKayitForm(StokTakipDbContext context)
        {
            InitializeComponent();
            _context = context;
            LoadWholesalerData();
            SetupEventHandlers();
            InitializeForm();
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

        private void LoadToptanciDetails(DataGridViewRow row)
        {
            // Load selected wholesaler details into form fields
            txtToptanciAdi.Text = row.Cells["colToptanciAdi"].Value?.ToString() ?? "";

            // For demonstration, populate other fields with sample data
            txtSirketYetkisi.Text = "Satış Müdürü";
            txtEmail.Text = "info@example.com";
            txtInternetAdresi.Text = "www.example.com";
            txtVDaire.Text = "Kadıköy";
            txtVNo.Text = "1234567890";
            txtAdres.Text = "Örnek Adres, İstanbul";
            txtIsTelefonu.Text = "0212 123 45 67";
            txtGsmTelefonu.Text = "0555 123 45 67";
            txtFax.Text = "0212 123 45 68";
            txtOzelNotlar.Text = "Özel notlar...";
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

        private void BtnToptanciEkle_Click(object? sender, EventArgs e)
        {
            using (var yeniKayitForm = new ToptanciYeniKayitForm(false))
            {
                if (yeniKayitForm.ShowDialog() == DialogResult.OK)
                {
                    // Add new wholesaler to grid
                    int newRowIndex = dgvToptancilar.Rows.Count + 1;
                    dgvToptancilar.Rows.Add(newRowIndex.ToString(), yeniKayitForm.ToptanciAdi, yeniKayitForm.ToptanciyaOlanBorcunuz.ToString("F2"));

                    UpdateTotalDebt();
                    MessageBox.Show("Toptancı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Select the newly added row
                    if (dgvToptancilar.Rows.Count > 0)
                    {
                        dgvToptancilar.Rows[dgvToptancilar.Rows.Count - 1].Selected = true;
                    }
                }
            }
        }

        private void BtnToptanciyaOdemeYap_Click(object? sender, EventArgs e)
        {
            if (dgvToptancilar.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvToptancilar.SelectedRows[0];
                string toptanciAdi = selectedRow.Cells["colToptanciAdi"].Value?.ToString() ?? "";
                decimal toplamBorc = decimal.TryParse(selectedRow.Cells["colBorc"].Value?.ToString(), out decimal borc) ? borc : 0;

                using (var odemeForm = new ToptanciyaOdemeYapForm(toptanciAdi, toplamBorc))
                {
                    if (odemeForm.ShowDialog() == DialogResult.OK)
                    {
                        // Update debt amount after payment
                        decimal yeniBorc = toplamBorc - odemeForm.OdemeTutari;
                        selectedRow.Cells["colBorc"].Value = $"{yeniBorc:F2}";

                        UpdateTotalDebt();
                        MessageBox.Show($"Ödeme başarıyla gerçekleştirildi.\nÖdenen Tutar: {odemeForm.OdemeTutari:F2} TL\nÖdeme Şekli: {odemeForm.OdemeSekli}",
                            "Ödeme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string toptanciAdi = selectedRow.Cells["colToptanciAdi"].Value?.ToString() ?? "";
                decimal toplamBorc = decimal.TryParse(selectedRow.Cells["colBorc"].Value?.ToString(), out decimal borc) ? borc : 0;

                using (var borcEklemeForm = new ToptanciBorcunaEklemeForm(toptanciAdi, toplamBorc))
                {
                    if (borcEklemeForm.ShowDialog() == DialogResult.OK)
                    {
                        // Update debt amount after adding debt
                        decimal yeniBorc = toplamBorc + borcEklemeForm.EklenecekTutar;
                        selectedRow.Cells["colBorc"].Value = $"{yeniBorc:F2}";

                        UpdateTotalDebt();
                        MessageBox.Show($"Borç ekleme başarıyla gerçekleştirildi.\nEklenen Tutar: {borcEklemeForm.EklenecekTutar:F2} TL\nAçıklama: {borcEklemeForm.Aciklama}",
                            "Borç Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    dgvToptancilar.Rows.RemoveAt(dgvToptancilar.SelectedRows[0].Index);
                    UpdateTotalDebt();
                    ClearFields();
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
                string toptanciAdi = selectedRow.Cells["colToptanciAdi"].Value?.ToString() ?? "";
                decimal mevcutBorc = decimal.TryParse(selectedRow.Cells["colBorc"].Value?.ToString(), out decimal borc) ? borc : 0;

                using (var iadeForm = new ToptanciyaUrunIadeForm(toptanciAdi, mevcutBorc))
                {
                    if (iadeForm.ShowDialog() == DialogResult.OK)
                    {
                        // Update debt amount after return (reduce debt)
                        decimal yeniBorc = mevcutBorc - iadeForm.IadeTutari;
                        selectedRow.Cells["colBorc"].Value = $"{yeniBorc:F2}";

                        UpdateTotalDebt();
                        MessageBox.Show($"Ürün iadesi başarıyla gerçekleştirildi.\n\n" +
                            $"İade Edilen Ürün: {iadeForm.IadeEdilecekUrun}\n" +
                            $"İade Miktarı: {iadeForm.IadeEdilecekMiktar} adet\n" +
                            $"İade Tutarı: {iadeForm.IadeTutari:F2} TL\n" +
                            $"Açıklama: {iadeForm.IadeAciklamasi}",
                            "İade Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            using (var borcListesiForm = new ToptanciBorcListesiForm())
            {
                borcListesiForm.ShowDialog();
            }
        }

        private void BtnToptanciHesapDetayi_Click(object? sender, EventArgs e)
        {
            if (dgvToptancilar.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvToptancilar.SelectedRows[0];
                string toptanciAdi = selectedRow.Cells["colToptanciAdi"].Value?.ToString() ?? "";
                decimal mevcutBorc = decimal.TryParse(selectedRow.Cells["colBorc"].Value?.ToString(), out decimal borc) ? borc : 0;

                using (var hesapDetayForm = new ToptanciHesapDetayiForm(toptanciAdi, mevcutBorc))
                {
                    hesapDetayForm.ShowDialog();
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
                string mevcutToptanciAdi = selectedRow.Cells["colToptanciAdi"].Value?.ToString() ?? "";
                decimal mevcutBorc = decimal.TryParse(selectedRow.Cells["colBorc"].Value?.ToString(), out decimal borc) ? borc : 0;

                using (var duzenleForm = new ToptanciYeniKayitForm(true))
                {
                    // Load existing data from form fields
                    duzenleForm.LoadToptanciData(
                        toptanciAdi: mevcutToptanciAdi,
                        sirketYetkisi: txtSirketYetkisi.Text,
                        email: txtEmail.Text,
                        internetAdresi: txtInternetAdresi.Text,
                        vDaire: txtVDaire.Text,
                        vNo: txtVNo.Text,
                        adres: txtAdres.Text,
                        isTelefonu: txtIsTelefonu.Text,
                        gsmTelefonu: txtGsmTelefonu.Text,
                        fax: txtFax.Text,
                        ozelNotlar: txtOzelNotlar.Text,
                        toptanciyaOlanBorcunuz: mevcutBorc
                    );

                    if (duzenleForm.ShowDialog() == DialogResult.OK)
                    {
                        // Update grid with new data
                        selectedRow.Cells["colToptanciAdi"].Value = duzenleForm.ToptanciAdi;
                        selectedRow.Cells["colBorc"].Value = duzenleForm.ToptanciyaOlanBorcunuz.ToString("F2");

                        // Update form fields
                        LoadToptanciDetailsFromForm(duzenleForm);
                        UpdateTotalDebt();

                        MessageBox.Show("Toptancı bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir toptancı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadToptanciDetailsFromForm(ToptanciYeniKayitForm form)
        {
            txtToptanciAdi.Text = form.ToptanciAdi;
            txtSirketYetkisi.Text = form.SirketYetkisi;
            txtEmail.Text = form.Email;
            txtInternetAdresi.Text = form.InternetAdresi;
            txtVDaire.Text = form.VDaire;
            txtVNo.Text = form.VNo;
            txtAdres.Text = form.Adres;
            txtIsTelefonu.Text = form.IsTelefonu;
            txtGsmTelefonu.Text = form.GsmTelefonu;
            txtFax.Text = form.Fax;
            txtOzelNotlar.Text = form.OzelNotlar;
        }
    }
}
