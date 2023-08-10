using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.IRepository.SubMenuMaster;
using Microsoft.Extensions.Configuration;
using OHSB.IRepository.MenuMaster;
using OHSB.Domain.MenuMaster;
using OHSB.Domain.SubMenuMaster;
using Newtonsoft.Json;

namespace OHSB.Web.Controllers
{
    public class SubMenuController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly ISubMenuRepo _Repository;
        private readonly IMenuRepository _menuRepo;
        public IConfiguration Configuration { get; }
        public SubMenuController(IHostingEnvironment hostingEnvironment, ISubMenuRepo repository,IMenuRepository menuRepo, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
            _menuRepo = menuRepo;
        }
        public IActionResult AddSubMenu()
        {
            ViewBag.Name = _Repository.GetAllMenu().Result;
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> AddSubMenu(SubMenuEntity entity)
        {
            try
            {
                int retMsg = _Repository.SubMenuInsertAndUpdate(entity).Result;

                if (retMsg == 1)
                {
                    return Json("SubMenu Saved Successfully");
                }
                else if (retMsg == 2)
                {
                    return Json("SubMenu Updated Successfully");
                }
                else
                {
                    return Json("SubMenu Already Exist");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IActionResult ViewSubMenu()
        {
            ViewBag.Result = _Repository.SubMenuSelectAll(new SubMenuEntity()).Result;
            return View();
        }

        [HttpPost]
        public IActionResult DeleteSubMenu(int SubMenuID)
        {
            try
            {
                int Result = _Repository.SubMenuDelete(SubMenuID).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        [HttpGet]
        public IActionResult SubMenuGetById(int SubMenuID)
        {
            var SubMenus = _Repository.SubMenuSelectOne(Convert.ToInt32(SubMenuID)).Result;
            return Ok(JsonConvert.SerializeObject(SubMenus));
        }


    }
}
