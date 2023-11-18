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
                    CustomerID = 1
                },
                
                new Comment()
                {
                    CommentID = 2,
                    Text = "ben 2",
                    CommentDate = DateTime.Now,
                    CustomerID = 2
                },
                new Comment()
                {
                    CommentID = 3,
                    Text = "ben 3",
                    CommentDate = DateTime.Now,
                    CustomerID = 3
                }
                
            );
        }
    }
}