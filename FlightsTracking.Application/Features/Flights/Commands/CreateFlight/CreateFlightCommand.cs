using MediatR;
using System;

namespace FlightsTracking.Application.Features.Flights.Commands.CreateFlight
{
    public class CreateFlightCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public Guid DepartureAirport { get; set; }
        public Guid ArrivalAirport { get; set; }
    }
}
