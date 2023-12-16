using Microsoft.EntityFrameworkCore;
using sklad_sport_invent.Context.Contacts;

namespace sklad_sport_invent.Context
{
    public class SkladContext : DbContext , IContext 
    {
        /// <summary>
        /// Контекст работы с БД
        /// </summary>
        /// <remarks>
        /// 1) dotnet tool install --global dotnet-ef
        /// 2) dotnet tool update --global dotnet-ef
        /// 3) dotnet ef migrations add [name] --project TimeTable207.Context\TimeTable207.Context.csproj
        /// 4) dotnet ef database update --project TimeTable207.Context\TimeTable207.Context.csproj
        /// </remarks>
        public SkladContext(DbContextOptions<SkladContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Nakladnaya> Nakladnaya { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

       
        
    }
}
