﻿// <auto-generated />
using System;
using DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Invoices.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230217222940_datetimeUTC")]
    partial class datetimeUTC
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
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
                });
#pragma warning restore 612, 618
        }
    }
}