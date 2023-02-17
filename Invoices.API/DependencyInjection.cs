using DAL.DataContext;
using Invoices.DAL.Interfaces;
using Invoices.DAL.Models;
using Invoices.DAL.Repo;
using Microsoft.EntityFrameworkCore;

namespace Invoices.API
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration) 
        {
            //services.AddScoped<IRepository<Product>, Repository<Product>>();
            services.AddScoped(typeof(IRepositoryAsync<Product>), typeof(RepositoryAsync<Product>));
            services.AddScoped(typeof(IRepositoryAsync<Client>), typeof(RepositoryAsync<Client>));
            services.AddScoped(typeof(IRepositoryAsync<Invoice>), typeof(RepositoryAsync<Invoice>));
            services.AddScoped(typeof(IRepositoryAsync<StoreInfo>), typeof(RepositoryAsync<StoreInfo>));
            services.AddDbContext<DatabaseContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
