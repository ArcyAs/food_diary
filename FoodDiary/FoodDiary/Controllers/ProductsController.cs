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
    public class ProductsController : Controller
    {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly UserManager<AppUser> _userManager;

        public ProductsController(IRepositoryFactory repositoryFactory, UserManager<AppUser> userManager)
        {
            _repositoryFactory = repositoryFactory;
            this._userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(ProductEntity productEntity)
        {
            await _repositoryFactory.GetUserRepository().AddProductToDataBase(productEntity);
            
            return RedirectToAction("Index");
        }
    }
}