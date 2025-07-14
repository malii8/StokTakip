using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class VeresiyeDefteri : Form
    {
        public VeresiyeDefteri()
        {
            InitializeComponent();

            // Event handler'ları bağla
            btnTahsilatYap.Click += BtnTahsilatYap_Click;
            btnHesabaBorcEkle.Click += BtnHesabaBorcEkle_Click;
        }

        private void BtnTahsilatYap_Click(object? sender, EventArgs e)
        {
            TahsilatYapForm tahsilatYapForm = new TahsilatYapForm();
            tahsilatYapForm.ShowDialog();
        }

        private void BtnHesabaBorcEkle_Click(object? sender, EventArgs e)
        {
            HesabaBorcEkleForm hesabaBorcEkleForm = new HesabaBorcEkleForm();
            hesabaBorcEkleForm.ShowDialog();
        }
    }
}
