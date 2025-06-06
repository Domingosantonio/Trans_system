using Trans_system.Domain.Entities;
using Trans_system.Domain.Interfaces;

namespace Trans_system.Infrastructure.DataAccess;
internal class LocationRepository : ILocationRepository
{
    private List<Location> _locations;
    public void DeleteLocations(Location location)
    {
        _locations.Remove(location);
    }

    public List<Location> GetAllLocations()
    {
        return _locations.ToList();
    }

    public Location RegisterLocation(Location location)
    {
        _locations.Add(location);
        return location;
    }

    public Location UpdateLocation(Location location)
    {
        _locations.Remove(location);
       return RegisterLocation(location);
    }
}
