namespace Trans_system.Application.DTOs;
public class RouteDTO
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public int Origin_Id { get; set; }
    public int Destination_Id { get; set; }
    public decimal? Distance { get; set; }
}
