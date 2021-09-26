using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaToDo.Controllers
{
    public class TareaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
