using MediatR;
using System;

namespace FlightsTracking.Application.Features.Flights.Commands.UpdateFlight
{
    public class UpdateFlightCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid DepartureAirport { get; set; }
        public Guid ArrivalAirport { get; set; }
    }
}
