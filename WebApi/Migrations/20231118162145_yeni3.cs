using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class yeni3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 18, 11, 34, 798, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 18, 11, 34, 798, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 18, 11, 34, 798, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 18, 11, 34, 798, DateTimeKind.Local).AddTicks(8540));
        }
    }
}
