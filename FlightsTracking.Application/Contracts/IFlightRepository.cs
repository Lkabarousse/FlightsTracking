using FlightsTracking.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightsTracking.Application.Contracts
{
    public interface IFlightRepository : IAsyncRepository<Flight>
    {
        Task<Flight> GetFlightByIdAsync(Guid id);
        Task<IReadOnlyList<Flight>> GetListAllFlightAsync();
    }
}
