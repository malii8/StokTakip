using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using StokTakip.Data;

namespace StokTakip
{
    public class StokTakipDbContextFactory : IDesignTimeDbContextFactory<StokTakipDbContext>
    {
        public StokTakipDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StokTakipDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StokTakipDb;Trusted_Connection=true;");

            return new StokTakipDbContext(optionsBuilder.Options);
        }
    }
}
