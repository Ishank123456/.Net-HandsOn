using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly SmartHmsdbContext patientDbContext;
        public PatientRepository(SmartHmsdbContext _patientDbContext)
        {
            patientDbContext = _patientDbContext;
        }

        public int AddPatient(Patient patient)
        {
            patientDbContext.Patients.Add(patient);
            return patientDbContext.SaveChanges();
        }

        public bool DeletePatient(int id)
        {
            var filterData = patientDbContext.Patients.SingleOrDefault(p => p.PatientId == id);
            var result = patientDbContext.Patients.Remove(filterData);
            patientDbContext.SaveChanges();
            return result != null ? true : false;
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return patientDbContext.Patients.ToList();
        }

        public Patient GetPatient(int id)
        {
            return patientDbContext.Patients.SingleOrDefault(p => p.PatientId == id);
        }

        public int UpdatePatient(Patient patient)
        {
            patientDbContext.Patients.Update(patient);
            return patientDbContext.SaveChanges();
        }
    }
}
