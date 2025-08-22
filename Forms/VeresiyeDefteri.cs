using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Data;
using StokTakip.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace StokTakip.Forms
{
    public partial class VeresiyeDefteri : Form
    {
        private readonly StokTakipDbContext _context;
        private readonly IServiceProvider _serviceProvider;
        private Customer? _customer;

        public VeresiyeDefteri(StokTakipDbContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _serviceProvider = serviceProvider;
            dgvBorcDetayi.AutoGenerateColumns = false;
            dgvAlisverisDetayi.AutoGenerateColumns = false;

            // Tarih filtrelerini ayarla
            dtpBaslangic.Value = new DateTime(2023, 1, 1); // Başlangıç tarihini 01.01.2023 olarak ayarla
            dtpBitis.Value = DateTime.Now;

            // Olayları bağla
            dtpBaslangic.ValueChanged += dtpBaslangic_ValueChanged;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;

            // Event handler'ları bağla
            btnTahsilatYap.Click += BtnTahsilatYap_Click;
            btnHesabaBorcEkle.Click += BtnHesabaBorcEkle_Click;
            btnTabloExcelAktar.Click += BtnTabloExcelAktar_Click;
            btnTabloExcelAktar2.Click += BtnTabloExcelAktar2_Click;
            btnSeciUrunSatisFisiniGoster.Click += BtnSeciUrunSatisFisiniGoster_Click;
        }

        private void BtnTabloExcelAktar_Click(object? sender, EventArgs e)
        {
            ExportDataGridViewToCsv(dgvBorcDetayi, "BorcDetayi");
        }

        private void BtnTabloExcelAktar2_Click(object? sender, EventArgs e)
        {
            ExportDataGridViewToCsv(dgvAlisverisDetayi, "AlisverisDetayi");
        }

        private void BtnSeciUrunSatisFisiniGoster_Click(object? sender, EventArgs e)
        {
            if (dgvAlisverisDetayi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAlisverisDetayi.SelectedRows[0];
                int salesReceiptId = Convert.ToInt32(selectedRow.Cells["colSalesReceiptId"].Value);

                var fisDetayiForm = _serviceProvider.GetRequiredService<FisDetayiForm>();
                fisDetayiForm.SetSalesReceiptId(salesReceiptId);
                fisDetayiForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen satış fişini görmek istediğiniz ürünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExportDataGridViewToCsv(DataGridView dgv, string defaultFileName)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Dışa aktarılacak veri bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV Dosyası (*.csv)|*.csv", FileName = defaultFileName + ".csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            // Genel Başlık
                            sw.WriteLine("XXXX Market");
                            sw.WriteLine();

                            // Müşteri Bilgileri
                            if (_customer != null)
                            {
                                sw.WriteLine($"Müşterinin Adı;{_customer.Name}");
                                sw.WriteLine($"Adresi;{_customer.Address}");
                                sw.WriteLine($"Borç Miktarı;{_customer.Debt:F2} TL");
                                sw.WriteLine();
                            }

                            // Tablo Başlığı
                            if (defaultFileName == "BorcDetayi")
                            {
                                sw.WriteLine("BORÇ DETAYI");
                            }
                            else if (defaultFileName == "AlisverisDetayi")
                            {
                                sw.WriteLine("ALIŞVERİŞ DETAYI");
                            }
                            sw.WriteLine();

                            // Başlıkları yaz
                            for (int i = 0; i < dgv.Columns.Count; i++)
                            {
                                sw.Write(dgv.Columns[i].HeaderText);
                                if (i < dgv.Columns.Count - 1)
                                {
                                    sw.Write(";");
                                }
                            }
                            sw.WriteLine();

                            // Satırları yaz
                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    for (int i = 0; i < dgv.Columns.Count; i++)
                                    {
                                        sw.Write(row.Cells[i].Value?.ToString());
                                        if (i < dgv.Columns.Count - 1)
                                        {
                                            sw.Write(";");
                                        }
                                    }
                                    sw.WriteLine();
                                }
                            }
                        }
                        MessageBox.Show("Veriler başarıyla Excel'e aktarıldı (CSV formatında).", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Veriler aktarılırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
            LoadCustomerDetails();
            LoadDebtMovements();
            LoadSalesDetails();
        }

        private void LoadCustomerDetails()
        {
            if (_customer == null) return;

            txtMusterininAdi.Text = _customer.Name;
            lblBorcMiktariValue.Text = $"{_customer.Debt:F2} TL";
            lblVeresiyeBorcMiktari.Text = "Veresiye Borç Miktarı"; // Etiketin metnini tekrar ayarla

            // Set debt status color
            if (_customer.Debt > 0)
            {
                lblBorcMiktariValue.BackColor = System.Drawing.Color.Red;
                lblBorcMiktariValue.ForeColor = System.Drawing.Color.White;
            }
            else if (_customer.Debt < 0)
            {
                lblBorcMiktariValue.BackColor = System.Drawing.Color.Green;
                lblBorcMiktariValue.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                lblBorcMiktariValue.BackColor = System.Drawing.Color.Gray; // Borç yoksa farklı bir renk
                lblBorcMiktariValue.ForeColor = System.Drawing.Color.White;
            }
        }

        private void LoadDebtMovements()
        {
            dgvBorcDetayi.Rows.Clear();

            if (_customer == null) return;

            try
            {
                var movements = _context.CustomerDebtMovements
                    .Where(m => m.CustomerId == _customer.Id)
                    .OrderBy(m => m.MovementDate) // Order by ascending date for correct balance calculation
                    .ToList();

                decimal currentBalance = 0;

                foreach (var movement in movements)
                {
                    decimal previousBalance = currentBalance;

                    if (movement.MovementType == "Borç Ekleme")
                    {
                        currentBalance += movement.Amount;
                    }
                    else if (movement.MovementType == "Tahsilat" || movement.MovementType == "İade")
                    {
                        currentBalance -= movement.Amount;
                    }

                    dgvBorcDetayi.Rows.Add(
                        movement.Id,
                        movement.MovementDate.ToShortDateString(),
                        movement.MovementType,
                        previousBalance.ToString("F2"),
                        movement.Amount.ToString("F2"),
                        currentBalance.ToString("F2"),
                        movement.Description ?? ""
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Borç hareketleri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSalesDetails()
        {
            dgvAlisverisDetayi.Rows.Clear();
            if (_customer == null)
            {
                MessageBox.Show("Müşteri seçilmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var receipts = _context.SalesReceipts
                    .Where(r => r.CustomerId == _customer.Id && r.ReceiptDate >= dtpBaslangic.Value && r.ReceiptDate <= dtpBitis.Value)
                    .Include(r => r.Details)
                    .ThenInclude(d => d.Product)
                    .OrderByDescending(r => r.ReceiptDate)
                    .ToList();

                decimal totalProductsAmount = 0; // Toplam tutarı tutacak değişken
                int siraNo = 1;
                foreach (var receipt in receipts)
                {
                    foreach (var detail in receipt.Details)
                    {
                        dgvAlisverisDetayi.Rows.Add(
                            siraNo++,
                            receipt.ReceiptDate.ToString("dd.MM.yyyy - HH:mm:ss"),
                            detail.Product.Name,
                            detail.UnitPrice.ToString("F2"),
                            detail.Quantity.ToString("F2"),
                            detail.Total.ToString("F2"),
                            receipt.PaymentType,
                            receipt.Id // colSalesReceiptId sütununa SalesReceiptId değerini ekle
                        );
                        totalProductsAmount += detail.Total; // Her ürünün toplam tutarını ekle
                    }
                }
                txtUrunToplami.Text = totalProductsAmount.ToString("F2") + " TL"; // Toplam tutarı etikete yaz
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Satış detayları yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTahsilatYap_Click(object? sender, EventArgs e)
        {
            if (_customer == null) return;

            var tahsilatYapForm = _serviceProvider.GetRequiredService<TahsilatYapForm>();
            tahsilatYapForm.SetCustomer(_customer);
            if (tahsilatYapForm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomerDetails(); // Refresh customer details
                LoadDebtMovements(); // Refresh movements
            }
        }

        private void BtnHesabaBorcEkle_Click(object? sender, EventArgs e)
        {
            if (_customer == null) return;

            var hesabaBorcEkleForm = _serviceProvider.GetRequiredService<HesabaBorcEkleForm>();
            hesabaBorcEkleForm.SetCustomer(_customer);
            if (hesabaBorcEkleForm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomerDetails(); // Refresh customer details
                LoadDebtMovements(); // Refresh movements
            }
        }

        private void dtpBaslangic_ValueChanged(object? sender, EventArgs e)
        {
            LoadDebtMovements();
            LoadSalesDetails();
        }

        private void dtpBitis_ValueChanged(object? sender, EventArgs e)
        {
            LoadDebtMovements();
            LoadSalesDetails();
        }

        private void LoadCustomerDebtDetails()
        {
            if (_customer == null) return;

            txtMusterininAdi.Text = _customer.Name;

            var allTransactions = _context.CustomerDebtMovements
                .Where(t => t.CustomerId == _customer.Id)
                .OrderBy(t => t.MovementDate)
                .ToList();

            decimal currentBalance = 0;

            // Calculate initial balance before the start date
            foreach (var transaction in allTransactions.Where(t => t.MovementDate < dtpBaslangic.Value))
            {
                if (transaction.MovementType == "Borç")
                {
                    currentBalance += transaction.Amount;
                }
                else if (transaction.MovementType == "Ödeme" || transaction.MovementType == "İade")
                {
                    currentBalance -= transaction.Amount;
                }
            }

            dgvBorcDetayi.Rows.Clear();
            int siraNo = 1;
            foreach (var transaction in allTransactions.Where(t => t.MovementDate >= dtpBaslangic.Value && t.MovementDate <= dtpBitis.Value))
            {
                decimal previousBalance = currentBalance;
                decimal transactionAmount = transaction.Amount;

                // Update current balance based on transaction type
                if (transaction.MovementType == "Borç")
                {
                    currentBalance += transactionAmount;
                }
                else if (transaction.MovementType == "Ödeme" || transaction.MovementType == "İade")
                {
                    currentBalance -= transactionAmount;
                }

                dgvBorcDetayi.Rows.Add(
                    siraNo++,
                    transaction.MovementDate.ToShortDateString(),
                    transaction.MovementType,
                    previousBalance.ToString("F2"),
                    transactionAmount.ToString("F2"),
                    currentBalance.ToString("F2")
                );
            }
            lblBorcMiktariValue.Text = _customer.Debt.ToString("F2") + " TL"; // This should reflect the actual current debt from the customer object
            lblKalanTaksitValue.Text = currentBalance.ToString("F2") + " TL"; // Update the total remaining debt label based on filtered transactions
        }
    }
}
