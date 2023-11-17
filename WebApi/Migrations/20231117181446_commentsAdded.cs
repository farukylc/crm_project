using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class commentsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11);

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentID", "CommentDate", "CustomerID", "ProductID", "Text" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5050), 2, 1, "Şarj ömrü beni şaşırttı. Bir günü rahatlıkla çıkarıyor." },
                    { 10, new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5070), 10, 1, "Harika bir alışveriş deneyimi yaşadım. Teşekkürler Apple!" }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "Email", "PhoneNumber", "Surname" },
                values: new object[] { new DateTime(1992, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.kaya@gmail.com", "5553344556", "Kaya" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { "Maltepe", new DateTime(1991, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "elif.aksoy@gmail.com", "Elif", "5558899001", "Aksoy" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 1, "Kadıköy", new DateTime(1985, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmet.yilmaz@gmail.com", "Ahmet", "5551112233", "Yılmaz" },
                    { 3, "Üsküdar", new DateTime(1988, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.yildiz@gmail.com", "Mehmet", "5555678899", "Yıldız" },
                    { 4, "Şişli", new DateTime(1995, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeynep.demir@gmail.com", "Zeynep", "5554455667", "Demir" },
                    { 5, "Beyoğlu", new DateTime(1990, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.veli@gmail.com", "Ali", "5552233445", "Veli" },
                    { 6, "Bağcılar", new DateTime(1987, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.aydin@gmail.com", "Fatma", "5559988776", "Aydın" },
                    { 7, "Gaziosmanpaşa", new DateTime(1993, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "osman.kurt@gmail.com", "Osman", "5551122334", "Kurt" },
                    { 8, "Esenler", new DateTime(1989, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "seda.arslan@gmail.com", "Seda", "5553344556", "Arslan" },
                    { 9, "Bakırköy", new DateTime(1996, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "kaan.ergin@gmail.com", "Kaan", "5555566778", "Ergin" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentID", "CommentDate", "CustomerID", "ProductID", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5020), 1, 1, "Kamera kalitesi muazzam! Gece çekimleri gerçekten etkileyici." },
                    { 3, new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5060), 3, 1, "İnanılmaz hızlı! A14 Bionic işlemci performansı harika." },
                    { 4, new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5060), 4, 1, "Ekran renkleri çok canlı, True Tone özelliği harika bir görüntü sağlıyor." },
                    { 5, new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5060), 5, 1, "5G desteğiyle internet hızları fırlamış durumda. Harika bir deneyim!" },
                    { 6, new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5060), 6, 1, "Tasarımı çok şık ve kullanımı çok rahat. Elde harika bir his bırakıyor." },
                    { 7, new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5060), 7, 1, "iOS 15 ile gelen yeni özellikler harika! Widget'lar çok kullanışlı." },
                    { 8, new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5060), 8, 1, "Face ID çok hızlı ve güvenilir. Şifre girmeye artık gerek yok!" },
                    { 9, new DateTime(2023, 11, 17, 21, 14, 46, 23, DateTimeKind.Local).AddTicks(5070), 9, 1, "Dayanıklılık konusunda bir numara! Su ve toza karşı çok iyi korunuyor." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "Email", "PhoneNumber", "Surname" },
                values: new object[] { new DateTime(1988, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.demir@gmail.com", "5559876543", "Demir" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { "Beyoğlu", new DateTime(1992, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.aydin@gmail.com", "Mehmet", "5557890123", "Aydın" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 11, "Üsküdar", new DateTime(1990, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "aliveli@gmail.com", "Ali", "555131231", "Veli" });
        }
    }
}
