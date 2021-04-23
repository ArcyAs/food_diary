namespace FoodDiary.Factories.BmiBmrCalculator
{
    public class WomenBmiCalculator: IBmiBmrCalculator
    {
        public double CalculateBMI(double weight, double height)
        {
            return (weight / ((height) * (height )));
        }

        public double CalculateBMR(double weight, double height, int age, double activityLevel)
        {
            return (655 + (9.6 * weight) + (1.8 * height ) - (age)) * activityLevel;
        }
    }
}