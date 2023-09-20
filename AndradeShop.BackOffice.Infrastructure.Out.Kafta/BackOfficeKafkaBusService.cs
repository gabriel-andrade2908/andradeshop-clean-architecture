using AndradeShop.Core.Infrastructure.Out.Kafta;

namespace AndradeShop.BackOffice.Infrastructure.Out.Kafta
{
    public class BackOfficeKafkaBusService : CoreKafkaBusService
    {
        public BackOfficeKafkaBusService(string connectionString, string applicationGroup) : base(connectionString, applicationGroup)
        {
        }
    }
}
