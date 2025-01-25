using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Wipro_OnlineMovieBookingApplication_MainProject.ViewModels;

namespace Wipro_OnlineMovieBookingApplication_MainProject.Controllers
{
    public class UserController : Controller
    {
        HttpClient client;
        IConfiguration configuration;
        IMapper mapper;
        public UserController(IConfiguration _configuration, IMapper _mapper)
        {
            mapper = _mapper;
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        public async Task<IActionResult> Index()
        {
            List<UserViewModel> model = new List<UserViewModel>();
            HttpResponseMessage res = await client.GetAsync("api/UserAPI/ListUsers");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<List<UserViewModel>>(result);
            }
            return View(model);
        }

        public ActionResult AddUserSuccess()
        {
            return View();
        }
        public ActionResult EditUserSuccess()
        {
            return View();
        }
        public ActionResult DeleteViewSuccess()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddUserViewModel userModel)
        {
            string url = "api/UserAPI/AddUser";
            if (ModelState.IsValid)
            {
                var response = await client.PostAsJsonAsync(url, userModel);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("AddUserSuccess");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            return View(userModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            UserViewModel objUserModel = new UserViewModel();
            string url = "api/UserAPI/SingleUser?userId=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objUserModel = JsonConvert.DeserializeObject<UserViewModel>(result);
            }
            EditUserViewModel editUserViewModel = mapper.Map<EditUserViewModel>(objUserModel);
            return View(editUserViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel userEditModel)
        {
            string url = "api/UserAPI/EditUser";
            if (ModelState.IsValid)
            {
                var response = await client.PutAsJsonAsync(url, userEditModel);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("EditUserSuccess");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            else
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }
            }
            return View(userEditModel);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            UserViewModel objUserModel = new UserViewModel();
            string url = "api/UserAPI/SingleUser?userId=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objUserModel = JsonConvert.DeserializeObject<UserViewModel>(result);
            }
            return View(objUserModel);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            UserViewModel objUserModel = new UserViewModel();
            string url = "api/UserAPI/SingleUser?userId=";
            using (var response = await client.GetAsync(url + id))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                objUserModel = JsonConvert.DeserializeObject<UserViewModel>(result);
            }
            return View(objUserModel);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            string url = "api/UserAPI/DeleteUser?userId=";
            await client.DeleteAsync(url + id);

            return RedirectToAction("DeleteViewSuccess");
        }
    }
}