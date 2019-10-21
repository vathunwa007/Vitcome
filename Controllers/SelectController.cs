using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netcore.Models;


namespace netcore.Controllers
{
    public class SelectController : Controller
    {
        public IActionResult Index()
        {
            
            if (checklogin() == true)
            {
                ViewBag.show = "ล็อกอินสำเร็จ";
                ViewBag.show = HttpContext.Session.GetString("username");

            }
            else
            {
                ViewBag.show = HttpContext.Session.GetString("username");
            }

            return View();
        }

        public bool checklogin()
        { //--------------------------------------ฟังชั่นทำการเช็คสถานะการล็อกอินเข้ามา---------------------------//
            bool result = false;

            if (HttpContext.Session.GetString("login") != null)
            {

                if (HttpContext.Session.GetString("login") == "1")
                {
                    result = true;
                }

            }
            return result;
        }

    }
}