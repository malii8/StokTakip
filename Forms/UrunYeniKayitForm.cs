using System.Windows.Forms;
using StokTakip.Data;

namespace StokTakip.Forms
{
    public partial class UrunYeniKayitForm : Form
    {
        private readonly StokTakipDbContext _context;

        public UrunYeniKayitForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
        }
    }
}
