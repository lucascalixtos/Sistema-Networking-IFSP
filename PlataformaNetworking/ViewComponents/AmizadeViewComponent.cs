using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;
using PlataformaNetworking.Migrations;
using PlataformaNetworking.Models;
using PlataformaNetworking.Models.Enums;
using PlataformaNetworking.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.ViewComponents
{

    public class AmizadeViewComponent : ViewComponent {
        private readonly PlataformaNetworkingContext _context;

        public AmizadeViewComponent(PlataformaNetworkingContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            List<HomeViewModel> amizadesUsuario = new List<HomeViewModel>();
            
            List<Amizade> listaAmizades = new List<Amizade>();

            listaAmizades = await _context.Amizade.ToListAsync();
            foreach (var item in listaAmizades)
            {
                HomeViewModel amizade = new HomeViewModel();
                if (item.IdUsuario2 == id && item.Status == AmizadeStatus.Ativo)
                {
                    amizade.Amizade = item;
                    amizade.Usuario = _context.Usuario.First(x => x.Id == item.IdUsuario1);
                    amizadesUsuario.Add(amizade);
                }
                else if (item.IdUsuario1 == id && item.Status == AmizadeStatus.Ativo)
                {
                    amizade.Amizade = item;
                    amizade.Usuario = _context.Usuario.First(x => x.Id == item.IdUsuario2);
                    amizadesUsuario.Add(amizade);
                }
            }

            return View(amizadesUsuario);
        }
    }
}
