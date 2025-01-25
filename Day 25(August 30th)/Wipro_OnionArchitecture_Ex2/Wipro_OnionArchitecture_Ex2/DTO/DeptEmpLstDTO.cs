using Domain.Models;

namespace Wipro_OnionArchitecture_Ex2.DTO
{
    public class DeptEmpLstDTO
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        public List<EmpDTO> LstEmployee { get; set; }
    }
}
