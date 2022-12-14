using Microsoft.AspNetCore.Mvc;
using MvcVistas.Models;
using System.Diagnostics;

namespace MvcVistas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{

        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Index(string selUsuarios)
        {
            List<string> listaUsuarios = new List<string>();
            listaUsuarios.Add("Fernando");
            listaUsuarios.Add("Moises");
            listaUsuarios.Add("Adrian");

            //ViewBag.ListaUsuarios = listaUsuarios;
            ViewBag.Nombre = listaUsuarios;
            ViewBag.Nombre1 = listaUsuarios;
            return View();
        }

        [HttpPost]
        //La llamo selUsuarios que tiene el mismo nombre que en la vista para recuperar los datos
        //Lo mismo con el ViewBag.Nombre
        //public IActionResult Index(string selUsuarios)
        //{
        //    List<string> listaUsuarios = new List<string>();
        //    listaUsuarios.Add("Fernando");
        //    listaUsuarios.Add("Moises");
        //    listaUsuarios.Add("Adrian");

        //    ViewBag.ListaUsuarios = listaUsuarios;
        //    ViewBag.Nombre = listaUsuarios;
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}