﻿using AndradeShop.BackOffice.Domain.Products.ValueObjects.ValidationsPolicies;
using AndradeShop.Core.Domain.Interfaces.Entities;
using AndradeShop.Core.Domain.Services.Validations.Helpers;

namespace AndradeShop.BackOffice.Domain.Products.ValueObjects
{
    public class ProductPriceVO : IClassWithDomainValidations<ProductPriceVO>
    {
        private ProductPriceVO() { }

        public ProductPriceVO(double sale, double provide)
        {
            Sale = sale;
            Cost = provide;
        }

        public double Sale { get; private set; }
        public double Cost { get; private set; }

        public IEnumerable<DomainValidationStrategyPolicy<ProductPriceVO>> GetValidationStrategyPolicies()
        {
            return new List<DomainValidationStrategyPolicy<ProductPriceVO>>
            {
                new ProductPriceValidationStrategyPolicy(this)
            };
        }
    }
}
