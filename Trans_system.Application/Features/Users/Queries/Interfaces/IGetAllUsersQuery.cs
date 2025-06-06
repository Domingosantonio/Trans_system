using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Users.Queries.Interfaces;
public interface IGetAllUsersQuery
{
    List<UserDTO> GetAll();
}
