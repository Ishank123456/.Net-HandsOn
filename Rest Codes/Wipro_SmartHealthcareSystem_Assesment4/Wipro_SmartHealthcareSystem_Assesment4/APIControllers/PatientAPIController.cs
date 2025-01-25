using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repositories;

namespace Wipro_SmartHealthcareSystem_Assesment4.APIControllers
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

        [HttpPost("AddPatient")]
        public ActionResult AddPatient(Patient patient)
        {
            return Ok(patientRepository.AddPatient(patient));
        }

        [HttpGet("PatientList")]
        public ActionResult GetPatientList()
        {
            return Ok(patientRepository.GetAllPatients());
        }

        [HttpGet("SearchPatientById")]
        public ActionResult SearchPatientById(int patientId)
        {
            return Ok(patientRepository.GetPatient(patientId));
        }

        [HttpPut("UpdatePatient")]
        public ActionResult UpdatePatient(Patient patient)
        {
            return Ok(patientRepository.UpdatePatient(patient));
        }

        [HttpPost("DeletePatient")]
        public ActionResult DeletePatient(int patientId)
        {
            return Ok(patientRepository.DeletePatient(patientId));
        }
    }
}
