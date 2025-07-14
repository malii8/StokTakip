using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StokTakip.Data;
using StokTakip.Forms;
using System;
using System.Windows.Forms;

namespace StokTakip
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create service collection and configure services
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Build service provider
            var serviceProvider = services.BuildServiceProvider();

            // Initialize database
            InitializeDatabase(serviceProvider);

            // Run the application with dependency injection
            var mainForm = serviceProvider.GetRequiredService<AnaForm>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Add Entity Framework
            services.AddDbContext<StokTakipDbContext>(options =>
                options.UseSqlServer(GetConnectionString()));

            // Add forms as services
            services.AddTransient<AnaForm>();
            services.AddTransient<StoklarForm>();
            services.AddTransient<SatisIslemiForm>();
            services.AddTransient<ToptanciKayitForm>();
            services.AddTransient<MusterilerForm>();
            services.AddTransient<KasaForm>();
            services.AddTransient<RaporlarForm>();
        }

        private static string GetConnectionString()
        {
            // For development, use LocalDB. In production, this should come from configuration
            return @"Server=(localdb)\mssqllocaldb;Database=StokTakipDb;Trusted_Connection=true;MultipleActiveResultSets=true";
        }

        private static void InitializeDatabase(ServiceProvider serviceProvider)
        {
            try
            {
                using var scope = serviceProvider.CreateScope();
                var context = scope.ServiceProvider.GetRequiredService<StokTakipDbContext>();
                
                // Ensure database is created
                context.Database.EnsureCreated();
                
                // Run pending migrations
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı bağlantısı kurulamadı: {ex.Message}", "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
