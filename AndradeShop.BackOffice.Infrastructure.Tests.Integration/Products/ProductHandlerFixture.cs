using AndradeShop.BackOffice.Domain.Products;
using Xunit;

namespace AndradeShop.BackOffice.Infrastructure.Tests.Integration.Products
{
    [CollectionDefinition(nameof(ProductHandlerCollection))]
    public class ProductHandlerCollection : ICollectionFixture<ProductHandlerFixture>
    {
    }
    public class ProductHandlerFixture
    {
        public Product AddedProduct { private set; get; }
        public void AddProduct(Product product) => AddedProduct = product;
    }
}
