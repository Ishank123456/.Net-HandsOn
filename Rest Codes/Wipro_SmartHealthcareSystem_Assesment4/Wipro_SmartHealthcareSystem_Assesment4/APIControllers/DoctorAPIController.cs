using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repositories;

namespace Wipro_SmartHealthcareSystem_Assesment4.APIControllers
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

        [HttpPost("AddDoctor")]
        public ActionResult AddDoctor(Doctor doctor)
        {
            return Ok(doctorRepository.AddDoctor(doctor));
        }

        [HttpGet("DoctorList")]
        public ActionResult GetDoctorList()
        {
            return Ok(doctorRepository.GetAllDoctors());
        }

        [HttpGet("SearchDoctorById")]
        public ActionResult SearchDoctorById(int doctorId)
        {
            return Ok(doctorRepository.GetDoctor(doctorId));
        }

        [HttpPut("UpdateDoctor")]
        public ActionResult UpdateDoctor(Doctor doctor)
        {
            return Ok(doctorRepository.UpdateDoctor(doctor));
        }

        [HttpPost("DeleteDoctor")]
        public ActionResult DeleteDoctor(int doctorId)
        {
            return Ok(doctorRepository.DeleteDoctor(doctorId));
        }
    }
}
