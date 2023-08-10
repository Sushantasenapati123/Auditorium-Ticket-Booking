using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.Domain.Row_SeatMaster;
using OHSB.IRepository.Row_SeatMaster;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace OHSB.Web.Controllers
{
    public class AuditoriumCapacityController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly IRowSeatRepo _Repository;
        public IConfiguration Configuration { get; }
        public AuditoriumCapacityController(IHostingEnvironment hostingEnvironment, IRowSeatRepo repository, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
        }
        public async Task<IActionResult> Add()
        {
            ViewBag.Row_No = _Repository.BindRows().Result;
            ViewBag.AuditoriumID = _Repository.BindAuditorium().Result;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(RowSeatEntity doc)
        {
            int retMsg = _Repository.Create(doc).Result;

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

            ViewBag.Result = await _Repository.GetAll();
            return View();

        }
        //[HttpPost]
        //public async Task<IActionResult> ViewData(OHSB_Entity client)
        //{
        //    ViewBag.Result = await _Repository.GetAllData(client);
        //    return View();
        //}
        [HttpPost]
        public IActionResult Delete(RowSeatEntity Id)
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
        public IActionResult Getbyid(int AuditseatID)
        {
            var client = _Repository.Getbyid(Convert.ToInt32(AuditseatID)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }

    }
}

