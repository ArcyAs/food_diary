namespace FoodDiary.Factories.BmiBmrCalculator
{
    public interface IBmiBmrCalculator
    {
        public double CalculateBMR(double weight, double height, int age, double activityLevel);
        public double CalculateBMI(double weight, double height);
    }
}