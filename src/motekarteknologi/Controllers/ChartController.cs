using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace motekarteknologi.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Chartjs()
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

        public IActionResult InlineChart()
        {
            return View();
        }
    }
}