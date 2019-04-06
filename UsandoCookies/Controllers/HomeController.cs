using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
            var options = new CookieOptions();
            options.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Append("CookieComAMensagem", mensagem.Entrada, options);

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
