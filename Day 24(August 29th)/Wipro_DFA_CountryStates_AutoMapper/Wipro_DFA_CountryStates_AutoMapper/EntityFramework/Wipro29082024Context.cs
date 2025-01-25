using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Wipro_DFA_CountryStates_AutoMapper.Models;

namespace Wipro_DFA_CountryStates_AutoMapper.EntityFramework;

public partial class Wipro29082024Context : DbContext
{
    public Wipro29082024Context(DbContextOptions<Wipro29082024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Country { get; set; }

    public virtual DbSet<State> State { get; set; }
}
