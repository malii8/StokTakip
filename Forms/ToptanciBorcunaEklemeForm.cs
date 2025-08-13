using System;
using System.Windows.Forms;
using StokTakip.Models;
using StokTakip.Data;

namespace StokTakip.Forms
{
    public partial class ToptanciBorcunaEklemeForm : Form
    {
        public decimal EklenecekTutar { get; private set; }
        public string Aciklama { get; private set; } = string.Empty;

        private Wholesaler? _wholesaler;
        private readonly StokTakipDbContext _context;

        public ToptanciBorcunaEklemeForm(StokTakipDbContext context)
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
        }

        private void BtnOnayla_Click(object? sender, EventArgs e)
        {
            if (ValidateInput() && _wholesaler != null)
            {
                EklenecekTutar = Convert.ToDecimal(txtEklenecekTutar.Text);
                Aciklama = txtAciklama.Text;

                // Update wholesaler debt
                _wholesaler.Debt += EklenecekTutar;

                // Record wholesaler debt movement
                var debtMovement = new WholesalerDebtMovement
                {
                    WholesalerId = _wholesaler.Id,
                    Amount = EklenecekTutar,
                    MovementType = "Borç Ekleme",
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
            if (string.IsNullOrWhiteSpace(txtEklenecekTutar.Text))
            {
                MessageBox.Show("Eklenecek tutar boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEklenecekTutar.Focus();
                return false;
            }

            if (!decimal.TryParse(txtEklenecekTutar.Text, out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Geçerli bir tutar giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEklenecekTutar.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAciklama.Text))
            {
                MessageBox.Show("Açıklama boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAciklama.Focus();
                return false;
            }

            return true;
        }
    }
}
