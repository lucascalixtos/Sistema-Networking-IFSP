using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlataformaNetworking.Data;
using PlataformaNetworking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.ViewComponents
{
    public class AfinidadeVagaViewComponent : ViewComponent
    {
        private readonly PlataformaNetworkingContext _context;

        public AfinidadeVagaViewComponent(PlataformaNetworkingContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int idVaga)
        {
            List<HabilidadeVaga> habilidadeVagas = _context.HabilidadeVaga.Where(x => x.IdVaga == idVaga).ToList();
            int? idUsuario = HttpContext.Session.GetInt32("id");
            List<Habilidade> habilidadesUsuario = _context.Habilidade.Where(x => x.IdAluno == idUsuario).ToList();
            int totalHabilidadesVaga = habilidadeVagas.Count();
            int totalHabilidadeUsuario = 0;
            foreach (var  hv in habilidadeVagas)
            {
                foreach (var hu in habilidadesUsuario)
                {
                    if (hu.NomeHabilidade.ToLower().Equals(hv.NomeHabilidade.ToLower()))
                    {
                        totalHabilidadeUsuario++;
                    }
                }
                hv.NomeHabilidade.ToLower();
            }
            
            double totalPorcentagem = 0;
            if (totalHabilidadeUsuario > 0)
                 totalPorcentagem = (totalHabilidadeUsuario * 100) / totalHabilidadesVaga;

            return View(totalPorcentagem);
        }
    }
}
