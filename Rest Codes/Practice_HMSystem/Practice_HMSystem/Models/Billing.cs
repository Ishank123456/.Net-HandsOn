namespace Practice_HMSystem.Models
{
    public class Billing
    {
        public int BillingId { get; set; }
        public int AppointmentId { get; set; }
        public double Amount { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime BillingDate { get; set; }

        public Appointment Appointment { get; set; }
    }
}
