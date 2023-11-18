using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class ıhopethisworks6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                columns: new[] { "CommentDate", "CustomerIDP" },
                values: new object[] { new DateTime(2023, 11, 18, 15, 46, 27, 873, DateTimeKind.Local).AddTicks(3130), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                columns: new[] { "CommentDate", "CustomerIDP" },
                values: new object[] { new DateTime(2023, 11, 18, 15, 45, 25, 446, DateTimeKind.Local).AddTicks(9450), 0 });
        }
    }
}
