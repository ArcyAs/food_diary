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

namespace FoodDiary.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<AppUser> userManager;

        public ProductsController(ApplicationDbContext applicationDbContext, UserManager<AppUser> userManager)
        {
            this._applicationDbContext = applicationDbContext;
            this.userManager = userManager;

        }
        public IActionResult Index()
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var productDetails = _applicationDbContext.ProductDetailsEntity.All(x => x.ProductId > 0);

            return View();
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
