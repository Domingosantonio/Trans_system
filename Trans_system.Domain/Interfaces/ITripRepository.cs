using Trans_system.Domain.Entities;

namespace Trans_system.Domain.Interfaces;
public interface ITripRepository
{
    public Trip RegisterTrip(Trip trip);
    public Trip UpdateTrip(Trip trip);
    public List<Trip> GetAllTrips();
    public Trip CancelTrip(Trip trip);
    public Trip CloseTrip(Trip trip);
    public void DeleteTrip(Trip trip);
}
