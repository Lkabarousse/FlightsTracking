using FlightsTracking.Application.Features.Airports.Queries.GetAirportsList;
using FlightsTracking.Application.Features.Flights.Commands.CreateFlight;
using FlightsTracking.Application.Features.Flights.Commands.DeleteFlight;
using FlightsTracking.Application.Features.Flights.Commands.UpdateFlight;
using FlightsTracking.Application.Features.Flights.Queries.GetFlightDetail;
using FlightsTracking.Application.Features.Flights.Queries.GetFlightList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FlightsTracking.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FlightsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllFlights")]
        public async Task<ActionResult<List<FlightsListViewModel>>> GetAllFlightsVV()
        {
            var dtos = await _mediator.Send(new GetFlightsListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetFlightById")]
        public async Task<ActionResult<FlightDetailViewModel>> GetFlightById(Guid id)
        {
            var getDetailQuery = new GetFlightDetailQuery() { FlightId = id };
            return await _mediator.Send(getDetailQuery);
        }

        [HttpPost(Name = "AddFlight")]
        public async Task<ActionResult<Guid>> AddFlight([FromBody] CreateFlightCommand createFlightCommand)
        {
            Guid id = await _mediator.Send(createFlightCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateFlight")]
        public async Task<ActionResult> UpdateFlight([FromBody] UpdateFlightCommand udateFlightCommand)
        {
            await _mediator.Send(udateFlightCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteFlight")]
        public async Task<ActionResult> DeleteFlight(Guid id)
        {
            var deleteFlightCommande = new DeleteFlightCommand() { FlightId = id };
            await _mediator.Send(deleteFlightCommande);
            return Ok();
        }

        [HttpGet("AllAirports", Name = "GetAllAirports")]
        public async Task<ActionResult<List<AirportsListViewModel>>> GetAllAirports()
        {
            var dtos = await _mediator.Send(new GetAirportsListQuery());
            return Ok(dtos);
        }
    }
}
