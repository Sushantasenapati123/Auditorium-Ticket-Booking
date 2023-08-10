using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.Domain.EmployeeMaster;
using OHSB.Domain.AuditoriumMaster;
using OHSB.IRepository.Employee_Master;
using OHSB.IRepository.AuditoriumIRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;

namespace OHSB.Web.Controllers
{
    public class AccountController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly IEmployeeRepository _Repository;
        private readonly IAuditoriumRepo _auditorium;
        public IConfiguration Configuration { get; }
        public AccountController(IHostingEnvironment hostingEnvironment, IEmployeeRepository repository, IAuditoriumRepo auditorium, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
            _auditorium = auditorium;
        }
        [HttpGet]
        public IActionResult Login()
        {           
            return View();
        }
        [HttpGet]
        public IActionResult NewUSerCreateAccount()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> Login(string UserName, string Password)
        {
          
            try
            {
                //string pass = EncodePasswordToBase64(Password);

                var x = await _Repository.UserGetByUserNamePwd(UserName, Password);
                if (x != null)
                {
                    if (x.UserName == UserName && x.Password == Password)
                    {
                        SetSession(x);//admin
                        return Json(x.DesignationId);
                    }
                

                }
                else
                {
                    return Json(x.DesignationId);
                }
            }
            catch (Exception ex)
            {
              
                return Json(0);
            }
            return Json(0);
        }
        public void SetSession(EmployeeEntity x)
        {
            HttpContext.Session.SetInt32("UserId", x.UserId);
            HttpContext.Session.SetString("UserName", x.UserName);
            HttpContext.Session.SetInt32("AuditoriumID", x.AuditoriumID);
            if(x.AuditoriumName==null)
            {
                HttpContext.Session.SetString("AuditoriumName", "Not Mention");
            }
            else
            HttpContext.Session.SetString("AuditoriumName", x.AuditoriumName);
            HttpContext.Session.SetString("Password", x.Password);
            HttpContext.Session.SetString("FullName", x.FullName);
            HttpContext.Session.SetString("Email", x.Email);
            HttpContext.Session.SetString("Mobile", x.Mobile);
            HttpContext.Session.SetString("Gender", x.Gender);
            HttpContext.Session.SetInt32("RollID", x.RollID);

        }
        [HttpGet]
        public async Task<IActionResult> ChangePassword()
        {
           
            ViewBag.RollName = HttpContext.Session.GetInt32("RollID");
            if (HttpContext.Session.GetString("UserName") != null)
            {
                ViewBag.pwd = HttpContext.Session.GetString("Password");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
        [HttpPost]
        public async Task<JsonResult> ChangePassword(EmployeeEntity doc)
        {
            //string s2 = EncodePasswordToBase64(doc.Password);
            //doc.Password = s2;
            doc.UserName = HttpContext.Session.GetString("UserName");//get
            var x = await _Repository.UpdatePassword(doc);
            if (x == 1)
            {
                return Json("Password Saved Successfully");
            }
            else if (x == 2)
            {
                return Json("Please check your inserted password");
            }
            return Json(x);
        }
        public IActionResult Logout()
        {
            //Delete the Session object.
            HttpContext.Session.Remove("UserName");
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }


        //Encode Password
        //public static string EncodePasswordToBase64(string password)
        //{
        //    try
        //    {
        //        byte[] encData_byte = new byte[password.Length];
        //        encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
        //        string encodedData = Convert.ToBase64String(encData_byte);
        //        return encodedData;
        //    }
        //    catch (Exception ex)
        //    {
        //        return password;
        //    }
        //}
    }

}
