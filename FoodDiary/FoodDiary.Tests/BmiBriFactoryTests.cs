using System;
using FluentAssertions;
using FoodDiary.Factories;
using FoodDiary.Factories.BmiBmrCalculator;
using FoodDiary.Models.Enums;
using NSubstitute;
using Xunit;

namespace FoodDiary.Tests
{
    public class BmiBriFactoryTests
    {
        private readonly IBmiBmrFactory _factory;

        public BmiBriFactoryTests()
        {
            _factory = Substitute.For<IBmiBmrFactory>();
        }

        [Fact]
        public void GetBmiBriCalculatorForFemale_ShouldNotThrowNotException()
        {
            Action act = () => _factory.GetCalculator(Gender.Female);
            act.Should().NotThrow<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void GetBmiBriCalculatorForMale_ShouldNotThrowNotException()
        {
            Action act = () => _factory.GetCalculator(Gender.Male);
            act.Should().NotThrow<ArgumentOutOfRangeException>();
        }
        
        [Fact]
        public void GetBmiBriCalculatorForFemale_ShouldProperlyCalculateBmi()
        {
             _factory.GetCalculator(Gender.Female).CalculateBMI(90, 180).Returns(27.8);
             Assert.Equal(27.8,  _factory.GetCalculator(Gender.Female).CalculateBMI(90, 180));
        }
    }
}