using Microsoft.AspNetCore.Mvc;

namespace Wipro_ViewData_Ex2.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult CountryList()
        {
            List<string> lstCountries = new List<string>();
            lstCountries.Add("India");
            lstCountries.Add("USA");
            lstCountries.Add("Japan");
            lstCountries.Add("France");
            lstCountries.Add("Russia");
            lstCountries.Add("China");
            lstCountries.Add("UK");
            lstCountries.Add("Germany");
            lstCountries.Add("Brazil");
            lstCountries.Add("Iran");

            ViewData["LstCountries"] = lstCountries;
            return View();
        }
    }
}
