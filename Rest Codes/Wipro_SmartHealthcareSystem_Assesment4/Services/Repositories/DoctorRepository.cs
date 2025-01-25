using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly SmartHmsdbContext doctorDbContext;
        public DoctorRepository(SmartHmsdbContext _doctorDbContext)
        {
            doctorDbContext = _doctorDbContext;
        }

        public int AddDoctor(Doctor doctor)
        {
            doctorDbContext.Doctors.Add(doctor);
            return doctorDbContext.SaveChanges();
        }

        public bool DeleteDoctor(int id)
        {
            var filterData = doctorDbContext.Doctors.SingleOrDefault(p => p.DoctorId == id);
            var result = doctorDbContext.Doctors.Remove(filterData);
            doctorDbContext.SaveChanges();
            return result != null ? true : false;
        }

        public IEnumerable<Doctor> GetAllDoctors()
        {
            return doctorDbContext.Doctors.ToList();
        }

        public Doctor GetDoctor(int id)
        {
            return doctorDbContext.Doctors.SingleOrDefault(d => d.DoctorId == id);
        }

        public int UpdateDoctor(Doctor doctor)
        {
            doctorDbContext.Doctors.Update(doctor);
            return doctorDbContext.SaveChanges();
        }
    }
}
