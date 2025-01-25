using System;
using System.Collections.Generic;

namespace Wipro_DFA_API_E_CommerceApplication.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerEmail { get; set; }

    public string? CustomerOrderHistory { get; set; }

    public string? Reviews { get; set; }

    public virtual ICollection<OrderHistory> OrderHistories { get; set; } = new List<OrderHistory>();
}
