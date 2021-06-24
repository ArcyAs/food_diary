using FoodDiary.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDiary.Services.Abstract
{
    public interface IKcalCalculatorService
    {
        int KcalCalculator(int carbs, int fat, int proteins);

    }
}
