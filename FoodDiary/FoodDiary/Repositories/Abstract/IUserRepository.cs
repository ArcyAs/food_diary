using System.Threading.Tasks;
using Repositories.Entities;

namespace Repositories.Abstract
{
    public interface IUserRepository
    {
        Task AddUserDetails(UserDetailsEntity userDetailsEntity);
    }
}