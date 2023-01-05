using Microsoft.AspNetCore.Mvc;

namespace GerenciadorFolhaPagamento_Frontend.Controllers
{
    public class ParametrosController : Controller
    {
        [HttpGet]
        public IActionResult Parametros()
        {
            return View();
        }
    }
}
