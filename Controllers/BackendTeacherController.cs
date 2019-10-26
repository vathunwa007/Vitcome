using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using netcore.Models;
using MySql.Data.MySqlClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace netcore.Controllers
{
    public class BackendTeacherController : Controller
    {
        public IActionResult Index()
        {
     
            Connectdb context = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;

            return View(context.BackendTeachers());
        }
        public IActionResult MainIndex()
        {
            return View();
        }
    }
}


/*public IActionResult Index()
{

    Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
    string strSQL;
    MySqlDataReader dtReader;
    strSQL = "SELECT a.title,a.timeimage,b.username FROM savecs1 a Inner Join student b ON a.studentid=b.id WHERE b.idTeacher = 1";

    dtReader = con.QueryDataReader(strSQL);


    dtReader.Read();

    ViewBag.username = dtReader["username"].ToString();

    ViewBag.title = dtReader["title"].ToString();

    ViewBag.timeimage = dtReader["timeimage"].ToString();

    return View();
}*/



//public IActionResult Addcomment(BackendTeacheraddform backendTeacherform)
//{
  // Connectdb Addcomment = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
  // Addcomment.Addcommemt(backendTeacherform);
   //return RedirectToAction("Index");
//}



