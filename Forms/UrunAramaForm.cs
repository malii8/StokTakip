using System.Windows.Forms;
using StokTakip.Data;

namespace StokTakip.Forms
{
    public partial class UrunAramaForm : Form
    {
        private readonly StokTakipDbContext _context;

        public UrunAramaForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
        }
    }
}
