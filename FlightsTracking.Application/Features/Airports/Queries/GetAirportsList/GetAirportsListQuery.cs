using MediatR;
using System.Collections.Generic;

namespace FlightsTracking.Application.Features.Airports.Queries.GetAirportsList
{
    public class GetAirportsListQuery : IRequest<List<AirportsListViewModel>>
    {
    }
}
