﻿using System.ComponentModel.DataAnnotations;

namespace Wipro_HealthManagementSystemCFA.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Specialization { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }
    }
}
