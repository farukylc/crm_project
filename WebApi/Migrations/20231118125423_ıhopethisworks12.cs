using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class ıhopethisworks12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Customers_CustomerIDP",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CustomerIDP",
                table: "Comments",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_CustomerIDP",
                table: "Comments",
                newName: "IX_Comments_CustomerID");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                columns: new[] { "CommentDate", "CustomerID" },
                values: new object[] { new DateTime(2023, 11, 18, 15, 54, 23, 511, DateTimeKind.Local).AddTicks(8120), 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Customers_CustomerID",
                table: "Comments",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Customers_CustomerID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Comments",
                newName: "CustomerIDP");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_CustomerID",
                table: "Comments",
                newName: "IX_Comments_CustomerIDP");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                columns: new[] { "CommentDate", "CustomerIDP" },
                values: new object[] { new DateTime(2023, 11, 18, 15, 50, 16, 616, DateTimeKind.Local).AddTicks(6560), 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Customers_CustomerIDP",
                table: "Comments",
                column: "CustomerIDP",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
