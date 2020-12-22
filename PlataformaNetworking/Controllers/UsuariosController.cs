using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;
using PlataformaNetworking.Models;
using PlataformaNetworking.Models.Enums;
using PlataformaNetworking.Models.ViewModels;

namespace PlataformaNetworking.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly PlataformaNetworkingContext _context;

        public int IdSessao;

        public UsuariosController(PlataformaNetworkingContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuario.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Sobrenome,Email,DataNascimento,Curso,CursoId,AnoIngresso,Semestre,Senha,ProfilePictureUrl")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Situacao = Situacao.Ativo;
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login");
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Usuario model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    //Busca o usuário no contexto
                    var usuario = await _context.Usuario.FindAsync(id);

                    //Prepara os dados a serem atualizados no banco
                    usuario.Nome = model.Nome;
                    usuario.Sobrenome = model.Sobrenome;
                    //usuario.Curso = model.Curso;
                    usuario.Email = model.Email;
                    usuario.DataNascimento = model.DataNascimento;

                    _context.Update(usuario);

                    //Salva a alteração
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Perfil");
            }
            return View(model);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            //Verifica se o id digitado é valido
            if (id == null)
            {
                return NotFound();
            }

            //Busca o usuário a ser deletado
            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Id == id);


            //Verifica se o usuário existe
            if (usuario == null)
            {
                return NotFound();
            }

            //Retorna o usuário para a view
            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);
            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.Id == id);
        }

        [Route("/Cadastro")]
        public IActionResult Cadastro()
        {
            return View();
        }


        [Route("/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("/Login")]
        public IActionResult Login(string Email, string Senha) {

            try {
                var contaAtiva = _context.Usuario.Where(l => (l.Email == Email) && (l.Senha == Senha)).Select(l => l.Situacao).First();

                System.Diagnostics.Debug.WriteLine("Conta ativa: " + contaAtiva.ToString());

                if (contaAtiva.ToString().Equals("Ativo")) {
                    Usuario usuario = _context.Usuario.Where(l => (l.Email == Email) && (l.Senha == Senha)).FirstOrDefault();
                    System.Diagnostics.Debug.WriteLine("Conta ativa: Entrou no if");
                    HttpContext.Session.SetInt32("id", usuario.Id);
                    HttpContext.Session.GetInt32("id");
                    System.Diagnostics.Debug.WriteLine("Teste: " + HttpContext.Session.GetInt32("id").ToString());
                    string tipo = usuario.GetType().Name;
                    HttpContext.Session.SetString("tipo", tipo);
                    if (tipo == "Administrador"){
                        return Redirect(Url.Action("Index", "Administradors"));
                    } else {
                        return Redirect(Url.Action("Index", "Home"));
                    }

                } else {
                    ViewBag.error = "Invalid Account";
                    return View("Login");
                }
            } catch (Exception) {

                return View("Login");
            }
        }

        [Route("/Logout")]
        [HttpGet]
        public IActionResult Logout() {
            HttpContext.Session.Remove("id");
            return RedirectToAction("Login");
        }

        [HttpPost]
        public async Task<bool> AlterarImagemPerfil(string ProfilePictureUrl)
        {
            try
            {

                Usuario usuario = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));
                usuario.ProfilePictureUrl = ProfilePictureUrl;
                int sucesso = await _context.SaveChangesAsync();

                return sucesso == 0 ? false:true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPost]
        public async Task<bool> UploadImagem(string UploadPictureUrl)
        {
            try
            {

                //Usuario usuario = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));
                //usuario.UploadPictureUrl = UploadPictureUrl;
                //int sucesso = await _context.SaveChangesAsync();

                //return sucesso == 0 ? false : true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [Route("/MeuPerfil")]
        public  IActionResult MeuPerfil()
        {
           if (HttpContext.Session.GetInt32("id") != null) {
                Usuario usuarioLogado = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));
                HomeViewModel usuario = new HomeViewModel();
                usuario.Usuario = usuarioLogado;
                return View(usuario);
            } else {
                return RedirectToAction("Login");
            }
            
        }

        // GET: Usuarios/Perfil/5
        public async Task<IActionResult> Perfil(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioLogado = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Id == id);
            HomeViewModel usuario = new HomeViewModel();
            usuario.Usuario = usuarioLogado;
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        [HttpPost]
        public async Task<bool> NovaHabilidade([Bind("NomeHabilidade")]  Habilidade habilidade) {
            try {
                if (string.IsNullOrEmpty(habilidade.NomeHabilidade))
                    return false;

                //Busca o usuário logado 
                Usuario usuario = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));

                habilidade.IdAluno = usuario.Id;

                _context.Add(habilidade);

                int sucesso = await _context.SaveChangesAsync();
                

                return sucesso == 0 ? false : true;
            } catch (Exception) {
                return false;
            }
        }

        public class JsonRequest
        {
            public string IdHabilidade { get; set; }
            public string IdAluno { get; set; }
        }

        [HttpPost]
        public async Task<bool> RecomendaHabilidade([FromBody]JsonRequest data)
        {
            try
            {
                //Busca o usuário logado 
                Usuario usuario = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));


                Habilidade habilidade = _context.Habilidade.ToList()
                    .Find(u => u.Id == Convert.ToInt32(data.IdHabilidade) && u.IdAluno == Convert.ToInt32(data.IdAluno));
                habilidade.Recomendacoes += 1;

                int sucesso = await _context.SaveChangesAsync();
                return sucesso == 0 ? false : true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> SolicitaAmizade([Bind("IdUsuario2")] Amizade amizade)
        {
            try
            {
                //Busca o usuário logado 
                Usuario usuario = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));

                amizade.IdUsuario1 = usuario.Id;
                amizade.Status = AmizadeStatus.Pendente;
                usuario.AmizadesPendentes = true;

                _context.Add(amizade);

                int sucesso = await _context.SaveChangesAsync();

                return sucesso == 0 ? false : true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ActionResult> AceitaSolicitacaoAmizade(int id)
        {
            try
            {
                Amizade amizade = _context.Amizade.First(x => x.Id == id);
                amizade.Status = AmizadeStatus.Ativo;

                _context.Amizade.Update(amizade);

                int sucesso = await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");

                //return sucesso == 0 ? false : true;
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }


    }
}
