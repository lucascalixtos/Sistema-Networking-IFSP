using Microsoft.AspNetCore.Mvc;
using PlataformaNetworking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.ViewComponents
{

    public class PainelViewComponent : ViewComponent {
        private readonly PlataformaNetworkingContext _context;

        public PainelViewComponent(PlataformaNetworkingContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
