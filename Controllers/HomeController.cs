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
            var order = new List<Order>();
            new Order()
            {
            Id = 1,
            Name = "Thunwa"
            };
            new Order(){
                Id = 2,
                Name ="Nisama"
            };


            return View(order);
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
        public IActionResult Techer()
        {

            var techer = new List<Techer>();
            techer.Add(new Techer(){
                 Id = 1,
                 Name = "รวินทร์ คงอำไพ",
                 Skill = "๋Java langust",
                 Status = "ยังไม่เต็ม"


            });
            techer.Add(new Techer(){
                 Id = 2,
                 Name = "เบนซ์ เรสซิ่ง",
                 Skill = "๋PyThon langules",
                 Status = "ยังไม่เต็ม"


            });
            techer.Add(new Techer(){
                 Id = 3,
                 Name = "ตรีพล งงมากๆ",
                 Skill = "๋WalkPlay",
                 Status = "ยังไม่เต็ม"


            });

            return View(techer);
        }


       


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }

}
