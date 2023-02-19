using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Invoices.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ID", "Email", "IDNumber", "IdType", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "juan@gmail.com", "232131", "CC", "Juan", "0644445532" },
                    { 2, "pedro@gmail.com", "45423498", "CC", "Pedro", "06432324884" },
                    { 3, "alberto@gmail.com", "2349895-2", "CE", "Alberto", "3117758739" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "ID", "Date", "Serial" },
                values: new object[,]
                {
                    { 1, "2023-02-19 16:58:43.2661354", "234234342" },
                    { 2, "2023-02-19 16:58:43.2661358", "3423432422" },
                    { 3, "2023-02-19 16:58:43.2661361", "878342223" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Cellphone", 450000 },
                    { 2, "PlayStation 4", 2000000 },
                    { 3, "Laptop", 3000000 }
                });

            migrationBuilder.InsertData(
                table: "StoreInfo",
                columns: new[] { "ID", "AccountNumber", "Address", "City", "NIT", "OwnerName", "Phone", "State" },
                values: new object[] { 1, "4560393234289", "Av Siempre Viva 123", "Springfield", "98712311-3", "Jhon Smith", "3134435498", "Columbia" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StoreInfo",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
