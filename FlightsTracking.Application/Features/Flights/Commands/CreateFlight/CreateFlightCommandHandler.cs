using AutoMapper;
using FlightsTracking.Application.Contracts;
using FlightsTracking.Application.Features.Utility;
using FlightsTracking.Domain;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FlightsTracking.Application.Features.Flights.Commands.CreateFlight
{
    public class CreateFlightCommandHandler : IRequestHandler<CreateFlightCommand, Guid>
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IAirportRepository _airportRepository;
        private readonly IMapper _mapper;

        public CreateFlightCommandHandler(IFlightRepository flightRepository, IAirportRepository airportRepository, IMapper mapper)
        {
            _flightRepository = flightRepository;
            _airportRepository = airportRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateFlightCommand request, CancellationToken cancellationToken)
        {
            var flight = _mapper.Map<Flight>(request);
            CreateFlightCommandValidator validator = new();
            var result = await validator.ValidateAsync(request);
            if (result.Errors.Any())
            {
                throw new Exception("Flight is not valid");
            }
            var DataDepartureAirport = await _airportRepository.GetAirportByIdAsync(request.DepartureAirport);
            var DataArrivalAirport = await _airportRepository.GetAirportByIdAsync(request.ArrivalAirport);
            flight.Distance = FlightsHelper.GetDistanceFromLatLonInKm(DataDepartureAirport.Latitude, DataDepartureAirport.Longitude, DataArrivalAirport.Latitude, DataArrivalAirport.Longitude);
            flight = await _flightRepository.AddAsync(flight);
            return flight.Id;
        }
    }
}
