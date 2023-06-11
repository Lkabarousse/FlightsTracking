using FlightsTracking.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace FlightsTracking.Persistence
{
    public class TrackingFlightsDbContext : DbContext
    {
        public TrackingFlightsDbContext(DbContextOptions<TrackingFlightsDbContext> options) : base(options)
        {

        }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airport> Airports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region initiateAirports
            modelBuilder.Entity<Airport>().HasData(new Airport { Id = Guid.Parse("{57D0C2A5-796B-49BF-8336-FCF749008971}"), Code = "CMN", Name = "Aéroport Mohamed V", Latitude = 33.3699704, Longitude = -7.5857231 });
            modelBuilder.Entity<Airport>().HasData(new Airport { Id = Guid.Parse("{5F0ADF77-6C6B-4B06-A61E-A9E302AF7A46}"), Code = "ORY", Name = "Paris ORLY", Latitude = 48.7277, Longitude = 2.36708 });
            modelBuilder.Entity<Airport>().HasData(new Airport { Id = Guid.Parse("{EA017E0E-E6EB-40FE-BCA9-4EEECF47D58D}"), Code = "LHR", Name = "Londres Heathrow", Latitude = 51.4700256, Longitude = -0.4564842 });
            modelBuilder.Entity<Airport>().HasData(new Airport { Id = Guid.Parse("{B0C36946-E543-4C3B-9DAF-7E0724DB4FFC}"), Code = "RAK", Name = "Marrakech", Latitude = 32.9262536, Longitude = 8.4107989 });
            modelBuilder.Entity<Airport>().HasData(new Airport { Id = Guid.Parse("{FE6A6ADE-AF16-48E7-A323-432B4C4D2615}"), Code = "MAD", Name = "Madrid", Latitude = 40.4935, Longitude = -3.56629 });
            modelBuilder.Entity<Airport>().HasData(new Airport { Id = Guid.Parse("{E4AF1EFB-4549-4CB1-BF02-21491E2F2261}"), Code = "CDG", Name = "Charles de Gaulle", Latitude = 49.007, Longitude = 2.55979 });
            #endregion
        }
    }
}
