using AndradeShop.Core.Domain.Interfaces.DTOs;

namespace AndradeShop.Core.Domain.GenericDTOs.Entities
{
    public class EntityDTO : IEntityDTO
    {
        public Guid Id { get; set; }
    }
}
