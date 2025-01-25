using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_HealthManagementSystemCFA.Models;
using Wipro_HealthManagementSystemCFA.Repository;

namespace Wipro_HealthManagementSystemCFA.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorAPIController : ControllerBase
    {
        private readonly IDoctorRepository doctorRepository;
        public DoctorAPIController(IDoctorRepository _doctorRepository)
        {
            doctorRepository = _doctorRepository;
        }

        [HttpPost("Create")]
        public ActionResult CreateDoctor(Doctor doctor)
        {
            return Ok(doctorRepository.InsertDoctor(doctor));
        }

        [HttpGet("ListDoctors")]
        public ActionResult ListDoctors()
        {
            return Ok(doctorRepository.GetAllDoctors());
        }

        [HttpGet("SearchDoctor")]
        public IActionResult GetDoctor(int id)
        {
            return Ok(doctorRepository.GetDoctor(id));
        }

        [HttpPut("Edit")]
        public ActionResult EditDoctor(Doctor doctor)
        {
            return Ok(doctorRepository.UpdateDoctor(doctor));
        }

        [HttpPut("Delete")]
        public ActionResult DeleteDoctor(int id)
        {
            return Ok(doctorRepository.DeleteDoctor(id));
        }
    }
}
