using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDiary.Repositories.Entities
{
    public class UserDetailsEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int Gender { get; set; }
        
        [Display(Name = "Height[cm]")]
        public int Height { get; set; }
        public double Bmi { get; set; }
        public double Bmr { get; set; }
        
        [Display(Name = "Weight[kg]")]
        public double Weight { get; set; }
        
        [Display(Name = "Your target")]
        public int Target { get; set; }
        public DateTime AddDate { get; set; }
    }
}