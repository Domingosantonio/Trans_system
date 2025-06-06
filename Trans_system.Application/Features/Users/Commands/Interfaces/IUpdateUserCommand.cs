using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Users.Commands.Interfaces;
public interface IUpdateUserCommand
{
    UserDTO Update(UserDTO userDTO);
}
