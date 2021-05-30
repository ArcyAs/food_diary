using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;

namespace FoodDiary.Tests
{
    public class SystemUnderTest
    {
        public HttpClient Client { get; }

        private SystemUnderTest()
        {
            var factory = new WebApiTestApplicationFactory();
            Client = factory
                .WithWebHostBuilder(builder =>
                {
                    builder.ConfigureTestServices(testServices =>
                    {
                    });
                })
                .CreateClient();
        }
        
        internal static SystemUnderTest New()
        {
            return new();
        }
    }

    public class WebApiTestApplicationFactory : WebApplicationFactory<Startup>
    {
    }
}