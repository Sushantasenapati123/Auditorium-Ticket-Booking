using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.IRepository.SeatMaster;
using Microsoft.Extensions.Configuration;
using OHSB.IRepository.RowMaster;
using OHSB.IRepository.AuditoriumIRepository;
using OHSB.Domain.RowMaster;
using OHSB.Domain.SeatMaster;
using Newtonsoft.Json;

namespace OHSB.Web.Controllers
{
    public class SeatMasterController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly ISeatRepo _Repository;
        private readonly IRowRepository _rowrepo;
        private readonly IAuditoriumRepo _auditoriumrepo;

        public IConfiguration Configuration { get; }
        public SeatMasterController(IHostingEnvironment hostingEnvironment, ISeatRepo repository, IAuditoriumRepo auditoriumRepo, IRowRepository rowrepo, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
            _rowrepo = rowrepo;
            _auditoriumrepo = auditoriumRepo;
        }
        public IActionResult AddSeatInfo()
        {
            ViewBag.AuditoriumID = _auditoriumrepo.GetAll().Result;
            ViewBag.Row_No = _rowrepo.GetAllRows(new RowEntity()).Result;
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> AddSeatInfo(SeatEntity entity)
        {
            try
            {
                if (entity.SeatId != 0)
                {
                    int retMsgd = _Repository.deleteSeatNos(entity.SeatId).Result;
                    int retMg = _Repository.InsertSeat(entity).Result;
                    SeatEntity sp = new SeatEntity();
                    sp = await _Repository.GetseatCapacitybyid(retMg);

                    for (int i = 1; i <= sp.SeatCapacity; i++)
                    {
                        SeatNumbers spp = new SeatNumbers();
                        spp.SeatId = retMg;
                        spp.SeatNos = i;
                        spp.AuditoriumID = entity.AuditoriumID;
                        spp.Row_No = entity.Row_No;
                        int hg = _Repository.insertSeatnos(spp).Result;

                    }
                    return Json("Record updated ");
                }
                else
                {   
                    
                    int retMsg = _Repository.InsertSeat(entity).Result;
                    if (retMsg != -2)
                    {
                        SeatEntity sp = new SeatEntity();
                        sp = await _Repository.GetseatCapacitybyid(retMsg);
                        for (int i = 1; i <= sp.SeatCapacity; i++)
                        {
                            SeatNumbers spp = new SeatNumbers();
                            spp.SeatId = retMsg;
                            spp.SeatNos = i;
                            spp.AuditoriumID = entity.AuditoriumID;
                            spp.Row_No = entity.Row_No;
                            int hg = _Repository.insertSeatnos(spp).Result;

                        }

                        return Json("SeatNos Saved Successfully");
                    }
                  
                }

                return Json("Record Already exist");

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult ViewSeatInfo()
        {
            ViewBag.AuditoriumID = _auditoriumrepo.GetAll().Result;
            ViewBag.Result = _Repository.GetAllSeat().Result;
            return View();
        }
       
        public IActionResult GetSeat( int AuditoriumID)
        {
            ViewBag.AuditoriumID = AuditoriumID;

            ViewBag.AuditoriumID = _auditoriumrepo.GetAll().Result;
            ViewBag.Resultdata = _Repository.GetSeatdetailsbyid(AuditoriumID).Result;
            return View("ViewSeatInfo");
        }
        [HttpPost]
        public IActionResult DeleteSeat(SeatEntity op)
        {
            try
            {
                int Result = _Repository.deleteSeat(op).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        [HttpGet]
        public IActionResult SeatGetById(int SeatId)
        {
            var SubMenus = _Repository.GetSeatbyid(Convert.ToInt32(SeatId)).Result;
            return Ok(JsonConvert.SerializeObject(SubMenus));
        }

        //Demo Seat Design

        public IActionResult DemoSeatDesign()
        {
            ViewBag.AuditoriumID = _auditoriumrepo.GetAll().Result;
            return View();
        }
        [HttpGet]
        public IActionResult SeatNosGetByAuditoriumId(int AuditoriumID)
        {
            var SubMenus = _Repository.GetSeatNosbyid(Convert.ToInt32(AuditoriumID)).Result;
            return Ok(JsonConvert.SerializeObject(SubMenus));
        }
    }
}
