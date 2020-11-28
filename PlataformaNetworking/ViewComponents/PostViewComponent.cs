using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;
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
            
            var posts = await _context.Post.ToListAsync();
            return View(posts);
        }
    }
}
