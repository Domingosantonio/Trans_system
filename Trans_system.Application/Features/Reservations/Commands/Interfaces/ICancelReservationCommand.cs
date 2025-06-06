using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Reservations.Commands.Interfaces;
public interface ICancelReservationCommand
{
    ReservationDTO Cancel(ReservationDTO reservationDTO);
}
