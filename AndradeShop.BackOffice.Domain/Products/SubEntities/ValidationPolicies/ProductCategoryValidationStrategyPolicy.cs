﻿using AndradeShop.Core.Domain.Services.Validations.Helpers;

namespace AndradeShop.BackOffice.Domain.Products.SubEntities.ValidationPolicies
{
    public class ProductCategoryValidationStrategyPolicy : DomainValidationStrategyPolicy<ProductCategory>
    {
        public ProductCategoryValidationStrategyPolicy(ProductCategory entity) : base(entity)
        {
        }

        public override void SetValidationRules()
        {
            IsRequired(entity => entity.ProductId);
            IsRequired(entity => entity.CategoryId);
        }
    }
}
