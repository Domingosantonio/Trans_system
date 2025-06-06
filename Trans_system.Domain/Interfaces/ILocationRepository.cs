using Trans_system.Domain.Entities;

namespace Trans_system.Domain.Interfaces;
public interface ILocationRepository
{
    public Location RegisterLocation(Location location);
    public Location UpdateLocation(Location location);
    public List<Location> GetAllLocations();
    public void DeleteLocations(Location location);
}
