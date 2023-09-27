using AndradeShop.Core.Application.Tests.Integration.Domain.FakieEntities;
using AndradeShop.Core.Application.Tests.Integration.Infrastructure.DbAccess.DbConnection;
using AndradeShop.Core.Application.Tests.Integration.Infrastructure.DbAccess.FakeEntities;
using AndradeShop.Core.Application.Tests.Integration.Tests.FakeCommandHandlers;
using AndradeShop.Core.Domain.Auth;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AndradeShop.Core.Application.Tests.Integration.Infrastructure.TestsConfig.IoC
{
    public static class TestsServiceProvider
    {
        public static IServiceProvider GetServiceProvider<TInfrastructureBusService>(Func<IServiceProvider, TInfrastructureBusService> instanceOfInfrastructureBusDelegate) where TInfrastructureBusService : class, IInfrastructureBusService
        {
            var services = new ServiceCollection();
            services.AddCoreApplication(new List<Assembly>() { typeof(EntityCrudCommandHandlerTest).Assembly }, instanceOfInfrastructureBusDelegate);
            services.AddDbContext<TestDb>();
            services.AddScoped<IFakeEntityRepository, FakeEntityRepository>();
            return services.BuildServiceProvider();
        }

        public static UserHttpRequest HttpRequest() => new TestUserHttpRequest();

    }
}
