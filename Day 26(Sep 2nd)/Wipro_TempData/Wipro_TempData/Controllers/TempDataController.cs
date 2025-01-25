using Microsoft.AspNetCore.Mvc;

namespace Wipro_TempData.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult Index()
        {
            List<string> lstCourses = new List<string>();
            lstCourses.Add("B.Tech");
            lstCourses.Add("M.Tech");
            lstCourses.Add("BCA");
            lstCourses.Add("MCA");
            lstCourses.Add("MBBS");

            TempData["Name"] = "WELCOME";
            TempData["LstCourse"] = lstCourses;
            return RedirectToAction("PassingData");
        }

        public IActionResult PassingData()
        {
            string str = TempData["Name"].ToString();
            ViewBag.Name = str; 
            var lstCourse = TempData["LstCourse"];
            ViewBag.LstCourse = lstCourse;
            return View();
        }
    }
}
