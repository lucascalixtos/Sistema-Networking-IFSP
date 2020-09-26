using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlataformaNetworking.Data;
using PlataformaNetworking.Models;

namespace PlataformaNetworking.Controllers
{
    public class HomeController : Controller
    {
        private readonly CadernoDigitalColaborativoContext _context;

        public HomeController(CadernoDigitalColaborativoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("id") != null) {
                
                //Busca o usuário logado 
                Usuario usuario = _context.Usuario.First(x => x.Id == HttpContext.Session.GetInt32("id"));
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
