using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Trips.Commands.Interfaces;
public interface IDeleteTripCommand
{
    TripDTO Delete(TripDTO tripDTO);
}
