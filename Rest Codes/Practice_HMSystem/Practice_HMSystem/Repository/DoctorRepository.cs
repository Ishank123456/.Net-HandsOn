using Practice_HMSystem.EntityFramework;
using Practice_HMSystem.Models;

namespace Practice_HMSystem.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public DoctorRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }

        public int DeleteDoctor(int id)
        {
            var filterData = applicationDbContext.Doctors.SingleOrDefault(d => d.DoctorId == id);
            applicationDbContext.Doctors.Remove(filterData);
            return applicationDbContext.SaveChanges();
        }

        public IEnumerable<Doctor> GetAllDoctors()
        {
            return applicationDbContext.Doctors.ToList();
        }

        public Doctor GetDoctor(int id)
        {
            return applicationDbContext.Doctors.SingleOrDefault(d => d.DoctorId == id);
        }

        public int InsertDoctor(Doctor doctor)
        {
            applicationDbContext.Doctors.Add(doctor);
            return applicationDbContext.SaveChanges();
        }

        public int UpdateDoctor(Doctor doctor)
        {
            applicationDbContext.Doctors.Update(doctor);
            return applicationDbContext.SaveChanges();
        }
    }
}
