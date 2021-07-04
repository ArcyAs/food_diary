using FoodDiary.Areas.Identity.Pages.Account;

namespace FoodDiary.Builders
{
    public interface IUserNameBuilder
    {
        string Build(Register.InputModel appUser);
    }
}