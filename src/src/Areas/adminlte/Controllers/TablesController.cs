using Microsoft.AspNetCore.Mvc;

namespace src.Areas.adminlte.Controllers
{
    [Area("adminlte")]
    public class TablesController : Controller
    {
        public IActionResult SimpleTables()
        {
            return View();
        }

        public IActionResult DataTables()
        {
            return View();
        }
    }
}