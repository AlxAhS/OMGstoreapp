﻿// <auto-generated />
using System;
using DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Invoices.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Invoices.DAL.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("IDNumber")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("IdType")
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("ID");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Email = "juan@gmail.com",
                            IDNumber = "232131",
                            IdType = "CC",
                            Name = "Juan",
                            PhoneNumber = "0644445532"
                        },
                        new
                        {
                            ID = 2,
                            Email = "pedro@gmail.com",
                            IDNumber = "45423498",
                            IdType = "CC",
                            Name = "Pedro",
                            PhoneNumber = "06432324884"
                        },
                        new
                        {
                            ID = 3,
                            Email = "alberto@gmail.com",
                            IDNumber = "2349895-2",
                            IdType = "CE",
                            Name = "Alberto",
                            PhoneNumber = "3117758739"
                        });
                });

            modelBuilder.Entity("Invoices.DAL.Models.Invoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Serial")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("Invoices");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Date = "2023-03-07 21:47:23.42321",
                            Serial = "234234342"
                        },
                        new
                        {
                            ID = 2,
                            Date = "2023-03-07 21:47:23.4232103",
                            Serial = "3423432422"
                        },
                        new
                        {
                            ID = 3,
                            Date = "2023-03-07 21:47:23.4232106",
                            Serial = "878342223"
                        });
                });

            modelBuilder.Entity("Invoices.DAL.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Cellphone",
                            Price = 450000
                        },
                        new
                        {
                            ID = 2,
                            Name = "PlayStation 4",
                            Price = 2000000
                        },
                        new
                        {
                            ID = 3,
                            Name = "Laptop",
                            Price = 3000000
                        });
                });

            modelBuilder.Entity("Invoices.DAL.Models.StoreInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("NIT")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("OwnerName")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("StoreInfo");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AccountNumber = "4560393234289",
                            Address = "Av Siempre Viva 123",
                            City = "Springfield",
                            NIT = "98712311-3",
                            OwnerName = "Jhon Smith",
                            Phone = "3134435498",
                            State = "Columbia"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
