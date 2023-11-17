using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models;

namespace WebApi.Repositories.Config
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.CommentID);
            builder.Property(c => c.Text).IsRequired();
            builder.Property(c => c.CommentDate).IsRequired();

            builder.HasOne(c => c.Customer)
                .WithMany(customer => customer.Comments)
                .HasForeignKey(c => c.CustomerID)
                .IsRequired();

            builder.HasOne(c => c.Product)
                .WithMany(product => product.Comments)
                .HasForeignKey(c => c.ProductID)
                .IsRequired();

            builder.HasData(
                new Comment()
    {
        CommentID = 1,
        Text = "Kamera kalitesi muazzam! Gece çekimleri gerçekten etkileyici.",
        CommentDate = DateTime.Now,
        CustomerID = 1,
        ProductID = 1,
         

        
    },
    new Comment()
    {
        CommentID = 2,
        Text = "Şarj ömrü beni şaşırttı. Bir günü rahatlıkla çıkarıyor.",
        CommentDate = DateTime.Now,
        CustomerID = 2,
        ProductID = 1
    },
    new Comment()
    {
        CommentID = 3,
        Text = "İnanılmaz hızlı! A14 Bionic işlemci performansı harika.",
        CommentDate = DateTime.Now,
        CustomerID = 3,
        ProductID = 1
    },
    new Comment()
    {
        CommentID = 4,
        Text = "Ekran renkleri çok canlı, True Tone özelliği harika bir görüntü sağlıyor.",
        CommentDate = DateTime.Now,
        CustomerID = 4,
        ProductID = 1
    },
    new Comment()
    {
        CommentID = 5,
        Text = "5G desteğiyle internet hızları fırlamış durumda. Harika bir deneyim!",
        CommentDate = DateTime.Now,
        CustomerID = 5,
        ProductID = 1
    },
    new Comment()
    {
        CommentID = 6,
        Text = "Tasarımı çok şık ve kullanımı çok rahat. Elde harika bir his bırakıyor.",
        CommentDate = DateTime.Now,
        CustomerID = 6,
        ProductID = 1
    },
    new Comment()
    {
        CommentID = 7,
        Text = "iOS 15 ile gelen yeni özellikler harika! Widget'lar çok kullanışlı.",
        CommentDate = DateTime.Now,
        CustomerID = 7,
        ProductID = 1
    },
    new Comment()
    {
        CommentID = 8,
        Text = "Face ID çok hızlı ve güvenilir. Şifre girmeye artık gerek yok!",
        CommentDate = DateTime.Now,
        CustomerID = 8,
        ProductID = 1
    },
    new Comment()
    {
        CommentID = 9,
        Text = "Dayanıklılık konusunda bir numara! Su ve toza karşı çok iyi korunuyor.",
        CommentDate = DateTime.Now,
        CustomerID = 9,
        ProductID = 1
    }
    

            );
        }
    }
}