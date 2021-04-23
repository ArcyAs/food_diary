using FoodDiary.Factories.BmiBmrCalculator;
using FoodDiary.Models.Enums;

namespace FoodDiary.Factories
{
    public interface IBmiBmrFactory
    {
        IBmiBmrCalculator GetCalculator(Gender gender);
    }
}