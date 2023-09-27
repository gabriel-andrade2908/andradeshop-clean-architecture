using AndradeShop.Core.Domain.Auth;

namespace AndradeShop.Core.Application.Tests.Integration.Infrastructure.TestsConfig.IoC
{
    internal class TestUserHttpRequest : UserHttpRequest
    {
#pragma warning disable CS8625 // Não é possível converter um literal nulo em um tipo de referência não anulável.
        public TestUserHttpRequest() : base(null)
#pragma warning restore CS8625 // Não é possível converter um literal nulo em um tipo de referência não anulável.
        {
        }

        //protected override IEnumerable<ClaimApp> GetApplicationClaims()
        //{
        //    return new List<ClaimApp>
        //    {
        //        new ClaimApp("TestType", "TestValue")
        //    };
        //}
    }
}
