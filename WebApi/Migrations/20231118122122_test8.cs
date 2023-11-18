using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class test8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                columns: new[] { "CommentDate", "CustomerID" },
                values: new object[] { new DateTime(2023, 11, 18, 15, 21, 22, 659, DateTimeKind.Local).AddTicks(170), 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                columns: new[] { "CommentDate", "CustomerID" },
                values: new object[] { new DateTime(2023, 11, 18, 15, 20, 42, 957, DateTimeKind.Local).AddTicks(8450), 2 });
        }
    }
}
