using Practice_HMSystem.EntityFramework;
using Practice_HMSystem.Models;

namespace Practice_HMSystem.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public PatientRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }

        public int DeletePatient(int id)
        {
            var filterData = applicationDbContext.Patients.SingleOrDefault(p => p.PatientId == id);
            applicationDbContext.Patients.Remove(filterData);
            return applicationDbContext.SaveChanges();
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return applicationDbContext.Patients.ToList();
        }

        public Patient GetPatient(int id)
        {
            return applicationDbContext.Patients.SingleOrDefault(p => p.PatientId == id);
        }

        public int InsertPatient(Patient patient)
        {
            applicationDbContext.Patients.Add(patient);
            return applicationDbContext.SaveChanges();
        }

        public int UpdatePatient(Patient patient)
        {
            applicationDbContext.Patients.Update(patient);
            return applicationDbContext.SaveChanges();
        }
    }
}
