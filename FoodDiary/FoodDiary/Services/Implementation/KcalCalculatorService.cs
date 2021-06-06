using FoodDiary.Repositories.Entities;
using FoodDiary.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDiary.Services.Implementation
{
    public static class KcalCalculatorService

    {
        public static int KcalCalculator(int carb, int fat,int protein)
        {
            int kcal = 0;
            return kcal = carb * 4 + protein * 4 + fat * 9;
        }
    }
}
