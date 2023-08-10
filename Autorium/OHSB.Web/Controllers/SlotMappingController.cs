using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.IRepository.SlotMappingMaster;
using OHSB.IRepository.SlotMaster;
using OHSB.IRepository.ShowsMaster;
using OHSB.IRepository.AuditoriumIRepository;
using OHSB.Domain.SlotMapping;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace OHSB.Web.Controllers
{
    public class SlotMappingController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly ISlotMapping _Repository;
        private readonly IShowRepository _ShowRepository;
        private readonly ISlotRepository _slotRepository;
        private readonly IAuditoriumRepo _audiRepository;
        public IConfiguration Configuration { get; }
        public SlotMappingController(IHostingEnvironment hostingEnvironment, ISlotMapping repository, IShowRepository showRepository,ISlotRepository slotRepository,IAuditoriumRepo auditoriumRepo,IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
            _audiRepository = auditoriumRepo;
            _slotRepository = slotRepository;
            _ShowRepository = showRepository;
        }
        public IActionResult AddSlotMapping()
        { 
                ViewBag.AuditoriumID = _audiRepository.GetAll().Result;
                ViewBag.ShowID = _ShowRepository.GetAllShowsData().Result;
                return View(); 
        }
        public async Task<IActionResult> ViewSlotMapping()
        {
            ViewBag.Result = await _Repository.GetAll(new SlotMappingEntity());
                return View();
        }
        [HttpPost]
        public async Task<JsonResult> AddSlotMapping(SlotMappingEntity entity)
        {
            try
            {
                int retMsg = 0;
                if (entity.SMID != 0)
                {
                    //First Delete And Then Update The Data
                    int retdMsg = _Repository.DeleteToUpdate(entity.SlotID, entity.ShowID).Result;
                    
                        retMsg = _Repository.Create(entity).Result;
                   
                }
                else
                {
                    //Insert Data
                    retMsg = _Repository.Create(entity).Result;
                    
                }

                if (retMsg == 1)
                {
                    return Json("Record Saved Successfully");
                }
                else if (retMsg == 2)
                {
                    return Json("Record Updated Successfully");
                }
                else
                {
                    return Json("Record Already Exist");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public IActionResult DeleteSlotMapping(int SMID)
        {
            try
            {
                int Result = _Repository.Delete(SMID).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        [HttpGet]
        public IActionResult SlotMappingGetById(int SlotID, int ShowID)
        {
            var slotMapping = _Repository.GetAllShiftBySAndDId(Convert.ToInt32(SlotID), Convert.ToInt32(ShowID)).Result;
            return Ok(JsonConvert.SerializeObject(slotMapping));
        }
        //[HttpGet]
        //public IActionResult SlotTimeByHnSId(int AuditoriumID, int SlotID)
        //{
        //    var slotMapping = _Repository.SlotTimeByHnSId(Convert.ToInt32(AuditoriumID), Convert.ToInt32(SlotID)).Result;
        //    return Ok(JsonConvert.SerializeObject(slotMapping));
        //}
    }
}
