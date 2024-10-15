﻿using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1;

public class UserDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=DB.db");

    public UserDbContext()
    {
        Database.EnsureCreated();
    }
}
