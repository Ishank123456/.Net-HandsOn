﻿using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Specialty { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? OfficeLocation { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    //public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
}
