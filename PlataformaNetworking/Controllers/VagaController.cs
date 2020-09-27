using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlataformaNetworking.Data;
using PlataformaNetworking.Models;

namespace PlataformaNetworking.Controllers {
    public class VagaController : Controller {


        private readonly PlataformaNetworkingContext _context;


        public VagaController(PlataformaNetworkingContext context) {
            _context = context;
        }


        [HttpPost]
        public async Task<bool> NovaVaga([Bind("Titulo,Conteudo")]  Vaga PublicacaoVaga) {

            System.Diagnostics.Debug.WriteLine("Chegou aqui");
            try {
                if (string.IsNullOrEmpty(PublicacaoVaga.Titulo) && string.IsNullOrEmpty(PublicacaoVaga.Conteudo))
                    return false;

                //Busca o usuário logado 
                Usuario usuario = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));

                PublicacaoVaga.DataPostagem = DateTime.Now;
                PublicacaoVaga.IdUsuario = usuario.Id;
          

                _context.Add(PublicacaoVaga);

                //Salva os dados no banco
                int sucesso = await _context.SaveChangesAsync();

                return sucesso == 0 ? false : true;
            } catch (Exception) {
                return false;
            }
        }

        public class JsonRequest
        {
            public string IdVaga { get; set; }
        }

        [HttpPost]
        public async Task<bool> Candidatar([FromBody] JsonRequest data)
        {
            try
            {
                //Busca o usuário logado 
                Usuario usuario = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));

                Candidato candidato = new Candidato();

                candidato.IdUsuario = usuario.Id;
                candidato.Nome = usuario.Nome;
                candidato.Sobrenome = usuario.Sobrenome;
                candidato.Email = usuario.Email;
                candidato.IdVaga = Convert.ToInt32(data.IdVaga);
                _context.Add(candidato);

                //Salva os dados no banco
                int sucesso = await _context.SaveChangesAsync();
                return sucesso == 0 ? false : true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        
    }
}