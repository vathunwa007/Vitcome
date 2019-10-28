using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace netcore.Controllers
{
    public class TeacherController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int id)
        {
            Connectdb context = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
            ViewBag.id = id;

            return View(context.GetAllTecher());

            
        }

        public IActionResult Teacher()
        {
            Connectdb context = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
           

            return View(context.GetAllTecher());
        }


        [HttpGet]
        public IActionResult saveform(string name,string form)
        {
            return RedirectToAction("home","HomeController");
        }
    }
}
