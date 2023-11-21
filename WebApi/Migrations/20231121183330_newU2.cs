using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class newU2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CommentDate", "ProductID", "Text" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 33, 30, 639, DateTimeKind.Local).AddTicks(6030), 2, "Harika bir bilgisayar!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CommentDate", "ProductID", "Text" },
                values: new object[] { new DateTime(2023, 11, 20, 19, 20, 28, 663, DateTimeKind.Local).AddTicks(4460), 1, "ben 3" });
        }
    }
}
