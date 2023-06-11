using FlightsTracking.Domain;
using FlightsTracking.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Flight = FlightsTracking.Web.Models.Flight;

namespace FlightsTracking.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        { 
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            // Example to retrieve Flights
            string baseUrl = "http://flightapi/api/";
            var clientFly = new HttpClientWrapper<Flight>(baseUrl);
            string endpoint = "/flights/All";
            List<Flight> results = await clientFly.GetAllAsync(endpoint);


            // Example to retrieve Airports
            var clientAp = new HttpClientWrapper<Airport>(baseUrl);
            string endpointAp = "/flights/AllAirports";
            List<Airport> resultAp = await clientAp.GetAllAsync(endpointAp);

            return View();
        }
    }
}