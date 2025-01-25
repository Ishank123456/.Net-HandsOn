using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Services.Repositories;
using Wipro_SmartHealthcareSystem_Assesment4.ViewModels;
using Domain.Models;

namespace Wipro_SmartHealthcareSystem_Assesment4.Controllers
{
    public class UserController : Controller
    {
        HttpClient client;
        IConfiguration configuration;
        IUserRepository userRepository;
        public UserController(IConfiguration _configuration,
            IUserRepository _userRepository)
        {
            userRepository = _userRepository;
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public ActionResult UserDashboard(int id)
        {
            var userViewModel = userRepository.GetUser(id);

            //var viewModel = new UserViewModel
            //{
            //    UserId = userViewModel.UserId,
            //    FirstName = userViewModel.FirstName,
            //    LastName = userViewModel.LastName,
            //    Address = userViewModel.Address,
            //    ContactNo = userViewModel.ContactNo,
            //    UserName = userViewModel.UserName,
            //    Email = userViewModel.Email,
            //    IsAdmin = userViewModel.IsAdmin
            //};

            return View(userViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> UserDetails(int? id)
        {
            User objUser = new User();
            string url = "api/UserAPI/SingleUser?userId=";
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()  // Handles camelCase vs PascalCase differences
                }
            };
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objUser = JsonConvert.DeserializeObject<User>(result, settings);
            }
            return View(objUser);
        }
    }
}
