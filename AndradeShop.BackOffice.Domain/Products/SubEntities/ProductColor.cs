using AndradeShop.BackOffice.Domain.Products.Contexts.Colors;
using AndradeShop.BackOffice.Domain.Products.SubEntities.ValidationPolicies;
using AndradeShop.Core.Domain.Entities;

namespace AndradeShop.BackOffice.Domain.Products.SubEntities
{
    public class ProductColor : Entity<ProductColor>
    {
        public ProductColor(Guid id, Guid productId, Guid colorId, int stockQuantity) : base(id)
        {
            ProductId = productId;
            ColorId = colorId;
            StockQuantity = stockQuantity;
        }

        public Guid ProductId { get; private set; }
        public Guid ColorId { get; private set; }
        public int StockQuantity { get; private set; }

        public Product Product { get; private set; }
        public Color Color { get; private set; }

        protected override void SetValidationRules()
        {
            AddDomainValidationPolicy(new ProductColorValidationStrategyPolicy(this));
            base.SetValidationRules();
        }
    }
}
