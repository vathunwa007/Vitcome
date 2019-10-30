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
            /*
                HttpContext.Session.SetString("login", "1");
                HttpContext.Session.SetString("idstudent", dtReader["idstudent"].ToString());
                HttpContext.Session.SetString("password", dtReader["password"].ToString());
                HttpContext.Session.SetString("username", dtReader["username"].ToString());
                HttpContext.Session.SetString("lastname", dtReader["lastname"].ToString());
                HttpContext.Session.SetString("year", dtReader["year"].ToString());
                HttpContext.Session.SetString("email", dtReader["email"].ToString());
                HttpContext.Session.SetString("telephone", dtReader["telephone"].ToString());
                */
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