using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class ıhopethisworks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                columns: new[] { "CommentDate", "CustomerID" },
                values: new object[] { new DateTime(2023, 11, 18, 15, 30, 11, 270, DateTimeKind.Local).AddTicks(3620), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                columns: new[] { "CommentDate", "CustomerID" },
                values: new object[] { new DateTime(2023, 11, 18, 15, 21, 22, 659, DateTimeKind.Local).AddTicks(170), 0 });
        }
    }
}
