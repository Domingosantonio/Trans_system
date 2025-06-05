using Trans_system.Domain.Entities;

namespace Trans_system.Domain.Interfaces;
public interface IReservationRepository
{
    public Reservation RegisterReservation(Reservation reservation);
    public Reservation UpdateReservation(Reservation reservation);
    public List<Reservation> GetAllReservations();
    public Reservation CancelReservation(Reservation reservation);
    public void DeleteReservation(Reservation reservation);
}
