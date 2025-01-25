using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Services.Repository;
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
        OnlineMovieBookingApplicationContext context;
        public UserController(IConfiguration _configuration, IMapper _mapper,
            IUserRepository _userRepository, IBookingRepository _bookingRepository, OnlineMovieBookingApplicationContext _context)
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
        public ActionResult UserDashboard(int id)
        {
            var userViewModel = userRepository.GetUser(id);
            var bookingViewModels = bookingRepository.GetAllBookingsByUserId(id);

            var viewModel = new UserViewModel
            {
                UserId = userViewModel.UserId,
                FirstName = userViewModel.FirstName,
                LastName = userViewModel.LastName,
                Address = userViewModel.Address,
                ContactNo = userViewModel.ContactNo,
                UserName = userViewModel.UserName,
                Email = userViewModel.Email,
                IsAdmin = userViewModel.IsAdmin,
                Bookings = bookingViewModels.Select(b => new BookingViewModel
                {
                    BookingId = b.BookingId,
                    BookingDate = b.BookingDate,
                    ShowTime = b.ShowTime,
                    NumberOfTickets = b.NumberOfTickets,
                    //TotalPrice = b.TotalPrice
                }).ToList()
            };

            return View(viewModel);
        }

        //private UserViewModel GetUserViewModel()
        //{
        //    var currentUserId = User.Identity.Name;

        //    var user = context.Users
        //        .Where(u => u.UserName == currentUserId)
        //        .Select(u => new UserViewModel
        //        {
        //            UserId = u.UserId,
        //            UserName = u.UserName,
        //            Email = u.Email,
        //        })
        //        .FirstOrDefault();

        //    return user;
        //}

        //public ActionResult EditUserSuccess()
        //{
        //    return View();
        //}
        //public ActionResult DeleteViewSuccess()
        //{
        //    return View();
        //}
        //public ActionResult AddBookingViewSuccess()
        //{
        //    return View();
        //}

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

        public IActionResult AddBookingForUser(int id, int userId)
        {
            ViewBag.MovieOptions = context.Movies
            .Where(m => m. MovieId == id)
            .Select(m => new
            {
                m.MovieId,
                m.MovieName,
                m.MoviePrice
            })
            .ToList();

            ViewBag.UserOptions = context.Users
            .Where (u => u.UserId == userId)
            .Select(u => new
            {
                u.UserId,
                u.UserName
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
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("AddBookingSuccess", "Booking");
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
                u.UserName
            }).ToList();

            return View(viewModel);
        }

        public async Task<IActionResult> BookingDetails(int userId)
        {
            if (userId == null)
            {
                return BadRequest("User ID are required.");
            }

            string url = $"api/BookingAPI/GetAllBookingsForUser?userId={userId}";
            using (var response = await client.GetAsync(url))
            {
                var result = await response.Content.ReadAsStringAsync();

                // Deserialize to a list of BookingViewModel
                var bookings = JsonConvert.DeserializeObject<List<BookingViewModel>>(result);

                // Map to UserBookingViewModel
                var user = userRepository.GetUser(userId); // Fetch user details

                if (user == null)
                {
                    return NotFound("User not found.");
                }

                var viewModel = new UserViewModel
                {
                    UserId = user.UserId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Address = user.Address,
                    ContactNo = user.ContactNo,
                    UserName = user.UserName,
                    Email = user.Email,
                    IsAdmin = user.IsAdmin,
                    Bookings = bookings
                };

                return View(viewModel);
            }
        }


        //public async Task<IActionResult> BookingDetails(int? id)
        //{
        //    BookingViewModel bookingModel = new BookingViewModel();
        //    string url = "api/BookingAPI/GetBookingById?bookingId=";
        //    using (var response = await client.GetAsync(url + id))
        //    {
        //        var result = response.Content.ReadAsStringAsync().Result;
        //        bookingModel = JsonConvert.DeserializeObject<BookingViewModel>(result);
        //    }
        //    return View(bookingModel);
        //}
    }
}
