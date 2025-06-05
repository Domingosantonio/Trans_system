namespace Trans_system.Domain.Entities;
public class Route
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public int Origin_Id { get; set; }
    public int Destination_Id { get; set; }
    public decimal? Distance { get; set; }
}
