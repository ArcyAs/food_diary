using FoodDiary.Repositories.Abstract;

namespace Repositories.Abstract
{
    public interface IRepositoryFactory
    {
        IUserRepository GetUserRepository();
        IProductsRepository GetProductRepository();
    }
}