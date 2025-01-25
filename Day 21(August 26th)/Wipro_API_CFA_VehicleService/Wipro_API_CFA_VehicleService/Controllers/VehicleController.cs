using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_API_CFA_VehicleService.Model;
using Wipro_API_CFA_VehicleService.Repository;

namespace Wipro_API_CFA_VehicleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository iVehicleRepository;
        public VehicleController(IVehicleRepository _iVehicleRepository)
        {
            iVehicleRepository = _iVehicleRepository;
        }

        [HttpPost("CreateVehicle")]
        public ActionResult CreateVehicle(Vehicle vehicle)
        {
            return Ok(iVehicleRepository.CreateVehicle(vehicle));
        }
        [HttpGet("GetAllVehicles")]
        public ActionResult GetAllVehicles()
        {
            return Ok(iVehicleRepository.GetAllVehicles());
        }
        [HttpGet("SelectVehicleById")]
        public ActionResult SelectVehicleById(int vehicleId)
        {
            return Ok(iVehicleRepository.SearchVehicle(vehicleId));
        }
        [HttpPut("UpdateVehicleInfo")]
        public ActionResult UpdateVehicleInfo(Vehicle vehicle)
        {
            return Ok(iVehicleRepository.UpdateVehicleInfo(vehicle));
        }
        [HttpDelete("DeleteVehicleInfo")]
        public ActionResult DeleteVehicleInfo(int vehicleId)
        {
            return Ok(iVehicleRepository.DeleteVehicleInfo(vehicleId));
        }
    }
}
