using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class test99 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 5,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 6,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 7,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 8,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 9,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 10,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8640));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4,
                column: "CommentDate",
                value: new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 5,
                column: "CommentDate",
                value: new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 6,
                column: "CommentDate",
                value: new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 7,
                column: "CommentDate",
                value: new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 8,
                column: "CommentDate",
                value: new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 9,
                column: "CommentDate",
                value: new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 10,
                column: "CommentDate",
                value: new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5070));
        }
    }
}
