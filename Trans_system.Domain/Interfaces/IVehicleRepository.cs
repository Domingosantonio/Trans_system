using Trans_system.Domain.Entities;

namespace Trans_system.Domain.Interfaces;
public interface IVehicleRepository
{
    public Vehicle RegisterVehicle(Vehicle vehicle);
    public Vehicle UpdateVehicle(Vehicle vehicle);
    public List<Vehicle> GetAllVehicles();
    public List<Vehicle> GetAllTripsByVehicle(Vehicle vehicle);
    public Vehicle ChangeVehicle(Vehicle vehicle);
    public void DeleteVehicle(Vehicle vehicle);
}
