using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Services.Repository;
using System.Text.Json.Serialization;
using Wipro_FinalProjectMVC.Models;

namespace Wipro_FinalProjectMVC.Controllers
{
    public class UserController : Controller
    {
        HttpClient client;
        IConfiguration configuration;
        private readonly IUserRepository userService;
        private readonly IUserProfileRepository userProfileService;

        public UserController(IUserRepository _userService,
            IUserProfileRepository _userProfileService, IConfiguration _configuration)
        {
            userService = _userService;
            userProfileService = _userProfileService;
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public async Task<IActionResult> Index()
        {
            List<UserViewModel> model = new List<UserViewModel>();
            HttpResponseMessage res = await client.GetAsync("api/User/ListUsers");
            if(res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<List<UserViewModel>>(result);
            }
            return View(model);
        }
    }
}
