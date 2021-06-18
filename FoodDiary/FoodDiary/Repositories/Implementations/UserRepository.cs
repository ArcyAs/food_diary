using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FoodDiary.Data;
using FoodDiary.Factories;
using FoodDiary.Models;
using FoodDiary.Models.Enums;
using FoodDiary.Repositories.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;



namespace FoodDiary.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<UserDetailsEntity> UserDetailsEntities { get; }
        private readonly UserManager<AppUser> _userManager;
        private readonly IBmiBmrFactory _bmibmrFactory;

        public UserRepository(ApplicationDbContext context, UserManager<AppUser> userManager, IBmiBmrFactory bmibmrFactory)
        {
            _context = context;
            _userManager = userManager;
            _bmibmrFactory = bmibmrFactory;
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

        public async Task<UserDetailsEntity>  GetUserDetailsByUserId(Guid userId)
        {
            var userDetailsEntity = await _context.UserDetailsEntities?.FirstOrDefaultAsync(p => p.UserId == userId);
            return userDetailsEntity;
        }

        public async Task UpdateUserDetails(UserDetailsEntity newParameters, UserDetailsEntity toUpdate, Guid userId)
        {

            var details = await _context.UserDetailsEntities?.FirstOrDefaultAsync(p => p.UserId == userId);  // await GetUserDetailsByUserId(newParameters.UserId);
            string userHelpId = userId.ToString();
            var userAppDetails = await _userManager.FindByIdAsync(userHelpId);

            details.Weight = newParameters.Weight;
            details.Height = newParameters.Height;
            details.Target = newParameters.Target;

            if (details.Target == 0)
            {
                details.Bmr=(_bmibmrFactory.GetCalculator((Gender)Enum.ToObject(typeof(Gender), details.Gender)).CalculateBMR(details.Weight, details.Height, userAppDetails.Age, userAppDetails.ActivityLevel)) + 200;
            }
            else if (details.Target == 1)
            {
                details.Bmr = (_bmibmrFactory.GetCalculator((Gender)Enum.ToObject(typeof(Gender), details.Gender)).CalculateBMR(details.Weight, details.Height, userAppDetails.Age, userAppDetails.ActivityLevel))-200;
            }
            else if (details.Target == 2)
            {
                details.Bmr = _bmibmrFactory.GetCalculator((Gender)Enum.ToObject(typeof(Gender), details.Gender)).CalculateBMR(details.Weight, details.Height, userAppDetails.Age, userAppDetails.ActivityLevel);
            }

            await _context.SaveChangesAsync();
        }

        //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        //var userAppDetails = await _userManager.FindByIdAsync(userId);


    }
}