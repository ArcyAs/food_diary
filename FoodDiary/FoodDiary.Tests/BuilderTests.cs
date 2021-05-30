using FluentAssertions;
using FoodDiary.Areas.Identity.Pages.Account;
using FoodDiary.Builders;
using Xunit;

namespace FoodDiary.Tests
{
    public class BuilderTests
    {
        private readonly UserNameBuilder _userNameBuilder;

        public BuilderTests()
        {
            _userNameBuilder = new UserNameBuilder();
        }

        [Fact]
        public void ShouldImplementsIUserNameInterface()
        {
            _userNameBuilder.Should().BeAssignableTo<IUserNameBuilder>();
        }

        [Fact]
        public void ShouldGenerateProperUserName()
        {
            var user = new Register.InputModel {FirstName = "Test", LastName = "Testowy"};
            _userNameBuilder.Build(user).Should().BeOfType<string>();
            _userNameBuilder.Build(user).Should().Be("Test Testowy");
            _userNameBuilder.Build(user).Should().NotBe("TestTestowy");
        }
    }
}