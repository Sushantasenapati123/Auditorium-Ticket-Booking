using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.IRepository.AuditoriumIRepository;
using OHSB.Domain.AuditoriumMaster;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace OHSB.Web.Controllers
{
    public class AuditoriumMasterController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly IAuditoriumRepo _Repository;
        public IConfiguration Configuration { get; }
        public AuditoriumMasterController(IHostingEnvironment hostingEnvironment, IAuditoriumRepo repository, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
        }
        public async Task<IActionResult> AddAuditorium()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAuditorium(AuditoriumEntity doc)
        {
            int retMsg = _Repository.CreateAuditorium(doc).Result;

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
        public async Task<IActionResult> ViewAuditorium()
        {

            ViewBag.Result = await _Repository.GetAll();
            return View();

        }

        [HttpPost]
        public IActionResult Delete(AuditoriumEntity ent)
        {
            try
            {
                int Result = _Repository.delete(ent).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        [HttpGet]
        public IActionResult Getbyid(int AuditoriumID)
        {
            var client = _Repository.Getbyid(Convert.ToInt32(AuditoriumID)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
    }
}
