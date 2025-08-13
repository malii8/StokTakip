using System;
using System.Windows.Forms;
using StokTakip.Data;
using Microsoft.Extensions.DependencyInjection;

namespace StokTakip.Forms
{
    public partial class FiyatGorForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public FiyatGorForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            btnUrunAdiIleAra.Click += new EventHandler(btnUrunAdiIleAra_Click);
        }

        private void btnUrunAdiIleAra_Click(object? sender, EventArgs e)
        {
            var urunAramaForm = _serviceProvider.GetRequiredService<UrunAramaForm>();
            urunAramaForm.ShowDialog();
        }
    }
}
