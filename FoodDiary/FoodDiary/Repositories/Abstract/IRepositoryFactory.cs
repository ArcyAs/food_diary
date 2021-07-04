namespace FoodDiary.Repositories.Abstract
{
    public interface IRepositoryFactory
    {
        IUserRepository GetUserRepository();
        IProductsRepository GetProductRepository();
        IDiaryRepository GetDiaryRepository();
    }
}