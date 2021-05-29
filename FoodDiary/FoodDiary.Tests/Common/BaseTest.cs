namespace FoodDiary.Tests.Common
{
    public class BaseTest
    {
        public BaseTest()
        {
            Sut = SystemUnderTest.New();
        }

        protected SystemUnderTest Sut { get; }
    }
}