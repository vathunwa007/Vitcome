using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcore.Models;


namespace netcore.Controllers
{
    public class SelectController : Controller
    {
        public IActionResult Index(/*int Idstudent, string Password, string Name, string Lastname, bool Year, string Email, int Telephone*/)
        {
         
            /*var register = new Register
            {
                Idstudent = Idstudent,
                Password = Password,
                Name = Name,
                Lastname = Lastname,
                Year = Year,
                Email = Email,
                Telephone = Telephone
            };*/

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Save(Register regis)
        {

            if (ModelState.IsValid)
            {
                Connectdb context = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
                context.Register(regis);
                return RedirectToAction("Index","Select");
            }
            else { return RedirectToAction("Index", "Home"); }

        }
    }
}