using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Wipro_API_DFA_ProductService.Models;

namespace Wipro_API_DFA_ProductService.EntityFramework;

public class WiproDfa26082024Context : DbContext
{ 
    public WiproDfa26082024Context(DbContextOptions<WiproDfa26082024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }
}
