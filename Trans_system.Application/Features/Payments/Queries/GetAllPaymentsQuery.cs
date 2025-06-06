using Trans_system.Application.DTOs;
using Trans_system.Application.Features.Payments.Queries.Interfaces;

namespace Trans_system.Application.Features.Payments.Queries;
public class GetAllPaymentsQuery : IGetAllPaymentsQuery
{
    public List<PaymentDTO> GetAll()
    {
        throw new NotImplementedException();
    }
}
