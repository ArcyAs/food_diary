using System.Text;
using FoodDiary.Areas.Identity.Pages.Account;

namespace FoodDiary.Builders
{
    public class UserNameBuilder : IUserNameBuilder
    {
        public string Build(Register.InputModel appUser)
        {
            var sb = new StringBuilder();

            sb.Append(appUser.FirstName);
            sb.Append(" ");
            sb.Append(appUser.LastName);

            return sb.ToString();
        }
    }
}