using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;

namespace PlataformaNetworking.ViewComponents
{

    public class ComentarioViewComponent : ViewComponent
    {
        private readonly PlataformaNetworkingContext _context;

        public ComentarioViewComponent(PlataformaNetworkingContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Comment.ToListAsync());
        }
    }
}
