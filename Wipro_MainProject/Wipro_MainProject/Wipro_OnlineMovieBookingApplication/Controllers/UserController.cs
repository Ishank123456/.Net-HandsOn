using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Services.Repository;
using Wipro_OnlineMovieBookingApplication.Models;
using Wipro_OnlineMovieBookingApplication.ViewModels;

namespace Wipro_OnlineMovieBookingApplication.Controllers
{
    public class UserController : Controller
    {
        HttpClient client;
        IConfiguration configuration;
        IMapper mapper;
        IUserRepository userRepository;
        IBookingRepository bookingRepository;
        WiproOnlineMovieBookingApplicationContext context;
        public UserController(IConfiguration _configuration, IMapper _mapper,
            IUserRepository _userRepository, IBookingRepository _bookingRepository, WiproOnlineMovieBookingApplicationContext _context)
        {
            mapper = _mapper;
            userRepository = _userRepository;
            bookingRepository = _bookingRepository;
            context = _context;
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public async Task<IActionResult> UserDashboard(int id)
        {
            var userViewModel = userRepository.GetUser(id);

            //var bookingViewModels = bookingRepository.GetAllBookingsByUserId(id);

            List<BookingViewModel> bookingViewModels = new List<BookingViewModel>();
            string url = $"api/BookingAPI/GetAllBookingForUser?userId={id}";
            using (var response = await client.GetAsync(url))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                bookingViewModels = JsonConvert.DeserializeObject<List<BookingViewModel>>(result);
            }

            var viewModel = new UserViewModel
            {

                UserId = userViewModel.UserId,
                FirstName = userViewModel.FirstName,
                LastName = userViewModel.LastName,
                Name = $"{userViewModel.FirstName} {userViewModel.LastName}",
                Password = userViewModel.Password,
                Address = userViewModel.Address,
                ContactNo = userViewModel.ContactNo,
                UserName = userViewModel.UserName,
                Email = userViewModel.Email,
                IsAdmin = userViewModel.IsAdmin,
                Bookings = bookingViewModels.Select(b => new BookingViewModel
                {
                    BookingId = b.BookingId,
                    MovieId = b.MovieId,
                    BookingDate = b.BookingDate,
                    ShowTime = b.ShowTime,
                    NumberOfTickets = b.NumberOfTickets,
                }).ToList()
            };

            return View(viewModel);
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
        public async Task<IActionResult> Edit(EditUserViewModel userEditModel, int userId)
        {
            string url = "api/UserAPI/EditUser";
            if (ModelState.IsValid)
            {
                var response = await client.PutAsJsonAsync(url, userEditModel);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("EditUserSuccess", "SuccessPopUp", new { id = userId });
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
                objUserModel = JsonConvert.DeserializeObject<UserViewModel>(result, settings);
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

            return RedirectToAction("DeleteViewSuccess", "SuccessPopUp", new { id = id });
        }


        [HttpGet]
        public async Task<IActionResult> MovieDetails(int userId)
        {
            ViewBag.Users = context.Users
            .Where(u => u.UserId == userId)
            .Select(u => new
            {
                u.UserId,
                u.UserName
            }).ToList();

            List<MovieViewModel> lstMovies = new List<MovieViewModel>();
            string url = "api/MovieAPI/GetAllMovies";
            using (var response = await client.GetAsync(url))
            {
                var result = response.Content.ReadAsStringAsync().Result;
                lstMovies = JsonConvert.DeserializeObject<List<MovieViewModel>>(result);
            }
            return View(lstMovies);
        }
        public async Task<IActionResult> BookingDetails(int userId)
        {
            List<BookingViewModel> model = new List<BookingViewModel>();
            HttpResponseMessage res = await client.GetAsync($"api/BookingAPI/GetAllBookingForUser?userId={userId}");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<List<BookingViewModel>>(result);
            }
            return View(model);
        }
        
        public IActionResult AddBookingForUser(int id, int userId)
        {
            ViewBag.MovieOptions = context.Movies
            .Where(m => m.MovieId == id)
            .Select(m => new
            {
                m.MovieId,
                m.MovieName,
                m.MoviePrice
            })
            .ToList();

            ViewBag.UserOptions = context.Users
            .Where(u => u.UserId == userId)
            .Select(u => new
            {
                u.UserId,
                u.UserName,
                u.Email
            }).ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBookingForUser(AddBookingViewModel viewModel, int userId, int id)
        {
            string url = "api/BookingAPI/AddBooking";

            viewModel.MovieId = id;
            var movie = context.Movies.FirstOrDefault(m => m.MovieId == id);
            if (movie != null)
            {
                viewModel.MovieId = movie.MovieId;
                viewModel.MoviePrice = movie.MoviePrice;
            }
            if (ModelState.IsValid)
            {
                try
                {

                    var response = await client.PostAsJsonAsync(url, viewModel);

                    var paymentDetail = new PaymentDetail
                    {
                        TransactionId = Guid.NewGuid(),
                        UserId = viewModel.UserId,
                        MovieId = viewModel.MovieId,
                        Amount = viewModel.NumberOfTickets * viewModel.MoviePrice,
                        PaymentDate = DateTime.UtcNow,
                        IsConfirmed = false
                    };
                    context.PaymentDetails.Add(paymentDetail);
                    await context.SaveChangesAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("AddBookingSuccessForUser", "User", new { id = userId });
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        ModelState.AddModelError(string.Empty, $"Server error: {response.StatusCode} - {errorContent}");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, $"Exception occurred: {ex.Message}");
                }
            }

            ViewBag.MovieOptions = context.Movies
            .Where(m => m.MovieId == id)
            .Select(m => new
            {
                m.MovieId,
                m.MovieName,
                m.MoviePrice
            })
            .ToList();

            ViewBag.UserOptions = context.Users
            .Where(u => u.UserId == userId)
            .Select(u => new
            {
                u.UserId,
                u.UserName,
                u.Email
            }).ToList();

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> BookingDetailsForOne(int bookingId)
        {
            BookingViewModel model = new BookingViewModel();
            HttpResponseMessage res = await client.GetAsync($"api/BookingAPI/GetBookingById?bookingId={bookingId}");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<BookingViewModel>(result);
            }
            return View(model);
        }

        public IActionResult AddBookingSuccessForUser(int id,UserViewModel model)
        {
            model.UserId = id;
            var userViewModel = userRepository.GetUser(id);
            return View(userViewModel);
        }

    }
}
