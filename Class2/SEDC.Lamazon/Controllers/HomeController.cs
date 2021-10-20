using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SEDC.Lamazon.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Lamazon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("PrivacyPage")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ReturnIndex()
        {
            return View("Index");
        }

        public IActionResult Empty()
        {
            return new EmptyResult();
        }

        public IActionResult JsonData()
        {
            Book book = new Book
            {
                ID = 1,
                Title = "My Book"
            };
            return new JsonResult(book);
        }

        public IActionResult ShowPrivacy()
        {
            return RedirectToAction("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
    }
}
