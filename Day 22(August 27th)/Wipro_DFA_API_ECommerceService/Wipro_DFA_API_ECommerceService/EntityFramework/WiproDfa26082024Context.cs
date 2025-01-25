using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Wipro_DFA_API_ECommerceService.Models;

namespace Wipro_DFA_API_ECommerceService.EntityFramework;

public partial class WiproDfa26082024Context : DbContext
{
    public WiproDfa26082024Context(DbContextOptions<WiproDfa26082024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<OrderTableInfo> OrderTableInfos { get; set; }
}
