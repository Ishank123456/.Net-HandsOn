using Wipro_API_CFA_VehicleService.EntityFramework;
using Wipro_API_CFA_VehicleService.Model;

namespace Wipro_API_CFA_VehicleService.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VehicleDbContext vehicleDbContext;
        public VehicleRepository(VehicleDbContext _vehicleDbContext)
        {
            vehicleDbContext = _vehicleDbContext;
        }

        public Vehicle CreateVehicle(Vehicle vehicle)
        {
            var result = vehicleDbContext.Vehicles.Add(vehicle);
            vehicleDbContext.SaveChanges();
            return result.Entity;
        }
        public IEnumerable<Vehicle> GetAllVehicles()
        {
            return vehicleDbContext.Vehicles.ToList();
        }
        public Vehicle SearchVehicle(int vehicleId)
        {
            return vehicleDbContext.Vehicles.SingleOrDefault(t => t.VehicleId == vehicleId);
        }
        public Vehicle UpdateVehicleInfo(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            var result = vehicleDbContext.Vehicles.Update(vehicle);
            vehicleDbContext.SaveChanges();
            return result.Entity;
        }
        public bool DeleteVehicleInfo(int vehicleId)
        {
            var filterData = vehicleDbContext.Vehicles.Where(x => x.VehicleId == vehicleId).FirstOrDefault();
            var result = vehicleDbContext.Vehicles.Remove(filterData);
            vehicleDbContext.SaveChanges();
            return result != null ? true : false;
        }
    }
}
