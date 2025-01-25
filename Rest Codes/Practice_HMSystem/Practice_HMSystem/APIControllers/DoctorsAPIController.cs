using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice_HMSystem.Models;
using Practice_HMSystem.Repository;

namespace Practice_HMSystem.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsAPIController : ControllerBase
    {
        private readonly IDoctorRepository doctorRepository;
        public DoctorsAPIController(IDoctorRepository _doctorRepository)
        {
            doctorRepository = _doctorRepository;
        }

        [HttpPost("CreateDoctor")]
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

        [HttpPut("EditDoctor")]
        public ActionResult EditDoctor(Doctor doctor)
        {
            return Ok(doctorRepository.UpdateDoctor(doctor));
        }

        [HttpPut("DeleteDoctor")]
        public ActionResult DeleteDoctor(int id)
        {
            return Ok(doctorRepository.DeleteDoctor(id));
        }
    }
}
