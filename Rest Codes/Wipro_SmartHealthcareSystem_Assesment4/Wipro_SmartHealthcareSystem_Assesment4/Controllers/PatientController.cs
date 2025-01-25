using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Wipro_SmartHealthcareSystem_Assesment4.Controllers
{
    public class PatientController : Controller
    {
        HttpClient client;
        IConfiguration configuration;
        public PatientController(IConfiguration _configuration)
        {
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
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
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time");
                }
            }
            return View(patient);
        }

        [HttpGet]
        public async Task<IActionResult> EditPatient(int? id)
        {
            Patient objPatient = new Patient();
            string url = "api/PatientAPI/SearchPatientById?patientId=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objPatient = JsonConvert.DeserializeObject<Patient>(result);
            }
            return View(objPatient);
        }

        [HttpPost]
        public async Task<IActionResult> EditPatient(Patient patient)
        {
            string url = "api/PatientAPI/UpdatePatient";
            if (ModelState.IsValid)
            {
                var response = await client.PutAsJsonAsync(url, patient);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time");
                }
            }
            return View(patient);
        }

        [HttpGet]
        public async Task<IActionResult> PatientDetails(int id)
        {
            Patient objPatient = new Patient();
            string url = "api/PatientAPI/SearchPatientById?patientId=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objPatient = JsonConvert.DeserializeObject<Patient>(result);
            }
            return View(objPatient);
        }

        [HttpGet]
        public async Task<IActionResult> DeletePatient(int? id)
        {
            Patient objPatient = new Patient();
            string url = "api/PatientAPI/SearchPatientById?patientId=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objPatient = JsonConvert.DeserializeObject<Patient>(result);
            }
            return View(objPatient);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            string url = "api/PatientAPI/DeletePatient?patientId=";
            await client.DeleteAsync(url + id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> ListOfPatients()
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
    }
}
