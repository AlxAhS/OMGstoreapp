using Microsoft.EntityFrameworkCore;
using DAL.DataContext;
using Invoices.API.Data;
using Invoices.API.Data.Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


        //AlxAhS: this is for use Repository ... if we have any error please DELETE. Thanks
        builder.Services.AddScoped<InterfaceClient, ClientRepository>();
        builder.Services.AddScoped<InterfaceInvoice, InvoiceRepository>();
        builder.Services.AddScoped<InterfaceProduct, ProductRepository>();


        //Configure SQL server
        builder.Services.AddDbContext<DatabaseContext>
            (
            options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            }
            );

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}