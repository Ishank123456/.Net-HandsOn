using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Services.Repository;
using Wipro_OnlineMovieBookingApplication.ViewModels;

namespace Wipro_OnlineMovieBookingApplication.Controllers
{
    public class PaymentDetailsController : Controller
    {
        HttpClient client;
        IConfiguration configuration;
        private readonly WiproOnlineMovieBookingApplicationContext context;
        private readonly IPaymentRepository paymentDetailsRepository;
        private readonly IUserRepository userRepository;
        private readonly IMovieRepository movieRepository;

        public PaymentDetailsController(IConfiguration _configuration, IPaymentRepository _paymentDetailsRepository,
            IUserRepository _userRepository, IMovieRepository _movieRepository, WiproOnlineMovieBookingApplicationContext _context)
        {
            configuration = _configuration;
            paymentDetailsRepository = _paymentDetailsRepository;
            userRepository = _userRepository;
            movieRepository = _movieRepository;
            string apiAddress = configuration["ApiAddress"];
            Uri baseAddress = new Uri(apiAddress);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
            context = _context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPaymentDetails()
        {
            List<PaymentDetailsViewModel> models = new List<PaymentDetailsViewModel>();
            HttpResponseMessage res = await client.GetAsync("api/PaymentDetailsAPI/GetAllPayments");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                models = JsonConvert.DeserializeObject<List<PaymentDetailsViewModel>>(result);
            }
            return View(models);
        }

        [HttpGet]
        public async Task<IActionResult> GetPaymentDetailsForOne(int id)
        {
            PaymentDetailsViewModel model = new PaymentDetailsViewModel();
            HttpResponseMessage res = await client.GetAsync($"api/PaymentDetailsAPI/GetPaymentDetailsById?id={id}");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<PaymentDetailsViewModel>(result);
            }
            return View(model);
        }



        [HttpGet]
        public async Task<IActionResult> GetAllPaymentDetailsForUser(int userId)
        {
            ViewBag.UserNames = context.Users
           .Where(u => u.UserId == userId)
           .Select(u => new
           {
               u.UserId,
               u.FirstName,
               u.LastName,
               u.Email
           }).ToList();

            List<PaymentDetailsViewModel> models = new List<PaymentDetailsViewModel>();
            HttpResponseMessage res = await client.GetAsync($"api/PaymentDetailsAPI/GetAllPaymentDetailsForUser?userId={userId}");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                models = JsonConvert.DeserializeObject<List<PaymentDetailsViewModel>>(result);
            }
            return View(models);
        }
        [HttpPost]
        public async Task<ActionResult> ConfirmPayment(int paymentId)
        {
            var paymentDetail = context.PaymentDetails
            .SingleOrDefault(p => p.PaymentId == paymentId);

            paymentDetail.IsConfirmed = true;
            context.PaymentDetails.Update(paymentDetail);
            context.SaveChanges();
            return RedirectToAction("ConfirmPaymentSuccess");
        }
        public ActionResult ConfirmPaymentSuccess()
        {
            return View();
        }
    }
}
