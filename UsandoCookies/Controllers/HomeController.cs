using Microsoft.AspNetCore.Mvc;
using UsandoCookies.Models;

namespace UsandoCookies.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Mensagem());
        }

        public IActionResult WriteCookie(Mensagem mensagem)
        {
            Response.Cookies.Append("CookieComAMensagem", mensagem.Entrada);

            return RedirectToAction("Leitura");
        }

        public IActionResult Leitura()
        {
            var resultado = new Mensagem();
            resultado.Saida = Request.Cookies["CookieComAMensagem"];
            
            return View(resultado);
        }
    }
}
