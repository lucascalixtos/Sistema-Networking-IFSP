using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;
using PlataformaNetworking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.ViewComponents {
    public class CurriculoViewComponent : ViewComponent {

        private readonly PlataformaNetworkingContext _context;

        public CurriculoViewComponent(PlataformaNetworkingContext context) {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id) {
            Curriculo curriculo = await _context.Aluno.Where(al => al.Id == id).Select(cur => cur.Curriculo).FirstOrDefaultAsync();
            return View(curriculo);
        }
    }
}
