using Trans_system.Domain.Entities;
using Trans_system.Domain.Interfaces;

namespace Trans_system.Infrastructure.DataAccess;
internal class PaymentRepository : IPaymentRepository
{
    public Payment CancelPayment(Payment payment)
    {
        throw new NotImplementedException();
    }

    public List<Payment> GetAllPayments(Payment payment)
    {
        throw new NotImplementedException();
    }

    public Payment RefundPayment(Payment payment)
    {
        throw new NotImplementedException();
    }

    public Payment RegisterPayment(Payment payment)
    {
        throw new NotImplementedException();
    }
}
