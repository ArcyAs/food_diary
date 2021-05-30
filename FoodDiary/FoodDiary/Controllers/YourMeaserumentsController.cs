using FoodDiary.Data;
using FoodDiary.Models;
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
        private readonly UserManager<AppUser> userManager;

        public YourMeaserumentsController(ApplicationDbContext applicationDbContext, UserManager<AppUser> userManager)
        {
            this._applicationDbContext = applicationDbContext;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userDetails = _applicationDbContext.UserDetailsEntities.Where(x=>x.UserId == Guid.Parse(userId)).OrderByDescending(x => x.AddDate).FirstOrDefault();

            return View(userDetails);
        }
        
        [HttpPost]
        public IActionResult Edit(UserDetailsEntity userDetailsEntity)
        {
            var userDetails = _applicationDbContext.UserDetailsEntities.Where(x => x.Id == userDetailsEntity.Id).FirstOrDefault();
            userDetails.Weight = userDetailsEntity.Weight;
            userDetails.Height = userDetailsEntity.Height;
            userDetails.Target = userDetailsEntity.Target;

            _applicationDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
