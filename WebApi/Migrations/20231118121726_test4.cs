using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11);

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentID", "CommentDate", "CustomerID", "Text" },
                values: new object[] { 1, new DateTime(2023, 11, 18, 15, 17, 26, 650, DateTimeKind.Local).AddTicks(2100), 123, "Kamera kalitesi muazzam! Gece çekimleri gerçekten etkileyici." });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { "Beyoğlu", new DateTime(1992, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.aydin@gmail.com", "Mehmet", "5557890123", "Aydın" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 1, "Beşiktaş", new DateTime(1988, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.demir@gmail.com", "Ayşe", "5559876543", "Demir" },
                    { 3, "Üsküdar", new DateTime(1990, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "aliveli@gmail.com", "Ali", "555131231", "Veli" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { "Beşiktaş", new DateTime(1988, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.demir@gmail.com", "Ayşe", "5559876543", "Demir" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 10, "Beyoğlu", new DateTime(1992, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.aydin@gmail.com", "Mehmet", "5557890123", "Aydın" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 11, "Üsküdar", new DateTime(1990, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "aliveli@gmail.com", "Ali", "555131231", "Veli" });
        }
    }
}
