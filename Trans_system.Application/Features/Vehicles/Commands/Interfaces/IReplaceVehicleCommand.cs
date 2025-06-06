using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Vehicles.Commands.Interfaces;
public interface IReplaceVehicleCommand
{
    VehicleDTO Replace(VehicleDTO vehicleDTO);
}
