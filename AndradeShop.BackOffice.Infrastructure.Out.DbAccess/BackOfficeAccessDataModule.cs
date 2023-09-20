using AndradeShop.BackOffice.Infrastructure.Out.DbAccess.Contexts.Products;
using EShopOnContainer.BackOffice.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AndradeShop.BackOffice.Infrastructure.Out.DbAccess
{
    public static class BackOfficeAccessDataModule
    {
        public static IServiceCollection AddBackOfficeAccessData(this IServiceCollection services, string connectionString)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<BackOfficeDb>(options => options.UseSqlServer(connectionString));
            services.AddBackOfficeApplicationRepositories<ProductRepository, ColorRepository, CategoryRepository>();

            return services;
        }
    }
}
