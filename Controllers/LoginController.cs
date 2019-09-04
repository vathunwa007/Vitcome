using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcore.Models;

namespace netcore.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult  index()
        {

            return View();

        }


    }
}