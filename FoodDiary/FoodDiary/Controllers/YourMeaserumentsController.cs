using FoodDiary.Data;
using FoodDiary.Factories;
using FoodDiary.Factories.BmiBmrCalculator;
using FoodDiary.Models;
using FoodDiary.Models.Enums;
using FoodDiary.Repositories.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repositories.Abstract;
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
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly UserManager<AppUser> _userManager;
        private readonly IBmiBmrFactory _bmibmrFactory;

        public YourMeaserumentsController(ApplicationDbContext applicationDbContext, IRepositoryFactory repositoryFactory, UserManager<AppUser> userManager, IBmiBmrFactory bmibmrFactory)
        {
            _repositoryFactory = repositoryFactory;
            this._userManager = userManager;
            this._applicationDbContext = applicationDbContext;
            _bmibmrFactory = bmibmrFactory;

        }
        public IActionResult Index()
        {
            var userId =  User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userDetails = _applicationDbContext.UserDetailsEntities.Where(x => x.UserId == Guid.Parse(userId)).OrderByDescending(x => x.AddDate).FirstOrDefault();

            return View(userDetails);
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(UserDetailsEntity userDetailsEntity)
        {
            var userDetails = await _repositoryFactory.GetUserRepository().GetUserDetailsByUserId(userDetailsEntity.UserId);
            await _repositoryFactory.GetUserRepository().UpdateUserDetails(userDetailsEntity, userDetails);
           
            _applicationDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
