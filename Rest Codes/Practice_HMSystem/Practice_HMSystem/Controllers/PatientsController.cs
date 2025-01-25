using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Practice_HMSystem.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Practice_HMSystem.Controllers
{
    public class PatientsController : Controller
    {
        HttpClient client;
        IConfiguration configuration;
        public PatientsController(IConfiguration _configuration)
        {
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        public async Task<IActionResult> Index()
        {
            List<Patient> model = new List<Patient>();
            HttpResponseMessage res = await client.GetAsync("api/PatientsAPI/ListPatients");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<List<Patient>>(result);
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Patient patient)
        {
            string url = "api/PatientsAPI/Create";
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
        public async Task<IActionResult> Edit(int? id)
        {
            Patient objPatient = new Patient();
            string url = "api/PatientsAPI/SearchPatient?id=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objPatient = JsonConvert.DeserializeObject<Patient>(result);
            }
            return View(objPatient);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Patient patient)
        {
            string url = "api/patientsAPI/Edit";
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
        public async Task<IActionResult> Details(int id)
        {
            Patient objPatient = new Patient();
            string url = "api/PatientsAPI/SearchPatient?id=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objPatient = JsonConvert.DeserializeObject<Patient>(result);
            }
            return View(objPatient);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Patient objPatient = new Patient();
            string url = "api/PatientsAPI/SearchPatient?id=";
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
            string url = "api/PatientsAPI/Delete";
            await client.DeleteAsync(url + id);
            return RedirectToAction("Index");
        }
    }
}
