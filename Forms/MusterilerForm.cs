using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class MusterilerForm : Form
    {
        public MusterilerForm()
        {
            InitializeComponent();

            // Event handler'ları bağla
            btnMusteriBorcDetayi.Click += BtnMusteriBorcDetayi_Click;
            btnHesabaBorcEkle.Click += BtnHesabaBorcEkle_Click;
            btnTahsilatYap.Click += BtnTahsilatYap_Click;
            btnMusteriEkle.Click += BtnMusteriEkle_Click;
            btnMusteriBilgileriDuzenle.Click += BtnMusteriBilgileriDuzenle_Click;
            btnMusteriIade.Click += BtnMusteriIade_Click;
            btnMusteriBorcListesi.Click += BtnMusteriBorcListesi_Click;
        }

        private void BtnMusteriBorcDetayi_Click(object? sender, EventArgs e)
        {
            VeresiyeDefteri veresiyeDefteri = new VeresiyeDefteri();
            veresiyeDefteri.ShowDialog();
        }

        private void BtnHesabaBorcEkle_Click(object? sender, EventArgs e)
        {
            HesabaBorcEkleForm hesabaBorcEkleForm = new HesabaBorcEkleForm();
            hesabaBorcEkleForm.ShowDialog();
        }

        private void BtnTahsilatYap_Click(object? sender, EventArgs e)
        {
            TahsilatYapForm tahsilatYapForm = new TahsilatYapForm();
            tahsilatYapForm.ShowDialog();
        }

        private void BtnMusteriEkle_Click(object? sender, EventArgs e)
        {
            MusteriEkleForm musteriEkleForm = new MusteriEkleForm();
            musteriEkleForm.ShowDialog();
        }

        private void BtnMusteriBilgileriDuzenle_Click(object? sender, EventArgs e)
        {
            MusteriBilgileriDuzenleForm musteriBilgileriDuzenleForm = new MusteriBilgileriDuzenleForm();
            musteriBilgileriDuzenleForm.ShowDialog();
        }

        private void BtnMusteriIade_Click(object? sender, EventArgs e)
        {
            MusteriIadeForm musteriIadeForm = new MusteriIadeForm();
            musteriIadeForm.ShowDialog();
        }

        private void BtnMusteriBorcListesi_Click(object? sender, EventArgs e)
        {
            MusteriBorcListesiForm musteriBorcListesiForm = new MusteriBorcListesiForm();
            musteriBorcListesiForm.ShowDialog();
        }
    }
}
