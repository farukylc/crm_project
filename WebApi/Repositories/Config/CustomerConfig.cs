using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models;
using System;

namespace WebApi.Repositories.Config
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
    {
        CustomerID = 1,
        Name = "Ahmet",
        Surname = "Yılmaz",
        Email = "ahmet.yilmaz@gmail.com",
        DateOfBirth = new DateTime(1985, 5, 12),
        Address = "Kadıköy",
        PhoneNumber = "5551112233",
        Comments = new List<Comment>()
    },
    new Customer
    {
        CustomerID = 2,
        Name = "Ayşe",
        Surname = "Kaya",
        Email = "ayse.kaya@gmail.com",
        DateOfBirth = new DateTime(1992, 8, 25),
        Address = "Beşiktaş",
        PhoneNumber = "5553344556",
        Comments = new List<Comment>()
    },
    new Customer
    {
        CustomerID = 3,
        Name = "Mehmet",
        Surname = "Yıldız",
        Email = "mehmet.yildiz@gmail.com",
        DateOfBirth = new DateTime(1988, 3, 7),
        Address = "Üsküdar",
        PhoneNumber = "5555678899",
        Comments = new List<Comment>()
    },
    new Customer
    {
        CustomerID = 4,
        Name = "Zeynep",
        Surname = "Demir",
        Email = "zeynep.demir@gmail.com",
        DateOfBirth = new DateTime(1995, 11, 15),
        Address = "Şişli",
        PhoneNumber = "5554455667",
        Comments = new List<Comment>()
    },
    new Customer
    {
        CustomerID = 5,
        Name = "Ali",
        Surname = "Veli",
        Email = "ali.veli@gmail.com",
        DateOfBirth = new DateTime(1990, 6, 22),
        Address = "Beyoğlu",
        PhoneNumber = "5552233445",
        Comments = new List<Comment>()
    },
    new Customer
    {
        CustomerID = 6,
        Name = "Fatma",
        Surname = "Aydın",
        Email = "fatma.aydin@gmail.com",
        DateOfBirth = new DateTime(1987, 9, 3),
        Address = "Bağcılar",
        PhoneNumber = "5559988776",
        Comments = new List<Comment>()
    },
    new Customer
    {
        CustomerID = 7,
        Name = "Osman",
        Surname = "Kurt",
        Email = "osman.kurt@gmail.com",
        DateOfBirth = new DateTime(1993, 2, 14),
        Address = "Gaziosmanpaşa",
        PhoneNumber = "5551122334",
        Comments = new List<Comment>()
    },
    new Customer
    {
        CustomerID = 8,
        Name = "Seda",
        Surname = "Arslan",
        Email = "seda.arslan@gmail.com",
        DateOfBirth = new DateTime(1989, 7, 18),
        Address = "Esenler",
        PhoneNumber = "5553344556",
        Comments = new List<Comment>()
    },
    new Customer
    {
        CustomerID = 9,
        Name = "Kaan",
        Surname = "Ergin",
        Email = "kaan.ergin@gmail.com",
        DateOfBirth = new DateTime(1996, 4, 29),
        Address = "Bakırköy",
        PhoneNumber = "5555566778",
        Comments = new List<Comment>()
    }
    
            );

            
        }
    }
}
