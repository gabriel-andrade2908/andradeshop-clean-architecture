using AndradeShop.BackOffice.Domain.Products.ValueObjects.DTOs;
using AndradeShop.Core.Domain.GenericDTOs.Entities;

namespace AndradeShop.BackOffice.Application.In.Products.Commands.Shared
{
    public class BaseProductDTO : NamedEntityDTO
    {
        public ProductPriceDTO Price { get; set; }
        public string Description { get; set; }
        public IReadOnlyCollection<EntityDTO> ProductCategories { get; set; }
        public IReadOnlyCollection<ProductColorDTO> ProductColors { get; set; }
    }
}
