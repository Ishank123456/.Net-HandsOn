using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_HealthManagementSystemCFA.Models;
using Wipro_HealthManagementSystemCFA.Repository;

namespace Wipro_HealthManagementSystemCFA.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientAPIController : ControllerBase
    {
        private readonly IPatientRepository patientRepository;
        public PatientAPIController(IPatientRepository _patientRepository)
        {
            patientRepository = _patientRepository;
        }

        [HttpPost("Create")]
        public ActionResult CreatePatient(Patient patient)
        {
            return Ok(patientRepository.InsertPatient(patient));
        }

        [HttpGet("ListPatients")]
        public ActionResult ListPatients()
        {
            return Ok(patientRepository.GetAllPatients());
        }

        [HttpGet("SearchPatient")]
        public IActionResult GetPatient(int id)
        {
            return Ok(patientRepository.GetPatient(id));
        }

        [HttpPut("Update")]
        public ActionResult EditPatient(Patient patient)
        {
            return Ok(patientRepository.UpdatePatient(patient));
        }

        [HttpDelete("Delete")]
        public ActionResult DeletePatient(int id)
        {
            return Ok(patientRepository.DeletePatient(id));
        }
    }
}
