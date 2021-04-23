using System.Threading.Tasks;
using FoodDiary.Data;
using Repositories.Abstract;
using Repositories.Entities;

namespace FoodDiary.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddUserDetails(UserDetailsEntity userDetailsEntity)
        {
            _context.UserDetailsEntities.Add(userDetailsEntity);
            await _context.SaveChangesAsync();
        }
    }
}