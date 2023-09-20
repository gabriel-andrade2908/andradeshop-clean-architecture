using AndradeShop.Core.Domain.Interfaces.DTOs;

namespace AndradeShop.Core.Domain.GenericDTOs.Search
{
    public class SearchQuery : IEntityDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string QueryKey { get; set; }
    }
}
