using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklad_sport_invent.Context
{
    internal class DesignSkladFactory
    {
        internal class DesignTimeFactory : IDesignTimeDbContextFactory<SkladContext>
        {
            public SkladContext CreateDbContext(string[] args)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appseting1.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");

                var options = new DbContextOptionsBuilder<SkladContext>()
                    .UseSqlServer(connectionString)
                    .Options;

                return new SkladContext(options);
            }
        }
    }
}
