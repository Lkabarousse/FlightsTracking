using FlightsTracking.Application.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightsTracking.Persistence.Repositories
{
    public partial class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly TrackingFlightsDbContext _dbContext;

        public BaseRepository(TrackingFlightsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T ientity)
        {
            await _dbContext.Set<T>().AddAsync(ientity);
            await _dbContext.SaveChangesAsync();
            return ientity;
        }

        public async Task DeleteAsync(T ientity)
        {
            _dbContext.Set<T>().Remove(ientity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T ientity)
        {
            _dbContext.Entry(ientity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
