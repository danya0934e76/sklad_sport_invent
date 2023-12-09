using Microsoft.EntityFrameworkCore;
using sklad_sport_invent.Context.Contacts;

namespace sklad_sport_invent.Context
{
    public class SkladContext : DbContext , IContext 
    {
        /// <summary>
        /// 
        /// </summary>
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
