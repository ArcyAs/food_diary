namespace FoodDiary.Factories.BmiBmrCalculator
{
    public class MaleBmiCalculator : IBmiBmrCalculator
    {
        public double CalculateBMI(double weight, double height)
        {
            return weight / (height / 100 * (height / 100));
        }

        public double CalculateBMR(double weight, double height, int age, double activityLevel)
        {
            return (5 + 9.99 * weight + 6.25 * height - 4.92 * age) * activityLevel;
        }
    }
}