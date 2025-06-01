using Trans_system.Domain.Enums;

namespace Trans_system.Domain.Entities;
public class Payment
{
    public int Id { get; set; }
    public int Reservation_Id {  get; set; }
    public decimal Amount { get; set; }
    public PaymentMethod Type { get; set; }
    public string Status { get; set; }
    public DateTime Transaction_Date { get; set; }
}
