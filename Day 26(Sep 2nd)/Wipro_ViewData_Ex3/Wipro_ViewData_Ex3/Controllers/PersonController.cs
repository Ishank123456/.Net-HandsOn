using Microsoft.AspNetCore.Mvc;
using Wipro_ViewData_Ex3.Models;

namespace Wipro_ViewData_Ex3.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonTable()
        {
            List<Person> lstPersons = new List<Person>();

            Person objPerson1 = new Person()
            {
                PersonId = 101,
                PersonName = "Rahul",
                PersonAge = 25,
                PersonEmail = "rahul@gmail.com",
                PersonAddress = "Mumbai, Maharashtra, India"
            };
            lstPersons.Add(objPerson1);

            Person objPerson2 = new Person()
            {
                PersonId = 102,
                PersonName = "Priya",
                PersonAge = 28,
                PersonEmail = "priya@gmail.com",
                PersonAddress = "New Delhi, Delhi, India"
            };
            lstPersons.Add(objPerson2);

            Person objPerson3 = new Person()
            {
                PersonId = 103,
                PersonName = "Subham",
                PersonAge = 24,
                PersonEmail = "subham@gmail.com",
                PersonAddress = "Kolkata, W.B., India"
            };
            lstPersons.Add(objPerson3);

            Person objPerson4= new Person()
            {
                PersonId = 104,
                PersonName = "Michael",
                PersonAge = 31,
                PersonEmail = "michael@yahoo.com",
                PersonAddress = "L.A., California, India"
            };
            lstPersons.Add(objPerson4);

            Person objPerson5 = new Person()
            {
                PersonId = 105,
                PersonName = "Emma",
                PersonAge = 27,
                PersonEmail = "emma@email.com",
                PersonAddress = "London, UK"
            };
            lstPersons.Add(objPerson5);

            ViewData["LstPerson"] = lstPersons;
            return View();
        }
    }
}
