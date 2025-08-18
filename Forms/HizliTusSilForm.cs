using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using System.Drawing;

namespace StokTakip.Forms
{
    public partial class HizliTusSilForm : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;
        private const int QUICK_SALE_BUTTON_COUNT = 21;
        private Button[] _quickSaleButtons;

        public HizliTusSilForm(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _serviceProvider = serviceProvider;

            _quickSaleButtons = new Button[QUICK_SALE_BUTTON_COUNT];
            InitializeQuickSaleButtons();
            LoadQuickSaleButtons();
            btnSave.Click += BtnSave_Click;
        }

        private void InitializeQuickSaleButtons()
        {
            int buttonWidth = 90;
            int buttonHeight = 40;
            int startX = 10;
            int startY = 10;
            int paddingX = 10;
            int paddingY = 10;
            int columns = 3;

            for (int i = 0; i < QUICK_SALE_BUTTON_COUNT; i++)
            {
                Button btn = new Button();
                btn.Width = buttonWidth;
                btn.Height = buttonHeight;
                btn.Text = "BOŞ";
                btn.Tag = i + 1; // Store button index (1-based)
                btn.Click += QuickSaleButton_Click;
                btn.BackColor = Color.LightCoral;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.DarkRed;
                btn.FlatAppearance.BorderSize = 1;

                int row = i / columns;
                int col = i % columns;

                btn.Left = startX + col * (buttonWidth + paddingX);
                btn.Top = startY + row * (buttonHeight + paddingY);

                pnlButtons.Controls.Add(btn);
                _quickSaleButtons[i] = btn;
            }
        }

        private void LoadQuickSaleButtons()
        {
            var configs = _context.QuickSaleButtonConfigs.ToList();
            for (int i = 0; i < QUICK_SALE_BUTTON_COUNT; i++)
            {
                var config = configs.FirstOrDefault(c => c.ButtonIndex == (i + 1));
                if (config != null)
                {
                    _quickSaleButtons[i].Text = config.ProductName;
                    _quickSaleButtons[i].Tag = config.ProductId; // Store product ID
                }
                else
                {
                    _quickSaleButtons[i].Text = "BOŞ";
                    _quickSaleButtons[i].Tag = i + 1; // Reset tag to button index
                }
            }
        }

        private void QuickSaleButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                if (clickedButton.Tag is int buttonIndex)
                {
                    var configToDelete = _context.QuickSaleButtonConfigs.FirstOrDefault(c => c.ButtonIndex == buttonIndex);
                    if (configToDelete != null)
                    {
                        _context.QuickSaleButtonConfigs.Remove(configToDelete);
                        _context.SaveChanges();
                        MessageBox.Show($"Hızlı tuş {configToDelete.ProductName} silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clickedButton.Text = "BOŞ";
                        clickedButton.Tag = buttonIndex; // Reset tag to button index
                    }
                    else
                    {
                        MessageBox.Show("Bu tuşa atanmış bir ürün yok.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
