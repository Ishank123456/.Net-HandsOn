using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Wipro_HealthManagementSystemCFA.Models;

namespace Wipro_HealthManagementSystemCFA.Controllers
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
        public async Task<IActionResult> Index()
        {
            List<Doctor> model = new List<Doctor>();
            HttpResponseMessage res = await client.GetAsync("api/DoctorAPI/ListDoctors");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<List<Doctor>>(result);
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
        public async Task<IActionResult> Create(Doctor doctor)
        {
            string url = "api/DoctorAPI/Create";
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
        public async Task<IActionResult> Edit(int? id)
        {
            Doctor objDoctor = new Doctor();
            string url = "api/DoctorAPI/SearchDoctor?id=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objDoctor = JsonConvert.DeserializeObject<Doctor>(result);

            }
            return View(objDoctor);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Doctor doctor)
        {
            string url = "api/DoctorAPI/Edit";
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
        public async Task<IActionResult> Details(int id)
        {
            Doctor objDoctor = new Doctor();
            string url = "api/DoctorAPI/SearchDoctor?id =";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objDoctor = JsonConvert.DeserializeObject<Doctor>(result);
            }
            return View(objDoctor);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Doctor objDoctor = new Doctor();
            string url = "api/DoctorAPI/SearchDoctor?id=";
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
            string url = "api/DoctorAPI/Delete";
            await client.DeleteAsync(url + id);
            return RedirectToAction("Index");
        }
    }
}
