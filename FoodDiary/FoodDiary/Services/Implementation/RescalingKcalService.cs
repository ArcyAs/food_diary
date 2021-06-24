using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDiary.Services.Implementation
{
    public static class RescalingKcalService
    {
        public static  double RescaleKcal(int kcal, double weight)
        {
            return (kcal * weight) / 100;
        }
    }
}
