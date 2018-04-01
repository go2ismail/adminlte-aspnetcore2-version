using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace src.Areas.adminlte.Controllers
{
    [Area("adminlte")]
    public class MailboxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Compose()
        {
            return View();
        }

        public IActionResult ReadMail()
        {
            return View();
        }
    }
}