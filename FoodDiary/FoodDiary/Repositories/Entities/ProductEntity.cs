using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDiary.Repositories.Entities
{
    public class ProductEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Product name")]
        public string ProductName { get; set; }
        public int  Protein { get; set; }
        
        [Display(Name = "Carbohydrates")]
        public int  Carb { get; set; }
        public int Fat { get; set; }
        public int Kcal { get; set; }
        
    }
}
