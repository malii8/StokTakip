using System.Windows.Forms;
using StokTakip.Data;
using Microsoft.Extensions.DependencyInjection;

namespace StokTakip.Forms
{
    public partial class AlisFaturasiForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public AlisFaturasiForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            btnYeniUrunEkle.Click += new System.EventHandler(btnYeniUrunEkle_Click);
            btnYeniToptanci.Click += new System.EventHandler(btnYeniToptanci_Click);
            btnUrunAra.Click += new System.EventHandler(btnUrunAra_Click);
        }

        private void btnYeniUrunEkle_Click(object? sender, System.EventArgs e)
        {
            var urunYeniKayitForm = _serviceProvider.GetRequiredService<UrunYeniKayitForm>();
            urunYeniKayitForm.ShowDialog();
        }

        private void btnYeniToptanci_Click(object? sender, System.EventArgs e)
        {
            var toptanciKayitForm = _serviceProvider.GetRequiredService<ToptanciKayitForm>();
            toptanciKayitForm.ShowDialog();
        }

        private void btnUrunAra_Click(object? sender, System.EventArgs e)
        {
            var urunAramaForm = _serviceProvider.GetRequiredService<UrunAramaForm>();
            urunAramaForm.ShowDialog();
        }
    }
}
