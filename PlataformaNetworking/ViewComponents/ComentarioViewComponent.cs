using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;
using Remotion.Linq.Clauses;

namespace PlataformaNetworking.ViewComponents
{

    public class ComentarioViewComponent : ViewComponent
    {
        private readonly PlataformaNetworkingContext _context;

        public ComentarioViewComponent(PlataformaNetworkingContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int IdPost)
        {
            var comentarios = await _context.Comment.Where(x => x.IdPost == IdPost).ToListAsync();
            return View(comentarios);
        }
    }
}
