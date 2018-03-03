using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace motekarteknologi.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Topnavigation()
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

        public IActionResult CollapsedSidebar()
        {
            return View();
        }
    }
}