using System;

namespace PlataformaNetworking.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int IdPost { get; set; }
        public DateTime CommentTime { get; set; }

        public int IdUsuario { get; set; }

        public String CommentText { get; set; }


    }
}
