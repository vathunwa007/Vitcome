using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netcore.Models;


namespace netcore.Controllers
{
    public class SelectController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.show = User.Identity.Name;

            
            return View();
        }

        public bool checklogin()
        { //--------------------------------------ฟังชั่นทำการเช็คสถานะการล็อกอินเข้ามา---------------------------//
            bool result = false;

            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("login")))
                {
                  return  result = true;
                }
            }
            catch (Exception e)
            {
                RedirectToAction("Index","Home");
            }
            return result;
        }

    }
}