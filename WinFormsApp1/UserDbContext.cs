using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1;

public class UserDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    string connectionString = "Server=localhost;Port=3306;DateBase=auth_app;User=root;Password=;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL(connectionString);

    public UserDbContext()
    {
        Database.EnsureCreated();
    }
}
