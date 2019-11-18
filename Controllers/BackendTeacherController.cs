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
            var idteacher = User.Identity.Name;
            return View(context.BackendTeachers(idteacher));
        }
        [HttpGet]
        public IActionResult MainIndex(int id)
        {
           
            Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
            string strSQL;
            MySqlDataReader dtReader;
            strSQL = "SELECT a.title,a.timeimage,b.username FROM savecs1 a Inner Join student b ON a.studentid=b.id WHERE a.studentid = '"+id+"' ";

            dtReader = con.QueryDataReader(strSQL);


            dtReader.Read();

            ViewBag.id = id;
            ViewBag.title = dtReader["title"].ToString();

            ViewBag.timeimage = dtReader["timeimage"].ToString();

            ViewBag.Name = dtReader["username"].ToString(); 
            return View();
        }
        public IActionResult ShowData(showdata showdataform)
        {

            Connectdb show = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
            show.Showdata(showdataform);

            return View("MainIndex");

        }
        [HttpGet]
        public async Task<IActionResult> Comment(string comment,int idstudent,int status)
        {
            if (status == null)
            {

                Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
                string strSQL;
                MySqlDataReader dtReader;
                strSQL = "UPDATE `student` SET comment = '" + comment + "', status= '" + status + "' WHERE `id` = " + idstudent + " ";
                //dtReader = con.QueryDataReader(strSQL);
                con.QueryDataTable(strSQL);
                return RedirectToAction("Index", "BackendTeacher");

            }
            else
            {
                if (status == 2)
                {
                    Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
                    string strSQL;
                    MySqlDataReader dtReader;
                    strSQL = "UPDATE `student` SET idteacher = 0 ,comment = '', status= 0 WHERE `id` = " + idstudent + " ";
                    //dtReader = con.QueryDataReader(strSQL);
                    con.QueryDataTable(strSQL);
                    return RedirectToAction("Index", "BackendTeacher");
                }
                else
                {
                    Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
                    string strSQL;
                    MySqlDataReader dtReader;
                    strSQL = "UPDATE `student` SET comment = '" + comment + "', status= '" + status + "' WHERE `id` = " + idstudent + " ";
                    //dtReader = con.QueryDataReader(strSQL);
                    con.QueryDataTable(strSQL);
                    return RedirectToAction("Index","BackendTeacher");
                }
            }
        }

    }
}


        /*public IActionResult MainIndex()
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



