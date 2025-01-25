using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly SmartHmsdbContext appointmentDbContext;
        public AppointmentRepository(SmartHmsdbContext _appointmentDbContext)
        {
            appointmentDbContext = _appointmentDbContext;
        }

        public int CreateAppointment(Appointment appointment)
        {
            appointmentDbContext.Add(appointment);
            return appointmentDbContext.SaveChanges();
        }

        public Appointment GetAppointmentById(int id)
        {
            return appointmentDbContext.Appointments
                .FirstOrDefault(a => a.AppointmentId == id);
        }

        public IEnumerable<Appointment> GetAppointments()
        {
            return appointmentDbContext.Appointments
                .ToList();
        }
    }
}
