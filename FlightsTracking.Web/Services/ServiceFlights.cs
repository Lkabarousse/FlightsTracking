using FlightsTracking.Web.Models;

namespace FlightsTracking.Web.Services
{
    public class ServiceFlights
    {
        private readonly IHttpClientWrapper<Flight> _httpClientWrapper;

        public ServiceFlights(IHttpClientWrapper<Flight> httpClientWrapper)
        {
            _httpClientWrapper = httpClientWrapper;
        }

        public async Task<Flight> GetFlightsFromApi(string endpoint)
        {
            Flight result = await _httpClientWrapper.GetAsync(endpoint);
            return result;
        }
    }
}
