using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.IRepository.PermissionMaster;
using OHSB.IRepository.SubMenuMaster;
using Microsoft.Extensions.Configuration;
using OHSB.Domain.PermissionMaster;
using Newtonsoft.Json;


namespace OHSB.Web.Controllers
{
    public class PermissionController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly IPermissionRepo _permissionRepository;
        private readonly ISubMenuRepo _submenuRepository;
        public IConfiguration Configuration { get; }
        public PermissionController(IHostingEnvironment hostingEnvironment, ISubMenuRepo submenuRepository, IPermissionRepo permissionRepository,  IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _submenuRepository = submenuRepository;
            _permissionRepository = permissionRepository;
            
        }

        public IActionResult AddPermission()
        {
            ViewBag.RollID = _permissionRepository.RollDDL().Result;
            return View();
        }
        [HttpPost]
        public IActionResult CreatePermission([FromBody] List<PermissionEntity> entity)
        {
            try
            {
                if (entity != null && entity.Count != 0)
                {
                    //First Delete And Then Update The Permission Data
                    int retdMsg = _permissionRepository.PermissionUpdateToDelete(entity[0].RollID, entity[0].UserId).Result;
                    foreach (var item in entity)
                    {
                        int retMsgPD = _permissionRepository.PermissionInsert(item).Result;
                    }
                    return Json("Permission Updated Successfully");
                }
                else
                {
                    return Json("Please select any of these Permission!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult GetSelectedPermissions(int UserId, int RollID)
        {
            ViewBag.RollID = RollID;
            ViewBag.UserId = UserId;
            ViewBag.RollID = _permissionRepository.RollDDL().Result;
            ViewBag.SubMenu = _permissionRepository.GetSelectedSubMenus(RollID, UserId).Result;
            return View("AddPermission");
        }
        public IActionResult GetSelectedMenuByDesig(int RollID, int UserId)
        {
            var MenuClasses = _permissionRepository.GetSelectedMenuByDesig(RollID, UserId).Result;
            var SubMenuClasses = _permissionRepository.GetSelectedSubMenuByDesig(RollID, UserId).Result;
            return Ok(new { MenuClasses = JsonConvert.SerializeObject(MenuClasses), SubMenuClasses = JsonConvert.SerializeObject(SubMenuClasses) });
        }
    }
}
