using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;
using PlataformaNetworking.Models;
using PlataformaNetworking.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlataformaNetworking.Models.Enums;

namespace PlataformaNetworking.ViewComponents {
    public class PedidoAmizadeViewComponent : ViewComponent {
        private readonly PlataformaNetworkingContext _context;

        public PedidoAmizadeViewComponent(PlataformaNetworkingContext context) {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            List<HomeViewModel> amizadesUsuario = new List<HomeViewModel>();
            HomeViewModel amizade = new HomeViewModel();
            List<Amizade> listaAmizades = new List<Amizade>();

            listaAmizades = await _context.Amizade.ToListAsync();
            int? usuarioLogado = HttpContext.Session.GetInt32("id");
            foreach (var item in listaAmizades)
            {
                
                if (item.IdUsuario2 == usuarioLogado && item.Status == AmizadeStatus.Pendente)
                {
                    amizade.Amizade = item;
                    amizade.Usuario = _context.Usuario.First(x => x.Id == item.IdUsuario1);
                    amizadesUsuario.Add(amizade);
                }
            }

            return View(amizadesUsuario);
        }
    }
}