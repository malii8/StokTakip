using System;
using System.Windows.Forms;
using StokTakip.Models;
using StokTakip.Data;

namespace StokTakip.Forms
{
    public partial class ToptanciyaOdemeYapForm : Form
    {
        public decimal OdemeTutari { get; private set; }
        public string Aciklama { get; private set; } = string.Empty;
        public string OdemeSekli { get; private set; } = string.Empty;

        private Wholesaler? _wholesaler;
        private readonly StokTakipDbContext _context;

        public ToptanciyaOdemeYapForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            InitializeForm();
        }

        public void SetWholesaler(Wholesaler wholesaler)
        {
            _wholesaler = wholesaler;
            txtToptanciAdi.Text = _wholesaler.Name;
            txtToplamBorc.Text = $"{_wholesaler.Debt:F2} TL";
        }

        private void InitializeForm()
        {
            dtpTarih.Value = DateTime.Now;
            dtpSaat.Value = DateTime.Now;

            // Default payment method
            rbNakit.Checked = true;
            OdemeSekli = "Nakit";
        }

        private void BtnOnayla_Click(object? sender, EventArgs e)
        {
            if (ValidateInput() && _wholesaler != null)
            {
                OdemeTutari = Convert.ToDecimal(txtOdemeTutari.Text);
                Aciklama = txtAciklama.Text;

                if (rbNakit.Checked) OdemeSekli = "Nakit";
                else if (rbKrediKarti.Checked) OdemeSekli = "Kredi Kartı";
                else if (rbHavale.Checked) OdemeSekli = "Havale";

                // Update wholesaler debt
                _wholesaler.Debt -= OdemeTutari;

                // Record cash movement
                var cashMovement = new CashMovement
                {
                    MovementType = "Gider", // Ödeme olduğu için gider
                    Amount = OdemeTutari,
                    MovementDate = dtpTarih.Value.Date + dtpSaat.Value.TimeOfDay,
                    Description = $"{_wholesaler.Name} toptancısına {OdemeSekli} ile ödeme",
                    Notes = Aciklama
                };
                _context.CashMovements.Add(cashMovement);

                // Record wholesaler debt movement
                var debtMovement = new WholesalerDebtMovement
                {
                    WholesalerId = _wholesaler.Id,
                    Amount = OdemeTutari,
                    MovementType = "Ödeme",
                    MovementDate = dtpTarih.Value.Date + dtpSaat.Value.TimeOfDay,
                    Description = Aciklama
                };
                _context.WholesalerDebtMovements.Add(debtMovement);

                _context.SaveChanges();

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnVazgec_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtOdemeTutari.Text))
            {
                MessageBox.Show("Ödeme tutarı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOdemeTutari.Focus();
                return false;
            }

            if (!decimal.TryParse(txtOdemeTutari.Text, out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Geçerli bir ödeme tutarı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOdemeTutari.Focus();
                return false;
            }

            if (tutar > _wholesaler?.Debt)
            {
                MessageBox.Show("Ödeme tutarı toplam borçtan fazla olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOdemeTutari.Focus();
                return false;
            }

            return true;
        }

        private void RbOdemeSekli_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                OdemeSekli = rb.Text;
            }
        }
    }
}
