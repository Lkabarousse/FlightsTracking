using System;

namespace FlightsTracking.Application.Features.Flights.Queries.GetFlightList
{
    public class FlightsListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public double Distance { get; set; }
        public Guid DepartureAirport { get; set; }
        public Guid ArrivalAirport { get; set; }
    }
}

