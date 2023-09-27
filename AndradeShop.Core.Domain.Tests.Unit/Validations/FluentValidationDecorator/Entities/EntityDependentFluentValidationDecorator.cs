using AndradeShop.Core.Domain.Interfaces.Entities;
using AndradeShop.Core.Domain.Services.Validations.Helpers;
using AndradeShop.Core.Domain.Tests.Unit.Validations.FluentValidationDecorator.Entities.Policies;

namespace AndradeShop.Core.Domain.Tests.Unit.Validations.FluentValidationDecorator.Entities
{
    public class EntityDependentFluentValidationDecorator : IClassWithDomainValidations<EntityDependentFluentValidationDecorator>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }

        public IEnumerable<DomainValidationStrategyPolicy<EntityDependentFluentValidationDecorator>> GetValidationStrategyPolicies()
        {
            return new List<DomainValidationStrategyPolicy<EntityDependentFluentValidationDecorator>>
            {
                new EntityDependentFluentValidationDecoratorPolicy(this)
            };
        }
    }
}
