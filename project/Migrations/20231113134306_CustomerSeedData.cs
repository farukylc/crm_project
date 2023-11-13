using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project.Migrations
{
    public partial class CustomerSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 1, "Kadıköy", new DateTime(1995, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmet.yilmaz@gmail.com", "Ahmet", "5551234567", "Yılmaz" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 2, "Beşiktaş", new DateTime(1988, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.demir@gmail.com", "Ayşe", "5559876543", "Demir" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 10, "Beyoğlu", new DateTime(1992, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.aydin@gmail.com", "Mehmet", "5557890123", "Aydın" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10);
        }
    }
}
