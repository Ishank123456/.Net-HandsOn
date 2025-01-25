using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Wipro_DFA_API_E_CommerceApplication.Models;

namespace Wipro_DFA_API_E_CommerceApplication.EntityFramework;

public partial class WiproDfa26082024Context : DbContext
{
    public WiproDfa26082024Context(DbContextOptions<WiproDfa26082024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<OrderHistory> OrderHistories { get; set; }
}
