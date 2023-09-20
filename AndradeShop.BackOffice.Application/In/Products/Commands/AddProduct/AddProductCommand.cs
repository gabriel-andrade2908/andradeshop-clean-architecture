using AndradeShop.BackOffice.Application.In.Products.Commands.Shared;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;

namespace AndradeShop.BackOffice.Application.In.Products.Commands.AddProduct
{
    public class AddProductCommand : BaseProductDTO, IAppMessage<Guid?>
    {
        public bool Enable { get; set; }

    }
}
