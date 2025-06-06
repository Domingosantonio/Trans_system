using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Payments.Commands.Interfaces;
public interface IRefundPaymentCommand
{
    PaymentDTO Refund(PaymentDTO paymentDTO);
}
