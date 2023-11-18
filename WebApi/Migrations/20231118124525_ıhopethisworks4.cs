using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class ıhopethisworks4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 15, 45, 25, 446, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Customers_CustomerIDP",
                table: "Comments",
                column: "CustomerIDP",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "CommentDate",
                value: new DateTime(2023, 11, 18, 15, 33, 10, 782, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Customers_CustomerID",
                table: "Comments",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
