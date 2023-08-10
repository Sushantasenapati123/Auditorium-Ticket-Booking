using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.IRepository.PriceMaster;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OHSB.Domain.PriceMaster;

namespace OHSB.Web.Controllers
{
    public class PriceMasterController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly IPriceRepository _Repository;
        //private readonly IAuditoriumRepo _auditoriumRepo;
        public IConfiguration Configuration { get; }
        public PriceMasterController(IHostingEnvironment hostingEnvironment, IPriceRepository repository, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
            //_auditoriumRepo = auditoriumRepo;
        }
        public async Task<IActionResult> AddPrice( )
        {
            ViewBag.AuditoriumID = _Repository.GetAllAuditorium().Result;           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPrice(PriceEntity doc)
        {
            int retMsg = _Repository.insertupdate(doc).Result;

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
        [HttpGet]
        public IActionResult GetBlockbyAuditoriumid(int AuditoriumID)
        {
            var client = _Repository.GetAllblock(Convert.ToInt32(AuditoriumID)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
        [HttpGet]
        public IActionResult GetRowkbyid(int BlockId)
        {
            var client = _Repository.GetAllRow(Convert.ToInt32(BlockId)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
        public async Task<IActionResult> ViewPrice()
        {

            ViewBag.Result = await _Repository.GetAllPrice();
            return View();

        }
        public IActionResult Delete(PriceEntity ent)
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
        public IActionResult Getbyid(int PriceId)
        {
            var client = _Repository.Getbyid(Convert.ToInt32(PriceId)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
    }
}
