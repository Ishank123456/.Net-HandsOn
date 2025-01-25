using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public partial class User
{
    [Key]
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Ipaddress { get; set; }

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
