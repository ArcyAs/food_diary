namespace Repositories.Abstract
{
    public interface IRepositoryFactory
    {
        IUserRepository GetUserRepository();
    }
}