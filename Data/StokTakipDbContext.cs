using Microsoft.EntityFrameworkCore;
using StokTakip.Models;

namespace StokTakip.Data
{
    public class StokTakipDbContext : DbContext
    {
        public StokTakipDbContext(DbContextOptions<StokTakipDbContext> options) : base(options)
        {
        }

        // DbSets
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Wholesaler> Wholesalers { get; set; }
        public DbSet<SalesReceipt> SalesReceipts { get; set; }
        public DbSet<SalesReceiptDetail> SalesReceiptDetails { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }
        public DbSet<CashMovement> CashMovements { get; set; }
        public DbSet<CustomerDebtMovement> CustomerDebtMovements { get; set; }
        public DbSet<WholesalerDebtMovement> WholesalerDebtMovements { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<QuickSaleButtonConfig> QuickSaleButtonConfigs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ProductGroup configuration
            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.HasIndex(e => e.Name).IsUnique();
            });

            // Unit configuration
            modelBuilder.Entity<Unit>(entity =>
            {
                entity.HasIndex(e => e.Name).IsUnique();
            });

            // Product configuration
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.BarcodeNo).IsUnique();
                entity.HasIndex(e => e.StockCode).IsUnique();

                entity.HasOne(p => p.ProductGroup)
                      .WithMany(pg => pg.Products)
                      .HasForeignKey(p => p.ProductGroupId)
                      .OnDelete(DeleteBehavior.SetNull);
            });

            // Customer configuration
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.TaxNumber).IsUnique();
                entity.HasIndex(e => e.Email).IsUnique();
            });

            // Wholesaler configuration
            modelBuilder.Entity<Wholesaler>(entity =>
            {
                entity.HasIndex(e => e.TaxNumber).IsUnique();
                entity.HasIndex(e => e.Email).IsUnique();
            });

            // SalesReceipt configuration
            modelBuilder.Entity<SalesReceipt>(entity =>
            {
                entity.HasIndex(e => e.ReceiptNumber).IsUnique();

                entity.HasOne(sr => sr.Customer)
                      .WithMany(c => c.SalesReceipts)
                      .HasForeignKey(sr => sr.CustomerId)
                      .OnDelete(DeleteBehavior.SetNull);
            });

            // SalesReceiptDetail configuration
            modelBuilder.Entity<SalesReceiptDetail>(entity =>
            {
                entity.HasOne(srd => srd.SalesReceipt)
                      .WithMany(sr => sr.Details)
                      .HasForeignKey(srd => srd.SalesReceiptId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(srd => srd.Product)
                      .WithMany(p => p.SalesReceiptDetails)
                      .HasForeignKey(srd => srd.ProductId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // StockMovement configuration
            modelBuilder.Entity<StockMovement>(entity =>
            {
                entity.HasOne(sm => sm.Product)
                  .WithMany(p => p.StockMovements)
                  .HasForeignKey(sm => sm.ProductId)
                  .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(sm => sm.Wholesaler)
                  .WithMany(w => w.StockMovements)
                  .HasForeignKey(sm => sm.WholesalerId)
                  .OnDelete(DeleteBehavior.Restrict);
            });

            // CashMovement configuration
            modelBuilder.Entity<CashMovement>(entity =>
            {
                entity.HasOne(cm => cm.SalesReceipt)
                      .WithMany(sr => sr.CashMovements)
                      .HasForeignKey(cm => cm.SalesReceiptId)
                      .OnDelete(DeleteBehavior.SetNull);
            });

            // CustomerDebtMovement configuration
            modelBuilder.Entity<CustomerDebtMovement>(entity =>
            {
                entity.HasOne(cdm => cdm.Customer)
                      .WithMany(c => c.DebtMovements)
                      .HasForeignKey(cdm => cdm.CustomerId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(cdm => cdm.SalesReceipt)
                      .WithMany(sr => sr.CustomerDebtMovements)
                      .HasForeignKey(cdm => cdm.SalesReceiptId)
                      .OnDelete(DeleteBehavior.SetNull);
            });

            // WholesalerDebtMovement configuration
            modelBuilder.Entity<WholesalerDebtMovement>(entity =>
            {
                entity.HasOne(wdm => wdm.Wholesaler)
                      .WithMany(w => w.DebtMovements)
                      .HasForeignKey(wdm => wdm.WholesalerId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(wdm => wdm.SalesReceipt)
                      .WithMany(sr => sr.WholesalerDebtMovements)
                      .HasForeignKey(wdm => wdm.SalesReceiptId)
                      .OnDelete(DeleteBehavior.SetNull);
            });

            // QuickSaleButtonConfig configuration
            modelBuilder.Entity<QuickSaleButtonConfig>(entity =>
            {
                entity.HasOne(qsbc => qsbc.Product)
                      .WithMany(p => p.QuickSaleButtonConfigs)
                      .HasForeignKey(qsbc => qsbc.ProductId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // Seed sample data
            modelBuilder.Entity<ProductGroup>().HasData(
                new ProductGroup { Id = 1, Name = "Filtreler", CreatedDate = new DateTime(2025, 1, 1) },
                new ProductGroup { Id = 2, Name = "Motor Yağları", CreatedDate = new DateTime(2025, 1, 1) }
            );

            modelBuilder.Entity<Unit>().HasData(
                new Unit { Id = 1, Name = "Adet", CreatedDate = new DateTime(2025, 1, 1) },
                new Unit { Id = 2, Name = "Koli", CreatedDate = new DateTime(2025, 1, 1) }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    BarcodeNo = "1234567890123",
                    Name = "Hava Filtresi",
                    StockCode = "HF-100",
                    ProductGroupId = 1,
                    PurchasePrice = 50.00m,
                    SalePrice = 75.00m,
                    CurrentStock = 100,
                    MinimumStock = 10,
                    VatRate = 18,
                    CreatedDate = new DateTime(2025, 1, 1)
                },
                new Product
                {
                    Id = 2,
                    BarcodeNo = "9876543210987",
                    Name = "Yağ Filtresi",
                    StockCode = "YF-200",
                    ProductGroupId = 1,
                    PurchasePrice = 30.00m,
                    SalePrice = 45.00m,
                    CurrentStock = 50,
                    MinimumStock = 5,
                    VatRate = 18,
                    CreatedDate = new DateTime(2025, 1, 1)
                },
                new Product
                {
                    Id = 3,
                    BarcodeNo = "1122334455667",
                    Name = "Motor Yağı 5W-30",
                    StockCode = "MY-5W30",
                    ProductGroupId = 2,
                    PurchasePrice = 120.00m,
                    SalePrice = 180.00m,
                    CurrentStock = 30,
                    MinimumStock = 3,
                    VatRate = 18,
                    CreatedDate = new DateTime(2025, 1, 1)
                },
                new Product
                {
                    Id = 4,
                    BarcodeNo = "000001",
                    Name = "MANN C24003",
                    StockCode = "MANN-C24003",
                    ProductGroupId = 1,
                    PurchasePrice = 40.00m,
                    SalePrice = 60.00m,
                    CurrentStock = 7,
                    MinimumStock = 1,
                    VatRate = 8,
                    CreatedDate = new DateTime(2025, 1, 1)
                },
                new Product
                {
                    Id = 5,
                    BarcodeNo = "000002",
                    Name = "OE 688 PASSAT YAĞ B7",
                    StockCode = "OE-688",
                    ProductGroupId = 2,
                    PurchasePrice = 100.00m,
                    SalePrice = 150.00m,
                    CurrentStock = 0,
                    MinimumStock = 30,
                    VatRate = 18,
                    CreatedDate = new DateTime(2025, 1, 1)
                }
            );

            // Seed sample Wholesalers
            modelBuilder.Entity<Wholesaler>().HasData(
                new Wholesaler
                {
                    Id = 1,
                    Name = "ATS FİLTRE İSTANBUL",
                    ContactPerson = "Ahmet Yılmaz",
                    BusinessPhone = "0212 123 45 67",
                    Email = "info@atsfiltre.com",
                    Address = "İstanbul",
                    TaxOffice = "Kadıköy",
                    TaxNumber = "1234567890",
                    Debt = 0.00m,
                    CreatedDate = new DateTime(2025, 1, 1)
                },
                new Wholesaler
                {
                    Id = 2,
                    Name = "LEVENT TİCARET",
                    ContactPerson = "Mehmet Kaya",
                    BusinessPhone = "0212 987 65 43",
                    Email = "info@leventticaret.com",
                    Address = "İstanbul",
                    TaxOffice = "Şişli",
                    TaxNumber = "0987654321",
                    Debt = 114.70m,
                    CreatedDate = new DateTime(2025, 1, 1)
                }
            );
        }
    }
}
