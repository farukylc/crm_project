using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class test1234567 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 18, 1, 20, 261, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 18, 1, 20, 261, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 18, 1, 20, 261, DateTimeKind.Local).AddTicks(7660));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 17, 58, 52, 667, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 17, 58, 52, 667, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 17, 58, 52, 667, DateTimeKind.Local).AddTicks(2820));
        }
    }
}
