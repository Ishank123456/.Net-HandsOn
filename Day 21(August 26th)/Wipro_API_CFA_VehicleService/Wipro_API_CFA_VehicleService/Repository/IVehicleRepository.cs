using Wipro_API_CFA_VehicleService.Model;

namespace Wipro_API_CFA_VehicleService.Repository
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAllVehicles();
        Vehicle SearchVehicle(int vehicleId);
        Vehicle CreateVehicle(Vehicle vehicle);
        Vehicle UpdateVehicleInfo(Vehicle vehicle);
        bool DeleteVehicleInfo(int vehicleId);
    }
}
