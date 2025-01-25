using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wipro_DFA_API_ECommerceService.Models;

public partial class Customer
{
    [Key]
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerEmail { get; set; }

    public string? CustomerOrderHistory { get; set; }

    public string? Reviews { get; set; }
}
