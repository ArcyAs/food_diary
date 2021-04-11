using System.Collections.Generic;
using FoodDiary.Areas.Identity.Pages.Account;
using FoodDiary.Models;

namespace FoodDiary.Builders
{
    public interface IUserNameBuilder
    {
        string Build(Register.InputModel appUser);
    }
}