using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_API_StudentServiceApplication.Model;
using Wipro_API_StudentServiceApplication.Repository;

namespace Wipro_API_StudentServiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        public StudentController(IStudentRepository _studentRepository)
        {
            studentRepository = _studentRepository;
        }

        [HttpPost("CreateStudentInfo")]
        public ActionResult CreateStudentInfo(Student student)
        {
            return Ok(studentRepository.CreateStudentInfo(student));
        }

        [HttpGet("GetAllStudents")]
        public ActionResult GetAllStudents()
        {
            return Ok(studentRepository.GetAllStudents());
        }

        [HttpGet("SelectStudentById")]
        public ActionResult SelectStudentById(int stuId)
        {
            return Ok(studentRepository.SelectStudentById(stuId));
        }

        [HttpPut("UpdateStudentInfo")]
        public ActionResult UpdateStudentInfo(Student student)
        {
            return Ok(studentRepository.UpdateStudentInfo(student));
        }

        [HttpDelete("DeleteStudentInfo")]
        public ActionResult DeleteStudentInfo(Student student)
        {
            return Ok(studentRepository.DeleteStudentInfo(student));
        }
    }
}
