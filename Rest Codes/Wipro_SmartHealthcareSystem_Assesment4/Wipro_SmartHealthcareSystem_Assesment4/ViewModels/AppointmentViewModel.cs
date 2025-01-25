namespace Wipro_SmartHealthcareSystem_Assesment4.ViewModels
{
    public class AppointmentViewModel
    {
        public int AppointmentId { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentStatus { get; set; }
        public string ReasonForVisit { get; set; }
    }
}
