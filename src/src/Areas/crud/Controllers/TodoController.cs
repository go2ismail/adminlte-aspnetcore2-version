using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace src.Areas.crud.Controllers
{
    [Area("crud")]
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}