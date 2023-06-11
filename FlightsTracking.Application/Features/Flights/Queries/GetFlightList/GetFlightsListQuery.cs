using MediatR;
using System.Collections.Generic;

namespace FlightsTracking.Application.Features.Flights.Queries.GetFlightList
{
    public class GetFlightsListQuery : IRequest<List<FlightsListViewModel>>
    {
    }
}
