using FlightsTracking.Application.Contracts;
using FlightsTracking.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightsTracking.Persistence.Repositories
{
    public class FlightRepository : BaseRepository<Flight>, IFlightRepository
    {
        public FlightRepository(TrackingFlightsDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Flight> GetFlightByIdAsync(Guid id)
        {
            Flight flight = new();
            flight =  await GetByIdAsync(id);
            return flight;
        }

        public async Task<IReadOnlyList<Flight>> GetListAllFlightAsync()
        {
            List<Flight> allflights = new();
            allflights = await _dbContext.Flights.ToListAsync();
            return allflights;
        }
    }
}
