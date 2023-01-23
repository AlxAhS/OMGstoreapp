using Microsoft.EntityFrameworkCore;
using DAL.DataContext;
using Invoices.DAL.Repo;
using Invoices.DAL.Models;
using Invoices.DAL.Interfaces;
using System.Configuration;
using Microsoft.Build.Framework;
using Invoices.API;
using Microsoft.AspNetCore.HttpOverrides;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddServices(builder.Configuration);
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        //app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
        //var builder = WebApplication.CreateBuilder(args);

        //builder.Services.AddCors(options =>

        //options.AddPolicy(name: "corsApp", policy =>
        //{
        //    policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
        //}));


        //// Add services to the container.

        //builder.Services.AddControllers();
        ////delete later
        ////builder.Services.Configure<ForwardedHeadersOptions>(options =>
        ////{
        ////    options.ForwardedHeaders =
        ////        ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
        ////});

        //// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


        //builder.Services.AddServices(builder.Configuration);


        //builder.Services.AddEndpointsApiExplorer();
        //builder.Services.AddSwaggerGen();

        //var app = builder.Build();

        //// Configure the HTTP request pipeline.
        //if (app.Environment.IsDevelopment())
        //{
        //    app.UseSwagger();
        //    app.UseSwaggerUI();
        //}



        //app.UseHttpsRedirection();
        //app.UseStaticFiles();
        //app.UseRouting();

        ////app cors
        //app.UseCors("corsApp");



        //app.UseAuthorization();

        //app.MapControllers();

        //app.Run();
    }
}