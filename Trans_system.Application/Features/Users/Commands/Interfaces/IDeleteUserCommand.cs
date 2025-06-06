using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Users.Commands.Interfaces;
public interface IDeleteUserCommand
{
    UserDTO Delete(UserDTO userDTO);
}
