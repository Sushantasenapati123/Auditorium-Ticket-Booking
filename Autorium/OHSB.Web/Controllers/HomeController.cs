using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OHSB.Domain.ScreenMap;
using OHSB.IRepository.ScreenMap;
using OHSB.Web.Models;
using Razorpay.Api;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Web.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly IScreenMap _Repository;
        public HomeController(ILogger<HomeController> logger, IScreenMap repository)
        {
            _Repository = repository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult> Dashboard()
        {
            return View();
        }
        public async Task<IActionResult> UserDashboard()
        {
            ViewBag.Result = await _Repository.findallFilm();

            return View();
        }
        public async Task<IActionResult> BookingTicketPage(int ScreenMapId)
        {
            ViewBag.Result = await _Repository.GetAllData();

            return View();
        }
        public async Task<IActionResult> BookingTicketPageFor_a_Moview(int ShowId)
        {
            ViewBag.Result = await _Repository.GetAuditoriumAndTimebyShowid(ShowId);

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
