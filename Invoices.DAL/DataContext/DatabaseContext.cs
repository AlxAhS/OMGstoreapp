using DAL.Models;
using Invoices.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataContext
{ 
    public class DatabaseContext : DbContext
    {
        public class OptionsBuild
        {
            public OptionsBuild() 
            {
                settings = new AppConfiguration();
                opsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                opsBuilder.UseSqlServer(settings.sqlConnectionString);
                dbOptions = opsBuilder.Options;
            }

            public DbContextOptionsBuilder<DatabaseContext> opsBuilder { get; set; }
            public DbContextOptions<DatabaseContext> dbOptions { get; set; }
            private AppConfiguration settings { get; set; }

        }
        public static OptionsBuild ops = new OptionsBuild();


        public DatabaseContext(DbContextOptions<DatabaseContext>options): base(options) {  }
        public DbSet<Client> ClientMod { get; set; }
        public DbSet<Invoice> InvoiceMod { get; set; }
        public DbSet<Product> ProductMod { get; set; }

    }
}
