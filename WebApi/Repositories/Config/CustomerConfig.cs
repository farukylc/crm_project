using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models;

namespace WebApi.Repositories.Config
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer()
                {
                    CustomerID = 2,
                    Name = "Ayşe",
                    Surname = "Demir",
                    Email = "ayse.demir@gmail.com",
                    DateOfBirth = new DateTime(1988, 7, 4),
                    Address = "Beşiktaş",
                    PhoneNumber = "5559876543"
                },
            
                new Customer()
                {
                    CustomerID = 10,
                    Name = "Mehmet",
                    Surname = "Aydın",
                    Email = "mehmet.aydin@gmail.com",
                    DateOfBirth = new DateTime(1992, 11, 30),
                    Address = "Beyoğlu",
                    PhoneNumber = "5557890123"
                },
                new Customer()
                {
                    CustomerID = 11,
                    Name = "Ali",
                    Surname = "Veli",
                    Email = "aliveli@gmail.com",
                    DateOfBirth = new DateTime(1990, 03, 18),
                    Address = "Üsküdar",
                    PhoneNumber = "555131231"
                }
            );
        }
    }
}
