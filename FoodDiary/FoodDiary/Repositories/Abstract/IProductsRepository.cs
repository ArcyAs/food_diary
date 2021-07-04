using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodDiary.Repositories.Entities;

namespace FoodDiary.Repositories.Abstract
{
    public interface IProductsRepository
    {
        Task AddProductToDataBase(ProductEntity productEntity);
        Task DeleteProductFromDataBase(Guid id);
        Task<List<ProductEntity>> GetAllProducts();
        Task<ProductEntity> GetProductById(Guid id);
        Task EditProductInDataBase(ProductEntity productEntity, Guid id);
    }
}