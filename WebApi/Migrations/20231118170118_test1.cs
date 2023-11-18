using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 20, 1, 18, 274, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 20, 1, 18, 274, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 20, 1, 18, 274, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 20, 1, 18, 274, DateTimeKind.Local).AddTicks(5600));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 19, 21, 45, 193, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 19, 21, 45, 193, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 19, 21, 45, 193, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 19, 21, 45, 193, DateTimeKind.Local).AddTicks(1680));
        }
    }
}
