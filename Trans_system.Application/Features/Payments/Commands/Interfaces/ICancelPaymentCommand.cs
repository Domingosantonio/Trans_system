using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Payments.Commands.Interfaces;
public interface ICancelPaymentCommand
{
    PaymentDTO Cancel(PaymentDTO paymentDTO);
}
