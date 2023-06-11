using System;

namespace FlightsTracking.Domain
{
    public class Flight
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid DepartureAirport { get; set; }
        public Guid ArrivalAirport { get; set; }
        public double Distance { get; set; }

    }
}
