using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using StokTakip.Data;

namespace StokTakip.Forms
{
    public partial class UrunGirisForm : Form
    {
        private readonly StokTakipDbContext _context;

        public UrunGirisForm(StokTakipDbContext context)
        {
            _context = context;
            InitializeComponent();
            btnYeniToptanci.Click += new EventHandler(btnYeniToptanci_Click);
            btnYeniUrunGrubu.Click += new EventHandler(btnYeniUrunGrubu_Click);
            btnUrunAra.Click += new EventHandler(btnUrunAra_Click);
            btnFaturaliGiris.Click += new EventHandler(btnFaturaliGiris_Click);
        }

        private void btnFaturaliGiris_Click(object? sender, EventArgs e)
        {
            AlisFaturasiForm alisFaturasiForm = new AlisFaturasiForm(_context);
            alisFaturasiForm.ShowDialog();
        }

        private void btnUrunAra_Click(object? sender, EventArgs e)
        {
            UrunAramaForm urunAramaForm = new UrunAramaForm(_context);
            urunAramaForm.ShowDialog();
        }

        private void btnYeniToptanci_Click(object? sender, EventArgs e)
        {
            ToptanciKayitForm toptanciKayitForm = new ToptanciKayitForm(_context);
            toptanciKayitForm.ShowDialog();
        }

        private void btnYeniUrunGrubu_Click(object? sender, EventArgs e)
        {
            string yeniGrup = Interaction.InputBox("Yeni ürün grubunu girin:", "Ürün Grubu Ekle", "");
            if (!string.IsNullOrWhiteSpace(yeniGrup))
            {
                cmbUrunGrubu.Items.Add(yeniGrup);
                cmbUrunGrubu.SelectedItem = yeniGrup;
            }
        }
    }
}
