using FlightsTracking.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightsTracking.Application.Contracts
{
    public interface IAirportRepository : IAsyncRepository<Airport>
    {
        Task<Airport> GetAirportByIdAsync(Guid id);
        Task<IReadOnlyList<Airport>> GetListAllAirportsAsync();
    }
}
