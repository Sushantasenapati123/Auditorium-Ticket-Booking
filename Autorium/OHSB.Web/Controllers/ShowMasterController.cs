using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.IRepository.ShowsMaster;
using OHSB.Domain.ShowsMaster;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace OHSB.Web.Controllers
{
    public class ShowMasterController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly IShowRepository _Repository;
        public IConfiguration Configuration { get; }
        public ShowMasterController(IHostingEnvironment hostingEnvironment, IShowRepository repository, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
        }
        public async Task<IActionResult> AddShow()
        {
            //ViewBag.id = _Repository.GetAllShowType().Result;
           ViewBag.AuditoriumID = _Repository.GetAllAuditorium().Result;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddShow(ShowEntity doc)
        {
            int retMsg = _Repository.insertupdateShow(doc).Result;

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
        public async Task<IActionResult> ViewShow()
        {

            ViewBag.Result = await _Repository.GetAllShowsData();
            return View();

        }
        public IActionResult Delete(ShowEntity Id)
        {
            try
            {
                int Result = _Repository.deleteShow(Id).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        [HttpGet]
        public IActionResult Getbyid(int ShowID)
        {
            var client = _Repository.GetShowsbyid(Convert.ToInt32(ShowID)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
    }
}
