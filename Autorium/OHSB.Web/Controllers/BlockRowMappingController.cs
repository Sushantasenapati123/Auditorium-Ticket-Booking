using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OHSB.IRepository.AuditoriumIRepository;
using OHSB.IRepository.BlockMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.IRepository.BlockRowMapping;
using OHSB.Domain.BlockRowMapping;


namespace OHSB.Web.Controllers
{
    public class BlockRowMappingController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly IAuditoriumRepo _Repository;
        private readonly IBlockRepo _BlockRepo;
        private readonly IBlockMappingRepository _blockMapping;
        public IConfiguration Configuration { get; }
        public BlockRowMappingController(IHostingEnvironment hostingEnvironment, IAuditoriumRepo repository, IBlockRepo blockRepo, IBlockMappingRepository blockMapping, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
            _BlockRepo = blockRepo;
            _blockMapping = blockMapping;
        }
        public IActionResult AddBlockMap()
        {
            ViewBag.AuditoriumID = _Repository.GetAll().Result;
            return View();
        }
        public IActionResult AddBlockRowMap()
        {
            ViewBag.AuditoriumID = _Repository.GetAll().Result;
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> AddBlockMap(BlockRowEntity entity)
        {
            try
            {
                int retMsg = 0;
                if (entity.BlockRowID != 0)

                {
                    int retdMsg = _blockMapping.DeleteToUpdate(entity.AuditoriumID, entity.BlockId).Result;
                    foreach (var day in entity.RowNumber)
                    {
                        entity.Row_No = Convert.ToInt32(day.Row_No);
                        entity.IsChecked = day.IsChecked;
                        retMsg = _blockMapping.CreateandUpdateRowMap(entity).Result;
                    }
                }
                else
                {
                    foreach (var day in entity.RowNumber)
                    {
                        entity.Row_No = Convert.ToInt32(day.Row_No);
                        entity.IsChecked = day.IsChecked;
                        retMsg = _blockMapping.CreateandUpdateRowMap(entity).Result;
                    }
                }
                if (retMsg == 1)
                {
                    return Json("Record Saved Successfully");

                }
                else if (retMsg == 4)
                {
                    return Json("Record Already Exists");
                }
                else
                {
                    return Json("There is some erroe");
                }

            }
         
           
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet]
        public IActionResult GetBlockbyid(int AuditoriumID)
        {
            ViewBag.AuditoriumID = _Repository.GetAll().Result;
            var client = _blockMapping.GetBlockDetails(Convert.ToInt32(AuditoriumID)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
        [HttpGet]
        public IActionResult GetRowkbyid(int AuditoriumID)
        {
            //ViewBag.ID = AuditoriumID;
            //ViewBag.AuditoriumID = _Repository.GetAll().Result;
            //ViewBag.Row_No = _blockMapping.GetRowDetails(Convert.ToInt32(AuditoriumID)).Result;
            var client= _blockMapping.GetRowDetails(Convert.ToInt32(AuditoriumID)).Result;
            //return View("AddBlockMap");
            return Ok(JsonConvert.SerializeObject(client));
        }
        
        public async Task<IActionResult> ViewSlotMapping()
        {
            ViewBag.Result = await _blockMapping.GetAll(new BlockRowEntity());
            return View();
        }
        [HttpGet]
        public IActionResult SlotMappingGetById(int AuditoriumID, int BlockId)
        {
            var slotMapping = _blockMapping.GetAllShiftByAAndBId(Convert.ToInt32(AuditoriumID), Convert.ToInt32(BlockId)).Result;
            ViewBag.Row_No = _blockMapping.GetRowDetails(Convert.ToInt32(AuditoriumID)).Result;
            return Ok(JsonConvert.SerializeObject(slotMapping));
        }
        [HttpPost]
        public IActionResult DeleteBlockMapping(int AuditoriumID, int BlockId)
        {
            try
            {
                int Result = _blockMapping.Delete(Convert.ToInt32(AuditoriumID), Convert.ToInt32(BlockId)).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }

}
