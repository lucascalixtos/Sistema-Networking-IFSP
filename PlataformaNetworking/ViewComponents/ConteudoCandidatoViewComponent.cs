using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.ViewComponents {
    public class ConteudoCandidatoViewComponent: ViewComponent {
        private readonly PlataformaNetworkingContext _context;

        public ConteudoCandidatoViewComponent(PlataformaNetworkingContext context) {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            return View(await _context.Candidato.ToListAsync());
        }
    }
}
