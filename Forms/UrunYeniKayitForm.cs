using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StokTakip.Forms
{
    public partial class UrunYeniKayitForm : Form
    {
        private readonly StokTakipDbContext _context;

        public UrunYeniKayitForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            SetupEventHandlers();
            LoadProductGroups();
            LoadWholesalers();
            LoadUnits(); // Ölçü birimlerini yükle
        }

        private void SetupEventHandlers()
        {
            btnKaydet.Click += BtnKaydet_Click;
            btnVazgec.Click += BtnVazgec_Click;
            btnOtomatikBarkod.Click += BtnOtomatikBarkod_Click; // Otomatik barkod düğmesi
            btnYeniOlcuBirimi.Click += BtnYeniOlcuBirimi_Click; // Yeni ölçü birimi düğmesi

            // Price calculation events
            txtAlisFiyatiKdvDahil.TextChanged += TxtAlisFiyatiKdvDahil_TextChanged;
            txtAlisFiyatiKdvHaric.TextChanged += TxtAlisFiyatiKdvHaric_TextChanged;
            txtKdvOrani.TextChanged += TxtKdvOrani_TextChanged;

            // KDV radio button events
            rbKdvDahil.CheckedChanged += RbKdvDahil_CheckedChanged;
            rbKdvHaric.CheckedChanged += RbKdvHaric_CheckedChanged;
            RbKdvDahil_CheckedChanged(rbKdvDahil, EventArgs.Empty); // Initial state
        }

        private void LoadProductGroups()
        {
            try
            {
                var groups = _context.ProductGroups.OrderBy(g => g.Name).ToList();
                cmbUrunGrubu.Items.Clear();
                foreach (var group in groups)
                {
                    cmbUrunGrubu.Items.Add(group.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün grupları yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadWholesalers()
        {
            // cmbToptanci does not exist in designer, so this method is not used.
            // If a wholesaler selection is needed, cmbToptanci needs to be added to the designer.
        }

        private void LoadUnits()
        {
            try
            {
                var units = _context.Units.OrderBy(u => u.Name).ToList();
                cmbOlcuBirimi.Items.Clear();
                foreach (var unit in units)
                {
                    cmbOlcuBirimi.Items.Add(unit.Name);
                }
                if (cmbOlcuBirimi.Items.Count > 0)
                {
                    cmbOlcuBirimi.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ölçü birimleri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnYeniOlcuBirimi_Click(object? sender, EventArgs e)
        {
            string newUnitName = Microsoft.VisualBasic.Interaction.InputBox("Yeni ölçü birimi adını girin:", "Yeni Ölçü Birimi Ekle", "");
            if (!string.IsNullOrWhiteSpace(newUnitName))
            {
                newUnitName = newUnitName.Trim();
                if (!_context.Units.Any(u => u.Name == newUnitName))
                {
                    _context.Units.Add(new Unit { Name = newUnitName });
                    _context.SaveChanges();
                    LoadUnits(); // Yeniden yükle
                    cmbOlcuBirimi.SelectedItem = newUnitName; // Yeni ekleneni seç
                    MessageBox.Show($"'{newUnitName}' ölçü birimi başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bu ölçü birimi zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnOtomatikBarkod_Click(object? sender, EventArgs e)
        {
            try
            {
                string newBarcode = GenerateNewBarcode();
                txtBarkodNo.Text = newBarcode;
                MessageBox.Show($"Otomatik barkod üretildi: {newBarcode}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Barkod üretilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateNewBarcode()
        {
            Random random = new Random();
            long newBarcodeNumber;
            string barcodeString;

            do
            {
                // Generate a random 12-digit number
                newBarcodeNumber = (long)(random.NextDouble() * 900000000000L) + 100000000000L; // Ensures 12 digits
                barcodeString = newBarcodeNumber.ToString();
            } while (_context.Products.Any(p => p.BarcodeNo == barcodeString)); // Check for uniqueness

            return barcodeString;
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

        private void BtnKaydet_Click(object? sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    // Check for existing barcode or stock code
                    if (_context.Products.Any(p => p.BarcodeNo == txtBarkodNo.Text))
                    {
                        MessageBox.Show("Bu barkod numarası zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBarkodNo.Focus();
                        return;
                    }
                    if (!string.IsNullOrEmpty(txtStokKodu.Text) && _context.Products.Any(p => p.StockCode == txtStokKodu.Text))
                    {
                        MessageBox.Show("Bu ürün kodu zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtStokKodu.Focus();
                        return;
                    }

                    ProductGroup? selectedGroup = null;
                    if (cmbUrunGrubu.SelectedItem != null)
                    {
                        selectedGroup = _context.ProductGroups.FirstOrDefault(g => g.Name == cmbUrunGrubu.SelectedItem.ToString());
                    }

                    var newProduct = new Product
                    {
                        BarcodeNo = txtBarkodNo.Text,
                        Name = txtUrunAdi.Text,
                        StockCode = txtStokKodu.Text,
                        ProductGroupId = selectedGroup?.Id,
                        PurchasePrice = decimal.TryParse(txtAlisFiyatiKdvHaric.Text, out decimal purchasePrice) ? purchasePrice : 0,
                        SalePrice = decimal.TryParse(txtSatisFiyati.Text, out decimal salePrice) ? salePrice : 0,
                        CurrentStock = decimal.TryParse(txtAsgariStok.Text, out decimal currentStock) ? currentStock : 0, // Using txtAsgariStok for current stock
                        MinimumStock = decimal.TryParse(txtAsgariStok.Text, out decimal minStock) ? minStock : 0,
                        Unit = cmbOlcuBirimi.SelectedItem?.ToString() ?? "Adet", // Use selected item from ComboBox
                        VatRate = decimal.TryParse(txtKdvOrani.Text, out decimal vatRate) ? vatRate : 10,
                        Notes = "", // No wholesaler selection in this form
                        IsActive = true,
                        CreatedDate = DateTime.Now
                    };

                    _context.Products.Add(newProduct);
                    _context.SaveChanges();

                    MessageBox.Show("Ürün başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ürün kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnVazgec_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtBarkodNo.Text))
            {
                MessageBox.Show("Barkod Numarası boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarkodNo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Ürün Adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUrunAdi.Focus();
                return false;
            }
            if (cmbUrunGrubu.SelectedItem == null)
            {
                MessageBox.Show("Ürün Grubu seçilmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUrunGrubu.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAlisFiyatiKdvDahil.Text) && string.IsNullOrWhiteSpace(txtAlisFiyatiKdvHaric.Text))
            {
                MessageBox.Show("Alış Fiyatı (KDV Dahil) veya Alış Fiyatı (KDV Hariç) boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSatisFiyati.Text))
            {
                MessageBox.Show("Satış Fiyatı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSatisFiyati.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtKdvOrani.Text))
            {
                MessageBox.Show("KDV Oranı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKdvOrani.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAsgariStok.Text))
            {
                MessageBox.Show("Asgari Stok boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAsgariStok.Focus();
                return false;
            }
            if (cmbOlcuBirimi.SelectedItem == null)
            {
                MessageBox.Show("Ölçü Birimi seçilmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbOlcuBirimi.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtBarkodNo.Clear();
            txtUrunAdi.Clear();
            txtStokKodu.Clear();
            cmbUrunGrubu.SelectedIndex = -1;
            txtAlisFiyatiKdvDahil.Clear();
            txtAlisFiyatiKdvHaric.Clear();
            txtSatisFiyati.Clear();
            txtKdvOrani.Text = "10"; // Default KDV
            txtAsgariStok.Text = "0";
            cmbOlcuBirimi.SelectedIndex = 0; // Default to first unit
            rbKdvDahil.Checked = true; // Default KDV option
            txtBarkodNo.Focus();
        }

        private void TxtAlisFiyatiKdvDahil_TextChanged(object? sender, EventArgs e)
        {
            if (rbKdvDahil.Checked)
            {
                if (decimal.TryParse(txtAlisFiyatiKdvDahil.Text, out decimal alisFiyatiDahil) && decimal.TryParse(txtKdvOrani.Text, out decimal kdvOrani))
                {
                    decimal alisFiyatiHaric = alisFiyatiDahil / (1 + (kdvOrani / 100));
                    txtAlisFiyatiKdvHaric.Text = alisFiyatiHaric.ToString("F2");
                }
                else
                {
                    txtAlisFiyatiKdvHaric.Text = string.Empty;
                }
            }
        }

        private void TxtAlisFiyatiKdvHaric_TextChanged(object? sender, EventArgs e)
        {
            if (rbKdvHaric.Checked)
            {
                if (decimal.TryParse(txtAlisFiyatiKdvHaric.Text, out decimal alisFiyatiHaric) && decimal.TryParse(txtKdvOrani.Text, out decimal kdvOrani))
                {
                    decimal alisFiyatiDahil = alisFiyatiHaric * (1 + (kdvOrani / 100));
                    txtAlisFiyatiKdvDahil.Text = alisFiyatiDahil.ToString("F2");
                }
                else
                {
                    txtAlisFiyatiKdvDahil.Text = string.Empty;
                }
            }
        }

        private void TxtKdvOrani_TextChanged(object? sender, EventArgs e)
        {
            // Recalculate prices based on which radio button is checked
            if (rbKdvDahil.Checked)
            {
                TxtAlisFiyatiKdvDahil_TextChanged(txtAlisFiyatiKdvDahil, EventArgs.Empty);
            }
            else if (rbKdvHaric.Checked)
            {
                TxtAlisFiyatiKdvHaric_TextChanged(txtAlisFiyatiKdvHaric, EventArgs.Empty);
            }
        }
    }
}
