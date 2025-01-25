using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Wipro_MusicLibProject.ViewModel;

namespace Wipro_MusicLibProject.Controllers
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
        public async Task<IActionResult> Index()
        {
            List<UserViewModel> lstUser = new List<UserViewModel>();
            HttpResponseMessage res = await client.GetAsync("api/UserAPI/ListUsers");
            if(res.IsSuccessStatusCode)
            {
                var response = res.Content.ReadAsStringAsync().Result;
                lstUser = JsonConvert.DeserializeObject<List<UserViewModel>>(response);
            }
            return View(lstUser);
        }
    }
}
