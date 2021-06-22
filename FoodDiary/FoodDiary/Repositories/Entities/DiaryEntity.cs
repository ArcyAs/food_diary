using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDiary.Repositories.Entities
{
    public class DiaryEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public Guid DiaryId { get; set; }
        public Guid IdProduct { get; set; }
        public double Weight { get; set; }
        public int Kcal { get; set; }
        public DateTime AddDate { get; set; }
    }
    public class Diary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public Guid DiaryId { get; set; }
        public string ProductName { get; set; }
        public double Weight { get; set; }
        public int Kcal { get; set; }
        public DateTime AddDate { get; set; }
    }
}


