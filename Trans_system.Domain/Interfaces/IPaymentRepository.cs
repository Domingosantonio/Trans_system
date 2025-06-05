using Trans_system.Domain.Entities;

namespace Trans_system.Domain.Interfaces;
public interface IPaymentRepository
{
    public Payment RegisterPayment(Payment payment);
    public Payment RefundPayment(Payment payment);
    public List<Payment> GetAllPayments(Payment payment);
    public Payment CancelPayment(Payment payment);
}
