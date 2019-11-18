using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using netcore.Models;
using System.Data;
using Microsoft.AspNetCore.Hosting;


namespace netcore.Controllers
{
    //[ValidateAntiForgeryToken]
    public class HomeController : Controller
    {
        private readonly RequestHandler _requestHandler;
        private IConverter _converter;
        private IHostingEnvironment _hostingEnvironment;


        public HomeController(IConverter converter, RequestHandler requestHandler, IHostingEnvironment hostingEnvironment)
        {
            _converter = converter;
            _requestHandler = requestHandler;
            _hostingEnvironment = hostingEnvironment;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {


            return View();

        }

        public IActionResult Privacy()
        {


            return View();
        }
        // [Route("Home/Detail/{name}")]

        [Authorize(Roles = "Student")]
        public IActionResult Detail()
        {

            Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
            string strSQL;
            MySqlDataReader dtReader;
            strSQL = "SELECT * FROM savecs1 WHERE studentid = '" + User.FindFirst("id").Value + "' ";
            dtReader = con.QueryDataReader(strSQL);
            dtReader.Read();
            if (dtReader.HasRows == true)
            {

                ViewBag.name = dtReader["name"].ToString();
                ViewBag.lastname = dtReader["lastname"].ToString();
                ViewBag.idstudent = dtReader["idstudent"].ToString();
                ViewBag.sector = dtReader["sector"].ToString();
                ViewBag.title = dtReader["title"].ToString();
                ViewBag.titleEng = dtReader["titleEng"].ToString();
                ViewBag.importance = dtReader["importance"].ToString();
                ViewBag.objective = dtReader["objective"].ToString();
                ViewBag.reasoning = dtReader["reasoning"].ToString();
                ViewBag.timeimage = dtReader["timeimage"].ToString();
                ViewBag.scope = dtReader["scope"].ToString();
                return View();
            } else {

                return View();
            }
        }

        [Authorize(Roles = "Student")]
        [HttpGet]
        public IActionResult Techer()

        {

            Connectdb context = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
            string strSQL;
            MySqlDataReader dtReader;
            strSQL = "SELECT * FROM savecs1 WHERE studentid = '" + User.FindFirst("id").Value + "' ";
            dtReader = context.QueryDataReader(strSQL);
            dtReader.Read();
            string strSQL2;
            MySqlDataReader dtReader2;
            strSQL2 = "SELECT * FROM student WHERE id = '" + User.FindFirst("id").Value + "' ";
            dtReader2 = context.QueryDataReader(strSQL2);
            dtReader2.Read();

            if (dtReader.HasRows == true)
            {
                ViewBag.FormPass = true;
            }
            else {

                ViewBag.FormPass = false;
            }
            if (dtReader2.GetInt64("idteacher") != 0) {

                ViewBag.teacherpass = true;
            }
            else {

                ViewBag.teacherpass = false;
            }
            return View(context.GetAllTecher());
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]//-------------------------------------------ฟั่งชั่นในการสมัครสมาชิก----------------------------------------------------------------//
        [AllowAnonymous]
        public async Task<IActionResult> Save(Register regis)
        {

            if (ModelState.IsValid)
            {
                Connectdb context = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
                context.Register(regis);
                return RedirectToAction("Index", "Select");
            }
            return View("Index");

        }

        [HttpPost]//----------------------------ฟั่งชั้นบันทึกแบบฟอร์ม CS1 ---------------------//
        public IActionResult SaveCs1(FormCs1Model result)
        {
            //-----------------------อัพโหลดไฟล์รูปเข้าระบบ--------------------------------------
            string namenew = null;
            if (result.timeimage != null)
            {
                string uploads = Path.Combine(_hostingEnvironment.WebRootPath, "img");
                namenew = Guid.NewGuid().ToString() + "_" + result.timeimage.FileName;
                string filePath = Path.Combine(uploads, namenew);
                result.timeimage.CopyTo(new FileStream(filePath, FileMode.Create));

            }
            //---------------------------------------------------------------------------------------------
            Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
            string strSQL;
            MySqlDataReader dtReader;
            strSQL = "INSERT INTO `savecs1`(`name`,`lastname`,`idstudent`,`sector`,`title`,`titleEng`,`importance`,`objective`,`reasoning`,`timeimage`,`scope`,`studentid`) VALUES" +
                " ('" + result.name + "','" + result.lastname + "','" + result.idstudent + "','" + result.sector + "','" + result.title + "','" + result.titleEng + "','" + result.importance + "','" + result.objective + "','" + result.reasoning + "','" + namenew + "','" + result.scope + "','" + User.FindFirst("id").Value + "'); ";

            con.QueryDataSet(strSQL);



            return RedirectToAction("Detail", new { savecs1 = "success" });
        }
        [HttpPost]//----------------------------ฟั่งชั้นบันทึกแบบฟอร์ม CS1 ---------------------//
        public IActionResult updatecs1(FormCs1Model result)
        {
            //-------------------------------------------------ฟังชั่นในการอัพโหลดไฟล์ลงระบบ**********************-----------
            string namenew = null;
            if (result.timeimage != null)
            {
                string uploads = Path.Combine(_hostingEnvironment.WebRootPath, "img");
                namenew = Guid.NewGuid().ToString() + "_" + result.timeimage.FileName;
                string filePath = Path.Combine(uploads, namenew);
                result.timeimage.CopyTo(new FileStream(filePath, FileMode.Create));
                //------------------------------------------------------------อัพเดทข้อมูลในระบบ--------------------------
                Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
                string strSQL;
                MySqlDataReader dtReader;
                strSQL = "UPDATE `savecs1`  SET `name` ='" + result.name + "' ,`lastname`= '" + result.lastname + "',`idstudent`= '" + result.idstudent + "',`sector`='" +
                    result.sector + "' ,`title`= '" + result.title + "',`titleEng`= '" + result.titleEng + "',`importance`='" + result.importance + "' ,`objective`= '" + result.objective + "',`reasoning`='" + result.reasoning + "' ,`timeimage`='" + namenew + "' ,`scope`='" + result.scope + "' ,`studentid`= '" + User.FindFirst("id").Value + "' WHERE studentid = '" + User.FindFirst("id").Value + "' ";

                con.QueryDataSet(strSQL);
                return RedirectToAction("Detail", new { update = "success" });
            }
            else {
                //------------------------------------------------------------อัพเดทข้อมูลในระบบถ้าไม่มีรูป--------------------------

                Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
                string strSQL;
                MySqlDataReader dtReader;
                strSQL = "UPDATE `savecs1`  SET `name` ='" + result.name + "' ,`lastname`= '" + result.lastname + "',`idstudent`= '" + result.idstudent + "',`sector`='" +
                    result.sector + "' ,`title`= '" + result.title + "',`titleEng`= '" + result.titleEng + "',`importance`='" + result.importance + "' ,`objective`= '" + result.objective + "',`reasoning`='" + result.reasoning + "' ,`scope`='" + result.scope + "' ,`studentid`= '" + User.FindFirst("id").Value + "' WHERE studentid = '" + User.FindFirst("id").Value + "' ";

                con.QueryDataSet(strSQL);
                return RedirectToAction("Detail", new { update = "success" });
            }


        }

        [HttpPost]//----------------------------ฟั่งชันในการล็อกอิน--------------------------------------//
        [AllowAnonymous]
        public async Task<IActionResult> Index(LoginModel login)
        {

            if (ModelState.IsValid)
            {
                if (login.checkteacher == false)
                {
                    Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
                    string strSQL;
                    MySqlDataReader dtReader;
                    strSQL = "SELECT * FROM student WHERE idstudent ='" + login.idstudent + "'";
                    dtReader = con.QueryDataReader(strSQL);

                    if (dtReader.HasRows == true)
                    {
                        dtReader.Read();
                        if (dtReader["password"].ToString() == login.password)
                        {
                            var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, dtReader["idstudent"].ToString()),
                        new Claim(ClaimTypes.Role,"Student"),
                        new Claim("id",dtReader["id"].ToString()),
                        new Claim("username",dtReader["username"].ToString()),
                        new Claim("lastname",dtReader["lastname"].ToString()),
                        new Claim("year",dtReader["year"].ToString()),
                        new Claim("email",dtReader["email"].ToString()),
                        new Claim("telephone",dtReader["telephone"].ToString())
                        //วิธีเข้าถึง claim ที่สร้างเอง= User.FindFirst("username").Value;
                        //วิธีเข้าถึงClaim ของฟังชั่น = User.Identity.Name; 
                        //ตรวจสอบ  [Authorize]
                        //ละเว้นการตรวจสอบ    [AllowAnonymous]


                       
                    };
                            var claimsIdentity = new ClaimsIdentity(
                            claims,
                            CookieAuthenticationDefaults.AuthenticationScheme);

                            await HttpContext.SignInAsync(
                                CookieAuthenticationDefaults.AuthenticationScheme,
                                new ClaimsPrincipal(claimsIdentity));
                            TempData["UserLoginPass"] = "Login Pass";
                            return RedirectToAction("Index", "Select");
                        }
                        else
                        {
                            TempData["UserLoginfail"] = "รหัสผ่านหรือพาสเวิดไม่ถูกต้อง";
                            return View();
                        }
                    }


                }
                else
                {
                    Connectdb con = HttpContext.RequestServices.GetService(typeof(netcore.Models.Connectdb)) as Connectdb;
                    string strSQL;
                    MySqlDataReader dtReader;
                    strSQL = "SELECT * FROM teacher WHERE idteacher ='" + login.idstudent + "'";
                    dtReader = con.QueryDataReader(strSQL);

                    if (dtReader.HasRows == true)
                    {
                        dtReader.Read();
                        if (dtReader["password"].ToString() == login.password)
                        {
                            var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, dtReader["Id"].ToString()),
                        new Claim(ClaimTypes.Role,"Admin", dtReader["idteacher"].ToString()),
                        new Claim("username",dtReader["Name"].ToString()),
                        new Claim("lastname",dtReader["skill"].ToString()),
                       
                        //วิธีเข้าถึง claim ที่สร้างเอง= User.FindFirst("username").Value;
                        //วิธีเข้าถึงClaim ของฟังชั่น = User.Identity.Name; 
                        //ตรวจสอบ  [Authorize]
                        //ละเว้นการตรวจสอบ    [AllowAnonymous]


                       
                    };
                            var claimsIdentity = new ClaimsIdentity(
                            claims,
                            CookieAuthenticationDefaults.AuthenticationScheme);

                            await HttpContext.SignInAsync(
                                CookieAuthenticationDefaults.AuthenticationScheme,
                                new ClaimsPrincipal(claimsIdentity));
                            return RedirectToAction("Index", "Backendteacher");
                        }
                        else
                        {
                            TempData["UserLoginfail"] = "ล็อกอินไม่สำเร็จ ชื่อหรือรหัสผ่านของคุณไม่ถูกต้องกรุณาเช็คและทำการเชื่อมต่อ";
                            return RedirectToAction("Index", "Home");
                        }

                    }
                }

            }
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            HttpContext.SignOutAsync(
         CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

      





    }


}
