using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Models;

namespace WebApi.Repositories.Config
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment()
                {
                    CommentID = 1,
                    Text = "Kamera kalitesi muazzam! Gece çekimleri gerçekten etkileyici.",
                    CommentDate = DateTime.Now,
                    CustomerID = 1,
                    ProductID = 1
                },
                new Comment()
                {
                    CommentID = 2,
                    Text = "İyi telefon",
                    CommentDate = DateTime.Now,
                    CustomerID = 1,
                    ProductID = 1
                },
                
                new Comment()
                {
                    CommentID = 3,
                    Text = "iPhone 13'ü bir süredir kullanıyorum ve gerçekten etkileyici bir deneyim sunuyor. Öncelikle, kamerasının performansı beni büyüledi. Gelişmiş gece modu sayesinde düşük ışıkta bile muhteşem fotoğraflar çekebiliyorum. Ayrıca, ekran kalitesi gerçekten harika; renkler canlı ve parlak, video izlemek ve oyun oynamak gerçekten keyifli.",
                    CommentDate = DateTime.Now,
                    CustomerID = 2,
                    ProductID = 1
                    
                },
                new Comment()
                {
                    CommentID = 4,
                    Text = "ben 3",
                    CommentDate = DateTime.Now,
                    CustomerID = 3,
                    ProductID = 1
                }
                
            );
        }
    }
}