using Wipro_HealthManagementSystemCFA.Models;

namespace Wipro_HealthManagementSystemCFA.Repository
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetAllPatients();
        Patient GetPatient(int id);
        int InsertPatient(Patient patient);
        int UpdatePatient(Patient patient);
        int DeletePatient(int id);
    }
}
