using AutoMapper;
using FlightsTracking.Application.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FlightsTracking.Application.Features.Flights.Queries.GetFlightDetail
{
    public class GetFlightDetailQueryHandler : IRequestHandler<GetFlightDetailQuery, FlightDetailViewModel>
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IMapper _mapper;

        public GetFlightDetailQueryHandler(IFlightRepository flightRepository, IMapper mapper) {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }
        public async Task<FlightDetailViewModel> Handle(GetFlightDetailQuery request, CancellationToken cancellationToken)
        {
            var Flight = await _flightRepository.GetFlightByIdAsync(request.FlightId);
            return _mapper.Map <FlightDetailViewModel> (Flight);
        }
    }
}
