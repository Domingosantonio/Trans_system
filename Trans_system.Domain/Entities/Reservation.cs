using Trans_system.Domain.Enums;

namespace Trans_system.Domain.Entities;
public class Reservation
{
    public int Id { get; set; }
    public int TripID { get; set; }    
    public int Passenger_Id { get; set; }
    public DateTime Date { get; set; }
    public ReservationStatus Status { get; set; }
    //public Trip Trip { get; set; }
}
