using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Entities
{
    public class UserDetailsEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int Gender { get; set; }
        public int Height { get; set; }
        public double Bmi { get; set; }
        public double Bmr { get; set; }
        public double Weight { get; set; }
    }
}