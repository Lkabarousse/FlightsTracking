using System;

namespace FlightsTracking.Application.Features.Airports.Queries.GetAirportsList
{
    public class AirportsListViewModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
