using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadernoDigitalColaborativo.Models
{
    public class CommentModel
    {
        public int Id { get; set; }

        public DateTime CommentTime { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public String CommentText { get; set; }

        public PostModel Post{ get; set; }

        public Usuario UsuarioPost { get; set; }
    }
}
