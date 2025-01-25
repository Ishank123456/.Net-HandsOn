using Microsoft.AspNetCore.Mvc;
using Wipro_ViewBag.Models;

namespace Wipro_ViewBag.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentDetails()
        {
            Student objStudent = new Student()
            {
                StudentId = 101,
                StudentName = "Subham",
                Branch = "Electrical Engineering",
                Section = "A",
                Gender = "Male"
            };

            ViewBag.Student = objStudent;
            return View();
        }
    }
}
