using System.ComponentModel.DataAnnotations;

namespace Wipro_API_EmployeeService_Ex2.Model
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpGender { get; set; }
        public int EmpAge { get; set; }
        public string EmpEmail { get; set; }
        public string EmpContact { get; set; }
        public string EmpCity { get; set; }
        public string EmpQualification { get; set; }
    }
}
