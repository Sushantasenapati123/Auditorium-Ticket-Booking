using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.IRepository.BlockMaster;
using OHSB.IRepository.AuditoriumIRepository;
using Microsoft.Extensions.Configuration;
using OHSB.Domain.AuditoriumMaster;
using OHSB.Domain.BlockMaster;
using Newtonsoft.Json;

namespace OHSB.Web.Controllers
{
    public class BlockMasterController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly IAuditoriumRepo _Repository;
        private readonly IBlockRepo _BlockRepo;
        public IConfiguration Configuration { get; }
        public BlockMasterController(IHostingEnvironment hostingEnvironment, IAuditoriumRepo repository,IBlockRepo blockRepo ,IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
            _BlockRepo = blockRepo;
        }
        public IActionResult AddBlock()
        {
            ViewBag.AuditoriumID = _Repository.GetAll().Result;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBlock(BlockEntity doc)
        {
            int retMsg = _BlockRepo.CreateandUpdateBlock(doc).Result;

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
        public async Task<IActionResult> ViewBlock()
        {

            ViewBag.Result = await _BlockRepo.GetAllBlock();
            return View();

        }
        [HttpPost]
        public IActionResult Delete(BlockEntity Id)
        {
            try
            {
                int Result = _BlockRepo.deleteBlock(Id).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        [HttpGet]
        public IActionResult Getbyid(int BlockId)
        {
            var client = _BlockRepo.GetBlockbyid(Convert.ToInt32(BlockId)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
    }
}
