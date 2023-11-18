using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class test123456 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                columns: new[] { "CommentDate", "ProductID" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 58, 52, 667, DateTimeKind.Local).AddTicks(2800), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                columns: new[] { "CommentDate", "ProductID" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 58, 52, 667, DateTimeKind.Local).AddTicks(2820), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                columns: new[] { "CommentDate", "ProductID" },
                values: new object[] { new DateTime(2023, 11, 18, 17, 58, 52, 667, DateTimeKind.Local).AddTicks(2820), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductID",
                table: "Comments",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Products_ProductID",
                table: "Comments",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Products_ProductID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ProductID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 17, 2, 5, 155, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 17, 2, 5, 155, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 17, 2, 5, 155, DateTimeKind.Local).AddTicks(7090));
        }
    }
}
