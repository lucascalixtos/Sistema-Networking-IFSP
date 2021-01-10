using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.ViewComponents
{
    public class HabilidadeVagaViewComponent : ViewComponent
    {

        private readonly PlataformaNetworkingContext _context;

        public HabilidadeVagaViewComponent(PlataformaNetworkingContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(_context.HabilidadeVaga.Where(x => x.IdVaga == id).ToList());
        }

    }
}
