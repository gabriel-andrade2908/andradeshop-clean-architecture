using AndradeShop.BackOffice.Domain.Products.Contexts.Categories;
using AndradeShop.BackOffice.Domain.Products.SubEntities.ValidationPolicies;
using AndradeShop.Core.Domain.Entities;

namespace AndradeShop.BackOffice.Domain.Products.SubEntities
{
    public class ProductCategory : Entity<ProductCategory>
    {
        public ProductCategory(Guid id, Guid productId, Guid categoryId) : base(id)
        {
            ProductId = productId;
            CategoryId = categoryId;
        }

        public Guid ProductId { get; private set; }
        public Guid CategoryId { get; private set; }

        public Product Product { get; private set; }
        public Category Category { get; private set; }

        protected override void SetValidationRules()
        {
            AddDomainValidationPolicy(new ProductCategoryValidationStrategyPolicy(this));
            base.SetValidationRules();
        }
    }
}
