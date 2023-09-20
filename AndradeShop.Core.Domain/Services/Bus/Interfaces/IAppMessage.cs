using AndradeShop.Core.Domain.Services.Bus.Models;
using MediatR;

namespace AndradeShop.Core.Domain.Services.Bus.Interfaces
{
    public interface IAppMessage : IRequest<CommandResult>
    {
    }

    public interface IAppMessage<TResponse> : IRequest<CommandResult<TResponse>>
    {
    }
}
