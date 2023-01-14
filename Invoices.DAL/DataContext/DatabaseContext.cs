using Invoices.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataContext
{

    public class DatabaseContext : DbContext
    {

       

        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        { 
        
        }
              

        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StoreInfo> StoreInfo { get; set; }
    
    }
}
