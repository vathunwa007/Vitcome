using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netcore.Controllers
{
    public class CheckstatusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}