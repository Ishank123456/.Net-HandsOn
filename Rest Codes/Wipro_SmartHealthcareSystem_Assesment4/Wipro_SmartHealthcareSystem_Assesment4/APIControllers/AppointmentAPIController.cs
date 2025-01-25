using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Repositories;

namespace Wipro_SmartHealthcareSystem_Assesment4.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentAPIController : ControllerBase
    {
        private readonly IAppointmentRepository appointmentRepository;

        public AppointmentAPIController(IAppointmentRepository _appointmentRepository)
        {
            appointmentRepository = _appointmentRepository;
        }

        [HttpPost("CreateAppointment")]
        public ActionResult CreateAppointment(Appointment appointment)
        {
            return Ok(appointmentRepository.CreateAppointment(appointment));
        }

        [HttpGet("AppointmentList")]
        public ActionResult GetAppointments()
        {
            return Ok(appointmentRepository.GetAppointments());
        }

        [HttpGet("GetAppointmentById")]
        public ActionResult GetAppointment(int appointmentId)
        {
            return Ok(appointmentRepository.GetAppointmentById(appointmentId));
        }
    }
}
