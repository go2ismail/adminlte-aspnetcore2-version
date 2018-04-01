using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace src.Areas.adminlte.Controllers
{
    [Area("adminlte")]
    public class LayoutOptionsController : Controller
    {
        public IActionResult TopNavigation()
        {
            return View();
        }

        public IActionResult Boxed()
        {
            return View();
        }

        public IActionResult Fixed()
        {
            return View();
        }

        public IActionResult Collapsed()
        {
            return View();
        }
    }
}