using Microsoft.AspNetCore.Mvc;

namespace Wipro_FirstProgram.Controllers
{
    public class WiproController : Controller
    {
        public IActionResult Index()
        {
            string str = "Hello Wipro, Welcome to MVC Core Programming";
            ViewData["Name"] = str;
            return View();
        }

        public IActionResult Arithmetic()
        {
            int a = 20;
            int b = 10;
            int add = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;
            ViewData["Addition"] = add;
            ViewData["Subtraction"] = sub;
            ViewData["Multiplication"] = mul;
            ViewData["Division"] = div;
            return View();
        }

        public string GetName()
        {
            return "Learning Wipro MVC";
        }
    }
}
