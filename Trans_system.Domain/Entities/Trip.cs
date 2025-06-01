using System.Security.Cryptography.X509Certificates;

namespace Trans_system.Domain.Entities;
public class Trip
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public int Route_Id { get; set; }
    public int Vehicle_Id { get; set; }
}
