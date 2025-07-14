using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using System;
using System.Windows.Forms;

namespace StokTakip.Forms
{
    public partial class AnaForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly StokTakipDbContext _context;

        public AnaForm(IServiceProvider serviceProvider, StokTakipDbContext context)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _context = context;
            
            btnUrunGiris.Click += new EventHandler(btnUrunGiris_Click);
            btnSatisİslem.Click += new EventHandler(btnSatisİslem_Click);
            btnFiyatGor.Click += new EventHandler(btnFiyatGor_Click);
            btnMusteriler.Click += new EventHandler(btnMusteriler_Click);
            btnIadeİslemleri.Click += new EventHandler(btnIadeİslemleri_Click);
            btnStoklar.Click += new EventHandler(btnStoklar_Click);
            btnRaporlar.Click += new EventHandler(btnRaporlar_Click);
        }

        private void btnUrunGiris_Click(object? sender, EventArgs e)
        {
            UrunGirisForm urunGirisForm = new UrunGirisForm(_context);
            urunGirisForm.ShowDialog();
        }

        private void btnSatisİslem_Click(object? sender, EventArgs e)
        {
            var satisIslemiForm = _serviceProvider.GetRequiredService<SatisIslemiForm>();
            satisIslemiForm.Show();
        }

        private void btnFiyatGor_Click(object? sender, EventArgs e)
        {
            FiyatGorForm fiyatGorForm = new FiyatGorForm(_context);
            fiyatGorForm.ShowDialog();
        }

        private void btnMusteriler_Click(object? sender, EventArgs e)
        {
            var musterilerForm = _serviceProvider.GetRequiredService<MusterilerForm>();
            musterilerForm.ShowDialog();
        }

        private void btnIadeİslemleri_Click(object? sender, EventArgs e)
        {
            MusteriIadeForm musteriIadeForm = new MusteriIadeForm();
            musteriIadeForm.ShowDialog();
        }

        private void btnStoklar_Click(object? sender, EventArgs e)
        {
            var stoklarForm = _serviceProvider.GetRequiredService<StoklarForm>();
            stoklarForm.ShowDialog();
        }

        private void btnRaporlar_Click(object? sender, EventArgs e)
        {
            var raporlarForm = _serviceProvider.GetRequiredService<RaporlarForm>();
            raporlarForm.ShowDialog();
        }

        private void btnKasa_Click(object? sender, EventArgs e)
        {
            var kasaForm = _serviceProvider.GetRequiredService<KasaForm>();
            kasaForm.ShowDialog();
        }

        private void btnToptancilar_Click(object? sender, EventArgs e)
        {
            ToptanciKayitForm toptanciKayitForm = new ToptanciKayitForm(_context);
            toptanciKayitForm.ShowDialog();
        }
    }
}
