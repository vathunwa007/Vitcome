using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using netcore.Models;

namespace netcore.Controllers
{
    public class CheckstatusController : Controller
    {
        public IActionResult Index()
        {
            Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
            string strSQL;
            MySqlDataReader dtReader;
            strSQL = "SELECT a.Id,a.Name,a.Skill,b.status,b.comment FROM techer a Inner Join student b ON  a.Id=b.idTeacher WHERE b.idTeacher = 5 ";

            dtReader = con.QueryDataReader(strSQL);


            dtReader.Read();

            ViewBag.idteacher = dtReader["Name"].ToString();

            ViewBag.skill = dtReader["Skill"].ToString();


            ViewBag.status = dtReader["status"];

            ViewBag.comment = dtReader["comment"].ToString();




            return View();

        }


      /*  public async Task <IActionResult> Checkstatus()
        {
           	Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
			string strSQL;
			MySqlDataReader dtReader;
			strSQL = "SELECT a.idstudent a.idTeacher,b.id,b.Skill FORM student a Inner Join techer b ON a.idTeacher = b.id WHERE a.idstudent = '15' ";

            dtReader = con.QueryDataReader(strSQL);

			
					dtReader.Read();
				
                    ViewBag.idteacher = dtReader["idTeacher"].ToString();

                    ViewBag.skill = dtReader["Skill"].ToString();
					
					

				

			
			return RedirectToAction("Index");

        }*/
    }
}
