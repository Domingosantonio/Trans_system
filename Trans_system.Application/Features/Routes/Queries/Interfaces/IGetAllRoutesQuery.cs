using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Routes.Queries.Interfaces;
public interface IGetAllRoutesQuery
{
    List<RouteDTO> GetAll();
}
