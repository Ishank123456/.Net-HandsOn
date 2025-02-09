﻿using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Wipro_OnlineMovieBookingApplication.Models;
using Wipro_OnlineMovieBookingApplication.ViewModels;

namespace Wipro_OnlineMovieBookingApplication.Controllers
{
    public class BookingController : Controller
    {
        HttpClient client;
        IConfiguration configuration;
        private readonly WiproOnlineMovieBookingApplicationContext context;
        public BookingController(IConfiguration _configuration,
            WiproOnlineMovieBookingApplicationContext _context)
        {
            context = _context;
            configuration = _configuration;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        public IActionResult AddBookingSuccess(BookingViewModel model)
        {
            var bookingViewModel = new BookingViewModel()
            {
                BookingId = model.BookingId,
                UserId = model.UserId,
                UserName = model.UserName,
                MovieId = model.MovieId,
                MovieName = model.MovieName,
                BookingDate = model.BookingDate,
                ShowTime = model.ShowTime,
                NumberOfTickets = model.NumberOfTickets
            };
            return View(bookingViewModel);
        }

        public async Task<IActionResult> BookingDetails()
        {
            List<BookingViewModel> model = new List<BookingViewModel>();
            HttpResponseMessage res = await client.GetAsync("api/BookingAPI/GetAllBookings");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<List<BookingViewModel>>(result);
            }
            return View(model);
        }

        public IActionResult AddBooking(int id)
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
        public async Task<IActionResult> AddBooking(AddBookingViewModel viewModel, int id)
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
                        return RedirectToAction("AddBookingSuccess");
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
            });

            ViewBag.UserOptions = context.Users
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

    }
}
