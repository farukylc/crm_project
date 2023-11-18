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
                    CommentDate = DateTime.Now
                }
                
            );
        }
    }
}