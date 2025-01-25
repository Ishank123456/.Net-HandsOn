using System;
using System.Collections.Generic;

namespace Wipro_API_DFA_ProductService.Models;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public int? Quantity { get; set; }
}
