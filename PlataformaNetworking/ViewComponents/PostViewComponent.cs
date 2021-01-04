using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;
using PlataformaNetworking.Models;
using PlataformaNetworking.Models.ViewModels;

namespace PlataformaNetworking.ViewComponents
{

    public class PostViewComponent : ViewComponent
    {
        private readonly PlataformaNetworkingContext _context;

        public PostViewComponent(PlataformaNetworkingContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<HomePostViewModel> posts = new List<HomePostViewModel>();
            
            List<PostModel> listaPosts = new List<PostModel>();

            listaPosts = await _context.Post.ToListAsync();

            foreach (var item in listaPosts)
            {
                HomePostViewModel post = new HomePostViewModel();
                post.Post = item;
                post.Usuario = _context.Usuario.First(x => x.Id == item.IdUsuario);
                posts.Add(post);
            }

            //var posts = await _context.Post.ToListAsync();
            return View(posts);
        }
    }
}
