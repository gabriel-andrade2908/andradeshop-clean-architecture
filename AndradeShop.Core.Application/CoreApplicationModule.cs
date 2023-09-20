using AndradeShop.Core.Domain;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AndradeShop.Core.Application
{
    public static class CoreApplicationModule
    {
        // extension methods from IServiceCollection
        public static IServiceCollection AddCoreApplication<TInfrastructureBusService>(this IServiceCollection services, IList<Assembly> applicationAssemblies, Func<IServiceProvider, TInfrastructureBusService> instanceOfInfrastructureBusDelegate)
            where TInfrastructureBusService : class, IInfrastructureBusService
        {
            applicationAssemblies.Add(typeof(CoreApplicationModule).Assembly);
            services.AddCoreDomainModule<TInfrastructureBusService>(applicationAssemblies, instanceOfInfrastructureBusDelegate);
            return services;
        }
    }
}
