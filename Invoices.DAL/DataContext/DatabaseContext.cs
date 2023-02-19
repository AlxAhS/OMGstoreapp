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


		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Client>().HasData(
				new Client
				{
					ID = 1,
					Name = "Juan",
					IdType = "CC",
					IDNumber = "232131",
					Email = "juan@gmail.com",
					PhoneNumber = "0644445532"
				},

				new Client
				{
					ID = 2,
					Name = "Pedro",
					IdType = "CC",
					IDNumber = "45423498",
					Email = "pedro@gmail.com",
					PhoneNumber = "06432324884"
				},

				new Client
				{
					ID = 3,
					Name = "Alberto",
					IdType = "CE",
					IDNumber = "2349895-2",
					Email = "alberto@gmail.com",
					PhoneNumber = "3117758739"
				}
				);

			builder.Entity<Invoice>().HasData(
				new Invoice
				{
					ID = 1,
					Date = DateTime.UtcNow,
					Serial = "234234342"
				},

				new Invoice
				{
					ID = 2,
					Date = DateTime.UtcNow,
					Serial = "3423432422"
				},

				new Invoice
				{
					ID = 3,
					Date = DateTime.UtcNow,
					Serial = "878342223"
				}
				);

			builder.Entity<Product>().HasData(
				new Product
				{
					ID = 1,
					Name = "Cellphone",
					Price = 450000
				},

				new Product
				{
					ID = 2,
					Name = "PlayStation 4",
					Price = 2000000
				},

				new Product
				{
					ID = 3,
					Name = "Laptop",
					Price = 3000000
				}

				);

			builder.Entity<StoreInfo>().HasData(
				new StoreInfo
				{
					ID = 1,
					NIT = "98712311-3",
					OwnerName = "Jhon Smith",
					Address = "Av Siempre Viva 123",
					City = "Springfield",
					State = "Columbia",
					Phone = "3134435498",
					AccountNumber = "4560393234289"
				}

				);

		}





	}
}
