using MenuOrder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MenuOrder.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext Dbcontext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            Dbcontext = dbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var menu = Dbcontext.MenuTypes.ToList();
            ViewBag.m = menu;
            return View();
        }

        public IActionResult GetMenuTypes()
        {
            var menu = Dbcontext.MenuTypes.ToList();
            return Json(menu);
        }
        public IActionResult GetMenuList(int id)
        {
            var menu = Dbcontext.MenuList.Where(e=>e.Type.Id == id);
            return Json(menu);
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
