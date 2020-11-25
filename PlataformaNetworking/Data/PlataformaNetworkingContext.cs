using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Models;
using PlataformaNetworking.ViewModels;

namespace PlataformaNetworking.Data
{
    public class PlataformaNetworkingContext : DbContext
    {
        public PlataformaNetworkingContext (DbContextOptions<PlataformaNetworkingContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<PostModel> Post { get; set; }
        public DbSet<LikeModel> Like { get; set; }
       // public DbSet<PostLikeViewModel> PostLikeViewModel { get; set; }
        public DbSet<DislikeModel> Dislike { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Vaga> Vaga { get; set; }
        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<Habilidade> Habilidade { get; set; }
        public DbSet<PlataformaNetworking.Models.Empresa> Empresa { get; set; }
    }
}
