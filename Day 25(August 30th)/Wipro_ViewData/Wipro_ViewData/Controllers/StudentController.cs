using Microsoft.AspNetCore.Mvc;
using Wipro_ViewData.Models;

namespace Wipro_ViewData.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentDetails()
        {
            ViewData["Title"] = "Student Details Page";
            ViewData["Header"] = "Student Page";

            Student objStudent = new Student()
            {
                StudentId = "STD-1001",
                StudentName = "Subham",
                Branch = "EE",
                Section = "A",
                Gender = "Male"
            };
            ViewData["StudentDetails"] = objStudent;
            return View();
        }
    }
}
