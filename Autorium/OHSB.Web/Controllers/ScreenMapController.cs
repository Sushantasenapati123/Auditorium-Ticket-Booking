using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.Domain.ScreenMap;
using OHSB.IRepository.ScreenMap;
using OHSB.IRepository.AuditoriumIRepository;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace OHSB.Web.Controllers
{
    public class ScreenMapController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private IHostingEnvironment _hostingEnvironment;
        private readonly IScreenMap _Repository;
        private readonly IAuditoriumRepo _auditoriumRepo;
        public IConfiguration Configuration { get; }
        public ScreenMapController(IWebHostEnvironment environment,IHostingEnvironment hostingEnvironment, IScreenMap repository,IAuditoriumRepo auditoriumRepo ,IConfiguration configuration)
        {
            _environment = environment;
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
            _auditoriumRepo = auditoriumRepo;
        }
        public async Task<IActionResult> AddScreenMapp()
        {
            ViewBag.id = _Repository.GetAllShowType().Result;
            ViewBag.AuditoriumID = _auditoriumRepo.GetAll().Result;
            ViewBag.ShowId = _Repository.GetAllShow().Result;
            return View();
        }
        [HttpPost]
        public IActionResult UploadImage(IFormFile MyUploader)
        {
            if (MyUploader != null)
            {
                string uploadsFolder = Path.Combine(_environment.WebRootPath, "prodimage");
                string filePath = Path.Combine(uploadsFolder, MyUploader.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    MyUploader.CopyTo(fileStream);
                }
                return new ObjectResult(new { status = "success" });
            }
            return new ObjectResult(new { status = "fail" });

        }
        [HttpPost]
        public async Task<IActionResult> AddScreenMapp(ScreenMapEntity doc)
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
        public async Task<IActionResult> ViewScreenMapp()
        {

            ViewBag.Result = await _Repository.GetAllData();
            return View();

        }
        public IActionResult Delete(ScreenMapEntity ent)
        {
            try
            {
                int Result = _Repository.deleteShow(ent).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        
            [HttpGet]
        public IActionResult GetbyShowid(int ScreenMapId)
        {
            var client = _Repository.GetbyShowid(Convert.ToInt32(ScreenMapId)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
        [HttpGet]
        public IActionResult Getbyid(int ScreenMapId)
        {
            var client = _Repository.GetShowsbyid(Convert.ToInt32(ScreenMapId)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
        [HttpGet]
        public IActionResult GetbyShowtimeid( int ShowId)
        {
            var client = _Repository.GetShowsTimebyid(Convert.ToInt32(ShowId)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
    }
}
