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
    }
}
