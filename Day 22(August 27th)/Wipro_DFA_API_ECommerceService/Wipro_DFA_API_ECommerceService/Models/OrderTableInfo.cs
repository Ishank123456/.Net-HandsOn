using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wipro_DFA_API_ECommerceService.Models;

public partial class OrderTableInfo
{
    [Key]
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public string? OrderedProducts { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? TotalAmount { get; set; }
}
