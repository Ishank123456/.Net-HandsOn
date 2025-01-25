using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Services.Repositories;
using System.Net.Http;
using System.Text;
using Wipro_SmartHealthcareSystem_Assesment4.ViewModels;

namespace Wipro_SmartHealthcareSystem_Assesment4.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;
        private readonly IPatientRepository patientRepository;
        private readonly IDoctorRepository doctorRepository;
        private readonly SmartHmsdbContext _context;

        public AppointmentController(IConfiguration configuration, IDoctorRepository _doctorRepository, IPatientRepository _patientRepository,
            SmartHmsdbContext context)
        {
            _configuration = configuration;
            _context = context;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            _client = new HttpClient { BaseAddress = baseAddress };
            patientRepository = _patientRepository;
            doctorRepository = _doctorRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var patients = patientRepository.GetAllPatients();
            var doctors = doctorRepository.GetAllDoctors();

            ViewBag.Patients = new SelectList(patients, "PatientId", "FirstName");
            ViewBag.Doctors = new SelectList(doctors, "DoctorId", "FirstName");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int patientId, int doctorId, DateTime appointmentDate, string appointmentStatus,
            string reasonForVisit)
        {
            if (ModelState.IsValid)
            {
                var appointment = new
                {
                    PatientId = patientId,
                    DoctorId = doctorId,
                    AppointmentDate = appointmentDate,
                    AppointmentStatus = appointmentStatus,
                    ReasonForVisit = reasonForVisit
                };

                string url = "api/AppointmentAPI/CreateAppointment";
                HttpResponseMessage response = await _client.PostAsJsonAsync(url, appointment);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("AppointmentDetails");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {errorContent}");
                }

                var errorMessage = await response.Content.ReadAsStringAsync();
                ModelState.AddModelError(string.Empty, $"Unable to create appointment: {errorMessage}");
            }

            var patients = patientRepository.GetAllPatients();
            var doctors = doctorRepository.GetAllDoctors();
            ViewBag.Patients = new SelectList(patients, "PatientId", "PatientName");
            ViewBag.Doctors = new SelectList(doctors, "DoctorId", "DoctorName");

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AppointmentDetails()
        {
            List<Appointment> objAppointmentDetails = new List<Appointment>();
            string url = "api/AppointmentAPI/AppointmentList";
            using (var response = await _client.GetAsync(url))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objAppointmentDetails = JsonConvert.DeserializeObject<List<Appointment>>(result);
            }
            return View(objAppointmentDetails);
        }

    }
}
