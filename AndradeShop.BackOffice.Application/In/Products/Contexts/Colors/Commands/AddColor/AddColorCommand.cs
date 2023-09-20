using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.BackOffice.Application.In.Products.Contexts.Colors.Commands.AddColor
{
    public class AddColorCommand : NamedEntityDTO, IAppMessage<Guid?>
    {
    }
}
