using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.IRepository.MenuMaster;
using Microsoft.Extensions.Configuration;
using OHSB.Domain.MenuMaster;
using Newtonsoft.Json;

namespace OHSB.Web.Controllers
{
    public class MenuMasterController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly IMenuRepository _Repository;
        public IConfiguration Configuration { get; }
        public MenuMasterController(IHostingEnvironment hostingEnvironment, IMenuRepository repository, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
        }
        public IActionResult AddMenu()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> AddMenu(MenuEntity entity)
        {
            try
            {
                int retMsg = _Repository.MenuInsertAndUpdate(entity).Result;

                if (retMsg == 1)
                {
                    return Json("Menu Saved Successfully");
                }
                else if (retMsg == 2)
                {
                    return Json("Menu Updated Successfully");
                }
                else
                {
                    return Json("Menu Already Exist");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IActionResult ViewMenu()
        {
            ViewBag.Result = _Repository.MenuSelectAll(new MenuEntity()).Result;
            return View();
        }

        [HttpPost]
        public IActionResult DeleteMenu(int MenuId)
        {
            try
            {
                int Result = _Repository.MenuDelete(MenuId).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        [HttpGet]
        public IActionResult MenuGetById(int MenuId)
        {
            var Menus = _Repository.MenuSelectOne(Convert.ToInt32(MenuId)).Result;
            return Ok(JsonConvert.SerializeObject(Menus));
        }
    }
}
