using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositories
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetAllDoctors();
        Doctor GetDoctor(int id);
        int AddDoctor(Doctor doctor);
        int UpdateDoctor(Doctor doctor);
        bool DeleteDoctor(int id);
    }
}
