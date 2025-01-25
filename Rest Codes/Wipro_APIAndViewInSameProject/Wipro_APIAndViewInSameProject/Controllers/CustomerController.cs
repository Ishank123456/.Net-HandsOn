using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Wipro_APIAndViewInSameProject.Models;

namespace Wipro_APIAndViewInSameProject.Controllers
{
    public class CustomerController : Controller
    {
        HttpClient client;
        IConfiguration configuration;
        public CustomerController(IConfiguration _configuration)
        {
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        public async Task<IActionResult> Index()
        {
            List<Customer> model = new List<Customer>();
            HttpResponseMessage res = await client.GetAsync("api/CustomerAPI/CustomerList");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<List<Customer>>(result);
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
        public async Task<IActionResult> Create(Customer customer)
        {
            string url = "api/CustomerAPI/Create";
            if (ModelState.IsValid)
            {
                var response = await client.PostAsJsonAsync(url, customer);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time");
                }
            }
            return View(customer);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            Customer objCustomer = new Customer();
            string url = "api/CustomerAPI/SearchCustomerById?id=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objCustomer = JsonConvert.DeserializeObject<Customer>(result);
            }
            return View(objCustomer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Customer customer)
        {
            string url = "api/CustomerAPI/Update";
            if (ModelState.IsValid)
            {
                var response = await client.PutAsJsonAsync(url, customer);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time");
                }
            }
            return View(customer);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            Customer objCustomer = new Customer();
            string url = "api/CustomerAPI/SearchCustomerById?id=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objCustomer = JsonConvert.DeserializeObject<Customer>(result);
            }
            return View(objCustomer);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Customer objCustomer = new Customer();
            string url = "api/CustomerAPI/SearchCustomerById?id=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objCustomer = JsonConvert.DeserializeObject<Customer>(result);
            }
            return View(objCustomer);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(Customer customer)
        {
            string url = "api/CustomerAPI/Delete";
            await client.DeleteAsync(url + customer);
            return RedirectToAction("Index");
        }
    }
}
