using AutoMapper;
using FlightsTracking.Application.Contracts;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FlightsTracking.Application.Features.Flights.Queries.GetFlightList
{
    public class GetFlightsListQueryHandler : IRequestHandler<GetFlightsListQuery, List<FlightsListViewModel>>
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IMapper _mapper;

        public GetFlightsListQueryHandler(IFlightRepository flightRepository, IMapper mapper) {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }
        public async Task<List<FlightsListViewModel>> Handle(GetFlightsListQuery request, CancellationToken cancellationToken)
        {
            var allFlights = await _flightRepository.GetListAllFlightAsync();
            return _mapper.Map <List<FlightsListViewModel>> (allFlights);
        }
    }
}
