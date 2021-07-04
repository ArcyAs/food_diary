using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FoodDiary.Data;
using FoodDiary.Factories;
using FoodDiary.Models;
using FoodDiary.Repositories.Abstract;
using FoodDiary.Repositories.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FoodDiary.Controllers
{
    public class YourMeaserumentsController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IBmiBmrFactory _bmibmrFactory;
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly UserManager<AppUser> _userManager;

        public YourMeaserumentsController(ApplicationDbContext applicationDbContext,
            IRepositoryFactory repositoryFactory, UserManager<AppUser> userManager, IBmiBmrFactory bmibmrFactory)
        {
            _repositoryFactory = repositoryFactory;
            _userManager = userManager;
            _applicationDbContext = applicationDbContext;
            _bmibmrFactory = bmibmrFactory;
        }

        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userDetails = _applicationDbContext.UserDetailsEntities.Where(x => x.UserId == Guid.Parse(userId))
                .OrderByDescending(x => x.AddDate).FirstOrDefault();

            return View(userDetails);
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(UserDetailsEntity userDetailsEntity)
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var userDetails = await _repositoryFactory.GetUserRepository()
                .GetUserDetailsByUserId(userDetailsEntity.UserId);
            await _repositoryFactory.GetUserRepository().UpdateUserDetails(userDetailsEntity, userDetails, userId);


            _applicationDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}