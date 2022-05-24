using Microsoft.AspNetCore.Mvc;

namespace TiendaOnline.Controllers
{
    public class VentaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Venta()
        {
            return View();
        }
    }
}
