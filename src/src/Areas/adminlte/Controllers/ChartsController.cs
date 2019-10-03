using Microsoft.AspNetCore.Mvc;

namespace src.Areas.adminlte.Controllers
{
    [Area("adminlte")]
    public class ChartsController : Controller
    {
        public IActionResult ChartJS()
        {
            return View();
        }

        public IActionResult Morris()
        {
            return View();
        }

        public IActionResult Flot()
        {
            return View();
        }

        public IActionResult Inline()
        {
            return View();
        }
    }
}