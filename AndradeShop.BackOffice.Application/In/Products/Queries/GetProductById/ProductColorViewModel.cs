using AndradeShop.Core.Domain.GenericDTOs.Entities;

namespace AndradeShop.BackOffice.Application.In.Products.Queries.GetProductById
{
    public class ProductColorViewModel : NamedEntityDTO
    {
        public int StockQuantity { get; set; }
    }
}