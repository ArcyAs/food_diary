using System;
using FluentAssertions;
using FoodDiary.Factories;
using FoodDiary.Factories.BmiBmrCalculator;
using FoodDiary.Models.Enums;
using Xunit;

namespace FoodDiary.Tests
{
    public class BmiBriFactoryTests
    {
        private readonly IBmiBmrFactory _factory;

        public BmiBriFactoryTests()
        {
            _factory = new BmiBmrFactory();
        }

        [Fact]
        public void GetBmiCalculatorForFemale_ShouldNotThrowNotExceptionAndBeSpecifiedType()
        {
            var result = _factory.GetCalculator(Gender.Female);
            result.Should().BeOfType<WomenBmiCalculator>();
            result.Should().NotBeOfType<MaleBmiCalculator>();
            result.Should().NotBeOfType<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void GetBmiCalculatorForMale_ShouldNotThrowNotExceptionAndBeSpecifiedType()
        {
            var result = _factory.GetCalculator(Gender.Male);
            result.Should().BeOfType<MaleBmiCalculator>();
            result.Should().NotBeOfType<WomenBmiCalculator>();
            result.Should().NotBeOfType<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void GetBmiCalculatorForFemale_ShouldProperlyCalculateBmi()
        {
            var result = _factory.GetCalculator(Gender.Female).CalculateBMI(90, 180);
            result.Should().BeOfType(typeof(double));
            result.Should().NotBeOfType(typeof(string));
            result.Should().NotBeOfType(typeof(decimal));
            result.Should().BeGreaterThan(27);
            result.Should().BeLessThan(28);
            result.Should().Be(27.777777777777775);
        }

        [Fact]
        public void GetBmiCalculatorForMale_ShouldProperlyCalculateBmi()
        {
            var result = _factory.GetCalculator(Gender.Male).CalculateBMI(90, 180);
            result.Should().BeOfType(typeof(double));
            result.Should().NotBeOfType(typeof(string));
            result.Should().NotBeOfType(typeof(decimal));
            result.Should().BeGreaterThan(27);
            result.Should().BeLessThan(28);
            result.Should().Be(27.777777777777775);
        }

        [Fact]
        public void GetBmiCalculator_ShouldThrowNotException()
        {
            Action act = () => _factory.GetCalculator(Gender.TestValue);
            act.Should().Throw<ArgumentOutOfRangeException>();
            act.Should().Throw<ArgumentOutOfRangeException>()
                .WithMessage("Selected gender is not supported (Parameter 'gender')");
        }

        [Fact]
        public void GetBmrCalculatorForMale_ShouldProperlyCalculateBmi()
        {
            var result = _factory.GetCalculator(Gender.Male).CalculateBMR(90, 180, 25, 1.2);
            result.Should().BeOfType(typeof(double));
            result.Should().NotBeOfType(typeof(string));
            result.Should().NotBeOfType(typeof(decimal));
            result.Should().Be(2287.3199999999997);
        }

        [Fact]
        public void GetBmrCalculatorForFemale_ShouldProperlyCalculateBmi()
        {
            var result = _factory.GetCalculator(Gender.Female).CalculateBMR(90, 180, 25, 1.2);
            result.Should().BeOfType(typeof(double));
            result.Should().NotBeOfType(typeof(string));
            result.Should().NotBeOfType(typeof(decimal));
            result.Should().Be(2181.5999999999999);
        }
    }
}