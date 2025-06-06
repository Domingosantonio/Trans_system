using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Reservations.Queries.Interfaces;
public interface IGetAllReservationsQuery
{
    List<ReservationDTO> GetAll();
}
