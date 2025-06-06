using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Reservations.Commands.Interfaces;
public interface IRegisterReservationCommand
{
    ReservationDTO Register(ReservationDTO reservationDTO);
}
