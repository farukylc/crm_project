using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class newmigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 2, "Beşiktaş", new DateTime(1988, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.demir@gmail.com", "Ayşe", "5559876543", "Demir" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 10, "Beyoğlu", new DateTime(1992, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.aydin@gmail.com", "Mehmet", "5557890123", "Aydın" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 11, "Üsküdar", new DateTime(1990, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "aliveli@gmail.com", "Ali", "555131231", "Veli" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
