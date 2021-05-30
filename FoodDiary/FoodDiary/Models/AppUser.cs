using Microsoft.AspNetCore.Identity;

namespace FoodDiary.Models
{
    public class AppUser: IdentityUser
    {
        public string FirstName { get; set; }      
        public string LastName { get; set; }
        public int Age { get; set; }
        public double ActivityLevel { get; set; }
        
    }
}