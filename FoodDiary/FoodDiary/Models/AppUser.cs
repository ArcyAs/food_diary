using FoodDiary.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace FoodDiary.Models
{
    public class AppUser: IdentityUser
    {
        public string FirstName { get; set; }      
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public int Height { get; set; }
        public double ActivityLevel { get; set; }
        public double Bmi { get; set; }
        public double Bmr { get; set; }
        public double Weight { get; set; }
    }
}