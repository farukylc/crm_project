using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class ıhopethisworks1222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                columns: new[] { "CommentDate", "CustomerID" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 12, 56, 707, DateTimeKind.Local).AddTicks(3850), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                columns: new[] { "CommentDate", "CustomerID" },
                values: new object[] { new DateTime(2023, 11, 18, 15, 56, 5, 895, DateTimeKind.Local).AddTicks(6000), 0 });
        }
    }
}
