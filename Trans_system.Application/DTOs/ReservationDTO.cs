using Trans_system.Domain.Enums;

namespace Trans_system.Application.DTOs;
public class ReservationDTO
{
    public int Id { get; set; }
    public int TripID { get; set; }
    public int Passenger_Id { get; set; }
    public DateTime Date { get; set; }
    public ReservationStatus Status { get; set; }
}
