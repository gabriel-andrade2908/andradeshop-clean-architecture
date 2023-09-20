using AndradeShop.Core.Domain.Services.Validations.Helpers;

namespace AndradeShop.BackOffice.Domain.Products.ValueObjects.ValidationsPolicies
{
    internal class ProductPriceValidationStrategyPolicy : DomainValidationStrategyPolicy<ProductPriceVO>
    {
        public ProductPriceValidationStrategyPolicy(ProductPriceVO entity) : base(entity)
        {
        }

        public override void SetValidationRules()
        {
            RangeNumberDouble(price => price.Sale, 999999, 0, "Venda");
            RangeNumberDouble(price => price.Cost, 999999, 0, "Custo");

            AddCustomValidation(price => price, price => price.Sale > price.Cost, "preço de venda precisa ser maior que o de custo");
        }
    }
}
