using System.Windows.Forms;
using StokTakip.Data;

namespace StokTakip.Forms
{
    public partial class AlisFaturasiForm : Form
    {
        private readonly StokTakipDbContext _context;

        public AlisFaturasiForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            btnYeniUrunEkle.Click += new System.EventHandler(btnYeniUrunEkle_Click);
            btnYeniToptanci.Click += new System.EventHandler(btnYeniToptanci_Click);
            btnUrunAra.Click += new System.EventHandler(btnUrunAra_Click);
        }

        private void btnYeniUrunEkle_Click(object? sender, System.EventArgs e)
        {
            UrunYeniKayitForm urunYeniKayitForm = new UrunYeniKayitForm(_context);
            urunYeniKayitForm.ShowDialog();
        }

        private void btnYeniToptanci_Click(object? sender, System.EventArgs e)
        {
            ToptanciKayitForm toptanciKayitForm = new ToptanciKayitForm(_context);
            toptanciKayitForm.ShowDialog();
        }

        private void btnUrunAra_Click(object? sender, System.EventArgs e)
        {
            UrunAramaForm urunAramaForm = new UrunAramaForm(_context);
            urunAramaForm.ShowDialog();
        }
    }
}
