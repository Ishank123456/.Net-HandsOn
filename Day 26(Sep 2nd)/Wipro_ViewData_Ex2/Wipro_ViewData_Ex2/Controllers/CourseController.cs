using Microsoft.AspNetCore.Mvc;

namespace Wipro_ViewData_Ex2.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult CourseList()
        {
            List<string> lstCourses = new List<string>();
            lstCourses.Add("B.Tech");
            lstCourses.Add("M.Tech");
            lstCourses.Add("BBA");
            lstCourses.Add("MBA");
            lstCourses.Add("BCA");
            lstCourses.Add("MCA");
            lstCourses.Add("MBBS");
            lstCourses.Add("MS");

            ViewData["LstCourses"] = lstCourses;
            return View();
        }
    }
}
