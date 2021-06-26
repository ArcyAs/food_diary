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
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace FoodDiary.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        UserManager<AppUser> _userManager;
        private DbSet<UserDetailsEntity> UserDetailsEntities { get; set; }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            UserDetailsEntities = _context.UserDetailsEntities;

        }
        public IActionResult IndexAsync()
        {
            var currentUser = _userManager.Users.FirstOrDefault(p => p.Email == User.FindFirstValue(ClaimTypes.Email));
            if (currentUser != null)
            {
                var userDetailsEntity = _context.UserDetailsEntities.FirstOrDefault(p => p.UserId == Guid.Parse(currentUser.Id));
                var data = _context.DiaryEntities.Where(x => x.DiaryId == userDetailsEntity.DiaryId && x.AddDate.Date == DateTime.Today && x.IdProduct != Guid.Empty).ToList();
                var totalKcal = data.AsEnumerable().Sum(row => row.Kcal);
                var userBmr = userDetailsEntity.Bmr - totalKcal;
                var data1 = _context.DiaryEntities.Where(x => x.DiaryId == userDetailsEntity.DiaryId && x.AddDate.Date.Day == DateTime.Today.Day-1 && x.IdProduct != Guid.Empty).ToList();
                var data2 = _context.DiaryEntities.Where(x => x.DiaryId == userDetailsEntity.DiaryId && x.AddDate.Date.Day == DateTime.Today.Day-2 && x.IdProduct != Guid.Empty).ToList();
                var data3 = _context.DiaryEntities.Where(x => x.DiaryId == userDetailsEntity.DiaryId && x.AddDate.Date.Day == DateTime.Today.Day-3 && x.IdProduct != Guid.Empty).ToList();
                var data4 = _context.DiaryEntities.Where(x => x.DiaryId == userDetailsEntity.DiaryId && x.AddDate.Date.Day == DateTime.Today.Day-4 && x.IdProduct != Guid.Empty).ToList();
                var data5 = _context.DiaryEntities.Where(x => x.DiaryId == userDetailsEntity.DiaryId && x.AddDate.Date.Day == DateTime.Today.Day-5 && x.IdProduct != Guid.Empty).ToList();
                var sumKcalDaily1 = data1.AsEnumerable().Sum(row => row.Kcal);
                var sumKcalDaily2 = data2.AsEnumerable().Sum(row => row.Kcal);
                var sumKcalDaily3 = data3.AsEnumerable().Sum(row => row.Kcal);
                var sumKcalDaily4 = data4.AsEnumerable().Sum(row => row.Kcal);
                var sumKcalDaily5 = data5.AsEnumerable().Sum(row => row.Kcal);
                if (totalKcal>userDetailsEntity.Bmr)
                {
                    userBmr = 0;
                }
                var viewModel = new HomeViewModel()
                {
                    sumKcal = totalKcal,
                    userbmr = Convert.ToInt32(userBmr),
                    totalKcalDaily1 = sumKcalDaily1,
                    totalKcalDaily2 = sumKcalDaily2,
                    totalKcalDaily3 = sumKcalDaily3,
                    totalKcalDaily4 = sumKcalDaily4,
                    totalKcalDaily5 = sumKcalDaily5,
                };
                return View(viewModel);
            }
            else
                return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }


        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        
    }

    public class HomeViewModel
    {
        public int userbmr { get; set; }
        public int sumKcal { get; set; }
        public int totalKcalDaily1 { get; set; }
        public int totalKcalDaily2 { get; set; }
        public int totalKcalDaily3 { get; set; }
        public int totalKcalDaily4 { get; set; }
        public int totalKcalDaily5 { get; set; }
    }
}