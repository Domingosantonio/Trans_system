using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Locations.Queries.Interfaces;
public interface IGetAllLocationsQuery
{
    List<LocationDTO> GetAllLocations();
}
