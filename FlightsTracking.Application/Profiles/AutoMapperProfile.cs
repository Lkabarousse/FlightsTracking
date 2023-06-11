using AutoMapper;
using FlightsTracking.Application.Features.Airports.Queries.GetAirportsList;
using FlightsTracking.Application.Features.Flights.Commands.CreateFlight;
using FlightsTracking.Application.Features.Flights.Commands.DeleteFlight;
using FlightsTracking.Application.Features.Flights.Commands.UpdateFlight;
using FlightsTracking.Application.Features.Flights.Queries.GetFlightDetail;
using FlightsTracking.Application.Features.Flights.Queries.GetFlightList;
using FlightsTracking.Domain;

namespace FlightsTracking.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<Flight, FlightsListViewModel>().ReverseMap();
            CreateMap<Flight, FlightDetailViewModel>().ReverseMap();
            CreateMap<Airport, AirportDto>().ReverseMap();
            CreateMap<Flight, CreateFlightCommand>().ReverseMap();
            CreateMap<Flight, UpdateFlightCommand>().ReverseMap();
            CreateMap<Flight, DeleteFlightCommand>().ReverseMap();
            CreateMap<Airport, AirportsListViewModel>().ReverseMap();
        }
    }
}
