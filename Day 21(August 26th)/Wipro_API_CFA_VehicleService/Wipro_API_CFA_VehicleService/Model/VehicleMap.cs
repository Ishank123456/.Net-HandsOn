using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Wipro_API_CFA_VehicleService.Model
{
    public class VehicleMap
    {
        //Vehicle Map is for Validation----->Model Validation-------->Database
        public VehicleMap(EntityTypeBuilder<Vehicle> entityTypeBuilderVehicle)
        {
            entityTypeBuilderVehicle.HasKey(veh => veh.VehicleId);
            entityTypeBuilderVehicle.Property(veh => veh.VehicleId).IsRequired();
            entityTypeBuilderVehicle.Property(veh => veh.VehicleRegNo).IsRequired();
            entityTypeBuilderVehicle.Property(veh => veh.VehicleBrandName).IsRequired();
            entityTypeBuilderVehicle.Property(veh => veh.VehicleBrandName).HasMaxLength(50);
            entityTypeBuilderVehicle.Property(veh => veh.VehicleManufacturingYear).IsRequired();
            entityTypeBuilderVehicle.Property(veh => veh.VehicleManufacturingYear).HasMaxLength(4);
            entityTypeBuilderVehicle.Property(veh => veh.VehiclePrice).IsRequired();
        }
    }
}
