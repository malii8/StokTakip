using System;
using System.Windows.Forms;
using StokTakip.Data;
using StokTakip.Models;

namespace StokTakip.Forms
{
    public partial class TahsilatYapForm : Form
    {
        private readonly StokTakipDbContext _context;
        private Customer? _customer;

        public decimal TahsilatTutari { get; private set; }
        public string Aciklama { get; private set; } = string.Empty;
        public string OdemeSekli { get; private set; } = string.Empty;

        public TahsilatYapForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            InitializeForm();

            // Wire up event handlers
            btnOnayla.Click += btnOnayla_Click;
            btnVazgec.Click += btnVazgec_Click;
        }

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
            txtMusterininAdi.Text = _customer.Name;
            txtToplamBorc.Text = $"{_customer.Debt:F2} TL";
        }

        private void InitializeForm()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtSaat.Text = DateTime.Now.ToShortTimeString();

            // Default payment method
            rbNakit.Checked = true;
            OdemeSekli = "Nakit";

            // Wire up CheckedChanged event for radio buttons
            rbNakit.CheckedChanged += rbOdemeSekli_CheckedChanged;
            rbKrediKarti.CheckedChanged += rbOdemeSekli_CheckedChanged;
            rbHavale.CheckedChanged += rbOdemeSekli_CheckedChanged;
        }

        private void btnOnayla_Click(object? sender, EventArgs e)
        {
            if (ValidateInput() && _customer != null)
            {
                TahsilatTutari = Convert.ToDecimal(txtOdemeTutari.Text);
                Aciklama = txtAciklama.Text;

                if (rbNakit.Checked) OdemeSekli = "Nakit";
                else if (rbKrediKarti.Checked) OdemeSekli = "Kredi Kartı";
                else if (rbHavale.Checked) OdemeSekli = "Havale";

                try
                {
                    // Update customer debt
                    _customer.Debt -= TahsilatTutari;

                    // Record customer debt movement
                    var debtMovement = new CustomerDebtMovement
                    {
                        CustomerId = _customer.Id,
                        Amount = TahsilatTutari,
                        MovementType = "Tahsilat",
                        MovementDate = DateTime.Parse(txtTarih.Text).Date + DateTime.Parse(txtSaat.Text).TimeOfDay,
                        Description = Aciklama
                    };
                    _context.CustomerDebtMovements.Add(debtMovement);

                    // Record cash movement (Gelir)
                    var cashMovement = new CashMovement
                    {
                        MovementType = "Gelir",
                        Amount = TahsilatTutari,
                        MovementDate = DateTime.Parse(txtTarih.Text).Date + DateTime.Parse(txtSaat.Text).TimeOfDay,
                        Description = $"Müşteri tahsilatı: {_customer.Name}",
                        PaymentMethod = OdemeSekli,
                        Notes = Aciklama
                    };
                    _context.CashMovements.Add(cashMovement);

                    _context.SaveChanges();

                    // Update the displayed total debt after successful payment
                    txtToplamBorc.Text = $"{_customer.Debt:F2} TL";

                    MessageBox.Show("Tahsilat başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Tahsilat kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVazgec_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOdemeBilgisiYazdir_Click(object? sender, EventArgs e)
        {
            printDocument1.PrintPage += printDocument1_PrintPage;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            printDocument1.PrintPage -= printDocument1_PrintPage;
        }

        private void printDocument1_PrintPage(object? sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (e.Graphics == null) return;
            var font = new System.Drawing.Font("Arial", 12);
            var boldFont = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            int y = 40;
            int lineHeight = 30;

            e.Graphics.DrawString("Ödeme Bilgisi", boldFont, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            e.Graphics.DrawString($"Müşteri: {txtMusterininAdi.Text}", font, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            e.Graphics.DrawString($"Toplam Borç: {txtToplamBorc.Text}", font, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            e.Graphics.DrawString($"Tarih: {txtTarih.Text}", font, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            e.Graphics.DrawString($"Saat: {txtSaat.Text}", font, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            e.Graphics.DrawString($"Ödeme Tutarı: {txtOdemeTutari.Text}", font, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            e.Graphics.DrawString($"Açıklama: {txtAciklama.Text}", font, System.Drawing.Brushes.Black, 40, y);
            y += lineHeight;
            string odemeSekli = rbNakit.Checked ? "Nakit" : rbKrediKarti.Checked ? "Kredi Kartı" : rbHavale.Checked ? "Havale" : "";
            e.Graphics.DrawString($"Ödeme Şekli: {odemeSekli}", font, System.Drawing.Brushes.Black, 40, y);
        }

        private bool ValidateInput()
        {
            if (_customer == null)
            {
                MessageBox.Show("Müşteri bilgisi yüklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOdemeTutari.Text))
            {
                MessageBox.Show("Tahsilat tutarı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOdemeTutari.Focus();
                return false;
            }

            if (!decimal.TryParse(txtOdemeTutari.Text, out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Geçerli bir tahsilat tutarı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOdemeTutari.Focus();
                return false;
            }

            if (tutar > _customer.Debt)
            {
                MessageBox.Show("Tahsilat tutarı mevcut borçtan fazla olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOdemeTutari.Focus();
                return false;
            }

            return true;
        }

        private void rbOdemeSekli_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                OdemeSekli = rb.Text;
            }
        }

        private void txtOdemeTutari_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and a single decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox)?.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
