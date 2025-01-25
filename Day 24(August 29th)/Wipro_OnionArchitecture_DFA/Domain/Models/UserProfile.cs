using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public partial class UserProfile
{
    [Key]
    public int UserProfileId { get; set; }

    public int? UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? ContactNo { get; set; }

    public virtual User? User { get; set; }
}
