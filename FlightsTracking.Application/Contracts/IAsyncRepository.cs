using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightsTracking.Application.Contracts
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T ientity);
        Task UpdateAsync(T ientity);
        Task DeleteAsync(T ientity);
    }
}
