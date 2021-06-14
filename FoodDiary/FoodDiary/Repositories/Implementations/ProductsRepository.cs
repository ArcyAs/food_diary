using FoodDiary.Data;
using FoodDiary.Repositories.Abstract;
using FoodDiary.Repositories.Entities;
using FoodDiary.Services.Implementation;
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
        public ProductsRepository(ApplicationDbContext context )
        {
            _context = context;
        }
        public async Task AddProductToDataBase(ProductEntity productEntity)
        {
            productEntity.Kcal =   KcalCalculatorService.KcalCalculator(productEntity.Carb, productEntity.Fat, productEntity.Protein);
            _context.ProductEntities.Add(productEntity);
           
            await _context.SaveChangesAsync();
        }
        public async Task DeleteProductFromDataBase(Guid id)
        {
            var product =_context.ProductEntities.FirstOrDefault(x => x.Id == id);
            _context.ProductEntities.Remove(product);
            await _context.SaveChangesAsync();
        }


        public async Task EditProductInDataBase(ProductEntity newProductEntity,Guid id)
        {
            var oldProductEntity = _context.ProductEntities.FirstOrDefault(x => x.Id == id);
            
            oldProductEntity.ProductName = newProductEntity.ProductName;
            oldProductEntity.Protein = newProductEntity.Protein;
            oldProductEntity.Fat = newProductEntity.Fat;
            oldProductEntity.Carb = newProductEntity.Carb;
            oldProductEntity.Kcal = KcalCalculatorService.KcalCalculator(newProductEntity.Carb, newProductEntity.Fat, newProductEntity.Protein);
            
            await _context.SaveChangesAsync();
        }


        public async Task<List<ProductEntity>> GetAllProducts()
        {
            var data = await _context.ProductEntities.ToListAsync();
            return data;
        }
        public async Task<ProductEntity> GetProductById(Guid id)
        {
            var product =  await _context.ProductEntities.FirstOrDefaultAsync(x => x.Id == id);
            return product;
        }
    
        
    }
}
