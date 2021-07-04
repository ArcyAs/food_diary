namespace FoodDiary.Services.Abstract
{
    public interface IKcalCalculatorService
    {
        int KcalCalculator(int carbs, int fat, int proteins);
    }
}