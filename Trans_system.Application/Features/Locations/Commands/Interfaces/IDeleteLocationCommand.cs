using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Locations.Commands.Interfaces;
public interface IDeleteLocationCommand
{
    void Delete(LocationDTO location);
}
