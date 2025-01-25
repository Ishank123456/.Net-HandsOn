using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Wipro_SmartHealthcareSystem_Assesment4.Controllers
{
    public class AdminController : Controller
    {
        HttpClient client;
        IConfiguration configuration;
        public AdminController(IConfiguration _configuration)
        {
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public ActionResult AdminDashboard()
        {
            return View();
        }

        public ActionResult AddPatient()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPatient(Patient patient)
        {
            string url = "api/PatientAPI/AddPatient";
            if (ModelState.IsValid)
            {
                var response = await client.PostAsJsonAsync(url, patient);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("AdminDashboard");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time");
                }
            }
            return View(patient);
        }

        [HttpGet]
        public async Task<IActionResult> PatientDetails()
        {
            List<Patient> objPatient = new List<Patient>();
            string url = "api/PatientAPI/PatientList";
            using (var response = await client.GetAsync(url))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objPatient = JsonConvert.DeserializeObject<List<Patient>>(result);
            }
            return View(objPatient);
        }

        [HttpGet]
        public ActionResult AddDoctor()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddDoctor(Doctor doctor)
        {
            string url = "api/DoctorAPI/AddDoctor";
            if (ModelState.IsValid)
            {
                var response = await client.PostAsJsonAsync(url, doctor);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("AdminDashboard");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time");
                }
            }
            return View(doctor);
        }

        [HttpGet]
        public async Task<IActionResult> DoctorDetails()
        {
            List<Doctor> objDoctor = new List<Doctor>();
            string url = "api/DoctorAPI/DoctorList";
            using (var response = await client.GetAsync(url))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objDoctor = JsonConvert.DeserializeObject<List<Doctor>>(result);
            }
            return View(objDoctor);
        }
    }
}
