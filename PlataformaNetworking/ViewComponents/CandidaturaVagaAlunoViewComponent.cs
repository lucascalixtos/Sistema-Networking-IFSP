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
    public class CandidaturaVagaAlunoViewComponent: ViewComponent {
        private readonly PlataformaNetworkingContext _context;

        public CandidaturaVagaAlunoViewComponent(PlataformaNetworkingContext context) {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            List<int> ids = await _context.Candidato.Where(x => x.IdUsuario == HttpContext.Session.GetInt32("id")).Select(x=> x.IdVaga).ToListAsync();

            List<Vaga> vagas = new List<Vaga>();

            foreach (var id in ids)
            {
                Vaga vaga = await _context.Vaga.FirstOrDefaultAsync(x => x.Id == id);
                vagas.Add(vaga);
            }
            
            return View(vagas);
        }
    }
}
