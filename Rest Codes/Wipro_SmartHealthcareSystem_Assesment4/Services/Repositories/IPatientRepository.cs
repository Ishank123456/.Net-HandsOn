using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositories
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetAllPatients();
        Patient GetPatient(int id);
        int AddPatient(Patient patient);
        int UpdatePatient(Patient patient);
        bool DeletePatient(int id);
    }
}
