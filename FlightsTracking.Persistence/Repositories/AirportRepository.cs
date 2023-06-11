using FlightsTracking.Application.Contracts;
using FlightsTracking.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightsTracking.Persistence.Repositories
{
    public class AirportRepository : BaseRepository<Airport>, IAirportRepository
    {
        public AirportRepository(TrackingFlightsDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Airport> GetAirportByIdAsync(Guid id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<IReadOnlyList<Airport>> GetListAllAirportsAsync()
        {
            return await ListAllAsync();
        }
    }
}
