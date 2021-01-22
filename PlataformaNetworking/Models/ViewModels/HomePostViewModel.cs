using PlataformaNetworking.Models;

namespace PlataformaNetworking.Models.ViewModels
{
    public class HomePostViewModel
    {
        public PostModel Post { get; set; }
        public Usuario Usuario { get; set; }

        public Comment Comentario { get; set; }
    }
}
