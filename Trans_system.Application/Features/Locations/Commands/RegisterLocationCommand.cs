using Trans_system.Application.DTOs;
using Trans_system.Application.Features.Locations.Commands.Interfaces;
using Trans_system.Domain.Interfaces;

namespace Trans_system.Application.Features.Locations.Commands;
public class RegisterLocationCommand : IRegisterLocationCommand
{
    private readonly ILocationRepository _repository;
    public RegisterLocationCommand(ILocationRepository repository)
    {
        _repository = repository;
    }
    public LocationDTO Register(LocationDTO locationDTO)
    {
        if (locationDTO == null) return null;
        
        throw new NotImplementedException();
    }
}
