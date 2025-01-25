using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using Wipro_OnlineMovieBookingApplication_MainProject.ViewModels;

namespace Wipro_OnlineMovieBookingApplication_MainProject.Controllers
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
                    if(Data != null)
                    {
                        bool isValid = Data.Email == modelLogin.Email && Data.Password == modelLogin.Password;
                        if(isValid)
                        {
                            var userClaims = new List<Claim>()
                            {
                                new Claim(ClaimTypes.Email, Data.Email),
                                new Claim(ClaimTypes.Role, Data.Id == 1?"Admin" : "User"),
                                new Claim("UserId", Convert.ToString(Data.Id))
                            };
                        }
                    }
                }
            }
        }
    }
}
