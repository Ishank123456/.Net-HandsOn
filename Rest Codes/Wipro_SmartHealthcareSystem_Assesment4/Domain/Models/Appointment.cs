using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public partial class Appointment
{ 
    
    public int AppointmentId { get; set; }

    public int PatientId { get; set; }

    //public string PatientName { get; set; }

    public int DoctorId { get; set; }

    //public string DoctorName { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string AppointmentStatus { get; set; } = null!;

    public string ReasonForVisit { get; set; }

    //public DateTime CreatedDate { get; set; }

    //public virtual Doctor Doctor { get; set; } = null!;

    //public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

    //public virtual Patient Patient { get; set; } = null!;
}
