using FlightsTracking.Application.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FlightsTracking.Application.Features.Flights.Commands.DeleteFlight
{
    public class DeleteFlightCommandHAndler : IRequestHandler<DeleteFlightCommand>
    {
        private readonly IFlightRepository _flightRepository;

        public DeleteFlightCommandHAndler(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public async Task<Unit> Handle(DeleteFlightCommand request, CancellationToken cancellationToken)
        {
            var flight = await _flightRepository.GetByIdAsync(request.FlightId);
            await _flightRepository.DeleteAsync(flight);
            return Unit.Value;
        }
    }
}
