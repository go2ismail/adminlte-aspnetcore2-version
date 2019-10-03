using Microsoft.AspNetCore.Mvc;

namespace src.Areas.adminlte.Controllers
{
    [Area("adminlte")]
    public class WidgetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}