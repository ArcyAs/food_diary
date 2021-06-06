using FoodDiary.Data;
using FoodDiary.Repositories.Abstract;
using FoodDiary.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDiary.Repositories.Implementations
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddProductToDataBase(ProductEntity productEntity)
        {
           
            _context.ProductEntities.Add(productEntity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ProductEntity>> GetAllProducts()
        {
            var data = await _context.ProductEntities.ToListAsync();
            return data;
        }
    }
}
