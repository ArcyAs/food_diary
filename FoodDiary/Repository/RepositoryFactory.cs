namespace Repository
{
    public class RepositoryFactory: IRepositoryFactory
    {
        public  GetCalculator(Gender gender)
        {
            return gender switch
            {
                Gender.Female => new WomenBmiCalculator(),
                Gender.Male => new MaleBmiCalculator(),
                _ => throw new ArgumentOutOfRangeException(nameof(gender), gender, "Selected gender is not supported")
            };
        }
    }

    public interface IRepositoryFactory
    {
    }
}