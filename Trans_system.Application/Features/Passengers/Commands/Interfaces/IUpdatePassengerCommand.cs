using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Passengers.Commands.Interfaces;
public interface IUpdatePassengerCommand
{
    PassengerDTO Update(PassengerDTO passengerDTO);
}
