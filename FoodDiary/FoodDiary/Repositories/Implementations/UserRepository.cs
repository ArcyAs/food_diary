using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDiary.Data;
using FoodDiary.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;

namespace FoodDiary.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<UserDetailsEntity> UserDetailsEntities { get; set; }

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
            UserDetailsEntities = _context.UserDetailsEntities;
        }
        public async Task AddUserDetails(UserDetailsEntity userDetailsEntity)
        {
            _context.UserDetailsEntities.Add(userDetailsEntity);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<UserDetailsEntity> GetAll()
        {
            return UserDetailsEntities.ToList();
        }
    }
}