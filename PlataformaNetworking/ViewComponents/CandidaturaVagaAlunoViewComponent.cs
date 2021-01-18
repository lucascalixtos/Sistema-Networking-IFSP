using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;
using PlataformaNetworking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.ViewComponents {
    public class EntrevistaAgendadaViewComponent: ViewComponent {
        private readonly PlataformaNetworkingContext _context;

        public EntrevistaAgendadaViewComponent(PlataformaNetworkingContext context) {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int idVaga) {

            Entrevista entrevista = await _context.Entrevista.Where(x => x.IdAluno == HttpContext.Session.GetInt32("id") && x.IdVaga == idVaga).FirstOrDefaultAsync();
            
            return View(entrevista);
        }
    }
}
