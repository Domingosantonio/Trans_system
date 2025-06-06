namespace Trans_system.Application.DTOs;
public class TripDTO
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public int Route_Id { get; set; }
    public int Vehicle_Id { get; set; }
}
