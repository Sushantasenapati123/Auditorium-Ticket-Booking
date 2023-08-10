using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OHSB.IRepository.OHSB_IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.Domain.OHSB_Master;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;

namespace OHSB.Web.Controllers
{
    public class OHSBController : Controller
    {
        private  IHostingEnvironment _hostingEnvironment;
        private readonly IOHSB_Master _Repository;
        public IConfiguration Configuration { get; }
        public OHSBController(IHostingEnvironment hostingEnvironment, IOHSB_Master repository, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
        }
        public async Task<IActionResult> Add()
        {        
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(OHSB_Entity doc)
        {
            int retMsg = _Repository.CreateDepartMent(doc).Result;

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
        public async Task<IActionResult> ViewData()
        {
            
            ViewBag.Result = await _Repository.GetAllDepartment();
            return View();
            
        }       
        [HttpPost]
        public IActionResult Delete(OHSB_Entity Id)
        {
            try
            {
                int Result = _Repository.deleteDepartment(Id).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        [HttpGet]
        public IActionResult Getbyid(int DepartmentId)
        {
            var client = _Repository.GetDepartmentbydepartmentId(Convert.ToInt32(DepartmentId)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }


        /////Designation/////////////
        
        public async Task<IActionResult> AddDesignation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddDesignation(OHSB_Entity doc)
        {
            int retMsg = _Repository.CreateDesignation(doc).Result;

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
        public async Task<IActionResult> ViewDesignation()
        {

            ViewBag.Result = await _Repository.GetAllDesignation();
            return View();

        }
        [HttpPost]
        public IActionResult DeleteDesignation(OHSB_Entity Id)
        {
            try
            {
                int Result = _Repository.deleteDesignation(Id).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        [HttpGet]
        public IActionResult GetDesigbyid(int DesignationId)
        {
            var client = _Repository.GetDesignationbyDesignationId(Convert.ToInt32(DesignationId)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }


        ////////////////////Role///////////////////////
        public async Task<IActionResult> AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(OHSB_Entity doc)
        {
            int retMsg = _Repository.CreateRoll(doc).Result;

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
        public async Task<IActionResult> ViewRole()
        {

            ViewBag.Result = await _Repository.GetAllRoll();
            return View();

        }
        [HttpPost]
        public IActionResult DeleteRole(OHSB_Entity Id)
        {
            try
            {
                int Result = _Repository.deleteRoll(Id).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        [HttpGet]
        public IActionResult GetRolebyid(int RollID)
        {
            var client = _Repository.GetRollbyRollId(Convert.ToInt32(RollID)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }

    }
}
