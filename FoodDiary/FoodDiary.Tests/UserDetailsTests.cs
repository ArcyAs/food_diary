using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using FoodDiary.Data;
using FoodDiary.Factories;
using FoodDiary.Models;
using FoodDiary.Repositories.Abstract;
using FoodDiary.Repositories.Entities;
using FoodDiary.Repositories.Implementations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace FoodDiary.Tests
{
    public class UserDetailsTests
    {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly ApplicationDbContext _context;

        private readonly List<UserDetailsEntity> _userDetailsEntities = new()
        {
            new UserDetailsEntity()
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
            new UserDetailsEntity
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

        private readonly List<AppUser> _users = new()
        {
            new() {Id = Guid.NewGuid().ToString()},
            new() {Id = Guid.NewGuid().ToString()}
        };

        public UserDetailsTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _context = new ApplicationDbContext(options);
            _context.UserDetailsEntities.AddRange(_userDetailsEntities);
            _context.SaveChanges();
        }

        [Fact]
        public void ShouldImplementIRepositoryFactoryInterface()
        {
            var repositories = new RepositoriesFactory(_context, MockUserManager(_users).Object, new BmiBmrFactory());
            repositories.Should().BeAssignableTo<IRepositoryFactory>();
        }

        [Fact]
        public void ShouldImplementIUserRepository()
        {
            var userRepository = new UserRepository(_context, MockUserManager(_users).Object, new BmiBmrFactory());
            userRepository.Should().BeOfType<UserRepository>();
            userRepository.Should().BeAssignableTo<IUserRepository>();
        }

        [Fact]
        public void ShouldGetAllUsersFromContext()
        {
            var userRepository = new UserRepository(_context, MockUserManager(_users).Object, new BmiBmrFactory());
            var result = userRepository.GetAll().ToList();
            result.Should().HaveCount(2);
            result.Should().BeOfType<List<UserDetailsEntity>>();
            result.FirstOrDefault().Should().BeOfType<UserDetailsEntity>();
            result.FirstOrDefault().Should().BeEquivalentTo(_userDetailsEntities.FirstOrDefault());
        }

        [Fact]
        public void ShouldGetAllPersonals()
        {
            var userRepository = new UserRepository(_context, MockUserManager(_users).Object, new BmiBmrFactory());
            var result = userRepository.GetAllPersonals().ToList();
            result.Should().HaveCount(2);
            result.Should().BeOfType<List<UserDetailsEntity>>();
            result.FirstOrDefault().Should().BeOfType<UserDetailsEntity>();
        }

        [Fact]
        public async Task ShouldAddNewUserDetails()
        {
            var data = new UserDetailsEntity
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

            var userRepository = new UserRepository(_context, MockUserManager(_users).Object, new BmiBmrFactory());
            var t = userRepository.AddUserDetails(data);

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
            var userRepository = new UserRepository(_context, MockUserManager(_users).Object, new BmiBmrFactory());
            var result = await userRepository.GetUserDetailsByUserId(_userDetailsEntities[0].UserId);

            result.Should().BeEquivalentTo(_userDetailsEntities[0]);
        }

        [Fact]
        public async Task ShouldUpdateTargetNewUserDetails()
        {
            var new_data = new UserDetailsEntity
            {
                Bmi = 20,
                Bmr = 40,
                Gender = 1,
                Height = 12,
                Id = Guid.NewGuid(),
                Target = 0,
                Weight = 12,
                AddDate = DateTime.Now,
                UserId = Guid.NewGuid()
            };

            var userRepository = new UserRepository(_context, MockUserManager(_users).Object, new BmiBmrFactory());
            var t = userRepository.UpdateUserDetails(new_data, new_data, _userDetailsEntities[0].UserId);

            userRepository.GetAll().Should().HaveCount(2);
            _userDetailsEntities[0].Weight.Should().Be(12);
            _userDetailsEntities[0].Height.Should().Be(12);
            _userDetailsEntities[0].Target.Should().Be(0);
        }

        public static Mock<UserManager<AppUser>> MockUserManager(ICollection<AppUser> ls)
        {
            var store = new Mock<IUserStore<AppUser>>();
            var mgr = new Mock<UserManager<AppUser>>(store.Object, null, null, null, null, null, null, null, null);
            mgr.Object.UserValidators.Add(new UserValidator<AppUser>());
            mgr.Object.PasswordValidators.Add(new PasswordValidator<AppUser>());

            mgr.Setup(x => x.DeleteAsync(It.IsAny<AppUser>())).ReturnsAsync(IdentityResult.Success);
            mgr.Setup(x => x.CreateAsync(It.IsAny<AppUser>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success)
                .Callback<AppUser, string>((x, y) => ls.Add(x));
            mgr.Setup(x => x.UpdateAsync(It.IsAny<AppUser>())).ReturnsAsync(IdentityResult.Success);

            return mgr;
        }
    }
}