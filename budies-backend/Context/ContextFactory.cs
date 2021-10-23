using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace budies_backend.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<BudiesDBContext>, IContextFactory
    {
        private readonly string connectionString;
        public ContextFactory()
        {
            string path = Directory.GetCurrentDirectory();

            IConfigurationBuilder builder =
                new ConfigurationBuilder()
                    .SetBasePath(path)
                    .AddJsonFile("appsettings.json");

            IConfigurationRoot config = builder.Build();

            connectionString = config.GetConnectionString("SQLCONNSTR_Database");

        }
        public ContextFactory(string connectionString)
        {
            this.connectionString = connectionString;

            var options = new DbContextOptionsBuilder<BudiesDBContext>();
            options.UseSqlServer(connectionString);
        }

        public BudiesDBContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<BudiesDBContext>();
            options.UseSqlServer(connectionString);

            return new BudiesDBContext(options.Options);
        }
    }
}
