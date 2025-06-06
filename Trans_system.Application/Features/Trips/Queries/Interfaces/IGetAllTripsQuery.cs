using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Trips.Queries.Interfaces;
public interface IGetAllTripsQuery
{
    List<TripDTO> GetAll();
}
