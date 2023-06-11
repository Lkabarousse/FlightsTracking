using AutoMapper;
using FlightsTracking.Application.Contracts;
using FlightsTracking.Application.Features.Utility;
using FlightsTracking.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FlightsTracking.Application.Features.Flights.Commands.UpdateFlight
{
    public class UpdateFlightCommandHandler : IRequestHandler<UpdateFlightCommand>
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IAirportRepository _airportRepository;
        private readonly IMapper _mapper;

        public UpdateFlightCommandHandler(IFlightRepository flightRepository, IAirportRepository airportRepository, IMapper mapper)
        {
            _flightRepository = flightRepository;
            _airportRepository = airportRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateFlightCommand request, CancellationToken cancellationToken)
        {
            Flight flight = _mapper.Map<Flight>(request);
            var DataDepartureAirport = await _airportRepository.GetAirportByIdAsync(request.DepartureAirport);
            var DataArrivalAirport = await _airportRepository.GetAirportByIdAsync(request.ArrivalAirport);
            flight.Distance = FlightsHelper.GetDistanceFromLatLonInKm(DataDepartureAirport.Latitude, DataDepartureAirport.Longitude, DataArrivalAirport.Latitude, DataArrivalAirport.Longitude);
            await _flightRepository.UpdateAsync(flight);
            return Unit.Value;
        }
    }
}
