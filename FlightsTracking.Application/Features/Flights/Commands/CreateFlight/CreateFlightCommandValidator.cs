using FluentValidation;

namespace FlightsTracking.Application.Features.Flights.Commands.CreateFlight
{
    public class CreateFlightCommandValidator : AbstractValidator<CreateFlightCommand>
    {
        public CreateFlightCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().MaximumLength(25);
            RuleFor(x => x.DepartureAirport).NotEmpty().NotNull();
            RuleFor(x => x.ArrivalAirport).NotEmpty().NotNull();
            RuleFor(x => x.ArrivalAirport).NotEqual(x=>x.DepartureAirport);
            
        }
    }
}
