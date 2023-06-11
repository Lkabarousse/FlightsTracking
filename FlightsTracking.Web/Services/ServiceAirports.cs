using FlightsTracking.Domain;
using FlightsTracking.Web.Models;

namespace FlightsTracking.Web.Services
{
    public class ServiceAirports
    {
        private readonly IHttpClientWrapper<Airport> _httpClientWrapper;

        public ServiceAirports(IHttpClientWrapper<Airport> httpClientWrapper)
        {
            _httpClientWrapper = httpClientWrapper;
        }

        public async Task<Airport> GetAirportsFromApi(string endpoint)
        {
            Airport result = await _httpClientWrapper.GetAsync(endpoint);
            return result;
        }
    }
}
