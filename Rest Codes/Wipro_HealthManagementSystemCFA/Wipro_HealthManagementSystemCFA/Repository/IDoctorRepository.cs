using Wipro_HealthManagementSystemCFA.Models;

namespace Wipro_HealthManagementSystemCFA.Repository
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetAllDoctors();
        Doctor GetDoctor(int id);
        int InsertDoctor(Doctor doctor);
        int UpdateDoctor(Doctor doctor);
        int DeleteDoctor(int id);
    }
}
