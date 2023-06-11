using MediatR;
using System;

namespace FlightsTracking.Application.Features.Flights.Commands.DeleteFlight
{
    public class DeleteFlightCommand : IRequest
    {
        public Guid FlightId { get; set; }
    }
}
