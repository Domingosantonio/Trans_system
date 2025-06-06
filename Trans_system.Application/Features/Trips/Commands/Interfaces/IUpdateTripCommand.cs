using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Trips.Commands.Interfaces;
public interface IUpdateTripCommand
{
    TripDTO Update(TripDTO tripDTO);
}
