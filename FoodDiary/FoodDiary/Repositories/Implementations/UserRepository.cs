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
            var userdetails = _context.UserDetailsEntities.ToList();
            return userdetails;
        }

        public List<UserDetailsEntity> GetAllPersonals()
        {
            var user_personal_details = _context.UserDetailsEntities
                .Select(x => new UserDetailsEntity()
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    Gender = x.Gender,
                    Height = x.Height,
                    Bmi = x.Bmi,
                    Bmr = x.Bmr,
                    Weight = x.Weight,
                    AddDate = x.AddDate

                }).ToList();
            return user_personal_details;
        }
    }
}