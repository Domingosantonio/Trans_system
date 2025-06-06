using Trans_system.Domain.Enums;

namespace Trans_system.Application.DTOs;
public class PassengerDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Idenfier_Number { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public PassengerStatus Type { get; set; }
    public int User_Id { get; set; }
}
