﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Repositories;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20231118150120_test1234567")]
    partial class test1234567
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApi.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentID"), 1L, 1);

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductID");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            CommentID = 1,
                            CommentDate = new DateTime(2023, 11, 18, 18, 1, 20, 261, DateTimeKind.Local).AddTicks(7630),
                            CustomerID = 1,
                            ProductID = 1,
                            Text = "Kamera kalitesi muazzam! Gece çekimleri gerçekten etkileyici."
                        },
                        new
                        {
                            CommentID = 2,
                            CommentDate = new DateTime(2023, 11, 18, 18, 1, 20, 261, DateTimeKind.Local).AddTicks(7660),
                            CustomerID = 2,
                            ProductID = 1,
                            Text = "ben 2"
                        },
                        new
                        {
                            CommentID = 3,
                            CommentDate = new DateTime(2023, 11, 18, 18, 1, 20, 261, DateTimeKind.Local).AddTicks(7660),
                            CustomerID = 3,
                            ProductID = 1,
                            Text = "ben 3"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            Address = "Beşiktaş",
                            DateOfBirth = new DateTime(1988, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ayse.demir@gmail.com",
                            Name = "Ayşe",
                            PhoneNumber = "5559876543",
                            Surname = "Demir"
                        },
                        new
                        {
                            CustomerID = 2,
                            Address = "Beyoğlu",
                            DateOfBirth = new DateTime(1992, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mehmet.aydin@gmail.com",
                            Name = "Mehmet",
                            PhoneNumber = "5557890123",
                            Surname = "Aydın"
                        },
                        new
                        {
                            CustomerID = 3,
                            Address = "Üsküdar",
                            DateOfBirth = new DateTime(1990, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "aliveli@gmail.com",
                            Name = "Ali",
                            PhoneNumber = "555131231",
                            Surname = "Veli"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SalesAmount")
                        .HasColumnType("int");

                    b.Property<float>("Stars")
                        .HasColumnType("real");

                    b.Property<string>("imgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            Price = 50,
                            ProductName = "IPhone 13",
                            SalesAmount = 20,
                            Stars = 4.7f,
                            imgUrl = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/apple/thumb/129743-1_large.jpg"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Comment", b =>
                {
                    b.HasOne("WebApi.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebApi.Models.Product", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
