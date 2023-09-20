using AndradeShop.BackOffice.Domain.Products.SubEntities;
using AndradeShop.Core.Domain.Entities;
using AndradeShop.Core.Domain.ValueObject;

namespace AndradeShop.BackOffice.Domain.Products.Contexts.Colors
{
    public class Color : NamedEntity<Color>
    {
        private Color()
        {
        }
        public Color(Guid id, string name) : base(id, name)
        {
        }

        public IReadOnlyCollection<ProductColor> ProductColors { get; private set; }

        public void SetName(string name)
        {
            Name = new SearchableStringVO(name);
        }
    }
}
