using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Common;
using FoodDiary.Data;
using FoodDiary.Repositories.Entities;
using FoodDiary.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Xunit;

namespace FoodDiary.Tests
{
    public class UserDetailsTests
    {
        private ApplicationDbContext _context;

        private List<UserDetailsEntity> _userDetailsEntities = new()
        {
            new()
            {
                Bmr = 12,
                Bmi = 12,
                Gender = 0,
                Height = 120,
                Target = 90,
                Weight = 200,
                AddDate = DateTime.Now,
                UserId = Guid.NewGuid(),
                Id = Guid.NewGuid()
            },
            new UserDetailsEntity()
            {
                Bmr = 122,
                Bmi = 122,
                Gender = 1,
                Height = 1220,
                Target = 902,
                Weight = 2003,
                AddDate = DateTime.Now,
                UserId = Guid.NewGuid(),
                Id = Guid.NewGuid()
            }
        };

        public UserDetailsTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new ApplicationDbContext(options);
            _context.UserDetailsEntities.AddRange(_userDetailsEntities);
            _context.SaveChanges();
        }

        [Fact]
        public void ShouldImplementIRepositoryFactoryInterface()
        {
            var repositories = new RepositoriesFactory(_context);
            repositories.Should().BeAssignableTo<IRepositoryFactory>();
        }

        [Fact]
        public void ShouldImplementIUserRepository()
        {
            var userRepository = new UserRepository(_context);
            userRepository.Should().BeOfType<UserRepository>();
            userRepository.Should().BeAssignableTo<IUserRepository>();
        }

        [Fact]
        public void ShouldGetAllUsersFromContext()
        {
            var userRepository = new UserRepository(_context);
            var result = userRepository.GetAll().ToList();
            result.Should().HaveCount(2);
            result.Should().BeOfType<List<UserDetailsEntity>>();
            result.FirstOrDefault().Should().BeOfType<UserDetailsEntity>();
            result.FirstOrDefault().Should().BeEquivalentTo(_userDetailsEntities.FirstOrDefault());
        }

        [Fact]
        public void ShouldGetAllPersonals()
        {
            var userRepository = new UserRepository(_context);
            var result = userRepository.GetAllPersonals().ToList();
            result.Should().HaveCount(2);
            result.Should().BeOfType<List<UserDetailsEntity>>();
            result.FirstOrDefault().Should().BeOfType<UserDetailsEntity>();
        }

        [Fact]
        public async Task ShouldAddNewUserDetails()
        {
            var data = new UserDetailsEntity()
            {
                Bmi = 20,
                Bmr = 40,
                Gender = 1,
                Height = 12,
                Id = Guid.NewGuid(),
                Target = 12,
                Weight = 12,
                AddDate = DateTime.Now,
                UserId = Guid.NewGuid()
            };

            var userRepository = new UserRepository(_context);
            var t= userRepository.AddUserDetails(data);

            userRepository.GetAll().Should().HaveCount(3);
            var newData = userRepository.GetAll().LastOrDefault();
            newData.Should().BeEquivalentTo(data);
            newData.Bmi.Should().Be(data.Bmi);
            newData.Bmr.Should().Be(data.Bmr);
            newData.Gender.Should().Be(data.Gender);
            newData.Height.Should().Be(data.Height);
            newData.Id.Should().Be(data.Id);
            newData.Target.Should().Be(data.Target);
            newData.Weight.Should().Be(data.Weight);
            newData.AddDate.Should().Be(data.AddDate);
            newData.UserId.Should().Be(data.UserId);
        }

        [Fact]
        public async Task ShouldReturnCorrectUser()
        {
            var userRepository = new UserRepository(_context);
            var result = await userRepository.GetUserDetailsByUserId(_userDetailsEntities[0].UserId);
            
            result.Should().BeEquivalentTo(_userDetailsEntities[0]);
            

        }
    }
}