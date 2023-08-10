using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.IRepository.Show_Master;
using Microsoft.Extensions.Configuration;
using OHSB.Domain.Show_Master;
using Newtonsoft.Json;

namespace OHSB.Web.Controllers
{
    public class Show_MasterController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly IShow_Master _Repository;
        public IConfiguration Configuration { get; }
        public Show_MasterController(IHostingEnvironment hostingEnvironment, IShow_Master repository, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
        }
        public async Task<IActionResult> AddShows()
        {
            ViewBag.id = _Repository.GetAllShowType().Result;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddShows(Show_Entity doc)
        {
            string[] files = doc.Photo.Split('\\');
            doc.Photo = "prodimage/" + files[files.Length - 1];

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
        public async Task<IActionResult> ViewShows()
        {

            ViewBag.Result = await _Repository.GetAllShowsData();
            return View();

        }
        public IActionResult Delete(Show_Entity ent)
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
        public IActionResult Getbyid(int ShowId)
        {
            var client = _Repository.GetShowsbyid(Convert.ToInt32(ShowId)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
    }
}
