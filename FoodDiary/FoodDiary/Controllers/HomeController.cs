using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FoodDiary.Models;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using FoodDiary.Data;
using FoodDiary.Repositories.Entities;
using System.Net;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace FoodDiary.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        private DbSet<UserDetailsEntity> UserDetailsEntities { get; set; }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            UserDetailsEntities = _context.UserDetailsEntities;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PersonalDetails()
        {
            var result = _context.UserDetailsEntities.ToList();
            return View(result);
        }

      
        public ActionResult GetJsonDataModel()
        {
            var webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.Cookie, "cookievalue");
            var json = webClient.DownloadString(@"https://jsonplaceholder.typicode.com/todos/1");
            Models.AppUser objJson = JsonConvert.DeserializeObject < Models.AppUser> (json);

            return View(objJson);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}