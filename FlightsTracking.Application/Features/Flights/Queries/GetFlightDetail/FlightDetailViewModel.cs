using System;

namespace FlightsTracking.Application.Features.Flights.Queries.GetFlightDetail
{
    public class FlightDetailViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; }
    }
}
