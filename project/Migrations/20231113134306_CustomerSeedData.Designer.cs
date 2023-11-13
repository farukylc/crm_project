﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project.Repositories;

#nullable disable

namespace project.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20231113134306_CustomerSeedData")]
    partial class CustomerSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("project.Models.Customer", b =>
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
                            DateOfBirth = new DateTime(1995, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ahmet.yilmaz@gmail.com",
                            Name = "Ahmet",
                            PhoneNumber = "5551234567",
                            Surname = "Yılmaz"
                        },
                        new
                        {
                            CustomerID = 2,
                            Address = "Beşiktaş",
                            DateOfBirth = new DateTime(1988, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ayse.demir@gmail.com",
                            Name = "Ayşe",
                            PhoneNumber = "5559876543",
                            Surname = "Demir"
                        },
                        new
                        {
                            CustomerID = 10,
                            Address = "Beyoğlu",
                            DateOfBirth = new DateTime(1992, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mehmet.aydin@gmail.com",
                            Name = "Mehmet",
                            PhoneNumber = "5557890123",
                            Surname = "Aydın"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
