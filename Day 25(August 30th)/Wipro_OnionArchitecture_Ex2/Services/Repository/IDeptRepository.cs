using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IDeptRepository
    {
        IEnumerable<Department> GetAllDepartments();

        Department GetDepartment(int deptId);
        Department CreateDepartment(Department department);
        Department UpdateDepartment(Department department);
        bool DeleteDepartment(int deptId);
    }
}
