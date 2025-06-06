using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Reservations.Commands.Interfaces;
public interface IUpdateReservationCommand
{
    ReservationDTO Update(ReservationDTO reservationDTO);
}
