using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tarea3Practica4.Models;

namespace Tarea3Practica4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var materia = new Materia()
            {
                Nombre = "Programacion Web |||",
                Semestre="4TO Semsetre",
                Universidad="Univalle"

            };
            return View("Index", materia);
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