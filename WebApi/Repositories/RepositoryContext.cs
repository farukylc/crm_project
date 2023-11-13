using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Repositories;

public class RepositoryContext:DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public RepositoryContext(DbContextOptions options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Customer>().HasData(
            new Customer()
            {
                CustomerID = 1,
                Name = "Ahmet",
                Surname = "Yılmaz",
                Email = "ahmet.yilmaz@gmail.com",
                DateOfBirth = new DateTime(1995, 3, 12),
                Address = "Kadıköy",
                PhoneNumber = "5551234567"
            },
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