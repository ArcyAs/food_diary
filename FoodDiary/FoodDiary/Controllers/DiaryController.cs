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
using FoodDiary.Repositories.Implementations;
using Repositories.Abstract;

namespace FoodDiary.Controllers
{
    public class DiaryController : Controller
    {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<AppUser> _userManager;
        

        public DiaryController(IRepositoryFactory repositoryFactory, UserManager<AppUser> userManager, ApplicationDbContext applicationDbContext)
        {
            _repositoryFactory = repositoryFactory;
            this._userManager = userManager;
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            var productsList = _applicationDbContext.ProductEntities.Where(x => x.Kcal > 0).ToList();                                                                    
            return View(productsList);
        }
       
    }
}