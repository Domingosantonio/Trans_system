using Trans_system.Domain.Entities;

namespace Trans_system.Domain.Interfaces;
public interface IPassengerRepository
{
    public Passenger RegisterPassenger(Passenger passenger);
    public Passenger UpdatePassenger(Passenger passenger);
    public List<Passenger> GetAllPassengers();
    public void DeletePassenger(Passenger passenger);
}
