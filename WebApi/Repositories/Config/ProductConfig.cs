using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models;

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
                    Price = 38000,
                    Stars = 4.7f,
                    SalesAmount = 20,
                    imgUrl = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/apple/thumb/129743-1_large.jpg",
                    
                },
                new Product()
                {
                    ProductID = 2,
                    ProductName = "Macbook Pro",
                    Price = 90000,
                    Stars = 4.7f,
                    SalesAmount = 23,
                    imgUrl = "https://cdn.akakce.com/z/apple/macbook-pro-mkgp3tu-a-apple-m1-pro-16-gb-512-gb-ssd-16-notebook.jpg"
                    
                }
            );
        }
    }
}