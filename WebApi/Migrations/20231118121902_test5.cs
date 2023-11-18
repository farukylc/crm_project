﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                columns: new[] { "CommentDate", "CustomerID" },
                values: new object[] { new DateTime(2023, 11, 18, 15, 19, 2, 464, DateTimeKind.Local).AddTicks(4280), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                columns: new[] { "CommentDate", "CustomerID" },
                values: new object[] { new DateTime(2023, 11, 18, 15, 17, 26, 650, DateTimeKind.Local).AddTicks(2100), 123 });
        }
    }
}
