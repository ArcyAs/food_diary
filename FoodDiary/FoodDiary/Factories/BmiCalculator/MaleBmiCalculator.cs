namespace FoodDiary.Factories.BmiCalculator
{
    public class MaleBmiCalculator: IBmiCalculator
    {
        public double Calculate(double weight, int height, int age, double activityLevel)
        {
            return (5 + (9.99 * weight) + (6.25 * height) - (4.92 * age)) * activityLevel;
        }
    }
}