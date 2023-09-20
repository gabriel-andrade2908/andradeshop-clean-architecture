using AndradeShop.Core.Domain.GenericDTOs.Entities;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.BackOffice.Application.In.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : EntityDTO, IAppMessage<GetProductByIdViewModel>
    {
    }
}
