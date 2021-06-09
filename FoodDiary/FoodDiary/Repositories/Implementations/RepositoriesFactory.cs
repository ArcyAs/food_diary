using System.ComponentModel;
using System.Threading.Tasks;
using FoodDiary.Data;
using Repositories.Abstract;
using FoodDiary.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using FoodDiary.Models;
using FoodDiary.Factories;

namespace FoodDiary.Repositories.Implementations
{
    public class RepositoriesFactory : IRepositoryFactory
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IBmiBmrFactory _bmibmrFactory;
       
        public RepositoriesFactory(ApplicationDbContext context, UserManager<AppUser> userManager, IBmiBmrFactory bmibmrFactory)
        {
            _userManager = userManager;
            _context = context;
            _bmibmrFactory = bmibmrFactory;
        }

        public IUserRepository GetUserRepository()
        {
            return new UserRepository(_context,_userManager,_bmibmrFactory);
        }

        public IProductsRepository GetProductsReposity()
        {
            return new ProductsRepository(_context);
        }
    }
}