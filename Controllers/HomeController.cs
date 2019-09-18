using System.Collections.Generic;
using System.Diagnostics;
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
                Showtecher context = HttpContext.RequestServices.GetService(typeof(netcore.Models.Showtecher)) as Showtecher;

                return View(context.GetAllTecher());
            }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public void Printpdf() {
          

        }
    }

}
