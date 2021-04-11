namespace FoodDiary.Factories.BmiCalculator
{
    public interface IBmiCalculator
    {
        public double Calculate(double weight, int height, int age, double activityLevel);
    }
}