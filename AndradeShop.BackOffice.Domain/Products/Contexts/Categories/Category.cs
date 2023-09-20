using AndradeShop.BackOffice.Domain.Products.SubEntities;
using AndradeShop.Core.Domain.Entities;
using AndradeShop.Core.Domain.ValueObject;

namespace AndradeShop.BackOffice.Domain.Products.Contexts.Categories
{
    public class Category : NamedEntity<Category>
    {
        private Category() { }
        public Category(Guid id, string name) : base(id, name)
        {
        }

        public void SetName(string name)
        {
            Name = new SearchableStringVO(name);
        }

        public IReadOnlyCollection<ProductCategory> ProductCategories { get; set; }
    }
}
