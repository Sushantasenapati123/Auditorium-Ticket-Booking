using Auditorium.Domain.BookingMaster;
using Auditorium.IRepository.Auditorium;

using Auditorium.IRepository.Booking;
using Auditorium.IRepository.Seat;
using Auditorium.IRepository.ShowSelectIRepo;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OHSB.IRepository.Block;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHSB.Web.Controllers
{
    public class BookingController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly AuditoriumIRepository _AudiRepository;
        private readonly ShowSelectIRepository _ShowSelectRepo;
        private readonly BlockIRepository _BlockRepo;
        private readonly SeatIRepository _SeatRepo;
        private readonly BookingIRepository _BookingRepo;
        public IConfiguration Configuration { get; }
        public BookingController(IHostingEnvironment hostingEnvironment, BookingIRepository BookingRepo, SeatIRepository SeatRepo, BlockIRepository BlockRepo, ShowSelectIRepository ShowSelectRepo, AuditoriumIRepository Audi, IConfiguration configuration)
        {
            _hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            _AudiRepository = Audi;
            _ShowSelectRepo = ShowSelectRepo;
            _BlockRepo = BlockRepo;
            _SeatRepo = SeatRepo;
            _BookingRepo = BookingRepo;

        }
        [HttpGet]
        public IActionResult GetSeats(int AuditoriumId)
        {
            var Slots = _SeatRepo.SelectAllForBlock(AuditoriumId).Result;
            return Ok(JsonConvert.SerializeObject(Slots));
        }
        [HttpGet]
        public async Task<IActionResult> GetBookedSeatsForAuditorium(int AuditoriumId, DateTime BookingDate)
        {

            var bookings = await _BookingRepo.GetBookedSeatsForAuditorium(AuditoriumId, BookingDate);
            return Ok(bookings);
        }
        public async Task<IActionResult> ViewSeats()
        {
            ViewBag.AudiList = _AudiRepository.AuditoriumBind().Result;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ViewSeats(int Id, DateTime BookingDate,int AuditoriumId, int BlockId, int RowId, int SeatId)
        {
            int retMsg = _BookingRepo.CreateBooking(Id, BookingDate, HttpContext.Session.GetString("UserName"), AuditoriumId, BlockId, RowId, SeatId).Result;

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
                return Json("Seat Already Booked");
            }
        }
        [HttpPost]
        public async Task<IActionResult> BookTicket(BookingMaster cu)
        {
            int retMsg=0;
            for (int x=0;x<cu.BookTickets.Length;x++)
            {
                string ticketId = cu.BookTickets[x];
                retMsg =_BookingRepo.CreateBooking(cu.Id, cu.BookingDate, HttpContext.Session.GetString("UserName"), cu.AuditoriumId, Int16.Parse(ticketId.Split("_")[3]), Int16.Parse(ticketId.Split("_")[1]), Int16.Parse(ticketId.Split("_")[2])).Result;//block,row,seat

            }

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
                return Json("Seat Already Booked");
            }
        }
        public async Task<IActionResult> ViewBooking()
        {
            ViewBag.Result = await _BookingRepo.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            try
            {
                int Result = _BookingRepo.Delete(Id).Result;
                return Json(Result);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        [HttpGet]
        public IActionResult Getbyid(int Id)
        {
            var client = _BookingRepo.Getbyid(Convert.ToInt32(Id)).Result;
            return Ok(JsonConvert.SerializeObject(client));
        }


    }
}
