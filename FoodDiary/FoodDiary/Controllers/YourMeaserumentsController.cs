using FoodDiary.Data;
using FoodDiary.Factories;
using FoodDiary.Factories.BmiBmrCalculator;
using FoodDiary.Models;
using FoodDiary.Models.Enums;
using FoodDiary.Repositories.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace FoodDiary.Controllers
{
    public class YourMeaserumentsController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly IBmiBmrFactory _bmibmrFactory;

        public YourMeaserumentsController(ApplicationDbContext applicationDbContext, UserManager<AppUser> userManager, IBmiBmrFactory bmibmrFactory)
        {
            this._applicationDbContext = applicationDbContext;
            this._userManager = userManager;
            _bmibmrFactory = bmibmrFactory;
        }
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userDetails = _applicationDbContext.UserDetailsEntities.Where(x=>x.UserId == Guid.Parse(userId)).OrderByDescending(x => x.AddDate).FirstOrDefault();


            return View(userDetails);
        }
        
        [HttpPost]
        public async Task<IActionResult> EditAsync(UserDetailsEntity userDetailsEntity)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAppDetails = await _userManager.FindByIdAsync(userId);
            var userDetails = _applicationDbContext.UserDetailsEntities.Where(x => x.Id == userDetailsEntity.Id).FirstOrDefault();
            userDetails.Weight = userDetailsEntity.Weight;
            userDetails.Height = userDetailsEntity.Height;
            userDetails.Target = userDetailsEntity.Target;
            if (userDetails.Target == 0)
            {
                userDetails.Bmr += 200;
            }
            else if (userDetails.Target == 1)
            {
                userDetails.Bmr -= 200;
            }
            else if (userDetails.Target == 2)
            {
                userDetails.Bmr = _bmibmrFactory.GetCalculator((Gender)Enum.ToObject(typeof(Gender), userDetails.Gender)).CalculateBMR(userDetails.Weight, userDetails.Height, userAppDetails.Age, userAppDetails.ActivityLevel);
            }

            _applicationDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
