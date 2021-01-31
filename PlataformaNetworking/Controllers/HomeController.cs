using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;
using PlataformaNetworking.Models;
using PlataformaNetworking.Models.ViewModels;

namespace PlataformaNetworking.Controllers
{
    public class HomeController : Controller
    {
        private readonly PlataformaNetworkingContext _context;

        public HomeController(PlataformaNetworkingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("id") != null) {

                //Busca o usuário logado 
                Usuario usuarioLogado = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));
                HomeViewModel usuario = new HomeViewModel();
                usuario.Usuario = usuarioLogado;

                return View(usuario);

            } else {
                return Redirect(Url.Action("Login", "Usuarios"));
            }

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [Route("/Vagas")]
        public IActionResult Vagas() {

            if (HttpContext.Session.GetInt32("id") != null) {
                //Busca o usuário logado 
                Usuario usuarioLogado = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));
                var tipo = usuarioLogado.GetType();
                System.Diagnostics.Debug.WriteLine("Tipo: " + usuarioLogado.GetType().ToString());
                //var discriminator = _context.Usuario.Where(l => (l.Id == HttpContext.Session.GetInt32("id"))).Select(l => l.Discriminator).first();
                HomeViewModel usuario = new HomeViewModel();
                usuario.Usuario = usuarioLogado;
                return View(usuario);

            } else {
                return Redirect(Url.Action("Login", "Usuarios"));
            }
        }

        [Route("/Candidaturas")]
        public IActionResult Candidaturas()
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                //Busca o usuário logado 
                Usuario usuarioLogado = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));
                var tipo = usuarioLogado.GetType();
                System.Diagnostics.Debug.WriteLine("Tipo: " + usuarioLogado.GetType().ToString());
                //var discriminator = _context.Usuario.Where(l => (l.Id == HttpContext.Session.GetInt32("id"))).Select(l => l.Discriminator).first();
                HomeViewModel usuario = new HomeViewModel();
                usuario.Usuario = usuarioLogado;
                return View(usuario);

            }
            else
            {
                return Redirect(Url.Action("Login", "Usuarios"));
            }
        }

        [Route("/ListaCandidatosVaga")]

        public async Task<IActionResult> ListaCandidatosVaga(int idVaga)
        {
            return View(await _context.Candidato.FromSql("SELECT * FROM dbo.Candidato").
                Where(c => c.IdVaga == idVaga).ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AgendarEntrevista([Bind("Endereco,Data,IdAluno,IdVaga")] Entrevista entrevista)
        {

            try
            {
                Aluno aluno = _context.Aluno.Where(x => x.Id == entrevista.IdAluno).FirstOrDefault();
                Vaga vaga = _context.Vaga.Where(x => x.Id == entrevista.IdVaga).FirstOrDefault();
                //Busca o usuário logado 
                _context.Entrevista.Add(entrevista);
                await _context.SaveChangesAsync();
                Candidato candidato = _context.Candidato.Where(cand => cand.IdUsuario == entrevista.IdAluno && cand.IdVaga == entrevista.IdVaga).FirstOrDefault();
                Console.WriteLine("aaa");
                candidato.EntrevistaAgendada = true;
                 //Salva os dados no banco
                 await _context.SaveChangesAsync();

                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("smtptcc@gmail.com", "Teste@123"),
                    EnableSsl = true
                };

                string titulo = "Plataforma de networking - Processo iniciado";
                string corpo = $"Parabens, {aluno.Nome}. \n\n Você foi selecionado para o processo seletivo da vaga {vaga.Titulo} e em breve a empresa deve entrar em contato com você. \n\n Boa sorte! ";

                client.Send("smtptcc@gmail.com", aluno.Email, titulo, corpo);

                return Redirect(Url.Action("ListaCandidatosVaga", "Home", new { idVaga = entrevista.IdVaga }));

            }
            catch (Exception ex)
            {
                return Redirect(Url.Action("ListaCandidatosVaga", "Home", new { idVaga = entrevista.IdVaga }));
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
