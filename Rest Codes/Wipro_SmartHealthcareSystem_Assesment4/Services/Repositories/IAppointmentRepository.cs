using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositories
{
    public interface IAppointmentRepository
    {
        IEnumerable<Appointment> GetAppointments();
        Appointment GetAppointmentById(int id);
        int CreateAppointment(Appointment appointment);
    }
}
