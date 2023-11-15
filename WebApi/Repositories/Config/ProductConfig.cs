using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models;

namespace WebApi.Repositories.Config;

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(
            new Product()
            {
                ProductID = 1,
                ProductName = "Product1",
                Price = 50,
                RateAmount = 4,
                SalesAmount = 20,
                Cost = 30
            },
            new Product()
            {
                ProductID = 2,
                ProductName = "Product2",
                Price = 80,
                RateAmount = 5,
                SalesAmount = 15,
                Cost = 40
            }
        );
    }
}