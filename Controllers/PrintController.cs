using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using netcore.Models;

namespace netcore.Controllers
{
    public class PrintController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
            string strSQL;
            MySqlDataReader dtReader;
            strSQL = "SELECT * FROM savecs1 WHERE studentid = '"+ User.FindFirst("id").Value+"' ";
            dtReader = con.QueryDataReader(strSQL);
            dtReader.Read();
            FormCs1Model add = new FormCs1Model();
            add.name = dtReader["name"].ToString();
            add.lastname = dtReader["lastname"].ToString();
            add.idstudent = dtReader["idstudent"].ToString();
            add.sector = dtReader["sector"].ToString();
            add.title = dtReader["title"].ToString();
            add.titleEng = dtReader["titleEng"].ToString();
            add.importance = dtReader["importance"].ToString();
            add.objective = dtReader["objective"].ToString();
            add.reasoning = dtReader["reasoning"].ToString();
            ViewBag.timeimage = dtReader["timeimage"].ToString();
            add.scope = dtReader["scope"].ToString();

           

            return View(add);
        }
        [HttpGet]
        public IActionResult Showcs1backend(string idstudent)
        {

            Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
            string strSQL;
            MySqlDataReader dtReader;
            strSQL = "SELECT * FROM savecs1 WHERE studentid = '" + idstudent+ "' ";
            dtReader = con.QueryDataReader(strSQL);
            dtReader.Read();
            FormCs1Model add2 = new FormCs1Model();

            add2.name = dtReader["name"].ToString();
            add2.lastname = dtReader["lastname"].ToString();
            add2.idstudent = dtReader["idstudent"].ToString();
            add2.sector = dtReader["sector"].ToString();
            add2.title = dtReader["title"].ToString();
            add2.titleEng = dtReader["titleEng"].ToString();
            add2.importance = dtReader["importance"].ToString();
            add2.objective = dtReader["objective"].ToString();
            add2.reasoning = dtReader["reasoning"].ToString();
            ViewBag.timeimage = dtReader["timeimage"].ToString();
            add2.scope = dtReader["scope"].ToString();



            return View(add2);
        }
    }
}
