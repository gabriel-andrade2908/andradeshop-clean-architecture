using AndradeShop.Core.Domain.Services.Validations.Helpers;

namespace AndradeShop.Core.Domain.Interfaces.Entities
{
    public interface IClassWithDomainValidations<TClassWithValidations>
    {
        IEnumerable<DomainValidationStrategyPolicy<TClassWithValidations>> GetValidationStrategyPolicies();
    }
}
