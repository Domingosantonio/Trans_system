using Trans_system.Domain.Enums;

namespace Trans_system.Application.DTOs;
public class PaymentDTO
{
    public int Id { get; set; }
    public int Reservation_Id { get; set; }
    public decimal Amount { get; set; }
    public PaymentMethod Type { get; set; }
    public string Status { get; set; }
    public DateTime Transaction_Date { get; set; }
}
