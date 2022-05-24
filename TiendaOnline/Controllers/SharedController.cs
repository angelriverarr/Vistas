using Microsoft.AspNetCore.Mvc;

namespace TiendaOnline.Controllers
{
    public class SharedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
