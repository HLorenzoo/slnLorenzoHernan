using Microsoft.AspNetCore.Mvc;

namespace SistemaWebMisRecetas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Tu sitio de Recetas.";
            return View();
        }
    }
}
