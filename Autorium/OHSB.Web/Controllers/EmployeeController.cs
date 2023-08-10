using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.IRepository.Employee_Master;
using Microsoft.Extensions.Configuration;
using OHSB.Domain.EmployeeMaster;
using OHSB.Domain.AuditoriumMaster;
using OHSB.IRepository.AuditoriumIRepository;
using Newtonsoft.Json;

namespace OHSB.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly IEmployeeRepository  _Repository;
        private readonly IAuditoriumRepo _auditorium;
        public IConfiguration Configuration { get; }
        public EmployeeController(IHostingEnvironment hostingEnvironment, IEmployeeRepository repository, IAuditoriumRepo auditorium,IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
            _auditorium = auditorium;
        }
        public IActionResult AddUser()
        {
            ViewBag.AuditoriumID = _auditorium.GetAll().Result;
            ViewBag.DepartmentId = _Repository.BindDepartment().Result;
            ViewBag.DesignationId = _Repository.BindDesignation().Result;
            ViewBag.RollID = _Repository.BindRole().Result;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(EmployeeEntity doc)
        {
            int retMsg = _Repository.insert(doc).Result;

            if (retMsg == 1)
            {
                return Json("Record Saved Successfully");
            }
            else if (retMsg == 2)
            {
                return Json("Record Updated Successfully");
            }
            else if (retMsg == 3)
            {
                return Json("Record Deleted Successfully");
            }
            else
            {
                return Json("Record Already Exist");
            }
        }
        public async Task<IActionResult> ViewUser()
        {

            ViewBag.Result = await _Repository.GetAllUser(new EmployeeEntity());
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> ViewUser(EmployeeEntity client)
        {
            ViewBag.Result = await _Repository.GetAllUser(client);
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int Id)
        {
            try
            {
                int Result = _Repository.delete(Id).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        [HttpGet]
        public IActionResult Getbyid(int UserId)
        {
            var client = _Repository.GetbyidUser(Convert.ToInt32(UserId)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
    }
}
