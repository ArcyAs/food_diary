using FoodDiary.Data;
using FoodDiary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FoodDiary.Repositories.Entities;
using Repositories.Abstract;

namespace FoodDiary.Controllers
{
    public class DiaryController : Controller
    {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<AppUser> _userManager;

        public DiaryController(IRepositoryFactory repositoryFactory, UserManager<AppUser> userManager)
        {
            _repositoryFactory = repositoryFactory;
            this._userManager = userManager;
        }
        public IActionResult Index()
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var userDetails = _applicationDbContext.UserDetailsEntities.Where(x => x.UserId == Guid.Parse(userId)).OrderByDescending(x => x.AddDate).FirstOrDefault();
            return View();
           // return View(userDetails);
        }

     //   [HttpPost]
    //    public async Task<IActionResult> EditAsync(ProductEntity productEntity)
    //    {
    //        await _repositoryFactory.GetUserRepository().AddProductToDataBase(productEntity);
            
    //        return RedirectToAction("Index");
    //    }
    }
}