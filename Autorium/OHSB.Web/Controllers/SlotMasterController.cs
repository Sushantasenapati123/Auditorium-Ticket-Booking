using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.IRepository.SlotMaster;
using Microsoft.Extensions.Configuration;
using OHSB.Domain.SlotMaster;
using Newtonsoft.Json;

namespace OHSB.Web.Controllers
{
    public class SlotMasterController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly ISlotRepository _Repository;
        public IConfiguration Configuration { get; }
        public SlotMasterController(IHostingEnvironment hostingEnvironment, ISlotRepository repository, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
        }
        public async Task<IActionResult> AddSlot()
        {
            ViewBag.AuditoriumID = _Repository.AuditoriumDDL().Result;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSlot(SlottimeEntity doc)
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
        public async Task<IActionResult> ViewSlot()
        {

            ViewBag.Result = await _Repository.GetAllSlot(new SlottimeEntity());
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> ViewData(SlottimeEntity client)
        {
            ViewBag.Result = await _Repository.GetAllSlot(client);
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
        public IActionResult Getbyid(int SlotID)
        {
            var client = _Repository.GetbyidSlot(Convert.ToInt32(SlotID)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
        [HttpGet]
        public IActionResult GetSlotByHospitalId(int AuditoriumID)
        {
            var Slots = _Repository.SlotAIdDDL(AuditoriumID).Result;
            return Ok(JsonConvert.SerializeObject(Slots));
        }
    }
}
