using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FoodDiary.Data;
using FoodDiary.Models;
using FoodDiary.Repositories.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FoodDiary.Controllers
{
    public class PersonalDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;

        public PersonalDetailsController(ILogger<HomeController> logger, ApplicationDbContext context,
            UserManager<AppUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            UserDetailsEntities = _context.UserDetailsEntities;
        }

        private DbSet<UserDetailsEntity> UserDetailsEntities { get; }

        public async Task<IActionResult> IndexAsync()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result_user = _context.UserDetailsEntities.FirstOrDefault(x => x.UserId == Guid.Parse(userId));
            var result = await _userManager.FindByIdAsync(userId);
            var model = new UserDetailsEntities_view
            {
                appUser = result,
                userDetailsEntity = result_user
            };

            return View(model);
        }

        public class UserDetailsEntities_view
        {
            public AppUser appUser { get; set; }
            public UserDetailsEntity userDetailsEntity { get; set; }
        }
    }
}