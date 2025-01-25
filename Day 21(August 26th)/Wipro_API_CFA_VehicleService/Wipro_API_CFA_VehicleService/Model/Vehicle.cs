using System.ComponentModel.DataAnnotations;

namespace Wipro_API_CFA_VehicleService.Model
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string VehicleRegNo { get; set; }
        public string VehicleBrandName { get; set; }
        public string VehicleModel { get; set; }
        public int VehicleManufacturingYear { get; set; }
        public double VehiclePrice { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleMileage { get; set; }
        public DateTime VehicleDate { get; set; }
    }
}
