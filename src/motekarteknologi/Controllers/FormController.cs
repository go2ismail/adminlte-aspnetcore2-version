using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace motekarteknologi.Controllers
{
    public class FormController : Controller
    {
        public IActionResult GeneralElement()
        {
            return View();
        }

        public IActionResult AdvancedElement()
        {
            return View();
        }

        public IActionResult Editor()
        {
            return View();
        }
    }
}