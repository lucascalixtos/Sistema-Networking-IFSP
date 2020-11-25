using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlataformaNetworking.Data;
using PlataformaNetworking.Models;

namespace PlataformaNetworking.Controllers
{
    public class PublicacoesController : Controller
    {
        private readonly PlataformaNetworkingContext _context;


        public PublicacoesController(PlataformaNetworkingContext context)
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
                publicacao.Like = 0;

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

        public class JsonRequest
        {
            public string IdPost { get; set; }
        }

        [HttpPost]
        public async Task<bool> Like([FromBody]JsonRequest data)
        {
            try
            {
                //Busca o usuário logado 
                Usuario usuario = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));


                PostModel updatePostLikes = _context.Post.ToList().Find(u => u.Id == Convert.ToInt32(data.IdPost));
                updatePostLikes.Like += 1;

                LikeModel like = new LikeModel();
                like.IdPost = Convert.ToInt32(data.IdPost);
                like.IdUsuario = usuario.Id;
                _context.Like.Add(like);
                int sucesso = await _context.SaveChangesAsync();
                return sucesso == 0 ? false : true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost]
        public async Task<bool> Comentario([Bind("IdPost", "CommentText")] Comment comment)
        {
            try
            {
                if (string.IsNullOrEmpty(comment.CommentText))
                    return false;

                //Busca o usuário logado 
                Usuario usuario = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));

                comment.IdUsuario = usuario.Id;
                comment.CommentTime = DateTime.Now;

                _context.Add(comment);

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
