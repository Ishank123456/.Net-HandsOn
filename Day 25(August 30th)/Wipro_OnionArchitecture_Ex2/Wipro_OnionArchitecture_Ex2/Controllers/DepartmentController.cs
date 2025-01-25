using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;
using Wipro_OnionArchitecture_Ex2.DTO;

namespace Wipro_OnionArchitecture_Ex2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDeptRepository deptRepository;
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;
        public DepartmentController(IDeptRepository _deptRepository, IEmployeeRepository _employeeRepository,
            IMapper _mapper)
        {
            deptRepository = _deptRepository;
            employeeRepository = _employeeRepository;
            mapper = _mapper;
        }

        [HttpPost("CreateDepartment")]
        public IActionResult CreateDepartment(CreateDeptDTO deptModel)
        {
            return Ok(deptRepository.CreateDepartment(mapper.Map<Department>(deptModel)));
        }

        [HttpGet("GetAllDepartmentsWithEmployees")]
        public IActionResult GetAllDepartmentsWithEmployees()
        {
            List<DeptEmpLstDTO> deptEmpLstDTOs = new List<DeptEmpLstDTO>();
            var lstDept = deptRepository.GetAllDepartments().ToList();
            foreach (var dept in lstDept)
            {
                var deptId = dept.DeptId;
                var lstEmp = employeeRepository.GetAllEmployees().Where(e => e.DeptId == deptId);
                DeptEmpLstDTO deptEmpLstDTO = new DeptEmpLstDTO();
                deptEmpLstDTO.DeptId = dept.DeptId;
                deptEmpLstDTO.DeptName = dept.DeptName;
                deptEmpLstDTO.LstEmployee = new List<EmpDTO>();
                foreach(var employee in lstEmp)
                {
                    EmpDTO empDTO = new EmpDTO();
                    empDTO.EmpId = employee.EmpId;
                    empDTO.EmpName = employee.EmpName;
                    empDTO.EmpSal = employee.EmpSal;
                    empDTO.EmpCity = employee.EmpCity;
                    empDTO.EmpGender = employee.EmpGender;
                    deptEmpLstDTO.LstEmployee.Add(empDTO);
                }
                deptEmpLstDTOs.Add(deptEmpLstDTO);
            }
            return Ok(deptEmpLstDTOs);
        }
    }
}
