using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Wipro_SmartHealthcareSystem_Assesment4.Controllers
{
    public class DoctorController : Controller
    {
        HttpClient client;
        IConfiguration configuration;
        public DoctorController(IConfiguration _configuration)
        {
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
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
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time");
                }
            }
            return View(doctor);
        }

        [HttpGet]
        public async Task<IActionResult> EditDoctor(int? id)
        {
            Doctor objDoctor = new Doctor();
            string url = "api/DoctorAPI/SearchDoctorById?doctorId=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objDoctor = JsonConvert.DeserializeObject<Doctor>(result);
            }
            return View(objDoctor);
        }

        [HttpPost]
        public async Task<IActionResult> EditDoctor(Doctor doctor)
        {
            string url = "api/DoctorAPI/UpdateDoctor";
            if (ModelState.IsValid)
            {
                var response = await client.PutAsJsonAsync(url, doctor);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time");
                }
            }
            return View(doctor);
        }

        [HttpGet]
        public async Task<IActionResult> DoctorDetails(int id)
        {
            Doctor objDoctor = new Doctor();
            string url = "api/DoctorAPI/SearchDoctorById?doctorId=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objDoctor = JsonConvert.DeserializeObject<Doctor>(result);
            }
            return View(objDoctor);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteDoctor(int? id)
        {
            Doctor objDoctor = new Doctor();
            string url = "api/DoctorAPI/SearchDoctorById?doctorId=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objDoctor = JsonConvert.DeserializeObject<Doctor>(result);
            }
            return View(objDoctor);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            string url = "api/PatientAPI/DeleteDoctor?doctorId=";
            await client.DeleteAsync(url + id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> ListOfDoctors()
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

