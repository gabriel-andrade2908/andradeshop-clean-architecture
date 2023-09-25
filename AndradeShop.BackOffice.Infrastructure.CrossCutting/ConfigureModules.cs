using AndradeShop.BackOffice.Application;
using AndradeShop.BackOffice.Infrastructure.Out.DbAccess;
using AndradeShop.BackOffice.Infrastructure.Out.Kafta;
using Microsoft.Extensions.DependencyInjection;

namespace AndradeShop.BackOffice.Infrastructure.CrossCutting
{
    public static class ConfigureModules
    {
        public static IServiceCollection AddApplicationWithDependencies(this IServiceCollection services, string connectionStringDb, string connectionStringBus)
        {
            services.AddBackOfficeAccessData(connectionStringDb);
            services.AddBackOfficeApplicationBase(services => new BackOfficeKafkaBusService(connectionStringBus, "AndradeShop"));
            return services;
        }
    }
}
