using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;
using Remotion.Linq.Clauses;
using PlataformaNetworking.Models.ViewModels;
using System.Collections.Generic;
using PlataformaNetworking.Models;

namespace PlataformaNetworking.ViewComponents
{

    public class ComentarioViewComponent : ViewComponent
    {
        private readonly PlataformaNetworkingContext _context;

        public ComentarioViewComponent(PlataformaNetworkingContext context)
        {
            _context = context;
        }

        /* public async Task<IViewComponentResult> InvokeAsync(int IdPost)
         {
             var comentarios = await _context.Comment.Where(x => x.IdPost == IdPost).ToListAsync();
             return View(comentarios);
         }*/

        public async Task<IViewComponentResult> InvokeAsync(int IdPost)
        {
            List<HomePostViewModel> posts = new List<HomePostViewModel>();

            List<Comment> comentarios = new List<Comment>();

            comentarios = await _context.Comment.Where(x => x.IdPost == IdPost).ToListAsync();

            foreach (var item in comentarios)
            {
                HomePostViewModel post = new HomePostViewModel();
                post.Comentario = item;
                post.Usuario = _context.Usuario.First(x => x.Id == item.IdUsuario);
                posts.Add(post);
            }

            //var posts = await _context.Post.ToListAsync();
            return View(posts);
        }
    }
}
