using Trans_system.Application.DTOs;

namespace Trans_system.Application.Features.Vehicles.Commands.Interfaces;
public interface IUpdateVehicleCommand
{
    VehicleDTO Update(VehicleDTO vehicleDTO);
}
