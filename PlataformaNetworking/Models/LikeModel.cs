namespace PlataformaNetworking.Models
{
    public class LikeModel
    {
        public int Id { get; set; }
        public int IdUsuario1 { get; set; }
        public Usuario Usuario1 { get; set; }
        public int IdUsuario2 { get; set; }
        public Usuario Usuario2 { get; set; }

    }
}

