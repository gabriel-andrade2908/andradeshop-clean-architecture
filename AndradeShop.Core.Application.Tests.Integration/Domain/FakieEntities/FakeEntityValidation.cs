using AndradeShop.Core.Domain.Services.Validations.Helpers;

namespace AndradeShop.Core.Application.Tests.Integration.Domain.FakieEntities
{
    internal class FakeEntityValidation : DomainValidationStrategyPolicy<FakeEntity>
    {
        public FakeEntityValidation(FakeEntity entity) : base(entity)
        {
        }

        public override void SetValidationRules()
        {
            IsRequired((entityValidate) => entityValidate.Id);

            IsRequired((entityValidate) => entityValidate.Description);
            MaxLength((entityValidate) => entityValidate.Description);
            MinLength((entityValidate) => entityValidate.Description);
        }
    }
}
