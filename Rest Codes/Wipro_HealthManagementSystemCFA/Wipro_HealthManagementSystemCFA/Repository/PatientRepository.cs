using Wipro_HealthManagementSystemCFA.EntityFramework;
using Wipro_HealthManagementSystemCFA.Models;

namespace Wipro_HealthManagementSystemCFA.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext patientDbContext;
        public PatientRepository(ApplicationDbContext _patientDbContext)
        {
            patientDbContext = _patientDbContext;
        }

        public int DeletePatient(int id)
        {
            var filterData = patientDbContext.Patients.SingleOrDefault(p => p.PatientId == id);
            patientDbContext.Patients.Remove(filterData);
            return patientDbContext.SaveChanges();
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return patientDbContext.Patients.ToList();
        }

        public Patient GetPatient(int id)
        {
            return patientDbContext.Patients.SingleOrDefault(p => p.PatientId == id);
        }

        public int InsertPatient(Patient patient)
        {
            patientDbContext.Patients.Add(patient);
            return patientDbContext.SaveChanges();
        }

        public int UpdatePatient(Patient patient)
        {
            patientDbContext.Patients.Update(patient);
            return patientDbContext.SaveChanges();
        }
    }
}
