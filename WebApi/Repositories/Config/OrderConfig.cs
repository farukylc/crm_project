using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models;

namespace WebApi.Repositories.Config
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                new Order()
                {
                    OrderID = 1 ,
                    CustomerID=1,
                    ProductID=1
                    
                },
                
                new Order()
                {
                    OrderID = 2 ,
                    CustomerID=2,
                    ProductID=2
                    
                },
                new Order()
                {
                    OrderID = 3 ,
                    CustomerID=3,
                    ProductID=2
                    
                },
                new Order()
                {
                    OrderID = 4 ,
                    CustomerID=1,
                    ProductID=2
                    
                }
                
            );
        }
    }
}