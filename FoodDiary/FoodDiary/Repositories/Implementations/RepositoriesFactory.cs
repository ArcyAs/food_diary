using System.ComponentModel;
using System.Threading.Tasks;
using FoodDiary.Data;
using Repositories.Abstract;
using FoodDiary.Repositories.Abstract;

namespace FoodDiary.Repositories.Implementations
{
    public class RepositoriesFactory : IRepositoryFactory
    {
        private readonly ApplicationDbContext _context;
        public RepositoriesFactory(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUserRepository GetUserRepository()
        {
            return new UserRepository(_context);
        }

        public IProductsRepository GetProductsReposity()
        {
            return new ProductsRepository(_context);
        }
    }
}