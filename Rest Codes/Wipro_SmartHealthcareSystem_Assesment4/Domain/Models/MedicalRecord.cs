using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class MedicalRecord
{
    public int MedicalRecordId { get; set; }

    public int PatientId { get; set; }

    public int DoctorId { get; set; }

    public int? AppointmentId { get; set; }

    public string Diagnosis { get; set; } = null!;

    public string TreatmentPlan { get; set; } = null!;

    public string? Prescription { get; set; }

    public string? Notes { get; set; }

    public DateTime RecordDate { get; set; }

    public virtual Appointment? Appointment { get; set; }

    public virtual Doctor Doctor { get; set; } = null!;

    public virtual Patient Patient { get; set; } = null!;
}
