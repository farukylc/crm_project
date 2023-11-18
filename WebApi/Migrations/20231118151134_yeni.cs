using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class yeni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CommentDate", "CustomerID", "Text" },
                values: new object[] { new DateTime(2023, 11, 18, 18, 11, 34, 798, DateTimeKind.Local).AddTicks(8540), 1, "İyi telefon" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                columns: new[] { "CommentDate", "CustomerID", "Text" },
                values: new object[] { new DateTime(2023, 11, 18, 18, 11, 34, 798, DateTimeKind.Local).AddTicks(8540), 2, "iPhone 13'ü bir süredir kullanıyorum ve gerçekten etkileyici bir deneyim sunuyor. Öncelikle, kamerasının performansı beni büyüledi. Gelişmiş gece modu sayesinde düşük ışıkta bile muhteşem fotoğraflar çekebiliyorum. Ayrıca, ekran kalitesi gerçekten harika; renkler canlı ve parlak, video izlemek ve oyun oynamak gerçekten keyifli." });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentID", "CommentDate", "CustomerID", "ProductID", "Text" },
                values: new object[] { 4, new DateTime(2023, 11, 18, 18, 11, 34, 798, DateTimeKind.Local).AddTicks(8540), 3, 1, "ben 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4);

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
                columns: new[] { "CommentDate", "CustomerID", "Text" },
                values: new object[] { new DateTime(2023, 11, 18, 18, 1, 20, 261, DateTimeKind.Local).AddTicks(7660), 2, "ben 2" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                columns: new[] { "CommentDate", "CustomerID", "Text" },
                values: new object[] { new DateTime(2023, 11, 18, 18, 1, 20, 261, DateTimeKind.Local).AddTicks(7660), 3, "ben 3" });
        }
    }
}
