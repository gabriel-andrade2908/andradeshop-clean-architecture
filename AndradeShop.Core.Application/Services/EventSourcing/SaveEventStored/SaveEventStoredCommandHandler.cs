﻿using AndradeShop.Core.Domain.Services.Bus;
using MediatR;

namespace AndradeShop.Core.Application.Services.EventSourcing.SaveEventStored
{
    public class SaveEventStoredCommandHandler : IRequestHandler<SaveEventStoredCommand>
    {

        private readonly BusService _busService;

        public SaveEventStoredCommandHandler(BusService busService)
        {
            _busService = busService;
        }

        public async Task Handle(SaveEventStoredCommand request, CancellationToken cancellationToken)
        {
            await _busService.SendMessage(request, BusTransactionType.Infrastructure, cancellationToken);
        }
    }
}
