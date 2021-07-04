using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using FoodDiary.Data;
using FoodDiary.Models;
using FoodDiary.Repositories.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FoodDiary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;


        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context,
            UserManager<AppUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            UserDetailsEntities = _context.UserDetailsEntities;
        }

        private DbSet<UserDetailsEntity> UserDetailsEntities { get; }

        public IActionResult IndexAsync()
        {
            var currentUser = _userManager.Users.FirstOrDefault(p => p.Email == User.FindFirstValue(ClaimTypes.Email));
            if (currentUser != null)
            {
                var userDetailsEntity =
                    _context.UserDetailsEntities.FirstOrDefault(p => p.UserId == Guid.Parse(currentUser.Id));
                var data = _context.DiaryEntities.Where(x =>
                    x.DiaryId == userDetailsEntity.DiaryId && x.AddDate.Date == DateTime.Today &&
                    x.IdProduct != Guid.Empty).ToList();
                var totalKcal = data.AsEnumerable().Sum(row => row.Kcal);
                var userBmr = userDetailsEntity.Bmr - totalKcal;
                var data1 = _context.DiaryEntities.Where(x =>
                    x.DiaryId == userDetailsEntity.DiaryId && x.AddDate.Date.Day == DateTime.Today.Day - 1 &&
                    x.IdProduct != Guid.Empty).ToList();
                var data2 = _context.DiaryEntities.Where(x =>
                    x.DiaryId == userDetailsEntity.DiaryId && x.AddDate.Date.Day == DateTime.Today.Day - 2 &&
                    x.IdProduct != Guid.Empty).ToList();
                var data3 = _context.DiaryEntities.Where(x =>
                    x.DiaryId == userDetailsEntity.DiaryId && x.AddDate.Date.Day == DateTime.Today.Day - 3 &&
                    x.IdProduct != Guid.Empty).ToList();
                var data4 = _context.DiaryEntities.Where(x =>
                    x.DiaryId == userDetailsEntity.DiaryId && x.AddDate.Date.Day == DateTime.Today.Day - 4 &&
                    x.IdProduct != Guid.Empty).ToList();
                var data5 = _context.DiaryEntities.Where(x =>
                    x.DiaryId == userDetailsEntity.DiaryId && x.AddDate.Date.Day == DateTime.Today.Day - 5 &&
                    x.IdProduct != Guid.Empty).ToList();
                var sumKcalDaily1 = data1.AsEnumerable().Sum(row => row.Kcal);
                var sumKcalDaily2 = data2.AsEnumerable().Sum(row => row.Kcal);
                var sumKcalDaily3 = data3.AsEnumerable().Sum(row => row.Kcal);
                var sumKcalDaily4 = data4.AsEnumerable().Sum(row => row.Kcal);
                var sumKcalDaily5 = data5.AsEnumerable().Sum(row => row.Kcal);
                if (totalKcal > userDetailsEntity.Bmr) userBmr = 0;
                var viewModel = new HomeViewModel
                {
                    SumKcal = totalKcal,
                    UserBmr = Convert.ToInt32(userBmr),
                    TotalKcalDaily1 = sumKcalDaily1,
                    TotalKcalDaily2 = sumKcalDaily2,
                    TotalKcalDaily3 = sumKcalDaily3,
                    TotalKcalDaily4 = sumKcalDaily4,
                    TotalKcalDaily5 = sumKcalDaily5
                };
                return View(viewModel);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
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
        public int UserBmr { get; set; }
        public int SumKcal { get; set; }
        public int TotalKcalDaily1 { get; set; }
        public int TotalKcalDaily2 { get; set; }
        public int TotalKcalDaily3 { get; set; }
        public int TotalKcalDaily4 { get; set; }
        public int TotalKcalDaily5 { get; set; }
    }
}