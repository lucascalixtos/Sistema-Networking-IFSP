using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CadernoDigitalColaborativo.Data;
using CadernoDigitalColaborativo.Models;

namespace CadernoDigitalColaborativo.Controllers
{
    public class PublicacoesController : Controller
    {
        private readonly CadernoDigitalColaborativoContext _context;


        public PublicacoesController(CadernoDigitalColaborativoContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<bool> NovaPublicacao([Bind("Imagem,TextoPost")]  PostModel publicacao)
        {
            try
            {
                if (string.IsNullOrEmpty(publicacao.TextoPost) && string.IsNullOrEmpty(publicacao.Imagem))
                    return false;

                //Busca o usuário logado 
                Usuario usuario = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));

                publicacao.PostTime = DateTime.Now;
                publicacao.IdUsuario = usuario.Id;
                publicacao.NomeUsuario = usuario.Nome + " " + usuario.Sobrenome;
                publicacao.FotoUsuario = usuario.ProfilePictureUrl;

                 _context.Add(publicacao);

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
