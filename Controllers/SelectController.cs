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
        public IActionResult Index(double idstudent, double password, string name, string lastname, int year, string email, double telephone)
        {
            var register = new RegisterModel
            {
                Idstudent = idstudent,
                Password = password,
                Name = name,
                Lastname = lastname,
                Year = year,
                Email = email,
                Telephone = telephone
            };

            return View(register);
        }
        public IActionResult Save(double idstudent, double password, string name, string lastname, int year, string email, double telephone)
        {
            
            if (idstudent == 1)
            {

                return RedirectToAction("Techer", "Home");
            }
            else { return RedirectToAction("Index", "Home"); }

        }
    }
}