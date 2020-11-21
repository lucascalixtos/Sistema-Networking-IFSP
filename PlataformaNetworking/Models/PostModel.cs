using System;
using System.Collections.Generic;

namespace PlataformaNetworking.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public Usuario UsuarioPost { get; set; }
        public int Like { get; set; }
        public List<CommentModel> Comments { get; set; }
        public DateTime PostTime { get; set; }
        public string Imagem { get; set; }
        public string TextoPost { get; set; }
        public string NomeUsuario { get; set; }
        public string FotoUsuario { get; set; }

        //TODO - Falta colocar o conteúdo 
    }
}
