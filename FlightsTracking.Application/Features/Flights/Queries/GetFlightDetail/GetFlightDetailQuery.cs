using MediatR;
using System;

namespace FlightsTracking.Application.Features.Flights.Queries.GetFlightDetail
{
    public class GetFlightDetailQuery : IRequest<FlightDetailViewModel>
    {
        public Guid FlightId {get; set; }
    }
}
