using DAL.EntityFramework;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class DeptRepository : IDeptRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public DeptRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }

        public Department CreateDepartment(Department department)
        {
            var result = applicationDbContext.Departments.Add(department);
            applicationDbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteDepartment(int deptId)
        {
            var filterData = applicationDbContext.Departments.SingleOrDefault(d => d.DeptId == deptId);
            var result = applicationDbContext.Departments.Remove(filterData);
            applicationDbContext.SaveChanges();
            return result != null ? true : false;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return applicationDbContext.Departments.ToList();
        }

        public Department GetDepartment(int deptId)
        {
            return applicationDbContext.Departments.SingleOrDefault(d => d.DeptId == deptId);
        }

        public Department UpdateDepartment(Department department)
        {
            var result = applicationDbContext.Departments.Update(department);
            applicationDbContext.SaveChanges();
            return result.Entity;
        }
    }
}
