using Wipro_HealthManagementSystemCFA.EntityFramework;
using Wipro_HealthManagementSystemCFA.Models;

namespace Wipro_HealthManagementSystemCFA.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ApplicationDbContext doctorDbContext;
        public DoctorRepository(ApplicationDbContext _doctorDbContext)
        {
            doctorDbContext = _doctorDbContext;
        }

        public int DeleteDoctor(int id)
        {
            var filterData = doctorDbContext.Doctors.SingleOrDefault(d => d.DoctorId == id);
            doctorDbContext.Doctors.Remove(filterData);
            return doctorDbContext.SaveChanges();
        }

        public IEnumerable<Doctor> GetAllDoctors()
        {
            return doctorDbContext.Doctors.ToList();
        }

        public Doctor GetDoctor(int id)
        {
            return doctorDbContext.Doctors.SingleOrDefault(d => d.DoctorId == id);
        }

        public int InsertDoctor(Doctor doctor)
        {
            doctorDbContext.Doctors.Add(doctor);
            return doctorDbContext.SaveChanges();
        }

        public int UpdateDoctor(Doctor doctor)
        {
            doctorDbContext.Doctors.Update(doctor);
            return doctorDbContext.SaveChanges();
        }
    }
}
