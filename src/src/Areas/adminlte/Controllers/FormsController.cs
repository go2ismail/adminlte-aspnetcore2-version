using Microsoft.AspNetCore.Mvc;

namespace src.Areas.adminlte.Controllers
{
    [Area("adminlte")]
    public class FormsController : Controller
    {
        public IActionResult General()
        {
            return View();
        }

        public IActionResult Advanced()
        {
            return View();
        }

        public IActionResult Editors()
        {
            return View();
        }
    }
}