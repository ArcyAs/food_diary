using System;
using FoodDiary.Factories.BmiBmrCalculator;
using FoodDiary.Models.Enums;

namespace FoodDiary.Factories
{
    public class BmiBmrFactory: IBmiBmrFactory
    {
        public IBmiBmrCalculator GetCalculator(Gender gender)
        {
            return gender switch
            {
                Gender.Female => new WomenBmiCalculator(),
                Gender.Male => new MaleBmiCalculator(),
                _ => throw new ArgumentOutOfRangeException(nameof(gender), "Selected gender is not supported")
            };
        }
    }
}