using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Vehicles.Queries.Interfaces;
public interface IGetAllVehiclesQuery
{
    List<VehicleDTO> GetAll();
}
