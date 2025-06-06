using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Routes.Commands.Interfaces;
public interface IRegisterRouteCommand
{
    RouteDTO Register(RouteDTO routeDTO);
}
