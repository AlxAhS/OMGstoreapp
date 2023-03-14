using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Invoices.DAL.Models;
using Microsoft.Identity.Client;
//using Invoices.API.Controllers.ProductController;

namespace OMGSupplyStoreApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
            public DbSet<Product> Products { get; set; }    
    }
}