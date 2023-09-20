using AndradeShop.Core.Domain.Auth;
using AndradeShop.Core.Domain.Services.Bus;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;
using AndradeShop.Core.Domain.Services.DomainNotifications;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AndradeShop.Core.Domain
{
    public static class CoreDomainModule
    {
        public static IServiceCollection AddCoreDomainModule<TInfrastructureBusService>(this IServiceCollection services, IList<Assembly> applicationAssemblies, Func<IServiceProvider, TInfrastructureBusService> instanceOfInfrastructureBusDelegate)
            where TInfrastructureBusService : class, IInfrastructureBusService
        {
            services.AddMediatR(cfg =>
            {
                foreach (var assembly in applicationAssemblies)
                    cfg.RegisterServicesFromAssembly(assembly);

                cfg.RegisterServicesFromAssembly(typeof(CoreDomainModule).Assembly);
            });

            services.AddScoped<DomainNotificationService>();
            services.AddScoped<UserHttpRequest>();
            services.AddScoped<IInfrastructureBusService, TInfrastructureBusService>(instanceOfInfrastructureBusDelegate);
            services.AddScoped<BusService>();

            return services;
        }
    }
}
