using AndradeShop.Core.Domain.EventSourcing;
using AndradeShop.Core.Domain.Services.Bus.Interfaces;
using MediatR;

namespace AndradeShop.Core.Application.Services.EventSourcing.SaveEventStored
{
    public class SaveEventStoredCommand : IAppMessage, IRequest
    {

        public SaveEventStoredCommand(EventStoredEvent eventStored)
        {
            EventStored = eventStored;
        }

        public EventStoredEvent EventStored { get; private set; }
    }
}
