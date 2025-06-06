using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Vehicles.Queries.Interfaces;
public interface IGetTripHistoryByVehicleQuery
{
    List<VehicleDTO> GetTripHistoryByVehicle(VehicleDTO vehicleDTO);
}
