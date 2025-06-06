using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Trips.Commands.Interfaces;
public interface ICancelTripCommand
{
    TripDTO Cancel(TripDTO tripDTO);
}
