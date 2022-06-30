using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using SalaEscape.Models;

namespace SalaEscape.Controllers
{
     public class EscapeController : Controller
    {

    
        public IActionResult Comenzar()
        {
            Escape.IniciarJuego();
            return View("Habitacion1");
            
        }
         public IActionResult Index()
        {
            return View();
        }
        [HttpPost] public IActionResult Habitacion(int sala, string clave)
        {
            bool respuesta;
            respuesta = Escape.ResolverSala(sala, clave);

            string vista;

            if(respuesta == false)
            {
                ViewBag.Error="Ha ingresado una respuesta erronea, vuelva a intentarlo";
            }
          

            if (Escape.EstadoJuego == 5)
            {
                vista = "Victoria";
            }
            else
            {
                vista = "Habitacion" + (Escape.EstadoJuego);
            }
            
            return View(vista);
            
        }
    }
}