using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;

namespace PlataformaNetworking.ViewComponents
{

    public class PostViewComponent : ViewComponent
    {
        private readonly CadernoDigitalColaborativoContext _context;

        public PostViewComponent(CadernoDigitalColaborativoContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Post.ToListAsync());
        }
    }
}
