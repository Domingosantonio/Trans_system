using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Locations.Commands.Interfaces;
public interface IRegisterLocationCommand
{
    public LocationDTO Register(LocationDTO locationDTO);
}
