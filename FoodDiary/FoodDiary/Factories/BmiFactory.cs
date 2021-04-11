using System;
using FoodDiary.Factories.BmiCalculator;
using FoodDiary.Models.Enums;

namespace FoodDiary.Factories
{
    public class BmiFactory: IBmiFactory
    {
        public IBmiCalculator GetCalculator(Gender gender)
        {
            return gender switch
            {
                Gender.Female => new WomenBmiCalculator(),
                Gender.Male => new MaleBmiCalculator(),
                _ => throw new ArgumentOutOfRangeException(nameof(gender), gender, "Selected gender is not supported")
            };
        }
    }
}