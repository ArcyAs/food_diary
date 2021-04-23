﻿using FoodDiary.Data;
using Repositories.Abstract;

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
    }
}