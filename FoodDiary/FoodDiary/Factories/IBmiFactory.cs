using FoodDiary.Factories.BmiCalculator;
using FoodDiary.Models.Enums;

namespace FoodDiary.Factories
{
    public interface IBmiFactory
    {
        IBmiCalculator GetCalculator(Gender gender);
    }
}