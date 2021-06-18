using FoodDiary.Data;
using FoodDiary.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using FoodDiary.Repositories.Implementations;
using FoodDiary.Factories;
using FoodDiary.Models;

namespace FoodDiary.Tests
{
    public class DiarysTests
    {
        private ApplicationDbContext _context;

        private List<DiaryEntity> diaryEntities = new List<DiaryEntity>()
        {
            new DiaryEntity()
            {
                Id = Guid.NewGuid()

            },
            new DiaryEntity()
            {
                Id = Guid.NewGuid()
            }
        };

        private List<AppUser> _users = new List<AppUser>
        {
            new() {Id = Guid.NewGuid().ToString()},
            new() {Id = Guid.NewGuid().ToString()},
        };

        public DiarysTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
             .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
             .Options;

            _context = new ApplicationDbContext(options);
            _context.DiaryEntities.AddRange(diaryEntities);
            _context.SaveChanges();
        }

        [Fact]
        public async Task ShouldGetIdDiaryByUserId()
        {
            UserDetailsEntity userDetails = new UserDetailsEntity()
            {
                Bmr = 12,
                Bmi = 12,
                Gender = 0,
                Height = 120,
                Target = 1,
                Weight = 200,
                AddDate = DateTime.Now,
                UserId = Guid.NewGuid(),
                Id = Guid.NewGuid(),
                DiaryId = diaryEntities[0].Id

            };

            var diaryRepository = new DiaryRepository(_context);
            var diaryId = await diaryRepository.GetDiaryByUserId(userDetails.Id);

            diaryId.Id.Should().Be(diaryEntities[0].Id);

        }
    }
}
