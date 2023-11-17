using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models;
using System;

namespace WebApi.Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product()
                {
                    ProductID = 1,
                    ProductName = "IPhone 13",
                    Price = 50,
                    Stars = 4.7f,
                    SalesAmount = 20,
                    imgUrl = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/apple/thumb/129743-1_large.jpg",
                    Category = "Telefon",
                    Customer = new Customer()
                    {
                        CustomerID = 10,
                        Name = "Elif",
                        Surname = "Aksoy",
                        Email = "elif.aksoy@gmail.com",
                        DateOfBirth = new DateTime(1991, 1, 8),
                        Address = "Maltepe",
                        PhoneNumber = "5558899001",
                        Comments = new List<Comment>()
                        {
                            new Comment()
                            {
                                CommentID = 10,
                                Text = "Harika bir alışveriş deneyimi yaşadım. Teşekkürler Apple!",
                                CommentDate = DateTime.Now,
                                CustomerID = 10,
                                ProductID = 1
                            }
                        }
                    }
                }
                
            );
            

            
        }
    }
}