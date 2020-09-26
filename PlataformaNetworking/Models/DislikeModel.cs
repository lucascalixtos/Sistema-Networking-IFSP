using System;

namespace PlataformaNetworking.Models
{
    public class DislikeModel
    {
        public int Id { get; set; }

        public int IdUsuario1 { get; set; }
        public Usuario Usario1 { get; set; }
        public int IdUsuario2 { get; set; }
        public Usuario Usario2 { get; set; }

        public DateTimeOffset DislikedAt { get; set; }
    }
}
