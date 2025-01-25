using System.ComponentModel.DataAnnotations;

namespace Wipro_HealthManagementSystemCFA.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? Dob { get; set; }

        public string? Gender { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }
    }
}
