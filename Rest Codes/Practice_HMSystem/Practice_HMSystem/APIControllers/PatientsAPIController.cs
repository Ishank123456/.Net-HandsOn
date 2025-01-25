using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice_HMSystem.EntityFramework;
using Practice_HMSystem.Models;
using Practice_HMSystem.Repository;

namespace Practice_HMSystem.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsAPIController : ControllerBase
    {
        private readonly IPatientRepository patientRepository;
        public PatientsAPIController(IPatientRepository _patientRepository)
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

        [HttpPut("Edit")]
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
