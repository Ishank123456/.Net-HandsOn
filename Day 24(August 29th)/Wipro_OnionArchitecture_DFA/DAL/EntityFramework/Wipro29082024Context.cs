using System;
using System.Collections.Generic;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.DAL;

public partial class Wipro29082024Context : DbContext
{
    public Wipro29082024Context()
    {
    }

    public Wipro29082024Context(DbContextOptions<Wipro29082024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }
}
