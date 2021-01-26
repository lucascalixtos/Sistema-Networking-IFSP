using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Models;


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
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Administrador> Administrador { get; set; }
        //public DbSet<AmizadeUsuarioViewModel> AmizadeUsuario { get; set; }
        public DbSet<Curriculo> Curriculo { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<HabilidadeVaga> HabilidadeVaga { get; set; }
        public DbSet<Entrevista> Entrevista { get; set; }
    }
}
