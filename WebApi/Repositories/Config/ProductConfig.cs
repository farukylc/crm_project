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
                ProductName = "IPhone 13",
                Price = 50,
                Stars = 4.7f,
                SalesAmount = 20,
                imgUrl = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/apple/thumb/129743-1_large.jpg"
            }
        );
    }
}