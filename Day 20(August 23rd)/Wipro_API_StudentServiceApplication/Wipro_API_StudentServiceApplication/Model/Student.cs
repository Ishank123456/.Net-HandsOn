using System.ComponentModel.DataAnnotations;

namespace Wipro_API_StudentServiceApplication.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public string StudentGender { get; set; }
        public string StudentMobileNo { get; set; }
        public string StudentCity { get; set; }
    }
}
