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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ProductGroup configuration
            modelBuilder.Entity<ProductGroup>(entity =>
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
                      .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(sm => sm.SalesReceipt)
                      .WithMany()
                      .HasForeignKey(sm => sm.SalesReceiptId)
                      .OnDelete(DeleteBehavior.SetNull);
            });

            // CashMovement configuration
            modelBuilder.Entity<CashMovement>(entity =>
            {
                entity.HasOne(cm => cm.SalesReceipt)
                      .WithMany()
                      .HasForeignKey(cm => cm.SalesReceiptId)
                      .OnDelete(DeleteBehavior.SetNull);
            });

            // CustomerDebtMovement configuration
            modelBuilder.Entity<CustomerDebtMovement>(entity =>
            {
                entity.HasOne(cdm => cdm.Customer)
                      .WithMany(c => c.DebtMovements)
                      .HasForeignKey(cdm => cdm.CustomerId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(cdm => cdm.SalesReceipt)
                      .WithMany()
                      .HasForeignKey(cdm => cdm.SalesReceiptId)
                      .OnDelete(DeleteBehavior.SetNull);
            });

            // WholesalerDebtMovement configuration
            modelBuilder.Entity<WholesalerDebtMovement>(entity =>
            {
                entity.HasOne(wdm => wdm.Wholesaler)
                      .WithMany(w => w.DebtMovements)
                      .HasForeignKey(wdm => wdm.WholesalerId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Seed data
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed ProductGroups
            modelBuilder.Entity<ProductGroup>().HasData(
                new ProductGroup { Id = 1, Name = "BİSKÜVİ", Description = "Bisküvi ürünleri" },
                new ProductGroup { Id = 2, Name = "FİLTRE", Description = "Filtre ürünleri" },
                new ProductGroup { Id = 3, Name = "SALÇA", Description = "Salça ürünleri" },
                new ProductGroup { Id = 4, Name = "YAĞ", Description = "Yağ ürünleri" },
                new ProductGroup { Id = 5, Name = "DETERJAN", Description = "Deterjan ürünleri" },
                new ProductGroup { Id = 6, Name = "SÜT ÜRÜNLERİ", Description = "Süt ürünleri" },
                new ProductGroup { Id = 7, Name = "İÇECEK", Description = "İçecek ürünleri" },
                new ProductGroup { Id = 8, Name = "KREMA", Description = "Krema ürünleri" }
            );

            // Seed sample Products
            modelBuilder.Entity<Product>().HasData(
                new Product 
                { 
                    Id = 1, 
                    BarcodeNo = "8690511010128", 
                    Name = "ABC ÇAMAŞIR SUYU 4000 ML", 
                    StockCode = "ABC-4000", 
                    ProductGroupId = 5,
                    PurchasePrice = 70.00m, 
                    SalePrice = 90.00m, 
                    CurrentStock = 12, 
                    MinimumStock = 2,
                    VatRate = 18
                },
                new Product 
                { 
                    Id = 2, 
                    BarcodeNo = "8690504034506", 
                    Name = "ÜLKER ALBENİ 35 GR", 
                    StockCode = "ULK-ALB", 
                    ProductGroupId = 1,
                    PurchasePrice = 7.00m, 
                    SalePrice = 10.00m, 
                    CurrentStock = 4, 
                    MinimumStock = 4,
                    VatRate = 8
                },
                new Product 
                { 
                    Id = 3, 
                    BarcodeNo = "8690876010016", 
                    Name = "YUDUM 1 LT SIVI YAĞ", 
                    StockCode = "YUD-1LT", 
                    ProductGroupId = 4,
                    PurchasePrice = 55.00m, 
                    SalePrice = 75.00m, 
                    CurrentStock = 3, 
                    MinimumStock = 1,
                    VatRate = 8
                },
                new Product 
                { 
                    Id = 4, 
                    BarcodeNo = "8690575012519", 
                    Name = "TAMEK DOMATES SALÇASI 830 GR", 
                    StockCode = "TAM-830", 
                    ProductGroupId = 3,
                    PurchasePrice = 45.00m, 
                    SalePrice = 60.00m, 
                    CurrentStock = 7, 
                    MinimumStock = 1,
                    VatRate = 8
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
                    VatRate = 18
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
                    Debt = 0.00m
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
                    Debt = 114.70m
                }
            );
        }
    }
}
