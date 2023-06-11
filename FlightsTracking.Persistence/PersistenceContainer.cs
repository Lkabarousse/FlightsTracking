using FlightsTracking.Application.Contracts;
using FlightsTracking.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FlightsTracking.Persistence
{
    public static class PersistenceContainer
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TrackingFlightsDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("FlightsTrackingConnectionString"))
                );
            services.AddScoped(typeof(IAsyncRepository<>),typeof(BaseRepository<>));
            services.AddScoped(typeof(IFlightRepository),typeof(FlightRepository));
            services.AddScoped(typeof(IAirportRepository),typeof(AirportRepository));
            return services;
        }
    }
}
