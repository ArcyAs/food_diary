using FoodDiary.Data;
using FoodDiary.Factories;
using FoodDiary.Models;
using FoodDiary.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;

namespace FoodDiary.Repositories.Implementations
{
    public class RepositoriesFactory : IRepositoryFactory
    {
        private readonly IBmiBmrFactory _bmibmrFactory;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public RepositoriesFactory(ApplicationDbContext context, UserManager<AppUser> userManager,
            IBmiBmrFactory bmibmrFactory)
        {
            _userManager = userManager;
            _context = context;
            _bmibmrFactory = bmibmrFactory;
        }

        public IUserRepository GetUserRepository()
        {
            return new UserRepository(_context, _userManager, _bmibmrFactory);
        }

        public IProductsRepository GetProductRepository()
        {
            return new ProductsRepository(_context);
        }

        public IDiaryRepository GetDiaryRepository()
        {
            return new DiaryRepository(_context);
        }
    }
}