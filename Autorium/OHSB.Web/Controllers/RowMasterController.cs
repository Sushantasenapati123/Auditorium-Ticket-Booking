using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OHSB.Repository.RowMaster;
using OHSB.IRepository.RowMaster;
using Microsoft.Extensions.Configuration;
using OHSB.Domain.RowMaster;
using Newtonsoft.Json;

namespace OHSB.Web.Controllers
{
    public class RowMasterController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly IRowRepository _Repository;
        public IConfiguration Configuration { get; }
        public RowMasterController(IHostingEnvironment hostingEnvironment, IRowRepository repository, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _Repository = repository;
        }
        public async Task<IActionResult> AddRow()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRow(RowEntity doc)
        {
            int retMsg = _Repository.InsertRow(doc).Result;

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
        public async Task<IActionResult> ViewRow()
        {

            ViewBag.Result = await _Repository.GetAllRows(new RowEntity());
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> ViewRow(RowEntity client)
        {
            ViewBag.Result = await _Repository.GetAllRows(client);
            return View();
        }
        [HttpPost]
        public IActionResult Delete(RowEntity Id)
        {
            try
            {
                int Result = _Repository.deleteRow(Id).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        [HttpGet]
        public IActionResult Getbyid(int Row_No)
        {
            var client = _Repository.GetRowbyid(Convert.ToInt32(Row_No)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }
        ////seatDetails
        //public async Task<IActionResult> AddSeat()
        //{
        //    ViewBag.Row_No = _Repository.GetAll().Result;
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> AddSeat(RowEntity doc)
        //{
        //    int retMsg = _Repository.InsertSeat(doc).Result;

        //    if (retMsg == 1)
        //    {
        //        return Json("Record Saved Successfully");
        //    }
        //    else if (retMsg == 2)
        //    {
        //        return Json("Record Updated Successfully");
        //    }
        //    else if (retMsg == 3)
        //    {
        //        return Json("Record Deleted Successfully");
        //    }
        //    else
        //    {
        //        return Json("Record Already Exist");
        //    }
        //}
        //public async Task<IActionResult> ViewSeatDeatils()
        //{

        //    ViewBag.Result = await _Repository.GetAllSeats(new RowEntity());
        //    return View();

        //}
        //[HttpPost]
        //public async Task<IActionResult> ViewSeatDeatils(RowEntity client)
        //{
        //    ViewBag.Result = await _Repository.GetAllSeats(client);
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult DeleteSeat(RowEntity Id)
        //{
        //    try
        //    {
        //        int Result = _Repository.deleteSeat(Id).Result;
        //        return Json(Result);
        //    }
        //    catch (Exception Ex)
        //    {
        //        throw Ex;
        //    }

        //}
        //[HttpGet]
        //public IActionResult GetSeatbyid(int Seat_Id)
        //{
        //    var client = _Repository.GetSeatbyid(Convert.ToInt32(Seat_Id)).Result;
        //    return Ok(JsonConvert.SerializeObject(client));
        //}
    }
}
