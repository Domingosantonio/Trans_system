using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Passengers.Queries.Interfaces;
public interface IGetAllPassengersQuery
{
    List<PassengerDTO> GetAll();
}
