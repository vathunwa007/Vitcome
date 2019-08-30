using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcore.Models;

namespace netcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
           
        }

        public IActionResult Privacy()
        {
            return View();
        }
       // [Route("Home/Detail/{name}")]
        public IActionResult Detail (string name,string lastname,string idstudent,string supername)
       {
            ViewBag.name = name;
            ViewBag.lastname = lastname;
            ViewBag.idstudent = idstudent;
            ViewBag.supername = supername;
        

            return View();
        }

        



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
    
}
