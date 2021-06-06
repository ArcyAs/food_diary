﻿using FoodDiary.Data;
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
using FoodDiary.Repositories.Abstract;

namespace FoodDiary.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsRepository _repositoryProduct;
        private readonly UserManager<AppUser> _userManager;

        public ProductsController(IProductsRepository productsRepository , UserManager<AppUser> userManager)
        {
            _repositoryProduct = productsRepository;
            this._userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(ProductEntity productEntity)
        {
            await _repositoryProduct.AddProductToDataBase(productEntity);
            
            return RedirectToAction("Index");
        }
    }
}