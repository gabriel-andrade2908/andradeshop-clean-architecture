using AndradeShop.BackOffice.Infrastructure.CrossCutting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AndradeShop.BackOffice.Infrastructure.Tests.Integration.Infrastructure
{
    internal class TestServiceProvider
    {
        public readonly ServiceProvider ServiceProvider;
        public TestServiceProvider()
        {
            var configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
            var services = new ServiceCollection();
            services.AddApplicationWithDependencies(configuration.GetConnectionString("DefaultConnection")!, configuration.GetSection("BusServiceConnection:Kafka").Value!);
            ServiceProvider = services.BuildServiceProvider();
        }

    }
}
