using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Models;

namespace PlataformaNetworking.Data
{
    public class CadernoDigitalColaborativoContext : DbContext
    {
        public CadernoDigitalColaborativoContext (DbContextOptions<CadernoDigitalColaborativoContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<PostModel> Post { get; set; }
        public DbSet<LikeModel> Like { get; set; }
        public DbSet<DislikeModel> Dislike { get; set; }
        public DbSet<CommentModel> Comment { get; set; }
    }
}
