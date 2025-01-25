using System;
using System.Collections.Generic;

namespace Wipro_DFA_API_E_CommerceApplication.Models;

public partial class OrderHistory
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public string? OrderedProducts { get; set; }

    public string? OrderDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual Customer? Customer { get; set; }
}
