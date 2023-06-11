using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightsTracking.Application.Features.Flights.Queries.GetFlightList
{
    public class AirportDto
    {
        public Guid Id { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
    }
}
