using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1;

public class UserDbContext : DbContext
{
    public DbSet<User> users { get; set; }

    string connectionString = "Server=localhost;Port=3306;Database=auth_app;User=root;Password=;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL(connectionString);

    public UserDbContext()
    {
        Database.EnsureCreated();
    }
}
