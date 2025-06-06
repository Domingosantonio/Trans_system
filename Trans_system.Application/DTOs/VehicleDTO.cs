using Trans_system.Domain.Enums;

namespace Trans_system.Application.DTOs;
public class VehicleDTO
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public string? Model { get; set; }
    public string? License_Plate { get; set; }
    public decimal Capacity { get; set; }
    public int Capacity_Passenger { get; set; }
    public VehicleType Type { get; set; }
}
