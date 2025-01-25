using Microsoft.AspNetCore.Mvc;
using Practice_APIWithView_MVC_Login.DTOs;
using Practice_APIWithView_MVC_Login.Models;

namespace Practice_APIWithView_MVC_Login.Controllers
{
    public class UserController : Controller
    {
        HttpClient client;
        IConfiguration configuration;
        public UserController(IConfiguration _configuration)
        {
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public IActionResult Index()
        {
            ViewData["Description"] = "My Page";
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserProfile user)
        {
            string url = "api/UserAPI/Register";
            if (ModelState.IsValid)
            {
                var response = await client.PostAsJsonAsync(url, user);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time");
                }
            }
            return View(user);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserProfileDTO user)
        {
            string url = "api/UserAPI/Login";
            if (ModelState.IsValid)
            {
                var response = await client.PostAsJsonAsync(url, user);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time");
                }
            }
            return View(user);
        }
    }
}
