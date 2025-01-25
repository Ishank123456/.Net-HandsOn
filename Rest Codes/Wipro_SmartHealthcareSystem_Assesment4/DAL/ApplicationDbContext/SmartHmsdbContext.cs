using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public partial class SmartHmsdbContext : DbContext
{
    public SmartHmsdbContext()
    {
    }

    public SmartHmsdbContext(DbContextOptions<SmartHmsdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=SmartHMSDB;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentId).HasName("PK__Appointm__8ECDFCA26931B785");

            entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");
            entity.Property(e => e.AppointmentDate).HasColumnType("datetime");
            entity.Property(e => e.AppointmentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            //entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DoctorId).HasColumnName("DoctorID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.ReasonForVisit)
                .HasMaxLength(255)
                .IsUnicode(false);

            //entity.HasOne(d => d.Doctor).WithMany(p => p.Appointments)
            //    .HasForeignKey(d => d.DoctorId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__Appointme__Docto__5DCAEF64");

            //entity.HasOne(d => d.Patient).WithMany(p => p.Appointments)
            //    .HasForeignKey(d => d.PatientId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__Appointme__Patie__5CD6CB2B");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.DoctorId).HasName("PK__Doctors__2DC00EBF94A3A9CB");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.OfficeLocation).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            entity.Property(e => e.Specialty).HasMaxLength(100);
        });

        modelBuilder.Entity<MedicalRecord>(entity =>
        {
            entity.HasKey(e => e.MedicalRecordId).HasName("PK__MedicalR__4411BBC28B4B2C43");

            entity.Property(e => e.MedicalRecordId).HasColumnName("MedicalRecordID");
            entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");
            entity.Property(e => e.Diagnosis)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DoctorId).HasColumnName("DoctorID");
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.Prescription).HasColumnType("text");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.TreatmentPlan)
                .HasMaxLength(255)
                .IsUnicode(false);

            //entity.HasOne(d => d.Appointment).WithMany(p => p.MedicalRecords)
            //    .HasForeignKey(d => d.AppointmentId)
            //    .HasConstraintName("FK__MedicalRe__Appoi__628FA481");

            //entity.HasOne(d => d.Doctor).WithMany(p => p.MedicalRecords)
            //    .HasForeignKey(d => d.DoctorId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__MedicalRe__Docto__619B8048");

            //entity.HasOne(d => d.Patient).WithMany(p => p.MedicalRecords)
            //    .HasForeignKey(d => d.PatientId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__MedicalRe__Patie__60A75C0F");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK__Patients__970EC366197C55D4");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C5E553734");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
