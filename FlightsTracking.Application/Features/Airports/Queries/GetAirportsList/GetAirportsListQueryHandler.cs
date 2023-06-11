using AutoMapper;
using FlightsTracking.Application.Contracts;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FlightsTracking.Application.Features.Airports.Queries.GetAirportsList
{
    public class GetAirportsListQueryHandler : IRequestHandler<GetAirportsListQuery, List<AirportsListViewModel>>
    {
        private readonly IAirportRepository _airportRepository;
        private readonly IMapper _mapper;

        public GetAirportsListQueryHandler(IAirportRepository airportRepository, IMapper mapper) {
            _airportRepository = airportRepository;
            _mapper = mapper;
        }
        public async Task<List<AirportsListViewModel>> Handle(GetAirportsListQuery request, CancellationToken cancellationToken)
        {
            var allAirports = await _airportRepository.GetListAllAirportsAsync();
            return _mapper.Map <List<AirportsListViewModel>> (allAirports);
        }
    }
}
