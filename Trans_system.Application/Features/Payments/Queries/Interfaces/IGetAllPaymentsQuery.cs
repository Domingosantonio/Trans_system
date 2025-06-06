using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Payments.Queries.Interfaces;
public interface IGetAllPaymentsQuery
{
    List<PaymentDTO> GetAll();
}
