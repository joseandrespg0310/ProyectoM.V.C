using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Tarea3Practica4.Models;

namespace Tarea3Practica4.Controllers
{
    public class TextController : Controller
    {
        public string Index()
        {
            return "Hola tujo";
        }
        public string Welcome(string name, int numTimes=1) 
        {
            return HtmlEncoder.Default.Encode($"Hello {name},NumTimes es :{numTimes}");

        }
       /* public ActionResult EjemploViewData()
        {
            IList<Persona> personaslist = new List<Persona>();
            personaslist.Add(new Persona() { Nombre = "Bill" });
            personaslist.Add(new Persona() { Nombre = "Steve" });
            personaslist.Add(new Persona() { Nombre = "Raq" });

            ViewData["personas"] = personaslist;
            return View();
        }*/
    }
}
