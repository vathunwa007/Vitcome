using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using netcore.Models;


namespace netcore.Controllers
{

	public class HomeController : Controller
	{

		public IActionResult Index()
		{

			return View();

		}


		public IActionResult Privacy()
		{


			return View();
		}

		public IActionResult Detail(string name, string lastname, string idstudent, string supername)
		{
			ViewBag.name = name;
			ViewBag.lastname = lastname;
			ViewBag.idstudent = idstudent;
			ViewBag.supername = supername;

			if (HttpContext.Session.GetString("login") == "1")
			{
				ViewBag.showsession = "login false";
			}
			else { ViewBag.showsession = "login pass"; }

			return View();
		}
		public IActionResult Techer()

		{
			Connectdb context = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;

			return View(context.GetAllTecher());
		}



		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		[HttpPost]//-------------------------------------------ฟั่งชั่นในการสมัครสมาชิก----------------------------------------------------------------//
		public async Task<IActionResult> Save(Register regis)
		{

			if (ModelState.IsValid)
			{
				Connectdb context = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
				context.Register(regis);
				return RedirectToAction("Index", "Select");
			}
			else { return RedirectToAction("Index", "Home"); }

		}


		[HttpPost]//----------------------------ฟั่งชั้นบันทึกแบบฟอร์ม CS1 ---------------------//
		public IActionResult SaveCs1(FormCs1Model saveform)
		{

			Connectdb saveformdata = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
			saveformdata.Savecs1(saveform);
			return RedirectToAction("Index");
		}
		[HttpPost]//----------------------------ฟั่งชันในการล็อกอิน--------------------------------------//
		public async Task<IActionResult> Login(LoginModel login)
		{

			Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
			string strSQL;
			MySqlDataReader dtReader;
			strSQL = "SELECT * FROM student WHERE idstudent ='" + login.idstudent + "' ";
			dtReader = con.QueryDataReader(strSQL);

			if (ModelState.IsValid)
			{
				if (dtReader.HasRows == true)
				{
					dtReader.Read();
					if (dtReader["password"].ToString() == login.password)
					{

						HttpContext.Session.SetString("login", "1");
						HttpContext.Session.SetString("idstudent", dtReader["idstudent"].ToString());
						HttpContext.Session.SetString("password", dtReader["password"].ToString());
						HttpContext.Session.SetString("username", dtReader["username"].ToString());
						HttpContext.Session.SetString("lastname", dtReader["lastname"].ToString());
						HttpContext.Session.SetString("year", dtReader["year"].ToString());
						HttpContext.Session.SetString("email", dtReader["email"].ToString());
						HttpContext.Session.SetString("telephone", dtReader["telephone"].ToString());

						return RedirectToAction("Index", "Select");
					}

				}

			}
			return RedirectToAction("Index");

		}


		public IActionResult Savefrom(Addfromteacher addfromteacher)
		{
			Connectdb saveform = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
			saveform.Addformteacher(addfromteacher);
			return RedirectToAction("Index");
		}
	}
}
       



