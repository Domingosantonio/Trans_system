using Trans_system.Application.DTOs;
using Trans_system.Application.Features.Payments.Commands.Interfaces;

namespace Trans_system.Application.Features.Payments.Commands;
public class CancelPaymentCommand : ICancelPaymentCommand
{
    public PaymentDTO Cancel(PaymentDTO paymentDTO)
    {
        throw new NotImplementedException();
    }
}
