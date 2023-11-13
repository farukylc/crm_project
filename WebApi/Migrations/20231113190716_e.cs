using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class e : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 11, "Üsküdar", new DateTime(1990, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "aliveli@gmail.com", "Ali", "555131231", "Veli" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11);
        }
    }
}
