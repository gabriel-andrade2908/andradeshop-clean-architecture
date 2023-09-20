using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Categories.Commands.AddCategory
{
    public class AddCategoryCommand : NamedEntityDTO, IAppMessage<Guid?>
    {
    }
}
