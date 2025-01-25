using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using Wipro_MusicLibProject.ViewModel;

namespace Wipro_MusicLibProject.Controllers
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
        public async Task<IActionResult> Login(UserLoginViewModel modelLogin)
        {
            if(ModelState.IsValid)
            {
                List<UserLoginViewModel> lstUsers = new List<UserLoginViewModel>();
                HttpResponseMessage res = await client.GetAsync("api/LoginAPI/CheckListOfUsers");
                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStringAsync().Result;
                    lstUsers = JsonConvert.DeserializeObject<List<UserLoginViewModel>>(result);

                    var Data = lstUsers.FirstOrDefault(u => u.Email == modelLogin.Email);
                    if( Data != null )
                    {
                        bool isValid = (Data.Email == modelLogin.Email && Data.Password == modelLogin.Password);
                        if ( isValid )
                        {
                            var userClaims = new List<Claim>
                            {
                                new Claim(ClaimTypes.Email, Data.Email),
                                //new Claim(ClaimTypes.Role, Data.Id == 1?"Admin" : "User"),
                                new Claim(ClaimTypes.Role, Data.IsAdmin == 1?"Admin" : "User"),
                                //new Claim("UserId", Convert.ToString(Data.Id))
                                new Claim("UserId", Convert.ToString(Data.IsAdmin)),
                                new Claim("ArtistId", Convert.ToString(Data.ArtistId  ?? 0))
                            };

                            var userIdentity = new ClaimsIdentity(userClaims, Data.Id == 1 ? "Admin" : "User");

                            await HttpContext.SignInAsync
                                (CookieAuthenticationDefaults.AuthenticationScheme,
                                new ClaimsPrincipal(userIdentity));
                            if (Data.Id == 1)
                                return RedirectToAction("Index", "User");
                            else
                                return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            TempData["errorPassword"] = "Invalid Password";
                            return View(modelLogin);
                        }
                    }
                    else
                    {
                        TempData["errorUsername"] = "User not found";
                        return View(modelLogin);
                    }
                }
                else
                {
                    TempData["errorApi"] = "Api not found";
                    return View(modelLogin);
                }
            }
            else
            {
                return View(modelLogin);
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
