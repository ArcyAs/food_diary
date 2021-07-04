namespace FoodDiary.Services.Implementation
{
    public static class KcalCalculatorService
    {
        public static int KcalCalculator(int carb, int fat, int protein)
        {
            var kcal = 0;
            return kcal = carb * 4 + protein * 4 + fat * 9;
        }
    }
}