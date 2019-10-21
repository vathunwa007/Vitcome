using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using netcore.Models;
using netcore.Untity;





namespace netcore.Controllers
{

     //[IActionfilter]
    public class HomeController : Controller
    {
        private IConverter _converter;

        public HomeController(IConverter converter)
        {
            _converter = converter;
        }
        public IActionResult Index()
        {

            return View();

        }

        public IActionResult Privacy()
        {


            return View();
        }
        // [Route("Home/Detail/{name}")]
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
            strSQL = "SELECT * FROM student WHERE idstudent ='" + login.idstudent + "'";
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
        [HttpGet]

        public IActionResult CreatePDF()
        {

            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report",
                ViewportSize = "1920x1080",
                DPI = 300
            };

            var objectSettings = new ObjectSettings
            {
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "main.css"), },


                UseLocalLinks = false,
                UseExternalLinks = false,
                ProduceForms = false,

                PagesCount = true,
                HtmlContent = TemplateGenerator.GetHTMLString(),
                //Page = "www.youtube.com",
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report CS1" }

            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);
            return File(file, "application/pdf");
        }


    }

}
