using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class test123450 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 11, 21, 22, 35, 57, 513, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 11, 21, 22, 35, 57, 513, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 11, 21, 22, 35, 57, 513, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4,
                column: "CommentDate",
                value: new DateTime(2023, 11, 21, 22, 35, 57, 513, DateTimeKind.Local).AddTicks(3960));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 11, 21, 21, 33, 30, 639, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 11, 21, 21, 33, 30, 639, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 11, 21, 21, 33, 30, 639, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4,
                column: "CommentDate",
                value: new DateTime(2023, 11, 21, 21, 33, 30, 639, DateTimeKind.Local).AddTicks(6030));
        }
    }
}
