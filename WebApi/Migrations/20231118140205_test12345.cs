using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class test12345 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Stars = table.Column<float>(type: "real", nullable: false),
                    SalesAmount = table.Column<int>(type: "int", nullable: false),
                    imgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "DateOfBirth", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 1, "Beşiktaş", new DateTime(1988, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.demir@gmail.com", "Ayşe", "5559876543", "Demir" },
                    { 2, "Beyoğlu", new DateTime(1992, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.aydin@gmail.com", "Mehmet", "5557890123", "Aydın" },
                    { 3, "Üsküdar", new DateTime(1990, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "aliveli@gmail.com", "Ali", "555131231", "Veli" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Price", "ProductName", "SalesAmount", "Stars", "imgUrl" },
                values: new object[] { 1, 50, "IPhone 13", 20, 4.7f, "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/apple/thumb/129743-1_large.jpg" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentID", "CommentDate", "CustomerID", "Text" },
                values: new object[] { 1, new DateTime(2023, 11, 18, 17, 2, 5, 155, DateTimeKind.Local).AddTicks(7060), 1, "Kamera kalitesi muazzam! Gece çekimleri gerçekten etkileyici." });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentID", "CommentDate", "CustomerID", "Text" },
                values: new object[] { 2, new DateTime(2023, 11, 18, 17, 2, 5, 155, DateTimeKind.Local).AddTicks(7080), 2, "ben 2" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentID", "CommentDate", "CustomerID", "Text" },
                values: new object[] { 3, new DateTime(2023, 11, 18, 17, 2, 5, 155, DateTimeKind.Local).AddTicks(7090), 3, "ben 3" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CustomerID",
                table: "Comments",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
