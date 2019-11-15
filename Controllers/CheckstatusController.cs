using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using netcore.Models;

namespace netcore.Controllers
{
    public class CheckstatusController : Controller
    {
        public IActionResult Index()
        {
            Connectdb context = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
            string strSQL;
            MySqlDataReader dtReader;
            strSQL = "SELECT a.id,a.idstudent,a.username,a.lastname,a.email,a.idTeacher,a.status,b.id,b.idteacher,b.Name,b.Skill,b.image FROM student a INNER JOIN teacher b ON a.idteacher = b.id WHERE a.id = '" + User.FindFirst("id").Value + "'";
            dtReader = context.QueryDataReader(strSQL);
            dtReader.Read();
            if (dtReader.HasRows == true) {
                ViewBag.teachername = dtReader["Name"].ToString();
                ViewBag.teacherskill = dtReader["Skill"].ToString();
                ViewBag.teacherimage = dtReader["image"].ToString();
                ViewBag.teacherstatus = dtReader["status"].ToString();
            }
            return View();
        }
    }
}