using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlataformaNetworking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.ViewComponents {
    public class HabilidadesViewComponent : ViewComponent {
        private readonly PlataformaNetworkingContext _context;

        public HabilidadesViewComponent(PlataformaNetworkingContext context) {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            return View( _context.Habilidade.Where(x => x.IdAluno == HttpContext.Session.GetInt32("id")).ToList());
        }
    }
}
