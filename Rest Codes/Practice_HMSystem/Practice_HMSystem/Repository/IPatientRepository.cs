using Practice_HMSystem.Models;

namespace Practice_HMSystem.Repository
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
