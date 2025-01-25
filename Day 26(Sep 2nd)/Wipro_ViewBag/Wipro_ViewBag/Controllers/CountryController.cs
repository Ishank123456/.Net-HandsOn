using Microsoft.AspNetCore.Mvc;

namespace Wipro_ViewBag.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult CountryList()
        {
            List<string> lstCountries = new List<string>();
            lstCountries.Add("India");
            lstCountries.Add("USA");
            lstCountries.Add("UK");
            lstCountries.Add("France");
            lstCountries.Add("Russia");
            lstCountries.Add("Japan");
            lstCountries.Add("Brazil");

            ViewBag.Countries = lstCountries;

            return View();
        }
    }
}
