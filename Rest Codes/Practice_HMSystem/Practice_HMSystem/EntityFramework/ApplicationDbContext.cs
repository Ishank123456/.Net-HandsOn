using Microsoft.EntityFrameworkCore;
using Practice_HMSystem.Models;

namespace Practice_HMSystem.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Billing> Billings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PatientId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId);

            modelBuilder.Entity<Billing>()
                .HasOne(b => b.Appointment)
                .WithOne()
                .HasForeignKey<Billing>(b => b.AppointmentId);
        }
    }
}
