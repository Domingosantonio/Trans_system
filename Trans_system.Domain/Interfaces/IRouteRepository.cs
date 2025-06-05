using Trans_system.Domain.Entities;

namespace Trans_system.Domain.Interfaces;
public interface IRouteRepository
{
    public Route RegisterRoute(Route route);
    public Route UpdateRoute(Route route);
    public List<Route> GetAllRoutes();
    public void DeleteRoute(Route route);
}
