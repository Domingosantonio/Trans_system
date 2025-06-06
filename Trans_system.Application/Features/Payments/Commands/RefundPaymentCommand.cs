using Trans_system.Application.DTOs;
using Trans_system.Application.Features.Payments.Commands.Interfaces;

namespace Trans_system.Application.Features.Payments.Commands;
public class RefundPaymentCommand : IRefundPaymentCommand
{
    public PaymentDTO Refund(PaymentDTO paymentDTO)
    {
        throw new NotImplementedException();
    }
}
