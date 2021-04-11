namespace FoodDiary.Factories.BmiCalculator
{
    public class WomenBmiCalculator: IBmiCalculator
    {
        public double Calculate(double weight, int height, int age, double activityLevel)
        {
            return (655 + (9.6 * weight) + (1.8 * height ) - (age)) * activityLevel;
        }
    }
}