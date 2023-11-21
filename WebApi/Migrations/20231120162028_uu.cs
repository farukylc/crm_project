using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class uu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 11, 20, 19, 20, 28, 663, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 11, 20, 19, 20, 28, 663, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 11, 20, 19, 20, 28, 663, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4,
                column: "CommentDate",
                value: new DateTime(2023, 11, 20, 19, 20, 28, 663, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Price",
                value: 38000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 11, 19, 20, 45, 42, 391, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 11, 19, 20, 45, 42, 391, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 11, 19, 20, 45, 42, 391, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4,
                column: "CommentDate",
                value: new DateTime(2023, 11, 19, 20, 45, 42, 391, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Price",
                value: 50);
        }
    }
}
