using System;
using System.Windows.Forms;
using StokTakip.Data;

namespace StokTakip.Forms
{
    public partial class FiyatGorForm : Form
    {
        private readonly StokTakipDbContext _context;

        public FiyatGorForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            btnUrunAdiIleAra.Click += new EventHandler(btnUrunAdiIleAra_Click);
        }

        private void btnUrunAdiIleAra_Click(object? sender, EventArgs e)
        {
            UrunAramaForm urunAramaForm = new UrunAramaForm(_context);
            urunAramaForm.ShowDialog();
        }
    }
}
