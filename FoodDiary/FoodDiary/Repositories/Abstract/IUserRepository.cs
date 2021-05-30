using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodDiary.Repositories.Entities;

namespace Repositories.Abstract
{
    public interface IUserRepository
    {
        Task AddUserDetails(UserDetailsEntity userDetailsEntity);
        IEnumerable<UserDetailsEntity> GetAll();
        List<UserDetailsEntity> GetAllPersonals();
        Task<UserDetailsEntity> GetUserDetailsByUserId(Guid userId);
        Task UpdateUserDetails(UserDetailsEntity newParameters, UserDetailsEntity toUpdate);
    }
}