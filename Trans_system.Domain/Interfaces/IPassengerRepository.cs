using Trans_system.Domain.Entities;

namespace Trans_system.Domain.Interfaces;
public interface IPassengerRepository
{
    public Passenger RegisterPassenger(Passenger passenger);
    public Passenger UpdatePassenger(Passenger passenger);
    public List<Passenger> GetAllPasses();
    public void DeletePassenger(Passenger passenger);
}
