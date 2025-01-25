using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using Wipro_SmartHealthcareSystem_Assesment4.ViewModels;

namespace Wipro_SmartHealthcareSystem_Assesment4.Controllers
{
    public class LoginController : Controller
    {
        HttpClient client;
        IConfiguration configuration;
        public LoginController(IConfiguration _configuration)
        {
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        [HttpGet, AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login(UserLoginViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                List<UserLoginViewModel> lstUsers = new List<UserLoginViewModel>();
                HttpResponseMessage res = await client.GetAsync("api/LoginAPI/CheckListOfUsers");
                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStringAsync().Result;
                    lstUsers = JsonConvert.DeserializeObject<List<UserLoginViewModel>>(result);

                    var Data = lstUsers.FirstOrDefault(u => u.Email == loginModel.Email);
                    if (Data != null)
                    {
                        bool isValid = Data.Email == loginModel.Email && Data.Password == loginModel.Password;
                        if (isValid)
                        {
                            var userClaims = new List<Claim>()
                            {
                                new Claim(ClaimTypes.Email, Data.Email),
                                new Claim(ClaimTypes.Role, Data.IsAdmin == 1 ? "Admin" : "User"),
                                new Claim("UserId", Convert.ToString(Data.IsAdmin))
                            };

                            var userIdentity = new ClaimsIdentity(userClaims, Data.Id == 1 ? "Admin" : "User");

                            await HttpContext.SignInAsync
                                (CookieAuthenticationDefaults.AuthenticationScheme,
                                new ClaimsPrincipal(userIdentity));
                            if (Data.Id == 1)
                                return RedirectToAction("AdminDashboard", "Admin");
                            else
                                return RedirectToAction("UserDashboard", "User", new { id = Data.Id });
                        }
                        else
                        {
                            TempData["errorPassword"] = "Invalid Password";
                            return View(loginModel);
                        }
                    }
                    else
                    {
                        TempData["errorUsername"] = "User not found";
                        return View(loginModel);
                    }
                }
                else
                {
                    TempData["errorApi"] = "Api not found";
                    return View(loginModel);
                }

            }
            else
            {
                return View(loginModel);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            Response.Cookies.Delete(".AspNetCore.Cookies");
            return RedirectToAction("login", "Login");
        }
    }
}
