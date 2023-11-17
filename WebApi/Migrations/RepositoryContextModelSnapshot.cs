﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Repositories;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CommentDate = new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8600),
                            CustomerID = 1,
                            ProductID = 1,
                            Text = "Kamera kalitesi muazzam! Gece çekimleri gerçekten etkileyici."
                        },
                        new
                        {
                            CommentID = 2,
                            CommentDate = new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8630),
                            CustomerID = 2,
                            ProductID = 1,
                            Text = "Şarj ömrü beni şaşırttı. Bir günü rahatlıkla çıkarıyor."
                        },
                        new
                        {
                            CommentID = 3,
                            CommentDate = new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8630),
                            CustomerID = 3,
                            ProductID = 1,
                            Text = "İnanılmaz hızlı! A14 Bionic işlemci performansı harika."
                        },
                        new
                        {
                            CommentID = 4,
                            CommentDate = new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8630),
                            CustomerID = 4,
                            ProductID = 1,
                            Text = "Ekran renkleri çok canlı, True Tone özelliği harika bir görüntü sağlıyor."
                        },
                        new
                        {
                            CommentID = 5,
                            CommentDate = new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8630),
                            CustomerID = 5,
                            ProductID = 1,
                            Text = "5G desteğiyle internet hızları fırlamış durumda. Harika bir deneyim!"
                        },
                        new
                        {
                            CommentID = 6,
                            CommentDate = new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8640),
                            CustomerID = 6,
                            ProductID = 1,
                            Text = "Tasarımı çok şık ve kullanımı çok rahat. Elde harika bir his bırakıyor."
                        },
                        new
                        {
                            CommentID = 7,
                            CommentDate = new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8640),
                            CustomerID = 7,
                            ProductID = 1,
                            Text = "iOS 15 ile gelen yeni özellikler harika! Widget'lar çok kullanışlı."
                        },
                        new
                        {
                            CommentID = 8,
                            CommentDate = new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8640),
                            CustomerID = 8,
                            ProductID = 1,
                            Text = "Face ID çok hızlı ve güvenilir. Şifre girmeye artık gerek yok!"
                        },
                        new
                        {
                            CommentID = 9,
                            CommentDate = new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8640),
                            CustomerID = 9,
                            ProductID = 1,
                            Text = "Dayanıklılık konusunda bir numara! Su ve toza karşı çok iyi korunuyor."
                        },
                        new
                        {
                            CommentID = 10,
                            CommentDate = new DateTime(2023, 11, 18, 0, 34, 54, 538, DateTimeKind.Local).AddTicks(8640),
                            CustomerID = 10,
                            ProductID = 1,
                            Text = "Harika bir alışveriş deneyimi yaşadım. Teşekkürler Apple!"
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
                            Address = "Kadıköy",
                            DateOfBirth = new DateTime(1985, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ahmet.yilmaz@gmail.com",
                            Name = "Ahmet",
                            PhoneNumber = "5551112233",
                            Surname = "Yılmaz"
                        },
                        new
                        {
                            CustomerID = 2,
                            Address = "Beşiktaş",
                            DateOfBirth = new DateTime(1992, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ayse.kaya@gmail.com",
                            Name = "Ayşe",
                            PhoneNumber = "5553344556",
                            Surname = "Kaya"
                        },
                        new
                        {
                            CustomerID = 3,
                            Address = "Üsküdar",
                            DateOfBirth = new DateTime(1988, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mehmet.yildiz@gmail.com",
                            Name = "Mehmet",
                            PhoneNumber = "5555678899",
                            Surname = "Yıldız"
                        },
                        new
                        {
                            CustomerID = 4,
                            Address = "Şişli",
                            DateOfBirth = new DateTime(1995, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "zeynep.demir@gmail.com",
                            Name = "Zeynep",
                            PhoneNumber = "5554455667",
                            Surname = "Demir"
                        },
                        new
                        {
                            CustomerID = 5,
                            Address = "Beyoğlu",
                            DateOfBirth = new DateTime(1990, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ali.veli@gmail.com",
                            Name = "Ali",
                            PhoneNumber = "5552233445",
                            Surname = "Veli"
                        },
                        new
                        {
                            CustomerID = 6,
                            Address = "Bağcılar",
                            DateOfBirth = new DateTime(1987, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "fatma.aydin@gmail.com",
                            Name = "Fatma",
                            PhoneNumber = "5559988776",
                            Surname = "Aydın"
                        },
                        new
                        {
                            CustomerID = 7,
                            Address = "Gaziosmanpaşa",
                            DateOfBirth = new DateTime(1993, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "osman.kurt@gmail.com",
                            Name = "Osman",
                            PhoneNumber = "5551122334",
                            Surname = "Kurt"
                        },
                        new
                        {
                            CustomerID = 8,
                            Address = "Esenler",
                            DateOfBirth = new DateTime(1989, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "seda.arslan@gmail.com",
                            Name = "Seda",
                            PhoneNumber = "5553344556",
                            Surname = "Arslan"
                        },
                        new
                        {
                            CustomerID = 9,
                            Address = "Bakırköy",
                            DateOfBirth = new DateTime(1996, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kaan.ergin@gmail.com",
                            Name = "Kaan",
                            PhoneNumber = "5555566778",
                            Surname = "Ergin"
                        },
                        new
                        {
                            CustomerID = 10,
                            Address = "Maltepe",
                            DateOfBirth = new DateTime(1991, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "elif.aksoy@gmail.com",
                            Name = "Elif",
                            PhoneNumber = "5558899001",
                            Surname = "Aksoy"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            Category = "Telefon",
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
                        .WithMany("Comments")
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

            modelBuilder.Entity("WebApi.Models.Customer", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("WebApi.Models.Product", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
